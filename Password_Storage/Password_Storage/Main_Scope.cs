namespace Passwords_Storage
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using Passwords_Storage.Model;

    public partial class Main_Scope : Form
    {
        My_Context db;
        Work_Area wArea;
        public Main_Scope()
        {
            InitializeComponent();
            db = new My_Context();
            wArea = new Work_Area();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                wArea.Name = nameTxt.Text;
                wArea.Email = emailTxt.Text;
                wArea.Login = loginTxt.Text;
                wArea.Password = passTxt.Text;
                wArea.Url = urlTxt.Text;
                db.Areas.Add(wArea);
                db.SaveChanges();
                this.Text = $"New Info - {nameTxt.Text} was Added Successfully!!!";
                MessageBox.Show($"User - {nameTxt.Text} was Added Successfully!!!", 
                "Congratulations!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                // Clear all fields:
                nameTxt.Text = "";
                emailTxt.Text = "";
                loginTxt.Text = "";
                passTxt.Text = "";
                urlTxt.Text = "";
                // After insert show all records from DB to ListBox:
                listInfo.Items.AddRange(db.Areas.ToArray()); 
            }
            catch (System.Data.DataException ex)
            {
                MessageBox.Show(ex.Message, "DataException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Something went wrong...", "Customer of an Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Main_Scope_Load(object sender, EventArgs e)
        {
            listInfo.Items.AddRange(db.Areas.ToArray());
        }
    }
}
