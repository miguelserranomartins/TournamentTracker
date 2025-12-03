namespace TrackerUI
{
    partial class TounamentViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblHeaderLabel = new Label();
            lblTournamentName = new Label();
            lblRoundLabel = new Label();
            RoundDropDown = new ComboBox();
            unplayedOnlyCheckBox = new CheckBox();
            matchupListBox = new ListBox();
            lblTeamOneName = new Label();
            lblTeamOneScoreLabel = new Label();
            txtTeamOneScoreValue = new TextBox();
            txtTeamTwoScoreValue = new TextBox();
            lblTeamTwoScoreLabel = new Label();
            lblTeamTwoName = new Label();
            lblVersusLabel = new Label();
            btnScoreButton = new Button();
            SuspendLayout();
            // 
            // lblHeaderLabel
            // 
            lblHeaderLabel.AutoSize = true;
            lblHeaderLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeaderLabel.ForeColor = Color.Blue;
            lblHeaderLabel.Location = new Point(26, 25);
            lblHeaderLabel.Name = "lblHeaderLabel";
            lblHeaderLabel.Size = new Size(214, 50);
            lblHeaderLabel.TabIndex = 0;
            lblHeaderLabel.Text = "Tournament:";
            // 
            // lblTournamentName
            // 
            lblTournamentName.AutoSize = true;
            lblTournamentName.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTournamentName.ForeColor = Color.Blue;
            lblTournamentName.Location = new Point(246, 25);
            lblTournamentName.Name = "lblTournamentName";
            lblTournamentName.Size = new Size(156, 50);
            lblTournamentName.TabIndex = 1;
            lblTournamentName.Text = "<None>";
            // 
            // lblRoundLabel
            // 
            lblRoundLabel.AutoSize = true;
            lblRoundLabel.ForeColor = Color.Blue;
            lblRoundLabel.Location = new Point(36, 104);
            lblRoundLabel.Name = "lblRoundLabel";
            lblRoundLabel.Size = new Size(73, 30);
            lblRoundLabel.TabIndex = 2;
            lblRoundLabel.Text = "Round";
            // 
            // RoundDropDown
            // 
            RoundDropDown.FormattingEnabled = true;
            RoundDropDown.Location = new Point(162, 101);
            RoundDropDown.Name = "RoundDropDown";
            RoundDropDown.Size = new Size(240, 38);
            RoundDropDown.TabIndex = 3;
            RoundDropDown.SelectedIndexChanged += RoundDropDown_SelectedIndexChanged;
            // 
            // unplayedOnlyCheckBox
            // 
            unplayedOnlyCheckBox.AutoSize = true;
            unplayedOnlyCheckBox.FlatStyle = FlatStyle.Flat;
            unplayedOnlyCheckBox.ForeColor = Color.Blue;
            unplayedOnlyCheckBox.Location = new Point(162, 145);
            unplayedOnlyCheckBox.Name = "unplayedOnlyCheckBox";
            unplayedOnlyCheckBox.Size = new Size(165, 34);
            unplayedOnlyCheckBox.TabIndex = 4;
            unplayedOnlyCheckBox.Text = "Unplayed Only";
            unplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            matchupListBox.BorderStyle = BorderStyle.FixedSingle;
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 30;
            matchupListBox.Location = new Point(36, 199);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(366, 302);
            matchupListBox.TabIndex = 5;
            matchupListBox.SelectedIndexChanged += matchupListBox_SelectedIndexChanged;
            // 
            // lblTeamOneName
            // 
            lblTeamOneName.AutoSize = true;
            lblTeamOneName.ForeColor = Color.Blue;
            lblTeamOneName.Location = new Point(464, 199);
            lblTeamOneName.Name = "lblTeamOneName";
            lblTeamOneName.Size = new Size(135, 30);
            lblTeamOneName.TabIndex = 6;
            lblTeamOneName.Text = "<Team One>";
            // 
            // lblTeamOneScoreLabel
            // 
            lblTeamOneScoreLabel.AutoSize = true;
            lblTeamOneScoreLabel.ForeColor = Color.Blue;
            lblTeamOneScoreLabel.Location = new Point(464, 259);
            lblTeamOneScoreLabel.Name = "lblTeamOneScoreLabel";
            lblTeamOneScoreLabel.Size = new Size(64, 30);
            lblTeamOneScoreLabel.TabIndex = 7;
            lblTeamOneScoreLabel.Text = "Score";
            // 
            // txtTeamOneScoreValue
            // 
            txtTeamOneScoreValue.Location = new Point(534, 259);
            txtTeamOneScoreValue.Name = "txtTeamOneScoreValue";
            txtTeamOneScoreValue.Size = new Size(100, 35);
            txtTeamOneScoreValue.TabIndex = 8;
            // 
            // txtTeamTwoScoreValue
            // 
            txtTeamTwoScoreValue.Location = new Point(533, 466);
            txtTeamTwoScoreValue.Name = "txtTeamTwoScoreValue";
            txtTeamTwoScoreValue.Size = new Size(100, 35);
            txtTeamTwoScoreValue.TabIndex = 11;
            // 
            // lblTeamTwoScoreLabel
            // 
            lblTeamTwoScoreLabel.AutoSize = true;
            lblTeamTwoScoreLabel.ForeColor = Color.Blue;
            lblTeamTwoScoreLabel.Location = new Point(463, 466);
            lblTeamTwoScoreLabel.Name = "lblTeamTwoScoreLabel";
            lblTeamTwoScoreLabel.Size = new Size(64, 30);
            lblTeamTwoScoreLabel.TabIndex = 10;
            lblTeamTwoScoreLabel.Text = "Score";
            // 
            // lblTeamTwoName
            // 
            lblTeamTwoName.AutoSize = true;
            lblTeamTwoName.ForeColor = Color.Blue;
            lblTeamTwoName.Location = new Point(464, 406);
            lblTeamTwoName.Name = "lblTeamTwoName";
            lblTeamTwoName.Size = new Size(133, 30);
            lblTeamTwoName.TabIndex = 9;
            lblTeamTwoName.Text = "<Team Two>";
            // 
            // lblVersusLabel
            // 
            lblVersusLabel.AutoSize = true;
            lblVersusLabel.ForeColor = Color.Blue;
            lblVersusLabel.Location = new Point(514, 336);
            lblVersusLabel.Name = "lblVersusLabel";
            lblVersusLabel.Size = new Size(53, 30);
            lblVersusLabel.TabIndex = 12;
            lblVersusLabel.Text = "-VS-";
            // 
            // btnScoreButton
            // 
            btnScoreButton.FlatAppearance.BorderColor = Color.Silver;
            btnScoreButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnScoreButton.FlatAppearance.MouseOverBackColor = Color.White;
            btnScoreButton.FlatStyle = FlatStyle.Flat;
            btnScoreButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnScoreButton.ForeColor = Color.Blue;
            btnScoreButton.Location = new Point(696, 316);
            btnScoreButton.Name = "btnScoreButton";
            btnScoreButton.Size = new Size(124, 89);
            btnScoreButton.TabIndex = 13;
            btnScoreButton.Text = "Score";
            btnScoreButton.UseVisualStyleBackColor = true;
            btnScoreButton.Click += btnScoreButton_Click;
            // 
            // TounamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(862, 542);
            Controls.Add(btnScoreButton);
            Controls.Add(lblVersusLabel);
            Controls.Add(txtTeamTwoScoreValue);
            Controls.Add(lblTeamTwoScoreLabel);
            Controls.Add(lblTeamTwoName);
            Controls.Add(txtTeamOneScoreValue);
            Controls.Add(lblTeamOneScoreLabel);
            Controls.Add(lblTeamOneName);
            Controls.Add(matchupListBox);
            Controls.Add(unplayedOnlyCheckBox);
            Controls.Add(RoundDropDown);
            Controls.Add(lblRoundLabel);
            Controls.Add(lblTournamentName);
            Controls.Add(lblHeaderLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "TounamentViewerForm";
            Text = "Tournament Viewer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeaderLabel;
        private Label lblTournamentName;
        private Label lblRoundLabel;
        private ComboBox RoundDropDown;
        private CheckBox unplayedOnlyCheckBox;
        private ListBox matchupListBox;
        private Label lblTeamOneName;
        private Label lblTeamOneScoreLabel;
        private TextBox txtTeamOneScoreValue;
        private TextBox txtTeamTwoScoreValue;
        private Label lblTeamTwoScoreLabel;
        private Label lblTeamTwoName;
        private Label lblVersusLabel;
        private Button btnScoreButton;
    }
}
