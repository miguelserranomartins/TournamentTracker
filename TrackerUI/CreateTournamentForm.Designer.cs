namespace TrackerUI
{
    partial class CreateTournamentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblHeaderLabel = new Label();
            txtTournamentNameValue = new TextBox();
            lblTournamentNameLabel = new Label();
            txtEntryFeeValue = new TextBox();
            lblEntryFeeLabel = new Label();
            SelectTeamDropDown = new ComboBox();
            lblSelectTeamLabel = new Label();
            CreateNewTeam = new LinkLabel();
            btnAddTeamButton = new Button();
            btnCreatePrizeButton = new Button();
            tournamentTeamsListBox = new ListBox();
            lblTournamentPlayersLabel = new Label();
            btnRemoveSelectedPlayersButton = new Button();
            btnRemoveSelectedPrizeButton = new Button();
            lblPrizesLabel = new Label();
            PrizesListBox = new ListBox();
            btnCreateTournamentButton = new Button();
            SuspendLayout();
            // 
            // lblHeaderLabel
            // 
            lblHeaderLabel.AutoSize = true;
            lblHeaderLabel.FlatStyle = FlatStyle.Flat;
            lblHeaderLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeaderLabel.ForeColor = Color.Blue;
            lblHeaderLabel.Location = new Point(38, 45);
            lblHeaderLabel.Name = "lblHeaderLabel";
            lblHeaderLabel.Size = new Size(317, 50);
            lblHeaderLabel.TabIndex = 1;
            lblHeaderLabel.Text = "Create Tournament";
            // 
            // txtTournamentNameValue
            // 
            txtTournamentNameValue.Location = new Point(38, 201);
            txtTournamentNameValue.Name = "txtTournamentNameValue";
            txtTournamentNameValue.Size = new Size(325, 35);
            txtTournamentNameValue.TabIndex = 10;
            // 
            // lblTournamentNameLabel
            // 
            lblTournamentNameLabel.AutoSize = true;
            lblTournamentNameLabel.ForeColor = Color.Blue;
            lblTournamentNameLabel.Location = new Point(38, 151);
            lblTournamentNameLabel.Name = "lblTournamentNameLabel";
            lblTournamentNameLabel.Size = new Size(186, 30);
            lblTournamentNameLabel.TabIndex = 9;
            lblTournamentNameLabel.Text = "Tournament Name";
            // 
            // txtEntryFeeValue
            // 
            txtEntryFeeValue.Location = new Point(158, 271);
            txtEntryFeeValue.Name = "txtEntryFeeValue";
            txtEntryFeeValue.Size = new Size(205, 35);
            txtEntryFeeValue.TabIndex = 12;
            txtEntryFeeValue.Text = "0";
            // 
            // lblEntryFeeLabel
            // 
            lblEntryFeeLabel.AutoSize = true;
            lblEntryFeeLabel.ForeColor = Color.Blue;
            lblEntryFeeLabel.Location = new Point(38, 271);
            lblEntryFeeLabel.Name = "lblEntryFeeLabel";
            lblEntryFeeLabel.Size = new Size(98, 30);
            lblEntryFeeLabel.TabIndex = 11;
            lblEntryFeeLabel.Text = "Entry Fee";
            // 
            // SelectTeamDropDown
            // 
            SelectTeamDropDown.FormattingEnabled = true;
            SelectTeamDropDown.Location = new Point(38, 403);
            SelectTeamDropDown.Name = "SelectTeamDropDown";
            SelectTeamDropDown.Size = new Size(325, 38);
            SelectTeamDropDown.TabIndex = 14;
            SelectTeamDropDown.SelectedIndexChanged += SelectTeamDropDown_SelectedIndexChanged;
            // 
            // lblSelectTeamLabel
            // 
            lblSelectTeamLabel.AutoSize = true;
            lblSelectTeamLabel.ForeColor = Color.Blue;
            lblSelectTeamLabel.Location = new Point(38, 349);
            lblSelectTeamLabel.Name = "lblSelectTeamLabel";
            lblSelectTeamLabel.Size = new Size(123, 30);
            lblSelectTeamLabel.TabIndex = 13;
            lblSelectTeamLabel.Text = "Select Team";
            // 
            // CreateNewTeam
            // 
            CreateNewTeam.AutoSize = true;
            CreateNewTeam.LinkColor = Color.Fuchsia;
            CreateNewTeam.Location = new Point(249, 349);
            CreateNewTeam.Name = "CreateNewTeam";
            CreateNewTeam.Size = new Size(114, 30);
            CreateNewTeam.TabIndex = 15;
            CreateNewTeam.TabStop = true;
            CreateNewTeam.Text = "create new";
            CreateNewTeam.LinkClicked += CreateNewTeam_LinkClicked;
            // 
            // btnAddTeamButton
            // 
            btnAddTeamButton.FlatAppearance.BorderColor = Color.Silver;
            btnAddTeamButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnAddTeamButton.FlatAppearance.MouseOverBackColor = Color.White;
            btnAddTeamButton.FlatStyle = FlatStyle.Flat;
            btnAddTeamButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddTeamButton.ForeColor = Color.Blue;
            btnAddTeamButton.Location = new Point(38, 472);
            btnAddTeamButton.Name = "btnAddTeamButton";
            btnAddTeamButton.Size = new Size(325, 58);
            btnAddTeamButton.TabIndex = 16;
            btnAddTeamButton.Text = "Add Team";
            btnAddTeamButton.UseVisualStyleBackColor = true;
            btnAddTeamButton.Click += btnAddTeamButton_Click;
            // 
            // btnCreatePrizeButton
            // 
            btnCreatePrizeButton.FlatAppearance.BorderColor = Color.Silver;
            btnCreatePrizeButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnCreatePrizeButton.FlatAppearance.MouseOverBackColor = Color.White;
            btnCreatePrizeButton.FlatStyle = FlatStyle.Flat;
            btnCreatePrizeButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreatePrizeButton.ForeColor = Color.Blue;
            btnCreatePrizeButton.Location = new Point(38, 550);
            btnCreatePrizeButton.Name = "btnCreatePrizeButton";
            btnCreatePrizeButton.Size = new Size(325, 58);
            btnCreatePrizeButton.TabIndex = 17;
            btnCreatePrizeButton.Text = "Create Prize";
            btnCreatePrizeButton.UseVisualStyleBackColor = true;
            btnCreatePrizeButton.Click += btnCreatePrizeButton_Click;
            // 
            // tournamentTeamsListBox
            // 
            tournamentTeamsListBox.BorderStyle = BorderStyle.FixedSingle;
            tournamentTeamsListBox.FormattingEnabled = true;
            tournamentTeamsListBox.ItemHeight = 30;
            tournamentTeamsListBox.Location = new Point(453, 184);
            tournamentTeamsListBox.Name = "tournamentTeamsListBox";
            tournamentTeamsListBox.Size = new Size(366, 182);
            tournamentTeamsListBox.TabIndex = 18;
            // 
            // lblTournamentPlayersLabel
            // 
            lblTournamentPlayersLabel.AutoSize = true;
            lblTournamentPlayersLabel.ForeColor = Color.Blue;
            lblTournamentPlayersLabel.Location = new Point(453, 151);
            lblTournamentPlayersLabel.Name = "lblTournamentPlayersLabel";
            lblTournamentPlayersLabel.Size = new Size(156, 30);
            lblTournamentPlayersLabel.TabIndex = 19;
            lblTournamentPlayersLabel.Text = "Teams / Players";
            // 
            // btnRemoveSelectedPlayersButton
            // 
            btnRemoveSelectedPlayersButton.FlatAppearance.BorderColor = Color.Silver;
            btnRemoveSelectedPlayersButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnRemoveSelectedPlayersButton.FlatAppearance.MouseOverBackColor = Color.White;
            btnRemoveSelectedPlayersButton.FlatStyle = FlatStyle.Flat;
            btnRemoveSelectedPlayersButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveSelectedPlayersButton.ForeColor = Color.Blue;
            btnRemoveSelectedPlayersButton.Location = new Point(841, 242);
            btnRemoveSelectedPlayersButton.Name = "btnRemoveSelectedPlayersButton";
            btnRemoveSelectedPlayersButton.Size = new Size(124, 89);
            btnRemoveSelectedPlayersButton.TabIndex = 20;
            btnRemoveSelectedPlayersButton.Text = "Remove Selected";
            btnRemoveSelectedPlayersButton.UseVisualStyleBackColor = true;
            btnRemoveSelectedPlayersButton.Click += btnRemoveSelectedPlayersButton_Click;
            // 
            // btnRemoveSelectedPrizeButton
            // 
            btnRemoveSelectedPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            btnRemoveSelectedPrizeButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnRemoveSelectedPrizeButton.FlatAppearance.MouseOverBackColor = Color.White;
            btnRemoveSelectedPrizeButton.FlatStyle = FlatStyle.Flat;
            btnRemoveSelectedPrizeButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveSelectedPrizeButton.ForeColor = Color.Blue;
            btnRemoveSelectedPrizeButton.Location = new Point(841, 472);
            btnRemoveSelectedPrizeButton.Name = "btnRemoveSelectedPrizeButton";
            btnRemoveSelectedPrizeButton.Size = new Size(124, 89);
            btnRemoveSelectedPrizeButton.TabIndex = 23;
            btnRemoveSelectedPrizeButton.Text = "Remove Selected";
            btnRemoveSelectedPrizeButton.UseVisualStyleBackColor = true;
            btnRemoveSelectedPrizeButton.Click += btnRemoveSelectedPrizeButton_Click;
            // 
            // lblPrizesLabel
            // 
            lblPrizesLabel.AutoSize = true;
            lblPrizesLabel.ForeColor = Color.Blue;
            lblPrizesLabel.Location = new Point(453, 394);
            lblPrizesLabel.Name = "lblPrizesLabel";
            lblPrizesLabel.Size = new Size(67, 30);
            lblPrizesLabel.TabIndex = 22;
            lblPrizesLabel.Text = "Prizes";
            // 
            // PrizesListBox
            // 
            PrizesListBox.BorderStyle = BorderStyle.FixedSingle;
            PrizesListBox.FormattingEnabled = true;
            PrizesListBox.ItemHeight = 30;
            PrizesListBox.Location = new Point(453, 427);
            PrizesListBox.Name = "PrizesListBox";
            PrizesListBox.Size = new Size(366, 182);
            PrizesListBox.TabIndex = 21;
            // 
            // btnCreateTournamentButton
            // 
            btnCreateTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            btnCreateTournamentButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnCreateTournamentButton.FlatAppearance.MouseOverBackColor = Color.White;
            btnCreateTournamentButton.FlatStyle = FlatStyle.Flat;
            btnCreateTournamentButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateTournamentButton.ForeColor = Color.Blue;
            btnCreateTournamentButton.Location = new Point(301, 637);
            btnCreateTournamentButton.Name = "btnCreateTournamentButton";
            btnCreateTournamentButton.Size = new Size(325, 58);
            btnCreateTournamentButton.TabIndex = 24;
            btnCreateTournamentButton.Text = "Create Tournament";
            btnCreateTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1002, 718);
            Controls.Add(btnCreateTournamentButton);
            Controls.Add(btnRemoveSelectedPrizeButton);
            Controls.Add(lblPrizesLabel);
            Controls.Add(PrizesListBox);
            Controls.Add(btnRemoveSelectedPlayersButton);
            Controls.Add(lblTournamentPlayersLabel);
            Controls.Add(tournamentTeamsListBox);
            Controls.Add(btnCreatePrizeButton);
            Controls.Add(btnAddTeamButton);
            Controls.Add(CreateNewTeam);
            Controls.Add(SelectTeamDropDown);
            Controls.Add(lblSelectTeamLabel);
            Controls.Add(txtEntryFeeValue);
            Controls.Add(lblEntryFeeLabel);
            Controls.Add(txtTournamentNameValue);
            Controls.Add(lblTournamentNameLabel);
            Controls.Add(lblHeaderLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTournamentForm";
            Text = "Create Tournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeaderLabel;
        private TextBox txtTournamentNameValue;
        private Label lblTournamentNameLabel;
        private TextBox txtEntryFeeValue;
        private Label lblEntryFeeLabel;
        private ComboBox SelectTeamDropDown;
        private Label lblSelectTeamLabel;
        private LinkLabel CreateNewTeam;
        private Button btnAddTeamButton;
        private Button btnCreatePrizeButton;
        private ListBox tournamentTeamsListBox;
        private Label lblTournamentPlayersLabel;
        private Button btnRemoveSelectedPlayersButton;
        private Button btnRemoveSelectedPrizeButton;
        private Label lblPrizesLabel;
        private ListBox PrizesListBox;
        private Button btnCreateTournamentButton;
    }
}