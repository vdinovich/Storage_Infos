namespace Passwords_Storage
{
    using System;
    using Passwords_Storage.Model;
    using System.Windows.Forms;
    public partial class Register : Form
    {
        My_Context db;
        User new_user;

        public Register()
        {
            InitializeComponent();
            db = new My_Context();
            new_user = new User();
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            try
            {
                new_user.Last_Name = lNameTxt.Text;
                new_user.First_Name = fNameTxt.Text;
                new_user.Login = loginTxt.Text;
                new_user.Password = passTxt.Text;
                new_user.Age = Convert.ToInt32(ageTxt.Text);
                new_user.Role = roleTxt.Text;
                new_user.Date_Register = DateTime.Now;
                db.Users.Add(new_user);
                db.SaveChanges(); // The same as 'Pressed Execute on SQL Server'
                this.Text = $"User - {fNameTxt.Text} was Added Successfully!!!";
                MessageBox.Show($"User - {fNameTxt.Text} was Added Successfully!!!", "Congratulations!!!", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                lNameTxt.Text = "";
                fNameTxt.Text = "";
                loginTxt.Text = "";
                passTxt.Text = "";
                ageTxt.Text = "";
                roleTxt.Text = "";
            }
            catch(System.Data.DataException ex)
            {
                MessageBox.Show(ex.Message, "DataException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch 
            {
                MessageBox.Show("Something went wrong...", "Customer of an Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
