namespace PokemonTeamApp
{
    partial class Demo
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
            btnAdd = new Button();
            panel1 = new Panel();
            flpPokePanel = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Right;
            btnAdd.Location = new Point(725, 0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 37);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAdd);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 413);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 37);
            panel1.TabIndex = 1;
            // 
            // flpPokePanel
            // 
            flpPokePanel.AutoScroll = true;
            flpPokePanel.Dock = DockStyle.Fill;
            flpPokePanel.Location = new Point(0, 0);
            flpPokePanel.Name = "flpPokePanel";
            flpPokePanel.Size = new Size(800, 413);
            flpPokePanel.TabIndex = 2;
            // 
            // Demo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flpPokePanel);
            Controls.Add(panel1);
            Name = "Demo";
            Text = "Demo";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdd;
        private Panel panel1;
        private FlowLayoutPanel flpPokePanel;
    }
}