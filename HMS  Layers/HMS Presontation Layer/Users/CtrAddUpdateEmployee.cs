using Business_Layer;
using HMS_Presontation_Layer.Global_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HMS_Presontation_Layer.Users
{
    public partial class CtrAddUpdateEmployee : UserControl
    {

        // Define a custom event handler delegate with parameters
        public event Action<int> OnEmployeeSelected;
        // Create a protected method to raise the event with a parameter
        protected virtual void EmployeeSelected(int PersonID)
        {
            Action<int> handler = OnEmployeeSelected;
            if (handler != null)
            {
                handler(PersonID); // Raise the event with the parameter
            }
        }


        DataTable _AllDepartementsNames = clsDepartememts.GetAllDepartementsName();

        clsEmployee _Employee;
        int _EmployeeID;

    

        public enum enMode { New=0,Update=1};

        public enMode Mode;
        public CtrAddUpdateEmployee()
        {
            InitializeComponent();
            cmbDepartmentID.ValueMember = "Name";
            cmbDepartmentID.DataSource = _AllDepartementsNames;

         ;

             
        }
        public void AddNewEmployee()
        {
            lblTitle.Text = "Add New Employee";
            Mode = enMode.New;
        }

        public void UpdateEmployee(int EmployeeID)
        {
            lblTitle.Text = "Update Employee";
            Mode = enMode.Update;
            _EmployeeID = EmployeeID;
            _Employee = clsEmployee.FindEmployeeByID(EmployeeID);

            lblGuestID.Text = _Employee.EmployeeID.ToString();

            tbFirstName.Text = _Employee.FirstName;
            tbLastName.Text  = _Employee.LastName;
            tbPhone.Text     = _Employee.Phone;
            tbAddress.Text   = _Employee.Address;
            tbEmail.Text     = _Employee.Email;

            tbNationalNumber.Text         = _Employee.NationalNo;
            cmbDepartmentID.SelectedIndex = _Employee.DepartmentID-1;
            tbSalary.Text                 = _Employee.Salary.ToString();
            tbBonus.Text                  = _Employee.Bonus.ToString();
           tbPerformanceRate.Text         = _Employee.PerformanceRate.ToString();



        }

        private void _UpdateEmployee()

        {
            _Employee.FirstName = tbFirstName.Text;
            _Employee.LastName = tbLastName.Text;
            _Employee.Phone = tbPhone.Text;
            _Employee.Address = tbAddress.Text;
            _Employee.Email = tbEmail.Text;
            _Employee.NationalNo = tbNationalNumber.Text;
            _Employee.DepartmentID = cmbDepartmentID.SelectedIndex + 1;
            _Employee.Salary =Convert.ToSingle (tbSalary.Text);
            _Employee.Bonus = Convert.ToSingle(tbBonus.Text);
            _Employee.PerformanceRate =Convert.ToInt32(  _Employee.PerformanceRate);

            if(_Employee.Save())
            {

                MessageBox.Show("The Employee Saved Seccefully", "Update Employee", MessageBoxButtons.OK);
            }

            else
            {
                MessageBox.Show("The Employee Not Updated", "Update Employee", MessageBoxButtons.OK,MessageBoxIcon.Error);


            }
        }

        private void _AddNewEmployee()
        {
            clsEmployee employee = new clsEmployee();
         

            employee.NationalNo = tbNationalNumber.Text;
            employee.FirstName = tbFirstName.Text;
            employee.LastName = tbLastName.Text;
            employee.Phone = tbPhone.Text;
            employee.Email = tbEmail.Text;
            employee.Address = tbAddress.Text;
            employee.DepartmentID = cmbDepartmentID.SelectedIndex + 1;
            employee.Salary =Convert.ToSingle(tbSalary.Text);
           
            if(string.IsNullOrEmpty(tbBonus.Text))
            {

                employee.Bonus = 0;
            }
            else
            {
                employee.Bonus = Convert.ToSingle(tbBonus.Text);

            }

            if (string.IsNullOrEmpty(tbPerformanceRate.Text))
            {

                employee.PerformanceRate = 0;
            }
            else
            {
                employee.PerformanceRate= Convert.ToInt32(tbPerformanceRate.Text);

            }
            

            if(employee==null)
            {
                MessageBox.Show("The Employee is null", "Save New Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            if (employee.Save())
            {
                _EmployeeID = employee.EmployeeID;
                lblGuestID.Text = employee.EmployeeID.ToString();
                _Employee = clsEmployee.FindEmployeeByID(_EmployeeID);
                MessageBox.Show("The Employee Saved Seccefully", "Save New Employee", MessageBoxButtons.OK);
            }
            else 
            {
                MessageBox.Show("The Employee Not Saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                
            }

        }




        private void tbPerformanceRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbBonus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
          (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;
            if (string.IsNullOrEmpty(textBox.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(textBox, null);
            }
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbEmail.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbEmail, "This field is required!");
            }
            if(!clsValidation.ValidateEmail(tbEmail.Text))
            {

                e.Cancel = true;
                errorProvider1.SetError(tbEmail, "Enter Matches Email Format!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(tbEmail, null);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (Mode==enMode.New)
            {
                  _AddNewEmployee();
                Mode = enMode.Update;
                if (OnEmployeeSelected != null)
                    // Raise the event with a parameter
                    EmployeeSelected(_EmployeeID);

                return;

            }

            if(Mode==enMode.Update)
            {

                _UpdateEmployee();

                if (OnEmployeeSelected != null)
                    // Raise the event with a parameter
                    EmployeeSelected(_EmployeeID);
            }
        }

      
    }
}
