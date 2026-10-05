using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace RB.ROCustomerInterfaceExportLibrary
{
    /// <summary>
    /// Abstraction for HTTP operations to enable unit testing without real network calls.
    /// </summary>
    public interface IHttpService
    {
        /// <summary>
        /// Performs an HTTP GET and returns the response body as a string.
        /// </summary>
        string Get(string url, Dictionary<string, string> headers);

        /// <summary>
        /// Performs an HTTP PUT with the given body and returns the response body as a string.
        /// </summary>
        string Put(string url, string body, string contentType, Dictionary<string, string> headers);

        /// <summary>
        /// Performs an HTTP GET and returns the response body as a byte array.
        /// </summary>
        byte[] GetBytes(string url, Dictionary<string, string> headers);

        /// <summary>
        /// Performs an HTTP POST with multipart form data containing a file.
        /// </summary>
        void PostMultipart(string url, string filePath, Dictionary<string, string> headers);
    }

    /// <summary>
    /// Default implementation of IHttpService that uses real HttpClient for production use.
    /// </summary>
    public class DefaultHttpService : IHttpService
    {
        public string Get(string url, Dictionary<string, string> headers)
        {
            using (var client = new HttpClient())
            {
                ApplyHeaders(client, headers);
                HttpResponseMessage response = client.GetAsync(url).Result;
                response.EnsureSuccessStatusCode();
                return response.Content.ReadAsStringAsync().Result;
            }
        }

        public string Put(string url, string body, string contentType, Dictionary<string, string> headers)
        {
            using (var client = new HttpClient())
            {
                ApplyHeaders(client, headers);
                HttpContent content = new StringContent(body, Encoding.UTF8, contentType);
                HttpResponseMessage response = client.PutAsync(url, content).Result;
                response.EnsureSuccessStatusCode();
                return response.Content.ReadAsStringAsync().Result;
            }
        }

        public byte[] GetBytes(string url, Dictionary<string, string> headers)
        {
            using (var client = new HttpClient())
            {
                ApplyHeaders(client, headers);
                return client.GetByteArrayAsync(url).GetAwaiter().GetResult();
            }
        }

        public void PostMultipart(string url, string filePath, Dictionary<string, string> headers)
        {
            using (var client = new HttpClient())
            using (var request = new HttpRequestMessage(HttpMethod.Post, url))
            {
                // Apply auth header separately for request-level headers
                if (headers != null && headers.ContainsKey("Authorization"))
                {
                    var parts = headers["Authorization"].Split(' ');
                    if (parts.Length == 2)
                        request.Headers.Authorization = new AuthenticationHeaderValue(parts[0], parts[1]);
                }

                var content = new MultipartFormDataContent();
                var fileStream = File.OpenRead(filePath);
                content.Add(new StreamContent(fileStream), "attachment", Path.GetFileName(filePath));
                request.Content = content;

                var response = client.SendAsync(request).GetAwaiter().GetResult();
                response.EnsureSuccessStatusCode();
            }
        }

        private static void ApplyHeaders(HttpClient client, Dictionary<string, string> headers)
        {
            if (headers == null) return;
            foreach (var kvp in headers)
            {
                if (kvp.Key == "Authorization")
                {
                    var parts = kvp.Value.Split(' ');
                    if (parts.Length == 2)
                        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(parts[0], parts[1]);
                }
                else if (kvp.Key == "Accept")
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(kvp.Value));
                }
                else
                {
                    client.DefaultRequestHeaders.Add(kvp.Key, kvp.Value);
                }
            }
        }
    }
}
