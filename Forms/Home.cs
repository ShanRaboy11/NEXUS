using NEXUS.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEXUS.Forms
{
    public partial class Home : Form
    {
        private Dashboard passengerDashboard;
        private DriverDashboard driverDashboard;
        private UserInformation currentUser;

        public Home(UserInformation user)
        {
            InitializeComponent();
            this.currentUser = user;


            if (user is Passenger passenger)
            {
                passengerDashboard = new Dashboard(passenger);
            }
            else if (user is Driver driver)
            {
                driverDashboard = new DriverDashboard(driver);
            }
        }

        private void pbMap_Click(object sender, EventArgs e)
        {
            //Scan scan = new Scan(currentUser.UserID);
            Map map = new Map();
            map.ShowDialog();
            //scan.ShowOverlay(map, null);
            /*
            if (currentUser is Passenger)
            {
                passengerDashboard?.OpenChildForm(map);
            }
            else if (currentUser is Driver)
            {
                driverDashboard?.OpenChildForm(map);
            }*/
        }
    }

}
