namespace Lab2
{
    partial class MushroomForm
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
            this.listLabel = new System.Windows.Forms.Label();
            this.ringLabel = new System.Windows.Forms.Label();
            this.ringBox = new System.Windows.Forms.ComboBox();
            this.forestLabel = new System.Windows.Forms.Label();
            this.forestBox = new System.Windows.Forms.ComboBox();
            this.gillsLabel = new System.Windows.Forms.Label();
            this.gillsBox = new System.Windows.Forms.ComboBox();
            this.convexCupLabel = new System.Windows.Forms.Label();
            this.convexCupBox = new System.Windows.Forms.ComboBox();
            this.identifyButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
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
            this.titleLabel.Text = "Mushroom Identifier";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLabel.UseMnemonic = false;
            //
            // listLabel
            //
            this.listLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.listLabel.ForeColor = System.Drawing.Color.Black;
            this.listLabel.Location = new System.Drawing.Point(30, 76);
            this.listLabel.Name = "listLabel";
            this.listLabel.Size = new System.Drawing.Size(420, 44);
            this.listLabel.TabIndex = 1;
            this.listLabel.Text = "Think of one: Agaric Jaunissant, Amanite tue-mouche, Cepe de bordeau, Coprin chevelu, Girolle, Pied bleu";
            this.listLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listLabel.UseMnemonic = false;
            //
            // ringLabel
            //
            this.ringLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ringLabel.ForeColor = System.Drawing.Color.Black;
            this.ringLabel.Location = new System.Drawing.Point(30, 132);
            this.ringLabel.Name = "ringLabel";
            this.ringLabel.Size = new System.Drawing.Size(280, 28);
            this.ringLabel.TabIndex = 2;
            this.ringLabel.Text = "Does it have a ring?";
            this.ringLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ringLabel.UseMnemonic = false;
            //
            // ringBox
            //
            this.ringBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ringBox.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular);
            this.ringBox.FormattingEnabled = true;
            this.ringBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.ringBox.Location = new System.Drawing.Point(330, 132);
            this.ringBox.Name = "ringBox";
            this.ringBox.Size = new System.Drawing.Size(120, 28);
            this.ringBox.TabIndex = 3;
            //
            // forestLabel
            //
            this.forestLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.forestLabel.ForeColor = System.Drawing.Color.Black;
            this.forestLabel.Location = new System.Drawing.Point(30, 174);
            this.forestLabel.Name = "forestLabel";
            this.forestLabel.Size = new System.Drawing.Size(280, 28);
            this.forestLabel.TabIndex = 4;
            this.forestLabel.Text = "Does it grow in a forest?";
            this.forestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.forestLabel.UseMnemonic = false;
            //
            // forestBox
            //
            this.forestBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.forestBox.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular);
            this.forestBox.FormattingEnabled = true;
            this.forestBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.forestBox.Location = new System.Drawing.Point(330, 174);
            this.forestBox.Name = "forestBox";
            this.forestBox.Size = new System.Drawing.Size(120, 28);
            this.forestBox.TabIndex = 5;
            //
            // gillsLabel
            //
            this.gillsLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gillsLabel.ForeColor = System.Drawing.Color.Black;
            this.gillsLabel.Location = new System.Drawing.Point(30, 216);
            this.gillsLabel.Name = "gillsLabel";
            this.gillsLabel.Size = new System.Drawing.Size(280, 28);
            this.gillsLabel.TabIndex = 6;
            this.gillsLabel.Text = "Does it have gills?";
            this.gillsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gillsLabel.UseMnemonic = false;
            //
            // gillsBox
            //
            this.gillsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gillsBox.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular);
            this.gillsBox.FormattingEnabled = true;
            this.gillsBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.gillsBox.Location = new System.Drawing.Point(330, 216);
            this.gillsBox.Name = "gillsBox";
            this.gillsBox.Size = new System.Drawing.Size(120, 28);
            this.gillsBox.TabIndex = 7;
            //
            // convexCupLabel
            //
            this.convexCupLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.convexCupLabel.ForeColor = System.Drawing.Color.Black;
            this.convexCupLabel.Location = new System.Drawing.Point(30, 258);
            this.convexCupLabel.Name = "convexCupLabel";
            this.convexCupLabel.Size = new System.Drawing.Size(280, 28);
            this.convexCupLabel.TabIndex = 8;
            this.convexCupLabel.Text = "Does it have a convex cup?";
            this.convexCupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.convexCupLabel.UseMnemonic = false;
            //
            // convexCupBox
            //
            this.convexCupBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.convexCupBox.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular);
            this.convexCupBox.FormattingEnabled = true;
            this.convexCupBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.convexCupBox.Location = new System.Drawing.Point(330, 258);
            this.convexCupBox.Name = "convexCupBox";
            this.convexCupBox.Size = new System.Drawing.Size(120, 28);
            this.convexCupBox.TabIndex = 9;
            //
            // identifyButton
            //
            this.identifyButton.BackColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.identifyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.identifyButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.identifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.identifyButton.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.identifyButton.ForeColor = System.Drawing.Color.Black;
            this.identifyButton.Location = new System.Drawing.Point(90, 308);
            this.identifyButton.Name = "identifyButton";
            this.identifyButton.Size = new System.Drawing.Size(140, 44);
            this.identifyButton.TabIndex = 10;
            this.identifyButton.Text = "Identify";
            this.identifyButton.UseVisualStyleBackColor = false;
            this.identifyButton.Click += new System.EventHandler(this.IdentifyButton_Click);
            //
            // resetButton
            //
            this.resetButton.BackColor = System.Drawing.Color.Black;
            this.resetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.resetButton.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.resetButton.Location = new System.Drawing.Point(250, 308);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(140, 44);
            this.resetButton.TabIndex = 11;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            //
            // resultLabel
            //
            this.resultLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.resultLabel.ForeColor = System.Drawing.Color.Black;
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultLabel.Location = new System.Drawing.Point(30, 366);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(420, 56);
            this.resultLabel.TabIndex = 12;
            this.resultLabel.Text = "";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resultLabel.UseMnemonic = false;
            //
            // MushroomForm
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(480, 470);
            this.Controls.Add(this.listLabel);
            this.Controls.Add(this.ringLabel);
            this.Controls.Add(this.ringBox);
            this.Controls.Add(this.forestLabel);
            this.Controls.Add(this.forestBox);
            this.Controls.Add(this.gillsLabel);
            this.Controls.Add(this.gillsBox);
            this.Controls.Add(this.convexCupLabel);
            this.Controls.Add(this.convexCupBox);
            this.Controls.Add(this.identifyButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MushroomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mushroom Identifier";
            this.headerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label listLabel;
        private System.Windows.Forms.Label ringLabel;
        private System.Windows.Forms.ComboBox ringBox;
        private System.Windows.Forms.Label forestLabel;
        private System.Windows.Forms.ComboBox forestBox;
        private System.Windows.Forms.Label gillsLabel;
        private System.Windows.Forms.ComboBox gillsBox;
        private System.Windows.Forms.Label convexCupLabel;
        private System.Windows.Forms.ComboBox convexCupBox;
        private System.Windows.Forms.Button identifyButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label resultLabel;
    }
}
