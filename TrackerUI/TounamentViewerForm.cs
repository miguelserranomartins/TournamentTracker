using System.ComponentModel;
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


        private void btnScoreButton_Click(object sender, EventArgs e)
        {

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
                    foreach(MatchupModel m in matchups)
                    {
                        selectedMatchups.Add(m);
                    }
                   
                }
            }
            LoadMatchup(selectedMatchups.First());
        }

        private void LoadMatchup(MatchupModel m )
        {
            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {
                        lblTeamOneName.Text = m.Entries[0].TeamCompeting.TeamName;
                        txtTeamOneScoreValue.Text = m.Entries[0].Score.ToString();

                        lblTeamOneName.Text = "<bye>";
                        txtTeamOneScoreValue.Text = "0";
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
                        lblTeamTwoName.Text = m.Entries[0].TeamCompeting.TeamName;
                        txtTeamTwoScoreValue.Text = m.Entries[1].Score.ToString();
                    }
                    else
                    {
                        lblTeamOneName.Text = "Not yet set";
                        txtTeamOneScoreValue.Text = "";
                    }
                }
            }
        }

        

        private void matchupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchup((MatchupModel)matchupListBox.SelectedItem);
        }
    }
}
