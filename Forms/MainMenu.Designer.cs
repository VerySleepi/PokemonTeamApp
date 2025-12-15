namespace PokemonTeamApp
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnTeam = new Button();
            SuspendLayout();
            // 
            // btnTeam
            // 
            btnTeam.Location = new Point(295, 228);
            btnTeam.Name = "btnTeam";
            btnTeam.Size = new Size(180, 40);
            btnTeam.TabIndex = 0;
            btnTeam.Text = "Team";
            btnTeam.UseVisualStyleBackColor = true;
            btnTeam.Click += btnTeam_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 497);
            Controls.Add(btnTeam);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnTeam;
    }
}
