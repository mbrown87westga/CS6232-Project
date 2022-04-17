using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace FurnitureRentalBusiness.Helpers
{
    public static class EncryptionHelper
    {
        public static string Hash(string password)
        {
            byte[] salt = new byte[] { 210, 93, 247, 67, 124, 154, 106, 53, 128, 44, 126, 104, 98, 220, 66, 121 };

            // derive a 256-bit subkey (use HMACSHA1 with 10,000 iterations)
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));
            return hashed;
        }
    }
}
