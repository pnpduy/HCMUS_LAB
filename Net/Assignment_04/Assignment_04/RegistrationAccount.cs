using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_04
{
    public partial class RegistrationAccount : Form
    {
        string startupPath;
        string AvatarPath;
        LoginForm ParentForm;

        public RegistrationAccount()
        {
            InitializeComponent();
            startupPath = LoginForm.OriginalForm.startupPath;
            ParentForm = LoginForm.OriginalForm;
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDlg.Title = "Find Avatar Images";
            openFileDlg.Filter = "JPG files|*.jpg";
            openFileDlg.InitialDirectory = startupPath;

            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                AvatarPath = openFileDlg.FileName;
                picAvatar.Image = Image.FromFile(AvatarPath);
                picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            ParentForm.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(RegistrationAccount));
            picAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picAvatar.Image")));
            picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            User obj = new User();
            Customer objcustomer = new Customer();

            if (textCustomerID.Text.Trim().Length == 0)
            {
                MessageBox.Show("CustomerID are blank!", "Input Error", MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation);
            }
            if (textCustomerName.Text.Trim().Length == 0)
            {
                MessageBox.Show("CustomerName are blank!", "Input Error", MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation);
            }
            if (textUserName.Text.Trim().Length == 0)
            {
                MessageBox.Show("UserName are blank!", "Input Error", MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation);
            }
            if (textPassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("Password are blank!", "Input Error", MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation);
            }
            if (textPassPortNbr.Text.Trim().Length == 0)
            {
                MessageBox.Show("PassPortNbr are blank!", "Input Error", MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation);
            }
            if (textNationality.Text.Trim().Length == 0)
            {
                MessageBox.Show("Nationality are blank!", "Input Error", MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation);
            }
            if (textEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Email are blank!", "Input Error", MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation);
            }

            if (textPassword.Text != textConfirmendPassword.Text)
            {
                MessageBox.Show("Password aren't matched", "Input Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                return;
            }

            User SpecificOne = ParentForm.UserList.Find(x => (x.UserName == textUserName.Text) && (x.Password == textPassword.Text));
            if (SpecificOne != null)
            {
                MessageBox.Show("UserName is existed", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            obj.UserName = textUserName.Text;
            obj.Password = textPassword.Text;
            obj.CustomerID = textCustomerID.Text;

            objcustomer.CustomerID = textCustomerID.Text;
            objcustomer.CustomerName = textCustomerName.Text;
            objcustomer.Email = textEmail.Text;
            objcustomer.Avatar = picAvatar.Image;
            objcustomer.Birthday = dtBirthday.Value;
            objcustomer.Gender = (rdMale.Checked == true) ? Sex.Male : Sex.Female;
            objcustomer.PassPortNbr = textPassPortNbr.Text;
            objcustomer.Nationality = textNationality.Text;

            ParentForm.UserList.Add(obj);
            ParentForm.CustomerList.Add(objcustomer);

            MessageBox.Show("New UserName is Cereated", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            textCustomerID.Text = "";
            textCustomerName.Text = "";
            textUserName.Text = "";
            textPassword.Text = "";
            textConfirmendPassword.Text = "";
            dtBirthday.Value = DateTime.Now;
            textPassPortNbr.Text = "";
            textNationality.Text = "";
            rdMale.Checked = true;
            rdFemale.Checked = false;
            textEmail.Text = "";

            ComponentResourceManager resources = new ComponentResourceManager(typeof(RegistrationAccount));
            picAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picAvatar.Image")));
            picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;


        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void RegistrationAccount_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtBirthday_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rdFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textConfirmendPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNationlity_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPassPortNbr_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCustomerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
