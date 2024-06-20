namespace Project2
{
    partial class FormFruit
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(34, 37);
            label1.Name = "label1";
            label1.Size = new Size(297, 23);
            label1.TabIndex = 0;
            label1.Text = "Welcome to the fruit matching game!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(34, 107);
            label2.Name = "label2";
            label2.Size = new Size(481, 23);
            label2.TabIndex = 1;
            label2.Text = "Here you play a simple game by matching three fruit pictures.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(34, 148);
            label3.Name = "label3";
            label3.Size = new Size(690, 23);
            label3.TabIndex = 2;
            label3.Text = "You may choose to flip each picture once or twice per second at any time during a game.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(34, 189);
            label4.Name = "label4";
            label4.Size = new Size(565, 23);
            label4.TabIndex = 3;
            label4.Text = "You will see the total games you win and lose displayed on the form title.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(34, 228);
            label5.Name = "label5";
            label5.Size = new Size(781, 23);
            label5.TabIndex = 4;
            label5.Text = "You may play as many games as you like until you double click on its form to close it and return here.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(34, 273);
            label6.Name = "label6";
            label6.Size = new Size(338, 23);
            label6.TabIndex = 5;
            label6.Text = "To begin a game, double click on this form.";
            // 
            // FormFruit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(1067, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormFruit";
            Text = "Fruit Matching Game";
            Load += FormFruit_Load;
            DoubleClick += FormFruit_DoubleClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}