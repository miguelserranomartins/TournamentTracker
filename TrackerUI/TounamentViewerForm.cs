using System.ComponentModel;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class TounamentViewerForm : Form
    {
        private TournamentModel tournament;
        BindingList<int> rounds = new BindingList<int>();
        BindingList<MatchupModel> selectedMatchups = new BindingList<MatchupModel>();



        public TounamentViewerForm(TournamentModel tournamentModel)
        {
            InitializeComponent();

            tournament = tournamentModel;

            WireUpLists();

            LoadFormData();

            LoadRounds();
        }

        private void LoadFormData()
        {
            lblTournamentName.Text = tournament.TournamentName;
        }

        private void WireUpLists()
        {

            RoundDropDown.DataSource = rounds;
            matchupListBox.DataSource = selectedMatchups;
            matchupListBox.DisplayMember = "DisplayName";

        }

        private void LoadRounds()
        {

            rounds.Clear();

            rounds.Add(1);
            int currRound = 1;

            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound > currRound)
                {
                    currRound = matchups.First().MatchupRound;
                    rounds.Add(currRound);
                }
            }

            LoadMatchups(1);

        }

        private void RoundDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)RoundDropDown.SelectedItem);

        }

        private void LoadMatchups(int round)
        {
            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound == round)
                {
                    selectedMatchups.Clear();
                    foreach (MatchupModel m in matchups)
                    {
                        if (m.Winner == null || !unplayedOnlyCheckBox.Checked)
                        {
                            selectedMatchups.Add(m);
                        }                  
                    }

                }
            }
            if (selectedMatchups.Count > 0)
            {
                LoadMatchup(selectedMatchups.First());
            }

            DisplayMatchupInfo();
        }

        private void DisplayMatchupInfo()
        {

            bool isVisible = (selectedMatchups.Count > 0);
            lblTeamOneName.Visible = isVisible;
            lblTeamTwoName.Visible = isVisible;
            txtTeamOneScoreValue.Visible = isVisible;
            txtTeamTwoScoreValue.Visible = isVisible;
            lblTeamOneScoreLabel.Visible = isVisible;
            lblTeamTwoScoreLabel.Visible = isVisible;
            lblVersusLabel.Visible = isVisible;
            btnScoreButton.Visible = isVisible;
   
           
        }

        private void LoadMatchup(MatchupModel m)
        {
            if(m == null)
            {
                return;
            }

            lblTeamOneName.Text = "";
            txtTeamOneScoreValue.Text = "";
            lblTeamTwoName.Text = "";
            txtTeamTwoScoreValue.Text = "";

            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {
                        lblTeamOneName.Text = m.Entries[0].TeamCompeting.TeamName;
                        txtTeamOneScoreValue.Text = m.Entries[0].Score.ToString();
                      
                    }
                    else
                    {
                        lblTeamOneName.Text = "Not yet set";
                        txtTeamOneScoreValue.Text = "";
                    }
                }
                if (i == 1)
                {
                    if (m.Entries[1].TeamCompeting != null)
                    {
                        lblTeamTwoName.Text = m.Entries[1].TeamCompeting.TeamName;
                        txtTeamTwoScoreValue.Text = m.Entries[1].Score.ToString();
                    }
                    else
                    {
                        lblTeamTwoName.Text = "Not yet set";
                        txtTeamTwoScoreValue.Text = "";
                    }
                }
                if (m.Entries.Count == 1)
                {
                    lblTeamTwoName.Text = "<bye>";
                    txtTeamTwoScoreValue.Text = "0";
                }
            }
        }
        



        private void matchupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchup((MatchupModel)matchupListBox.SelectedItem);
        }

        private void unplayedOnlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)RoundDropDown.SelectedItem);
        }

        private string ValidateData()
        {
            string output = "";

           double teamOneScore = 0;
           double teamTwoScore = 0;

           bool scoreOneValid = double.TryParse(txtTeamOneScoreValue.Text, out teamOneScore);
           bool scoreTwoValid = double.TryParse(txtTeamTwoScoreValue.Text, out teamTwoScore);
    
                if (!scoreOneValid)
                {
                 output = "the score One value is not a valid number" ;
                }

                else if (!scoreTwoValid)
                {
                output = "the score Two value is not a valid number";
                }


                else if (teamOneScore == 0 && teamTwoScore == 0)
                {
                 output = "you did not enter a score for either team";
                }
    
                else if (teamOneScore ==  teamTwoScore)
                {
                 output = "we do not allow ties in this application";
                }
    
                return output;
        }

        private void btnScoreButton_Click(object sender, EventArgs e)
        {

            string errorMessage = ValidateData();
            if (errorMessage.Length > 0)
            { 
            MessageBox.Show($"Input Error: {errorMessage}");
                return;
            }
            MatchupModel m = (MatchupModel)matchupListBox.SelectedItem;
            double teamOneScore = 0;
            double teamTwoScore = 0;

            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {   
                        bool scoreValid = double.TryParse(txtTeamOneScoreValue.Text, out teamOneScore);

                        if (scoreValid)
                        {
                            m.Entries[0].Score = teamOneScore;
                        }

                        else
                        {
                            MessageBox.Show("You must enter a valid score for team one.");
                            return;
                        }
                    }
                }

                if (i == 1)
                {
                    if (m.Entries[1].TeamCompeting != null)
                    {        
                        bool scoreValid = double.TryParse(txtTeamTwoScoreValue.Text, out teamTwoScore);

                        if (scoreValid)
                        {
                            m.Entries[1].Score = teamTwoScore;
                        }
                        else
                        {
                            MessageBox.Show("You must enter a valid score for team two.");
                            return;
                        }
                    }
                }
            }
            try
            {
                TournamentLogic.UpdateTournamentResults(tournament);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"The application had the following error: { ex.Message }");
                return;
            }

            LoadMatchups((int)RoundDropDown.SelectedItem);
        }
    }
}
