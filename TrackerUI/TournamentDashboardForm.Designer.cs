namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            lblTournamentDashboardLabel = new Label();
            LoadExistingTournamentDropDown = new ComboBox();
            lblLoadExistingTournamentLabel = new Label();
            btnLoadTournamentButton = new Button();
            btnCreateTournamentButton = new Button();
            SuspendLayout();
            // 
            // lblTournamentDashboardLabel
            // 
            lblTournamentDashboardLabel.AutoSize = true;
            lblTournamentDashboardLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTournamentDashboardLabel.ForeColor = Color.Blue;
            lblTournamentDashboardLabel.Location = new Point(200, 32);
            lblTournamentDashboardLabel.Name = "lblTournamentDashboardLabel";
            lblTournamentDashboardLabel.Size = new Size(385, 50);
            lblTournamentDashboardLabel.TabIndex = 4;
            lblTournamentDashboardLabel.Text = "Tournament Dashboard";
            // 
            // LoadExistingTournamentDropDown
            // 
            LoadExistingTournamentDropDown.FormattingEnabled = true;
            LoadExistingTournamentDropDown.Location = new Point(69, 182);
            LoadExistingTournamentDropDown.Name = "LoadExistingTournamentDropDown";
            LoadExistingTournamentDropDown.Size = new Size(646, 38);
            LoadExistingTournamentDropDown.TabIndex = 20;
            // 
            // lblLoadExistingTournamentLabel
            // 
            lblLoadExistingTournamentLabel.AutoSize = true;
            lblLoadExistingTournamentLabel.ForeColor = Color.Blue;
            lblLoadExistingTournamentLabel.Location = new Point(266, 117);
            lblLoadExistingTournamentLabel.Name = "lblLoadExistingTournamentLabel";
            lblLoadExistingTournamentLabel.Size = new Size(252, 30);
            lblLoadExistingTournamentLabel.TabIndex = 19;
            lblLoadExistingTournamentLabel.Text = "Load Existing Tournament";
            // 
            // btnLoadTournamentButton
            // 
            btnLoadTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            btnLoadTournamentButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnLoadTournamentButton.FlatAppearance.MouseOverBackColor = Color.White;
            btnLoadTournamentButton.FlatStyle = FlatStyle.Flat;
            btnLoadTournamentButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoadTournamentButton.ForeColor = Color.Blue;
            btnLoadTournamentButton.Location = new Point(230, 255);
            btnLoadTournamentButton.Name = "btnLoadTournamentButton";
            btnLoadTournamentButton.Size = new Size(325, 58);
            btnLoadTournamentButton.TabIndex = 21;
            btnLoadTournamentButton.Text = "Load Tournament";
            btnLoadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // btnCreateTournamentButton
            // 
            btnCreateTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            btnCreateTournamentButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnCreateTournamentButton.FlatAppearance.MouseOverBackColor = Color.White;
            btnCreateTournamentButton.FlatStyle = FlatStyle.Flat;
            btnCreateTournamentButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateTournamentButton.ForeColor = Color.Blue;
            btnCreateTournamentButton.Location = new Point(144, 348);
            btnCreateTournamentButton.Name = "btnCreateTournamentButton";
            btnCreateTournamentButton.Size = new Size(496, 152);
            btnCreateTournamentButton.TabIndex = 22;
            btnCreateTournamentButton.Text = "Create Tournament";
            btnCreateTournamentButton.UseVisualStyleBackColor = true;
            btnCreateTournamentButton.Click += btnCreateTournamentButton_Click;
            // 
            // TournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(794, 523);
            Controls.Add(btnCreateTournamentButton);
            Controls.Add(btnLoadTournamentButton);
            Controls.Add(LoadExistingTournamentDropDown);
            Controls.Add(lblLoadExistingTournamentLabel);
            Controls.Add(lblTournamentDashboardLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "TournamentDashboardForm";
            Text = "e4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTournamentDashboardLabel;
        private ComboBox LoadExistingTournamentDropDown;
        private Label lblLoadExistingTournamentLabel;
        private Button btnLoadTournamentButton;
        private Button btnCreateTournamentButton;
    }
}