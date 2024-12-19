using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_Presontation_Layer.Payments
{
    public partial class frmPayment : Form
    {
        public frmPayment(int GuestID,int RoomID)
        {
            InitializeComponent();
            ctrlAddUpdatePayment1.AddNewPayment(GuestID, RoomID);
        }
    }
}
