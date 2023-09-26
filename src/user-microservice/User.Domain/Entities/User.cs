namespace User.Domain.Entities
{
    public class User
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public DateTime Created { get; set; }
        public DateTime? LastLogin { get; set; }
        public bool IsActive { get; set; }

        public User() { }
        public User(string username, string passwordHash,  string email)
        {
            Username = username;
            PasswordHash = passwordHash;
            Email = email;
            Created = DateTime.Now;
            IsActive = true;
        }
    }
}
