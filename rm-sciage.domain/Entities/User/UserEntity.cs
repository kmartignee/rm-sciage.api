﻿namespace rm_sciage.domain.Entities.User;

public class UserEntity : EntityBase
{
    public string LastName { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public DateTime BirthDate { get; set; }
    public List<string> Skills { get; set; } = [];
    public bool IsAdmin { get; set; }
}