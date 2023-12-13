﻿namespace BlogApplicationWebAPI.DTO
{
    public class UserDTO
    {
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? PhoneNumber { get; set;}
        public string? UserStatus { get; set; }
        public string ? Role { get; set; }
    }
}
