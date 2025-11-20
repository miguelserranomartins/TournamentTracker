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
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        IPrizeRequester callingForm;

        public CreatePrizeForm(IPrizeRequester caller)
        {
            InitializeComponent();
            
            callingForm = caller;
        }

        private void btnCreatePrizeButton_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                txtPlaceNameValue.Text, 
                txtPlaceNumberValue.Text, 
                txtPrizeAmountValue.Text, 
                txtPrizePercentageValue.Text);

              
                GlobalConfig.Connection.CreatePrize(model);

                callingForm.PrizeComplete(model);

                this.Close();

                //txtPlaceNameValue.Text="";
                //txtPlaceNumberValue.Text="";
                //txtPrizeAmountValue.Text="0";
                //txtPrizePercentageValue.Text="0";
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
        }
        private bool ValidateForm()
        {
            
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(txtPlaceNumberValue.Text, out placeNumber);

            if (placeNumberValidNumber == false)
            {
                output = false;
            }

            if (placeNumber < 1)
            {
                output = false;
            }
            if (txtPlaceNameValue.Text.Length == 0)
            {
                output = false;
            }
           
            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(txtPrizeAmountValue.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(txtPrizePercentageValue.Text, out prizePercentage);

            if (prizeAmountValid == false || prizePercentageValid == false)
            {
                output = false;
            }

            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }

            if (prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }


            return output;
           
           
        }
    }
}
