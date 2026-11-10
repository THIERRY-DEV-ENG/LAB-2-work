namespace Lab2
{
    partial class BicycleForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.startLabel = new System.Windows.Forms.Label();
            this.startBox = new System.Windows.Forms.NumericUpDown();
            this.endLabel = new System.Windows.Forms.Label();
            this.endBox = new System.Windows.Forms.NumericUpDown();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.detailsBox = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.ratesLabel = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.startBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endBox)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            //
            // headerPanel
            //
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(480, 64);
            this.headerPanel.TabIndex = 0;
            //
            // titleLabel
            //
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.Black;
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Bicycle Rental";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLabel.UseMnemonic = false;
            //
            // startLabel
            //
            this.startLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.startLabel.ForeColor = System.Drawing.Color.Black;
            this.startLabel.Location = new System.Drawing.Point(30, 84);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(250, 28);
            this.startLabel.TabIndex = 1;
            this.startLabel.Text = "Starting hour (0-23):";
            this.startLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.startLabel.UseMnemonic = false;
            //
            // startBox
            //
            this.startBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular);
            this.startBox.Location = new System.Drawing.Point(330, 84);
            this.startBox.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            this.startBox.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            this.startBox.Name = "startBox";
            this.startBox.Size = new System.Drawing.Size(120, 28);
            this.startBox.TabIndex = 2;
            this.startBox.Value = new decimal(new int[] { 8, 0, 0, 0 });
            //
            // endLabel
            //
            this.endLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.endLabel.ForeColor = System.Drawing.Color.Black;
            this.endLabel.Location = new System.Drawing.Point(30, 126);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(250, 28);
            this.endLabel.TabIndex = 3;
            this.endLabel.Text = "Ending hour (1-24):";
            this.endLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.endLabel.UseMnemonic = false;
            //
            // endBox
            //
            this.endBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular);
            this.endBox.Location = new System.Drawing.Point(330, 126);
            this.endBox.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            this.endBox.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.endBox.Name = "endBox";
            this.endBox.Size = new System.Drawing.Size(120, 28);
            this.endBox.TabIndex = 4;
            this.endBox.Value = new decimal(new int[] { 17, 0, 0, 0 });
            //
            // calculateButton
            //
            this.calculateButton.BackColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.calculateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculateButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.calculateButton.ForeColor = System.Drawing.Color.Black;
            this.calculateButton.Location = new System.Drawing.Point(90, 172);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(140, 44);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            //
            // resetButton
            //
            this.resetButton.BackColor = System.Drawing.Color.Black;
            this.resetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.resetButton.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.resetButton.Location = new System.Drawing.Point(250, 172);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(140, 44);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            //
            // errorLabel
            //
            this.errorLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.errorLabel.ForeColor = System.Drawing.Color.FromArgb(170, 0, 0);
            this.errorLabel.Location = new System.Drawing.Point(30, 222);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(420, 24);
            this.errorLabel.TabIndex = 7;
            this.errorLabel.Text = "";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorLabel.UseMnemonic = false;
            //
            // detailsBox
            //
            this.detailsBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailsBox.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular);
            this.detailsBox.Multiline = true;
            this.detailsBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.detailsBox.ReadOnly = true;
            this.detailsBox.BackColor = System.Drawing.Color.White;
            this.detailsBox.Location = new System.Drawing.Point(30, 250);
            this.detailsBox.Name = "detailsBox";
            this.detailsBox.Size = new System.Drawing.Size(420, 170);
            this.detailsBox.TabIndex = 8;
            //
            // totalLabel
            //
            this.totalLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.totalLabel.ForeColor = System.Drawing.Color.Black;
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Location = new System.Drawing.Point(30, 432);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(420, 50);
            this.totalLabel.TabIndex = 9;
            this.totalLabel.Text = "";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.totalLabel.UseMnemonic = false;
            //
            // ratesLabel
            //
            this.ratesLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.ratesLabel.ForeColor = System.Drawing.Color.Black;
            this.ratesLabel.Location = new System.Drawing.Point(20, 494);
            this.ratesLabel.Name = "ratesLabel";
            this.ratesLabel.Size = new System.Drawing.Size(440, 40);
            this.ratesLabel.TabIndex = 10;
            this.ratesLabel.Text = "Rates: 0-6 = 500 | 7-13 = 1000 | 14-18 = 1500 | 19-20 = 1000 | 21-23 = 500";
            this.ratesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ratesLabel.UseMnemonic = false;
            //
            // BicycleForm
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(480, 560);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.startBox);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.endBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.detailsBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.ratesLabel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BicycleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bicycle Rental";
            this.headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.startBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.NumericUpDown startBox;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.NumericUpDown endBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.TextBox detailsBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label ratesLabel;
    }
}
