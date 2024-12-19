using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_Presontation_Layer.CurrentUser
{
    public partial class frmShowCurrentUserInformation : Form
    {
        public frmShowCurrentUserInformation()
        {
            InitializeComponent();
            ctrlUserInformation1.ShowUserInformation();
            ctrShowPersonInformation1.ShowCurrentUserInformation();
        }

        public frmShowCurrentUserInformation(int UserID)
        {
            InitializeComponent();
            ctrlUserInformation1.ShowUserInformation(UserID);
            ctrShowPersonInformation1.ShowCurrentUserInformation(UserID);
        }
    }
}
