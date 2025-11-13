namespace TrackerUI
{
    partial class CreatePrizeForm
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
            txtPlaceNumberValue = new TextBox();
            lblPlaceNumberLabel = new Label();
            txtPrizeAmountValue = new TextBox();
            lblPrizeAmountLabel = new Label();
            txtPlaceNameValue = new TextBox();
            lblPlaceNameLabel = new Label();
            txtPrizePercentageValue = new TextBox();
            lblPrizePercentageLabel = new Label();
            lblOrLabel = new Label();
            btnCreatePrizeButton = new Button();
            SuspendLayout();
            // 
            // lblHeaderLabel
            // 
            lblHeaderLabel.AutoSize = true;
            lblHeaderLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeaderLabel.ForeColor = Color.Blue;
            lblHeaderLabel.Location = new Point(29, 37);
            lblHeaderLabel.Name = "lblHeaderLabel";
            lblHeaderLabel.Size = new Size(209, 50);
            lblHeaderLabel.TabIndex = 3;
            lblHeaderLabel.Text = "Create Prize";
            // 
            // txtPlaceNumberValue
            // 
            txtPlaceNumberValue.Location = new Point(179, 125);
            txtPlaceNumberValue.Name = "txtPlaceNumberValue";
            txtPlaceNumberValue.Size = new Size(430, 35);
            txtPlaceNumberValue.TabIndex = 24;
            // 
            // lblPlaceNumberLabel
            // 
            lblPlaceNumberLabel.AutoSize = true;
            lblPlaceNumberLabel.ForeColor = Color.Blue;
            lblPlaceNumberLabel.Location = new Point(29, 125);
            lblPlaceNumberLabel.Name = "lblPlaceNumberLabel";
            lblPlaceNumberLabel.Size = new Size(144, 30);
            lblPlaceNumberLabel.TabIndex = 23;
            lblPlaceNumberLabel.Text = "Place Number";
            // 
            // txtPrizeAmountValue
            // 
            txtPrizeAmountValue.Location = new Point(179, 247);
            txtPrizeAmountValue.Name = "txtPrizeAmountValue";
            txtPrizeAmountValue.Size = new Size(430, 35);
            txtPrizeAmountValue.TabIndex = 26;
            // 
            // lblPrizeAmountLabel
            // 
            lblPrizeAmountLabel.AutoSize = true;
            lblPrizeAmountLabel.ForeColor = Color.Blue;
            lblPrizeAmountLabel.Location = new Point(29, 247);
            lblPrizeAmountLabel.Name = "lblPrizeAmountLabel";
            lblPrizeAmountLabel.Size = new Size(139, 30);
            lblPrizeAmountLabel.TabIndex = 25;
            lblPrizeAmountLabel.Text = "Prize Amount";
            // 
            // txtPlaceNameValue
            // 
            txtPlaceNameValue.Location = new Point(179, 186);
            txtPlaceNameValue.Name = "txtPlaceNameValue";
            txtPlaceNameValue.Size = new Size(430, 35);
            txtPlaceNameValue.TabIndex = 28;
            // 
            // lblPlaceNameLabel
            // 
            lblPlaceNameLabel.AutoSize = true;
            lblPlaceNameLabel.ForeColor = Color.Blue;
            lblPlaceNameLabel.Location = new Point(29, 186);
            lblPlaceNameLabel.Name = "lblPlaceNameLabel";
            lblPlaceNameLabel.Size = new Size(124, 30);
            lblPlaceNameLabel.TabIndex = 27;
            lblPlaceNameLabel.Text = "Place Name";
            // 
            // txtPrizePercentageValue
            // 
            txtPrizePercentageValue.Location = new Point(202, 392);
            txtPrizePercentageValue.Name = "txtPrizePercentageValue";
            txtPrizePercentageValue.Size = new Size(407, 35);
            txtPrizePercentageValue.TabIndex = 30;
            // 
            // lblPrizePercentageLabel
            // 
            lblPrizePercentageLabel.AutoSize = true;
            lblPrizePercentageLabel.ForeColor = Color.Blue;
            lblPrizePercentageLabel.Location = new Point(29, 392);
            lblPrizePercentageLabel.Name = "lblPrizePercentageLabel";
            lblPrizePercentageLabel.Size = new Size(167, 30);
            lblPrizePercentageLabel.TabIndex = 29;
            lblPrizePercentageLabel.Text = "Prize Percentage";
            // 
            // lblOrLabel
            // 
            lblOrLabel.AutoSize = true;
            lblOrLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrLabel.ForeColor = Color.Blue;
            lblOrLabel.Location = new Point(264, 311);
            lblOrLabel.Name = "lblOrLabel";
            lblOrLabel.Size = new Size(101, 50);
            lblOrLabel.TabIndex = 31;
            lblOrLabel.Text = "-OR-";
            // 
            // btnCreatePrizeButton
            // 
            btnCreatePrizeButton.FlatAppearance.BorderColor = Color.Silver;
            btnCreatePrizeButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnCreatePrizeButton.FlatAppearance.MouseOverBackColor = Color.White;
            btnCreatePrizeButton.FlatStyle = FlatStyle.Flat;
            btnCreatePrizeButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreatePrizeButton.ForeColor = Color.Blue;
            btnCreatePrizeButton.Location = new Point(156, 502);
            btnCreatePrizeButton.Name = "btnCreatePrizeButton";
            btnCreatePrizeButton.Size = new Size(325, 58);
            btnCreatePrizeButton.TabIndex = 32;
            btnCreatePrizeButton.Text = "Create Prize";
            btnCreatePrizeButton.UseVisualStyleBackColor = true;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(719, 618);
            Controls.Add(btnCreatePrizeButton);
            Controls.Add(lblOrLabel);
            Controls.Add(txtPrizePercentageValue);
            Controls.Add(lblPrizePercentageLabel);
            Controls.Add(txtPlaceNameValue);
            Controls.Add(lblPlaceNameLabel);
            Controls.Add(txtPrizeAmountValue);
            Controls.Add(lblPrizeAmountLabel);
            Controls.Add(txtPlaceNumberValue);
            Controls.Add(lblPlaceNumberLabel);
            Controls.Add(lblHeaderLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreatePrizeForm";
            Text = "CreatePrizeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeaderLabel;
        private TextBox txtPlaceNumberValue;
        private Label lblPlaceNumberLabel;
        private TextBox txtPrizeAmountValue;
        private Label lblPrizeAmountLabel;
        private TextBox txtPlaceNameValue;
        private Label lblPlaceNameLabel;
        private TextBox txtPrizePercentageValue;
        private Label lblPrizePercentageLabel;
        private Label lblOrLabel;
        private Button btnCreatePrizeButton;
    }
}