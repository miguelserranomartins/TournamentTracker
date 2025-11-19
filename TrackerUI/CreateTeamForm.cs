using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        public CreateTeamForm()
        {
            InitializeComponent();
        }

        private void btnCreateMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
               PersonModel p = new PersonModel();

                p.FirstName = txtFirstNameValue.Text;
                p.LastName = txtLastNameValue.Text;
                p.EmailAddress = txtEmailValue.Text;
                p.CellphoneNumber = txtCellPhoneValue.Text;
                
                GlobalConfig.Connection.CreatePerson(p);
                txtFirstNameValue.Text = "";
                txtLastNameValue.Text = "";
                txtEmailValue.Text = "";
                txtCellPhoneValue.Text = "";
            }
            else
            {
                MessageBox.Show("You need to fill in all of the fields.");
            }
        }

        private bool ValidateForm()
        {
            if (txtFirstNameValue.Text.Length == 0)
            {
                return false;
            }

            if (txtLastNameValue.Text.Length == 0)
            {
                return false;
            }

            if (txtEmailValue.Text.Length == 0)
            {
                return false;
            }

            if (txtCellPhoneValue.Text.Length == 0)
            {
                return false;
            }
            //TODO - Add validation to the form
            return true;
        }
    }
}
