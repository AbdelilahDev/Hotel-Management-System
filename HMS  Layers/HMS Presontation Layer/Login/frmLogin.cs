using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_Presontation_Layer.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        //if user is Admin return 2 and if User is Normal return 1
        private int TypeofUser()
        {
            if (rdbAdminUser.Checked)
                return 2;
            else
                return 1;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
