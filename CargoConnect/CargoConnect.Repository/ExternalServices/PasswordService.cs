using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CargoConnect.Application.Interfaces.ExternalServices;
using CargoConnect.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace CargoConnect.Infrastructure.ExternalServices
{
    public class PasswordService : IPasswordService
    {
        private readonly PasswordHasher<string> _hasher;

        public PasswordService(PasswordHasher<string> hasher)
        {
            _hasher = hasher;
        }

        public string HashPassword(string email,string password)
        {
            string hashedPassword = _hasher.HashPassword(email,password);
            return hashedPassword;
        }

        public bool VerifyPassword(string email, string hashedPassword, string providedPassword)
        {
            PasswordVerificationResult result = _hasher.VerifyHashedPassword(email, hashedPassword, providedPassword);

            if(result == PasswordVerificationResult.Success)
                return true;

            return false;
        }
    }
}
