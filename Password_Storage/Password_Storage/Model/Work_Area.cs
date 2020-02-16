namespace Passwords_Storage.Model
{
    public class Work_Area
    {
        public int Id { get; private set; }
        public string Name { get; set; } = null;
        public string Email { get; set; } = null;
        public string Login { get; set; } = null;
        public string Password { get; set; } = null;
        public string Url { get; set; } = null;
    }
}
