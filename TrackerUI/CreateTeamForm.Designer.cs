namespace TrackerUI
{
    partial class CreateTeamForm
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
            txtTeamNameValue = new TextBox();
            lblTeamNameLabel = new Label();
            btnAddMemberButton = new Button();
            SelectTeamMemberDropDown = new ComboBox();
            lblSelectTeamMemberLabel = new Label();
            addNewMemberGroupBox = new GroupBox();
            btnCreateMemberButton = new Button();
            txtCellPhoneValue = new TextBox();
            lblCellphoneLabel = new Label();
            txtEmailValue = new TextBox();
            lblEmailLabel = new Label();
            txtLastNameValue = new TextBox();
            lblLastNameLabel = new Label();
            txtFirstNameValue = new TextBox();
            lblFirstNameLabel = new Label();
            TeamMembersListBox = new ListBox();
            btnRemoveSelectedMemberButton = new Button();
            btnCreateTeamButton = new Button();
            addNewMemberGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeaderLabel
            // 
            lblHeaderLabel.AutoSize = true;
            lblHeaderLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeaderLabel.ForeColor = Color.Blue;
            lblHeaderLabel.Location = new Point(202, 22);
            lblHeaderLabel.Name = "lblHeaderLabel";
            lblHeaderLabel.Size = new Size(213, 50);
            lblHeaderLabel.TabIndex = 2;
            lblHeaderLabel.Text = "Create Team";
            // 
            // txtTeamNameValue
            // 
            txtTeamNameValue.Location = new Point(23, 153);
            txtTeamNameValue.Name = "txtTeamNameValue";
            txtTeamNameValue.Size = new Size(646, 35);
            txtTeamNameValue.TabIndex = 12;
            // 
            // lblTeamNameLabel
            // 
            lblTeamNameLabel.AutoSize = true;
            lblTeamNameLabel.ForeColor = Color.Blue;
            lblTeamNameLabel.Location = new Point(245, 102);
            lblTeamNameLabel.Name = "lblTeamNameLabel";
            lblTeamNameLabel.Size = new Size(124, 30);
            lblTeamNameLabel.TabIndex = 11;
            lblTeamNameLabel.Text = "Team Name";
            // 
            // btnAddMemberButton
            // 
            btnAddMemberButton.FlatAppearance.BorderColor = Color.Silver;
            btnAddMemberButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnAddMemberButton.FlatAppearance.MouseOverBackColor = Color.White;
            btnAddMemberButton.FlatStyle = FlatStyle.Flat;
            btnAddMemberButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddMemberButton.ForeColor = Color.Blue;
            btnAddMemberButton.Location = new Point(159, 342);
            btnAddMemberButton.Name = "btnAddMemberButton";
            btnAddMemberButton.Size = new Size(325, 58);
            btnAddMemberButton.TabIndex = 19;
            btnAddMemberButton.Text = "Add Member";
            btnAddMemberButton.UseVisualStyleBackColor = true;
            btnAddMemberButton.Click += btnAddMemberButton_Click;
            // 
            // SelectTeamMemberDropDown
            // 
            SelectTeamMemberDropDown.FormattingEnabled = true;
            SelectTeamMemberDropDown.Location = new Point(23, 279);
            SelectTeamMemberDropDown.Name = "SelectTeamMemberDropDown";
            SelectTeamMemberDropDown.Size = new Size(646, 38);
            SelectTeamMemberDropDown.TabIndex = 18;
            // 
            // lblSelectTeamMemberLabel
            // 
            lblSelectTeamMemberLabel.AutoSize = true;
            lblSelectTeamMemberLabel.ForeColor = Color.Blue;
            lblSelectTeamMemberLabel.Location = new Point(208, 218);
            lblSelectTeamMemberLabel.Name = "lblSelectTeamMemberLabel";
            lblSelectTeamMemberLabel.Size = new Size(207, 30);
            lblSelectTeamMemberLabel.TabIndex = 17;
            lblSelectTeamMemberLabel.Text = "Select Team Member";
            // 
            // addNewMemberGroupBox
            // 
            addNewMemberGroupBox.Controls.Add(btnCreateMemberButton);
            addNewMemberGroupBox.Controls.Add(txtCellPhoneValue);
            addNewMemberGroupBox.Controls.Add(lblCellphoneLabel);
            addNewMemberGroupBox.Controls.Add(txtEmailValue);
            addNewMemberGroupBox.Controls.Add(lblEmailLabel);
            addNewMemberGroupBox.Controls.Add(txtLastNameValue);
            addNewMemberGroupBox.Controls.Add(lblLastNameLabel);
            addNewMemberGroupBox.Controls.Add(txtFirstNameValue);
            addNewMemberGroupBox.Controls.Add(lblFirstNameLabel);
            addNewMemberGroupBox.ForeColor = Color.Blue;
            addNewMemberGroupBox.Location = new Point(23, 427);
            addNewMemberGroupBox.Name = "addNewMemberGroupBox";
            addNewMemberGroupBox.Size = new Size(646, 370);
            addNewMemberGroupBox.TabIndex = 20;
            addNewMemberGroupBox.TabStop = false;
            addNewMemberGroupBox.Text = "Add New Member";
            // 
            // btnCreateMemberButton
            // 
            btnCreateMemberButton.FlatAppearance.BorderColor = Color.Silver;
            btnCreateMemberButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnCreateMemberButton.FlatAppearance.MouseOverBackColor = Color.White;
            btnCreateMemberButton.FlatStyle = FlatStyle.Flat;
            btnCreateMemberButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateMemberButton.ForeColor = Color.Blue;
            btnCreateMemberButton.Location = new Point(136, 285);
            btnCreateMemberButton.Name = "btnCreateMemberButton";
            btnCreateMemberButton.Size = new Size(325, 58);
            btnCreateMemberButton.TabIndex = 29;
            btnCreateMemberButton.Text = "Create Member";
            btnCreateMemberButton.UseVisualStyleBackColor = true;
            btnCreateMemberButton.Click += btnCreateMemberButton_Click;
            // 
            // txtCellPhoneValue
            // 
            txtCellPhoneValue.Location = new Point(136, 213);
            txtCellPhoneValue.Name = "txtCellPhoneValue";
            txtCellPhoneValue.Size = new Size(430, 35);
            txtCellPhoneValue.TabIndex = 28;
            // 
            // lblCellphoneLabel
            // 
            lblCellphoneLabel.AutoSize = true;
            lblCellphoneLabel.ForeColor = Color.Blue;
            lblCellphoneLabel.Location = new Point(17, 213);
            lblCellphoneLabel.Name = "lblCellphoneLabel";
            lblCellphoneLabel.Size = new Size(106, 30);
            lblCellphoneLabel.TabIndex = 27;
            lblCellphoneLabel.Text = "Cellphone";
            // 
            // txtEmailValue
            // 
            txtEmailValue.Location = new Point(136, 160);
            txtEmailValue.Name = "txtEmailValue";
            txtEmailValue.Size = new Size(430, 35);
            txtEmailValue.TabIndex = 26;
            // 
            // lblEmailLabel
            // 
            lblEmailLabel.AutoSize = true;
            lblEmailLabel.ForeColor = Color.Blue;
            lblEmailLabel.Location = new Point(17, 160);
            lblEmailLabel.Name = "lblEmailLabel";
            lblEmailLabel.Size = new Size(63, 30);
            lblEmailLabel.TabIndex = 25;
            lblEmailLabel.Text = "Email";
            // 
            // txtLastNameValue
            // 
            txtLastNameValue.Location = new Point(136, 109);
            txtLastNameValue.Name = "txtLastNameValue";
            txtLastNameValue.Size = new Size(430, 35);
            txtLastNameValue.TabIndex = 24;
            // 
            // lblLastNameLabel
            // 
            lblLastNameLabel.AutoSize = true;
            lblLastNameLabel.ForeColor = Color.Blue;
            lblLastNameLabel.Location = new Point(17, 109);
            lblLastNameLabel.Name = "lblLastNameLabel";
            lblLastNameLabel.Size = new Size(112, 30);
            lblLastNameLabel.TabIndex = 23;
            lblLastNameLabel.Text = "Last Name";
            // 
            // txtFirstNameValue
            // 
            txtFirstNameValue.Location = new Point(136, 52);
            txtFirstNameValue.Name = "txtFirstNameValue";
            txtFirstNameValue.Size = new Size(430, 35);
            txtFirstNameValue.TabIndex = 22;
            // 
            // lblFirstNameLabel
            // 
            lblFirstNameLabel.AutoSize = true;
            lblFirstNameLabel.ForeColor = Color.Blue;
            lblFirstNameLabel.Location = new Point(17, 52);
            lblFirstNameLabel.Name = "lblFirstNameLabel";
            lblFirstNameLabel.Size = new Size(113, 30);
            lblFirstNameLabel.TabIndex = 21;
            lblFirstNameLabel.Text = "First Name";
            // 
            // TeamMembersListBox
            // 
            TeamMembersListBox.BorderStyle = BorderStyle.FixedSingle;
            TeamMembersListBox.FormattingEnabled = true;
            TeamMembersListBox.ItemHeight = 30;
            TeamMembersListBox.Location = new Point(754, 105);
            TeamMembersListBox.Name = "TeamMembersListBox";
            TeamMembersListBox.Size = new Size(366, 692);
            TeamMembersListBox.TabIndex = 21;
            TeamMembersListBox.SelectedIndexChanged += TeamMembersListBox_SelectedIndexChanged;
            // 
            // btnRemoveSelectedMemberButton
            // 
            btnRemoveSelectedMemberButton.FlatAppearance.BorderColor = Color.Silver;
            btnRemoveSelectedMemberButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnRemoveSelectedMemberButton.FlatAppearance.MouseOverBackColor = Color.White;
            btnRemoveSelectedMemberButton.FlatStyle = FlatStyle.Flat;
            btnRemoveSelectedMemberButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveSelectedMemberButton.ForeColor = Color.Blue;
            btnRemoveSelectedMemberButton.Location = new Point(1146, 386);
            btnRemoveSelectedMemberButton.Name = "btnRemoveSelectedMemberButton";
            btnRemoveSelectedMemberButton.Size = new Size(124, 89);
            btnRemoveSelectedMemberButton.TabIndex = 22;
            btnRemoveSelectedMemberButton.Text = "Remove Selected";
            btnRemoveSelectedMemberButton.UseVisualStyleBackColor = true;
            btnRemoveSelectedMemberButton.Click += btnRemoveSelectedMemberButton_Click;
            // 
            // btnCreateTeamButton
            // 
            btnCreateTeamButton.FlatAppearance.BorderColor = Color.Silver;
            btnCreateTeamButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnCreateTeamButton.FlatAppearance.MouseOverBackColor = Color.White;
            btnCreateTeamButton.FlatStyle = FlatStyle.Flat;
            btnCreateTeamButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateTeamButton.ForeColor = Color.Blue;
            btnCreateTeamButton.Location = new Point(464, 816);
            btnCreateTeamButton.Name = "btnCreateTeamButton";
            btnCreateTeamButton.Size = new Size(325, 58);
            btnCreateTeamButton.TabIndex = 25;
            btnCreateTeamButton.Text = "Create Team";
            btnCreateTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1312, 900);
            Controls.Add(btnCreateTeamButton);
            Controls.Add(btnRemoveSelectedMemberButton);
            Controls.Add(TeamMembersListBox);
            Controls.Add(addNewMemberGroupBox);
            Controls.Add(btnAddMemberButton);
            Controls.Add(SelectTeamMemberDropDown);
            Controls.Add(lblSelectTeamMemberLabel);
            Controls.Add(txtTeamNameValue);
            Controls.Add(lblTeamNameLabel);
            Controls.Add(lblHeaderLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTeamForm";
            Text = "Create Team";
            addNewMemberGroupBox.ResumeLayout(false);
            addNewMemberGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeaderLabel;
        private TextBox txtTeamNameValue;
        private Label lblTeamNameLabel;
        private Button btnAddMemberButton;
        private ComboBox SelectTeamMemberDropDown;
        private Label lblSelectTeamMemberLabel;
        private GroupBox addNewMemberGroupBox;
        private TextBox txtFirstNameValue;
        private Label lblFirstNameLabel;
        private TextBox txtLastNameValue;
        private Label lblLastNameLabel;
        private Button btnCreateMemberButton;
        private TextBox txtCellPhoneValue;
        private Label lblCellphoneLabel;
        private TextBox txtEmailValue;
        private Label lblEmailLabel;
        private ListBox TeamMembersListBox;
        private Button btnRemoveSelectedMemberButton;
        private Button btnCreateTeamButton;
    }
}