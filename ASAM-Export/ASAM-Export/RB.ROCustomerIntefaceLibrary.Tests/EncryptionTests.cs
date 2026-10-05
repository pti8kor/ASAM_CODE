using System;
using RB.ROCustomerInterfaceExportLibrary;
using Xunit;

namespace RB.ROCustomerIntefaceLibrary.Tests
{
    /// <summary>
    /// Unit tests for the Encryption class covering encrypt/decrypt round-trip and edge cases.
    /// </summary>
    public class EncryptionTests
    {
        [Theory]
        [InlineData("Hello World", "secret")]
        [InlineData("RQ1ML00138253", "RO")]
        [InlineData("", "key")]
        [InlineData("Special chars: ä ö ü ß € @", "passphrase")]
        public void EncryptDecrypt_RoundTrip_ReturnsOriginal(string message, string passphrase)
        {
            string encrypted = Encryption.EncryptString(message, passphrase);
            string decrypted = Encryption.DecryptString(encrypted, passphrase);
            Assert.Equal(message, decrypted);
        }

        [Fact]
        public void EncryptString_ProducesBase64Output()
        {
            string result = Encryption.EncryptString("test", "key");
            // Base64 should not throw on conversion
            byte[] bytes = Convert.FromBase64String(result);
            Assert.NotEmpty(bytes);
        }

        [Fact]
        public void EncryptString_DifferentPassphrases_ProduceDifferentResults()
        {
            string msg = "same message";
            string enc1 = Encryption.EncryptString(msg, "key1");
            string enc2 = Encryption.EncryptString(msg, "key2");
            Assert.NotEqual(enc1, enc2);
        }

        [Fact]
        public void DecryptString_WrongPassphrase_DoesNotReturnOriginal()
        {
            string original = "secret data";
            string encrypted = Encryption.EncryptString(original, "correctKey");

            // Decrypting with wrong key should either throw or return garbage
            try
            {
                string decrypted = Encryption.DecryptString(encrypted, "wrongKey");
                Assert.NotEqual(original, decrypted);
            }
            catch (System.Security.Cryptography.CryptographicException)
            {
                // Expected — wrong key can cause padding exception
            }
        }

        [Fact]
        public void EncryptString_SameInputSameKey_ProducesSameOutput()
        {
            string enc1 = Encryption.EncryptString("data", "key");
            string enc2 = Encryption.EncryptString("data", "key");
            Assert.Equal(enc1, enc2); // ECB mode is deterministic
        }
    }
}
