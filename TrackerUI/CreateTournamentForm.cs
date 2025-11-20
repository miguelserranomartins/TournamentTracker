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

    public partial class CreateTournamentForm : Form, IPrizeRequester, ITeamRequester
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();

        List<TeamModel> selectedTeams = new List<TeamModel>();

        List<PrizeModel> selectedPrizes = new List<PrizeModel>();

        public CreateTournamentForm()
        {
            InitializeComponent();
            WireUpLists();
        }
        private void WireUpLists()
        {
            SelectTeamDropDown.DataSource = null;
            SelectTeamDropDown.DataSource = availableTeams;
            SelectTeamDropDown.DisplayMember = "TeamName";

            tournamentTeamsListBox.DataSource = null;
            tournamentTeamsListBox.DataSource = selectedTeams;
            tournamentTeamsListBox.DisplayMember = "TeamName";

            PrizesListBox.DataSource = null;
            PrizesListBox.DataSource = selectedPrizes;
            PrizesListBox.DisplayMember = "PlaceName";
        }

        private void SelectTeamDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)SelectTeamDropDown.SelectedItem;

            if (t != null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);
                WireUpLists();
            }
        }

        private void btnCreatePrizeButton_Click(object sender, EventArgs e)
        {
            // Call the CreatePrizeForm

            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show();
        }

        public void PrizeComplete(PrizeModel model)
        {
            // Take the PrizeModel and put it into our selectedPrizes list

            selectedPrizes.Add(model);
            WireUpLists();
        }

        public void teamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireUpLists();
        }

        private void CreateNewTeam_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm frm = new CreateTeamForm(this);
            frm.Show();
        }

        private void btnRemoveSelectedPlayersButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)tournamentTeamsListBox.SelectedItem;
            if (t != null)
            {
                selectedTeams.Remove(t);
                availableTeams.Add(t);
                WireUpLists();
            }
        }

        private void btnRemoveSelectedPrizeButton_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)PrizesListBox.SelectedItem;
            if (p != null)
            {
                selectedPrizes.Remove(p);
                WireUpLists();
            }
        }

        private void btnCreateTournamentButton_Click(object sender, EventArgs e)
        {
            // Create Tournament logic
            // Validate data

            decimal fee = 0;
            
            bool feeAcceptable = decimal.TryParse(txtEntryFeeValue.Text, out fee);
            
            if (!feeAcceptable)
            {
                MessageBox.Show("You need to enter a valid Entry Fee.", "Invalid Fee",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Create Tournament model
            TournamentModel tm = new TournamentModel();

            tm.TournamentName = txtTournamentNameValue.Text;
            tm.EntryFee = fee;
            tm.Prizes = selectedPrizes;
            tm.EnteredTeams = selectedTeams;

            // Create our matchups


            //Create tournament entry
            //Create All of the prizes entries
            //Create All of team entries

            GlobalConfig.Connection.CreateTournament(tm);

            //tm.TournamentName = txtTournamentNameValue.Text;

            //tm.Rounds = TournementLogic.CreateRounds(tm.EnterdTeams);

        }
    }
}

