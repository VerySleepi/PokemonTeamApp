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
            flbPokemonTeam = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flbPokemonTeam
            // 
            flbPokemonTeam.Location = new Point(21, 121);
            flbPokemonTeam.Name = "flbPokemonTeam";
            flbPokemonTeam.Size = new Size(759, 191);
            flbPokemonTeam.TabIndex = 0;
            // 
            // TeamPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flbPokemonTeam);
            Name = "TeamPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TeamPage";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flbPokemonTeam;
    }
}