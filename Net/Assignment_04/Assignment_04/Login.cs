
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace Assignment_04
{
    public partial class LoginForm : Form
    {

        public static LoginForm OriginalForm;
        public List<Customer> CustomerList;
        public List<User> UserList;
        public List<Flight> FlightList;
        public List<FlightRegistration> FlightRegistrationList;
        public string startupPath;
        public bool ResetLogin;


        public LoginForm()
        {
            InitializeComponent();
            OriginalForm = this;
            startupPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            CustomerList = new List<Customer>();
            CustomerList.Add(new Customer("ST001", "Adrew", DateTime.Now, Sex.Male, "USA001", "USA", "admin@gmail.com",
                Image.FromFile(startupPath + "\\Images\\Nobita.jpg")));

            UserList = new List<User>();
            UserList.Add(new User("Admin", "1234", "ST001"));

            FlightList = new List<Flight>();
            FlightList.Add(new Flight("AL001", "Vietnam Airline", "8:00pm", "10:00pm"));
            FlightList.Add(new Flight("AL002", "BamBoo Airline", "8:00am", "10:00am"));
            FlightList.Add(new Flight("AL003", "VietJet Air", "10:00pm", "2:00am"));
            FlightList.Add(new Flight("AL004", "Jetstar Pacific Airlines", "9:00am", "11:00am"));
            FlightRegistrationList = new List<FlightRegistration>();
            ResetLogin = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textUserName.Text.Length == 0)
            {
                MessageBox.Show("Please enter user name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textUserName.Focus();
                return;
            }
            if (textPassword.Text.Length == 0)
            {
                MessageBox.Show("Please enter password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textPassword.Focus();
                return;
            }

            User SpecificOne = UserList.Find(x => (x.UserName == textUserName.Text) && (x.Password == textPassword.Text));
            if (SpecificOne == null)
            {
                MessageBox.Show("Username and Password are not matched. \n Please reinput or register a new one",
                                "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textUserName.Text = "";
                textPassword.Text = "";
                textUserName.Focus();
            }

            AirTicketBooking obj = new AirTicketBooking();
            User currentUser = UserList.Find(x => (x.UserName == textUserName.Text) && (x.Password == textPassword.Text));
            obj.SetCurrentUser(currentUser);
            this.Hide();
            obj.Show();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void linkLblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationAccount obj = new RegistrationAccount();
            this.Hide();
            obj.Show();
        }

        private void LoginForm_VisibleChanged(object sender, EventArgs e)
        {
            if (ResetLogin == true)
            {
                textUserName.Text = "";
                textPassword.Text = "";
            }
        }





        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
