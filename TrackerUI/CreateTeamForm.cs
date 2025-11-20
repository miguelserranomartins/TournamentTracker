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

        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        private ITeamRequester callingForm;
        public CreateTeamForm(ITeamRequester caller)
        {
            InitializeComponent();

            callingForm = caller;
           
            //CreateSampleData();

            WireUpLists();
        }



        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Tim", LastName = "Corey" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Sue", LastName = "Storm" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Jane", LastName = "Smith" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Bill", LastName = "Jones" });
        }

        private void WireUpLists()
        {
            SelectTeamMemberDropDown.DataSource = null;

            SelectTeamMemberDropDown.DataSource = availableTeamMembers;
            SelectTeamMemberDropDown.DisplayMember = "FullName";

            TeamMembersListBox.DataSource = null;

            TeamMembersListBox.DataSource = selectedTeamMembers;
            TeamMembersListBox.DisplayMember = "FullName";
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

                p = GlobalConfig.Connection.CreatePerson(p);

                selectedTeamMembers.Add(p);
                WireUpLists();

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

        private void TeamMembersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)SelectTeamMemberDropDown.SelectedItem;
            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);
                WireUpLists();
            }


        }

        private void btnRemoveSelectedMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)TeamMembersListBox.SelectedItem;

            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                WireUpLists();
            }
        }

        private void btnCreateTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();
           
            t.TeamName = txtTeamNameValue.Text;
            t.TeamMembers = selectedTeamMembers;
            
            GlobalConfig.Connection.CreateTeam(t);
            
            callingForm.teamComplete(t);
            
            this.Close();

        }
    }
}
