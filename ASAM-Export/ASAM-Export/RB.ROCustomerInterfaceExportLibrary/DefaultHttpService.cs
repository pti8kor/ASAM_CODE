        // Single shared HttpClient for the whole process.
        // Prevents socket / port exhaustion under heavy batch load.
        private static readonly HttpClient s_httpClient = new HttpClient();