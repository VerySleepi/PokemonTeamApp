namespace PokemonTeamApp
{
    partial class TeamPage
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
            flpPokemonTeam = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flpPokemonTeam
            // 
            flpPokemonTeam.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpPokemonTeam.Dock = DockStyle.Top;
            flpPokemonTeam.Location = new Point(0, 0);
            flpPokemonTeam.Name = "flpPokemonTeam";
            flpPokemonTeam.Size = new Size(587, 515);
            flpPokemonTeam.TabIndex = 0;
            // 
            // TeamPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(587, 599);
            Controls.Add(flpPokemonTeam);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimumSize = new Size(0, 629);
            Name = "TeamPage";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TeamPage";
            FormClosing += TeamPage_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpPokemonTeam;
    }
}