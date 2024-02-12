using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapiDotNet8.Models;

namespace webapiDotNet8.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}