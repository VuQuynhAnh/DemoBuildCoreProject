﻿namespace HappyBookingShare.Request.User;

public class RegisterUserRequest
{
    public string FullName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string PhoneNumber { get; set; } = string.Empty;

    public string CitizenIdentificationNumber { get; set; } = string.Empty;

    public string Address { get; set; } = string.Empty;

    public string AvatarImage { get; set; } = string.Empty;

    public int Role { get; set; }

    public string Password { get; set; } = string.Empty;
}
