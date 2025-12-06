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
    public partial class TournamentDashboardForm : Form
    {
        List<TournamentModel> tournaments = GlobalConfig.Connection.GetTournament_All();

        public TournamentDashboardForm()
        {
            InitializeComponent();

            WireUpLists();
        }

        private void WireUpLists()
        {

            LoadExistingTournamentDropDown.DataSource = tournaments;
            LoadExistingTournamentDropDown.DisplayMember = "TournamentName";
        }

        private void btnCreateTournamentButton_Click(object sender, EventArgs e)
        {
            CreateTournamentForm frm = new CreateTournamentForm();
            frm.Show();
        }

        private void btnLoadTournamentButton_Click(object sender, EventArgs e)
        {
            TournamentModel tm = (TournamentModel)LoadExistingTournamentDropDown.SelectedItem;
            TounamentViewerForm frm = new TounamentViewerForm(tm);
            frm.Show();
        }

        private void AddPrizesToTournament(TournamentModel tm, List<PrizeModel> prizes, List<string> prizeIds)
        {
            foreach (string id in prizeIds)
            {
                if (!string.IsNullOrWhiteSpace(id))
                {
                    tm.Prizes.Add(prizes.Where(x => x.Id == int.Parse(id)).First());
                }
            }
        }
    }
}
