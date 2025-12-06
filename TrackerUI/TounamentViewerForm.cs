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

        private void btnScoreButton_Click(object sender, EventArgs e)
        {
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
            if (teamOneScore == teamTwoScore)
            {
                MessageBox.Show("We do not allow ties in this application.");
                return;
            }

            if (teamOneScore > teamTwoScore)
            {
                m.Winner = m.Entries[0].TeamCompeting;
            }
            else if (teamTwoScore > teamOneScore)
            {
                m.Winner = m.Entries[1].TeamCompeting;
            }
           

            foreach (List<MatchupModel> round in tournament.Rounds)
            {
                foreach (MatchupModel rm in round)
                {
                    foreach (MatchupEntryModel me in rm.Entries)
                    {
                        if (me.ParentMatchup != null)
                        {
                            if (me.ParentMatchup.Id == m.Id)
                            {
                                me.TeamCompeting = m.Winner;
                                GlobalConfig.Connection.UpdateMatchup(rm);
                            }
                        }
                    }
                }
            }

            LoadMatchups((int)RoundDropDown.SelectedItem);

            GlobalConfig.Connection.UpdateMatchup(m);
        }
    }
}
