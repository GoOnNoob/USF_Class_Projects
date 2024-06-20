namespace Project2
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            gameToolStripMenuItem = new ToolStripMenuItem();
            fruitMatchingToolStripMenuItem = new ToolStripMenuItem();
            frogCatchingToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            bindingSource1 = new BindingSource(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F);
            label1.Location = new Point(167, 235);
            label1.Name = "label1";
            label1.Size = new Size(688, 89);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Project 2!";
            label1.Click += label1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { gameToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1086, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            gameToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fruitMatchingToolStripMenuItem, frogCatchingToolStripMenuItem, toolStripMenuItem1, exitToolStripMenuItem });
            gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            gameToolStripMenuItem.Size = new Size(62, 24);
            gameToolStripMenuItem.Text = "Game";
            // 
            // fruitMatchingToolStripMenuItem
            // 
            fruitMatchingToolStripMenuItem.Name = "fruitMatchingToolStripMenuItem";
            fruitMatchingToolStripMenuItem.Size = new Size(224, 26);
            fruitMatchingToolStripMenuItem.Text = "Fruit Matching";
            fruitMatchingToolStripMenuItem.Click += fruitMatchingToolStripMenuItem_Click;
            // 
            // frogCatchingToolStripMenuItem
            // 
            frogCatchingToolStripMenuItem.Name = "frogCatchingToolStripMenuItem";
            frogCatchingToolStripMenuItem.Size = new Size(224, 26);
            frogCatchingToolStripMenuItem.Text = "Frog Catching";
            frogCatchingToolStripMenuItem.Click += frogCatchingToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(221, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 778);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem gameToolStripMenuItem;
        private ToolStripMenuItem fruitMatchingToolStripMenuItem;
        private ToolStripMenuItem frogCatchingToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private BindingSource bindingSource1;
    }
}
