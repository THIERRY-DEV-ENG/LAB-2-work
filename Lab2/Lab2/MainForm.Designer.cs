namespace Lab2
{
    partial class MainForm
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.mushroomButton = new System.Windows.Forms.Button();
            this.bicycleButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            //
            // headerPanel
            //
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(400, 64);
            this.headerPanel.TabIndex = 0;
            //
            // titleLabel
            //
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.Black;
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "LAB 2";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLabel.UseMnemonic = false;
            //
            // welcomeLabel
            //
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.welcomeLabel.ForeColor = System.Drawing.Color.Black;
            this.welcomeLabel.Location = new System.Drawing.Point(20, 80);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(360, 28);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "Welcome!";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.welcomeLabel.UseMnemonic = false;
            //
            // mushroomButton
            //
            this.mushroomButton.BackColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.mushroomButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mushroomButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.mushroomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mushroomButton.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.mushroomButton.ForeColor = System.Drawing.Color.Black;
            this.mushroomButton.Location = new System.Drawing.Point(80, 124);
            this.mushroomButton.Name = "mushroomButton";
            this.mushroomButton.Size = new System.Drawing.Size(240, 48);
            this.mushroomButton.TabIndex = 2;
            this.mushroomButton.Text = "Mushroom Identifier";
            this.mushroomButton.UseVisualStyleBackColor = false;
            this.mushroomButton.Click += new System.EventHandler(this.MushroomButton_Click);
            //
            // bicycleButton
            //
            this.bicycleButton.BackColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.bicycleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bicycleButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bicycleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bicycleButton.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.bicycleButton.ForeColor = System.Drawing.Color.Black;
            this.bicycleButton.Location = new System.Drawing.Point(80, 184);
            this.bicycleButton.Name = "bicycleButton";
            this.bicycleButton.Size = new System.Drawing.Size(240, 48);
            this.bicycleButton.TabIndex = 3;
            this.bicycleButton.Text = "Bicycle Rental";
            this.bicycleButton.UseVisualStyleBackColor = false;
            this.bicycleButton.Click += new System.EventHandler(this.BicycleButton_Click);
            //
            // logoutButton
            //
            this.logoutButton.BackColor = System.Drawing.Color.Black;
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.logoutButton.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.logoutButton.Location = new System.Drawing.Point(80, 244);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(240, 48);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            //
            // MainForm
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 340);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.mushroomButton);
            this.Controls.Add(this.bicycleButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LAB 2";
            this.headerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button mushroomButton;
        private System.Windows.Forms.Button bicycleButton;
        private System.Windows.Forms.Button logoutButton;
    }
}
