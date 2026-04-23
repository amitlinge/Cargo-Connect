using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoConnect.Application.Interfaces.ExternalServices
{
    public interface IPasswordService
    {
        string HashPassword(string email,string password);
        bool VerifyPassword(string email, string userPassword,string storedPassword);
    }
}
