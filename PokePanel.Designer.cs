namespace PokemonTeamApp
{
    partial class PokePanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbPokeBall = new PictureBox();
            lblName = new Label();
            lblN = new Label();
            pnlName = new Panel();
            psbHealth = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pbPokeBall).BeginInit();
            pnlName.SuspendLayout();
            SuspendLayout();
            // 
            // pbPokeBall
            // 
            pbPokeBall.Enabled = false;
            pbPokeBall.Location = new Point(1, 0);
            pbPokeBall.Name = "pbPokeBall";
            pbPokeBall.Size = new Size(187, 178);
            pbPokeBall.SizeMode = PictureBoxSizeMode.Zoom;
            pbPokeBall.TabIndex = 0;
            pbPokeBall.TabStop = false;
            pbPokeBall.Click += PokePanel_Click;
            // 
            // lblName
            // 
            lblName.BackColor = SystemColors.ButtonFace;
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(47, 3);
            lblName.Name = "lblName";
            lblName.Size = new Size(140, 24);
            lblName.TabIndex = 1;
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            lblName.Click += PokePanel_Click;
            // 
            // lblN
            // 
            lblN.BackColor = SystemColors.ButtonFace;
            lblN.ForeColor = Color.Black;
            lblN.Location = new Point(8, 3);
            lblN.Name = "lblN";
            lblN.Size = new Size(42, 24);
            lblN.TabIndex = 2;
            lblN.Text = "Name:";
            lblN.TextAlign = ContentAlignment.MiddleCenter;
            lblN.Click += PokePanel_Click;
            // 
            // pnlName
            // 
            pnlName.BackColor = SystemColors.ButtonFace;
            pnlName.Controls.Add(lblN);
            pnlName.Controls.Add(lblName);
            pnlName.Location = new Point(0, 178);
            pnlName.Name = "pnlName";
            pnlName.Size = new Size(187, 31);
            pnlName.TabIndex = 3;
            pnlName.Click += PokePanel_Click;
            // 
            // psbHealth
            // 
            psbHealth.Location = new Point(8, 226);
            psbHealth.Name = "psbHealth";
            psbHealth.Size = new Size(170, 13);
            psbHealth.TabIndex = 4;
            // 
            // PokePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pbPokeBall);
            Controls.Add(pnlName);
            Controls.Add(psbHealth);
            Name = "PokePanel";
            Size = new Size(189, 242);
            Click += PokePanel_Click;
            ((System.ComponentModel.ISupportInitialize)pbPokeBall).EndInit();
            pnlName.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbPokeBall;
        private Label lblName;
        private Label lblN;
        private Panel pnlName;
        private ProgressBar psbHealth;
    }
}
