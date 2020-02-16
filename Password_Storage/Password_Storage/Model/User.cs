namespace Passwords_Storage.Model
{
    public partial class User
    {
        public int Id { get; private set; }
        public string First_Name { get; set; } = null;
        public string Last_Name { get; set; } = null;
        public string Login { get; set; } = null;
        public string Password { get; set; } = null;
        public string Role { get; set; } = null;
        public int Age { get; set; } = 0;
        public System.DateTime Date_Register { get; set; }
    }
}
