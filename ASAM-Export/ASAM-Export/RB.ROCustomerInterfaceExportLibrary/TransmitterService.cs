using System;
using System.IO;
using System.Net;
using System.Text;

namespace RB.ROCustomerInterfaceExportLibrary
{
    public class TransmitterService
    {
        private readonly string _serviceUrl;

        public TransmitterService(string serviceUrl)
        {
            _serviceUrl = serviceUrl;
        }

        public TransmitterResponse SendZipFile(string xprotID, string recordID, string zipFilePath,string transferType = "SUPPLIER_DATA")
        {
            TransmitterResponse responseObj =
                new TransmitterResponse();

            string filePath = BizTalkConfigParams.BT_MESSAGES + xprotID + "_" + recordID + "_" + "TransmitterResponse.xml";
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));

            try
            {
                if (!File.Exists(zipFilePath))
                {
                    responseObj.IsSuccess = false;
                    responseObj.ErrorMessage =
                        "ZIP file does not exist.";

                    return responseObj;
                }

                byte[] zipBytes =
                    File.ReadAllBytes(zipFilePath);

                string base64Zip =
                    Convert.ToBase64String(zipBytes);

                string fileName =
                    Path.GetFileName(zipFilePath);

                string soapXml =$@"<?xml version=""1.0"" encoding=""utf-8""?>

                                    <soapenv:Envelope
                                        xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/""
                                        xmlns:ser=""http://www.bosch.com/edexas/asam/transmitter/services"">

                                       <soapenv:Header/>

                                       <soapenv:Body>

                                          <ser:transmitterRequest>

                                             <transferBinary>{base64Zip}</transferBinary>

                                             <transferData>Uploaded From Service Class</transferData>

                                             <transferFile>{fileName}</transferFile>

                                             <transferType>{transferType}</transferType>

                                          </ser:transmitterRequest>

                                       </soapenv:Body>

                                    </soapenv:Envelope>";

                HttpWebRequest request =
                    (HttpWebRequest)WebRequest.Create(_serviceUrl);

                // Internal URL → bypass proxy
                request.Proxy = null;

                request.Method = "POST";

                request.ContentType =
                    "text/xml;charset=UTF-8";

                request.Timeout = 300000;

                request.Headers.Add("SOAPAction", "");

                byte[] soapBytes =
                    Encoding.UTF8.GetBytes(soapXml);

                request.ContentLength =
                    soapBytes.Length;

                using (Stream requestStream =
                    request.GetRequestStream())
                {
                    requestStream.Write(
                        soapBytes,
                        0,
                        soapBytes.Length);
                }

                using (HttpWebResponse response =
                    (HttpWebResponse)request.GetResponse())
                {
                    using (StreamReader reader =
                        new StreamReader(response.GetResponseStream()))
                    {
                        responseObj.IsSuccess = true;

                        responseObj.ResponseXml =
                            reader.ReadToEnd();

                        // Save XML response
                        File.WriteAllText(filePath, responseObj.ResponseXml);
                    }
                }
                
            }
            catch (WebException webEx)
            {
                responseObj.IsSuccess = false;

                if (webEx.Response != null)
                {
                    using (StreamReader reader =
                        new StreamReader(
                            webEx.Response.GetResponseStream()))
                    {
                        responseObj.ErrorMessage =
                            reader.ReadToEnd();
                        // Save XML response
                        File.WriteAllText(filePath, responseObj.ErrorMessage);
                    }
                }
                else
                {
                    responseObj.ErrorMessage =
                        webEx.ToString();
                    // Save XML response
                    File.WriteAllText(filePath, responseObj.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                responseObj.IsSuccess = false;
                responseObj.ErrorMessage = ex.ToString();
                // Save XML response
                File.WriteAllText(filePath, responseObj.ErrorMessage);
            }
            return responseObj;
        }
    }
}
