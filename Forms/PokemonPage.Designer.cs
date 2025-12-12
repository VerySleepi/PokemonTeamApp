namespace PokemonTeamApp.Forms
{
    partial class PokemonPage
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
            gBStats = new GroupBox();
            nudSpd = new NumericUpDown();
            nudSpDef = new NumericUpDown();
            nudSpAtk = new NumericUpDown();
            nudDef = new NumericUpDown();
            nudAtk = new NumericUpDown();
            nudLvl = new NumericUpDown();
            nudHP = new NumericUpDown();
            lblSpd = new Label();
            lblSpeDef = new Label();
            lblSpAtk = new Label();
            lblDef = new Label();
            lblAtk = new Label();
            lblHP = new Label();
            lblLevel = new Label();
            lblName = new Label();
            lblLvl = new Label();
            lblLvlValue = new Label();
            cbPkmnName = new ComboBox();
            btnSave = new Button();
            gBStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSpd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSpDef).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSpAtk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDef).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAtk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLvl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHP).BeginInit();
            SuspendLayout();
            // 
            // gBStats
            // 
            gBStats.Controls.Add(nudSpd);
            gBStats.Controls.Add(nudSpDef);
            gBStats.Controls.Add(nudSpAtk);
            gBStats.Controls.Add(nudDef);
            gBStats.Controls.Add(nudAtk);
            gBStats.Controls.Add(nudLvl);
            gBStats.Controls.Add(nudHP);
            gBStats.Controls.Add(lblSpd);
            gBStats.Controls.Add(lblSpeDef);
            gBStats.Controls.Add(lblSpAtk);
            gBStats.Controls.Add(lblDef);
            gBStats.Controls.Add(lblAtk);
            gBStats.Controls.Add(lblHP);
            gBStats.Controls.Add(lblLevel);
            gBStats.Font = new Font("Yu Gothic UI Semibold", 12F);
            gBStats.Location = new Point(295, 12);
            gBStats.Name = "gBStats";
            gBStats.Size = new Size(261, 426);
            gBStats.TabIndex = 0;
            gBStats.TabStop = false;
            gBStats.Text = "Stats";
            // 
            // nudSpd
            // 
            nudSpd.Font = new Font("Segoe UI", 11F);
            nudSpd.Location = new Point(156, 350);
            nudSpd.Maximum = new decimal(new int[] { 145, 0, 0, 0 });
            nudSpd.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSpd.Name = "nudSpd";
            nudSpd.Size = new Size(58, 27);
            nudSpd.TabIndex = 1;
            nudSpd.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudSpDef
            // 
            nudSpDef.Font = new Font("Segoe UI", 11F);
            nudSpDef.Location = new Point(156, 296);
            nudSpDef.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            nudSpDef.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSpDef.Name = "nudSpDef";
            nudSpDef.Size = new Size(58, 27);
            nudSpDef.TabIndex = 1;
            nudSpDef.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudSpAtk
            // 
            nudSpAtk.Font = new Font("Segoe UI", 11F);
            nudSpAtk.Location = new Point(156, 242);
            nudSpAtk.Maximum = new decimal(new int[] { 145, 0, 0, 0 });
            nudSpAtk.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSpAtk.Name = "nudSpAtk";
            nudSpAtk.Size = new Size(58, 27);
            nudSpAtk.TabIndex = 1;
            nudSpAtk.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudDef
            // 
            nudDef.Font = new Font("Segoe UI", 11F);
            nudDef.Location = new Point(156, 188);
            nudDef.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            nudDef.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDef.Name = "nudDef";
            nudDef.Size = new Size(58, 27);
            nudDef.TabIndex = 1;
            nudDef.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudAtk
            // 
            nudAtk.Font = new Font("Segoe UI", 11F);
            nudAtk.Location = new Point(156, 134);
            nudAtk.Maximum = new decimal(new int[] { 170, 0, 0, 0 });
            nudAtk.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAtk.Name = "nudAtk";
            nudAtk.Size = new Size(58, 27);
            nudAtk.TabIndex = 1;
            nudAtk.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudLvl
            // 
            nudLvl.Font = new Font("Segoe UI", 11F);
            nudLvl.Location = new Point(76, 27);
            nudLvl.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudLvl.Name = "nudLvl";
            nudLvl.Size = new Size(58, 27);
            nudLvl.TabIndex = 1;
            nudLvl.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudLvl.ValueChanged += NudLvl_ValueChanged;
            // 
            // nudHP
            // 
            nudHP.Font = new Font("Segoe UI", 11F);
            nudHP.Location = new Point(156, 80);
            nudHP.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nudHP.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudHP.Name = "nudHP";
            nudHP.Size = new Size(58, 27);
            nudHP.TabIndex = 1;
            nudHP.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblSpd
            // 
            lblSpd.Font = new Font("Yu Gothic UI Semibold", 11F);
            lblSpd.Location = new Point(47, 352);
            lblSpd.Name = "lblSpd";
            lblSpd.RightToLeft = RightToLeft.No;
            lblSpd.Size = new Size(57, 21);
            lblSpd.TabIndex = 0;
            lblSpd.Text = "Speed:";
            lblSpd.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSpeDef
            // 
            lblSpeDef.Font = new Font("Yu Gothic UI Semibold", 11F);
            lblSpeDef.Location = new Point(47, 298);
            lblSpeDef.Name = "lblSpeDef";
            lblSpeDef.RightToLeft = RightToLeft.No;
            lblSpeDef.Size = new Size(97, 21);
            lblSpeDef.TabIndex = 0;
            lblSpeDef.Text = "Sp. Defense:";
            lblSpeDef.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSpAtk
            // 
            lblSpAtk.Font = new Font("Yu Gothic UI Semibold", 11F);
            lblSpAtk.Location = new Point(47, 244);
            lblSpAtk.Name = "lblSpAtk";
            lblSpAtk.RightToLeft = RightToLeft.No;
            lblSpAtk.Size = new Size(97, 21);
            lblSpAtk.TabIndex = 0;
            lblSpAtk.Text = "Sp. Attack:";
            lblSpAtk.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDef
            // 
            lblDef.Font = new Font("Yu Gothic UI Semibold", 11F);
            lblDef.Location = new Point(47, 190);
            lblDef.Name = "lblDef";
            lblDef.RightToLeft = RightToLeft.No;
            lblDef.Size = new Size(69, 21);
            lblDef.TabIndex = 0;
            lblDef.Text = "Defense:";
            lblDef.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAtk
            // 
            lblAtk.Font = new Font("Yu Gothic UI Semibold", 11F);
            lblAtk.Location = new Point(47, 136);
            lblAtk.Name = "lblAtk";
            lblAtk.RightToLeft = RightToLeft.No;
            lblAtk.Size = new Size(57, 21);
            lblAtk.TabIndex = 0;
            lblAtk.Text = "Attack:";
            lblAtk.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblHP
            // 
            lblHP.Font = new Font("Yu Gothic UI Semibold", 11F);
            lblHP.Location = new Point(47, 82);
            lblHP.Name = "lblHP";
            lblHP.RightToLeft = RightToLeft.No;
            lblHP.Size = new Size(41, 21);
            lblHP.TabIndex = 0;
            lblHP.Text = "HP:";
            lblHP.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblLevel
            // 
            lblLevel.Font = new Font("Yu Gothic UI Semibold", 12F);
            lblLevel.Location = new Point(15, 28);
            lblLevel.Name = "lblLevel";
            lblLevel.RightToLeft = RightToLeft.No;
            lblLevel.Size = new Size(55, 21);
            lblLevel.TabIndex = 0;
            lblLevel.Text = "Level:";
            lblLevel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            lblName.BackColor = Color.LightSteelBlue;
            lblName.BorderStyle = BorderStyle.FixedSingle;
            lblName.Font = new Font("MS PGothic", 14F, FontStyle.Bold);
            lblName.Location = new Point(12, 20);
            lblName.Name = "lblName";
            lblName.Size = new Size(277, 41);
            lblName.TabIndex = 1;
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLvl
            // 
            lblLvl.BackColor = SystemColors.ControlLightLight;
            lblLvl.BorderStyle = BorderStyle.FixedSingle;
            lblLvl.Font = new Font("MS PGothic", 14F, FontStyle.Bold);
            lblLvl.Location = new Point(12, 59);
            lblLvl.Name = "lblLvl";
            lblLvl.Padding = new Padding(20, 0, 0, 0);
            lblLvl.Size = new Size(57, 29);
            lblLvl.TabIndex = 1;
            lblLvl.Text = "Lv.";
            lblLvl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblLvlValue
            // 
            lblLvlValue.BackColor = SystemColors.ControlLightLight;
            lblLvlValue.BorderStyle = BorderStyle.FixedSingle;
            lblLvlValue.Font = new Font("MS PGothic", 14F, FontStyle.Bold);
            lblLvlValue.Location = new Point(69, 59);
            lblLvlValue.Name = "lblLvlValue";
            lblLvlValue.Padding = new Padding(5, 0, 0, 0);
            lblLvlValue.Size = new Size(220, 29);
            lblLvlValue.TabIndex = 1;
            lblLvlValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbPkmnName
            // 
            cbPkmnName.DropDownHeight = 200;
            cbPkmnName.Font = new Font("MS PGothic", 14F, FontStyle.Bold);
            cbPkmnName.FormattingEnabled = true;
            cbPkmnName.IntegralHeight = false;
            cbPkmnName.Location = new Point(25, 28);
            cbPkmnName.MaxDropDownItems = 100;
            cbPkmnName.Name = "cbPkmnName";
            cbPkmnName.Size = new Size(253, 27);
            cbPkmnName.TabIndex = 2;
            cbPkmnName.Visible = false;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(597, 34);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(149, 30);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // PokemonPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(cbPkmnName);
            Controls.Add(lblName);
            Controls.Add(lblLvlValue);
            Controls.Add(lblLvl);
            Controls.Add(gBStats);
            Name = "PokemonPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PokemonPage";
            gBStats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudSpd).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSpDef).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSpAtk).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDef).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAtk).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLvl).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHP).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBStats;
        private Label lblSpd;
        private Label lblSpeDef;
        private Label lblSpAtk;
        private Label lblDef;
        private Label lblAtk;
        private Label lblHP;
        private Label lblLevel;
        private NumericUpDown nudHP;
        private NumericUpDown nudSpd;
        private NumericUpDown nudSpDef;
        private NumericUpDown nudSpAtk;
        private NumericUpDown nudDef;
        private NumericUpDown nudAtk;
        private NumericUpDown nudLvl;
        private Label lblName;
        private Label lblLvl;
        private Label lblLvlValue;
        private ComboBox cbPkmnName;
        private Button btnSave;
    }
}