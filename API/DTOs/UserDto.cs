using System;
using System.Net.NetworkInformation;

namespace API.DTOs;

public class UserDto
{
    public required string Username { get; set; }
    public required string Token { get; set; }
}
