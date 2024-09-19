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
    public partial class AirTicketBooking : Form
    {
        LoginForm ParentForm;
        string strRegistration;
        public Customer currentCustomer;
        public User currentUser;
        public int idxRegistration;

        public AirTicketBooking()
        {
            InitializeComponent();
            ParentForm = LoginForm.OriginalForm;

            foreach (Flight obj in ParentForm.FlightList)
                lsbFlightList.Items.Add(obj.FlightType);

            rtxtRegistrationInfo.Text = "";
        }

        public void SetCurrentUser(User user)
        {
            currentUser = user;
            currentCustomer = ParentForm.CustomerList.Find(x => (x.CustomerID == currentUser.CustomerID));

            idxRegistration = ParentForm.FlightRegistrationList.FindIndex(x => (x.CustomerID == currentCustomer.CustomerID));
            if (idxRegistration >= 0)
            {
                foreach (Flight obj in ParentForm.FlightRegistrationList[idxRegistration].FlightEnrolList)
                {
                    int idx = lsbFlightList.FindString(obj.FlightType.Trim());
                    lsbFlightList.SetSelected(idx, true);
                }
            }

            ShowRegistrationInfo();
        }

        public string ShowRegistrationInfo()
        {
            strRegistration = "\t\t\t Flight Registration of Customer \n";
            strRegistration += "_____________________________________________________________________\n";
            strRegistration += String.Format("CustomerID: {0}\nCustomer Name: {1}\n", currentCustomer.CustomerID
                                             , currentCustomer.CustomerName);
            Flight obj;
            foreach (Object selectedItem in lsbFlightList.SelectedItems)
            {
                obj = ParentForm.FlightList.Find(x => (x.FlightType == selectedItem.ToString()));

                if (obj != null)
                    strRegistration += "\n" + obj.FlightID + "\t" + obj.FlightType + "  " + obj.TimeDepart + "-" + obj.TimeArrival;
            }

            rtxtRegistrationInfo.Text = strRegistration;

            return strRegistration;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (idxRegistration < 0)
            {
                ParentForm.FlightRegistrationList.Add(new FlightRegistration(currentCustomer.CustomerID));
                idxRegistration = ParentForm.FlightRegistrationList.FindIndex(x => (x.CustomerID == currentCustomer.CustomerID));

                Flight obj;
                foreach (Object selectedItem in lsbFlightList.SelectedItems)
                {
                    obj = ParentForm.FlightList.Find(x => (x.FlightType == selectedItem.ToString()));
                    ParentForm.FlightRegistrationList[idxRegistration].FlightEnrolList.Add(obj);
                }
            }
            ShowRegistrationInfo();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ShowRegistrationInfo(), "thank you", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            ParentForm.ResetLogin = true;
            ParentForm.Show();
        }


        private void AirTicketBooking_Load(object sender, EventArgs e)
        {

        }

    }
}
