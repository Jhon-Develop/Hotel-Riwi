using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Hotel_Riwi.Models;

namespace Hotel_Riwi.Services.Interfaces
{
    public interface IJwtService
    {
        string GenerateTokenJwt(Employee employee);
        ClaimsPrincipal ValidateTokenJwt(string token);
    }
}