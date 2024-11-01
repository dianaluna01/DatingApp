using System;
using API.Entities;

namespace API.Interfaces;
//No abstraction code is implemented in interfaces!!!
public interface ITokenService
{
    string CreateToken(AppUser user);
}
