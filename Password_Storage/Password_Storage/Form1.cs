namespace Passwords_Storage
{
    using System.Linq;
    using System.Windows.Forms;
    using Passwords_Storage.Model;

    public partial class Form1 : Form
    {
        readonly string login, pass, role;
        User user;
        My_Context db;
        public Form1()
        {
            InitializeComponent();
            db = new My_Context();
            Text = " Authorization";
            label1.Visible = label2.Visible = loginTxt.Visible = passTxt.Visible = logBtn.Visible = regBtn.Visible = true;
            login = "jleno";
            pass = "12345";
            user = db.Users.FirstOrDefault(r => r.Role == "Admin");
            role = user.Role;
        }

        private void logBtn_Click(object sender, System.EventArgs e)
        {
            if (loginTxt.Text ==  login && passTxt.Text == pass && role == "Admin")
            {
                new Main_Scope().ShowDialog();
                this.Dispose();
                this.Close();
            }
            else MessageBox.Show("This Login or Password is Incorrect..", "..fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void regBtn_Click(object sender, System.EventArgs e)
        {
            new Register().ShowDialog();
        }
    }
}
