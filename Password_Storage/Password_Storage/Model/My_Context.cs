using System.Data.Entity;

namespace Passwords_Storage.Model
{
    public partial class My_Context : DbContext
    {
        public My_Context() : base("name=My_Context") { }

        // Table on an Entity Framework:
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Work_Area> Areas { get; set; }
    }
}
