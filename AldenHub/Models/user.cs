namespace AldenHub.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public bool IsAdmin { get; set; } = false;
        public bool IsVerified { get; set; } = false;
        public bool IsBanned { get; set; } = false;
    }
}