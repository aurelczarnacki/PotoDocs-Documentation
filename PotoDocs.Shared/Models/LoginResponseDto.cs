﻿namespace PotoDocs.Shared.Models;

public class LoginResponseDto
{
    public Role Role { get; set; }
    public string Token { get; set; }
}
public enum Role
{
    Admin,
    Driver,
    Boss
}
