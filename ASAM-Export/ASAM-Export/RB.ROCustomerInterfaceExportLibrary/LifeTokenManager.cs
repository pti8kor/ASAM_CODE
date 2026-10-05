using System;
using System.Collections.Concurrent;

namespace RB.ROCustomerInterfaceExportLibrary
{

    [Serializable]
    public class LifeTokenManager
    {
        // Thread-safe storage for all LifeTokens
        private readonly ConcurrentDictionary<string, string> _tokens = new ConcurrentDictionary<string, string>();

        // Initialize LifeTokens from a combined string
        public void Initialize(string lifeTokens)
        {
            if (string.IsNullOrWhiteSpace(lifeTokens))
                return;

            var tokens = lifeTokens.Split(new string[] { "||||" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var token in tokens)
            {
                var trimmedToken = token.Trim();
                var recordId = trimmedToken.Split(':')[0].Trim();
                _tokens[recordId] = trimmedToken;
            }
        }

        // Update LifeToken after success
        public void UpdateSuccess(string recordId)
        {
            if (_tokens.TryGetValue(recordId, out var val))
            {
                _tokens[recordId] = ReplaceStatus(val, "Success");
            }
        }

        // Update LifeToken after failure
        public void UpdateFailure(string recordId, string errorMessage)
        {
            if (_tokens.TryGetValue(recordId, out var val))
            {
                _tokens[recordId] = ReplaceStatus(val, $"Failure ({errorMessage})");
            }
        }

        // Retrieve a specific LifeToken
        public string GetLifeToken(string recordId)
        {
            return _tokens.TryGetValue(recordId, out var val) ? val : null;
        }

        //// Combine all LifeTokens back into a single string
        //public string GetCombinedLifeTokens()
        //{
        //    return string.Join(" |||| ", _tokens.Values);
        //}

        private string ReplaceStatus(string token, string newStatus)
        {
            // Assume LifeToken format: "recordID: Issue::Status"
            int lastIndex = token.LastIndexOf("::");
            if (lastIndex >= 0)
            {
                return token.Substring(0, lastIndex + 2) + newStatus;
            }
            return token + " :: " + newStatus; // fallback if format unexpected
        }

        public string UpdateLifeToken4FilesString(string originalLifeToken4Files)
        {
            if (string.IsNullOrWhiteSpace(originalLifeToken4Files))
                return originalLifeToken4Files;

            var tokens = originalLifeToken4Files.Split(new string[] { "||||" }, StringSplitOptions.None);

            for (int i = 0; i < tokens.Length; i++)
            {
                string token = tokens[i].Trim();
                string recordId = token.Split(':')[0].Trim();

                if (_tokens.TryGetValue(recordId, out var updatedToken))
                {
                    tokens[i] = updatedToken; // Replace with updated status from dictionary
                }
            }

            return string.Join(" |||| ", tokens);
        }

        
    }

}
