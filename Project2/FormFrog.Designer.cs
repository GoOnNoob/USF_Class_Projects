namespace Project2
{
    partial class FormFrog
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFrog));
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(334, 394);
            button1.Name = "button1";
            button1.Size = new Size(150, 150);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(182, 74);
            label1.Name = "label1";
            label1.Size = new Size(447, 35);
            label1.TabIndex = 1;
            label1.Text = "Win 1 point if you click and hit the frog";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(182, 129);
            label2.Name = "label2";
            label2.Size = new Size(384, 35);
            label2.TabIndex = 2;
            label2.Text = "Lose 2 point if clicked but missed";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(182, 180);
            label3.Name = "label3";
            label3.Size = new Size(400, 35);
            label3.TabIndex = 3;
            label3.Text = "Lose 1 point if you don't click at all";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 15F);
            label4.ForeColor = Color.Green;
            label4.Location = new Point(182, 290);
            label4.Name = "label4";
            label4.Size = new Size(277, 35);
            label4.TabIndex = 4;
            label4.Text = "Click the frog to begin...";
            // 
            // timer1
            // 
            timer1.Interval = 800;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 800;
            timer2.Tick += timer2_Tick;
            // 
            // FormFrog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 653);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "FormFrog";
            Text = "Score = 0";
            Load += FormFrog_Load;
            Click += FormFrog_Click;
            DoubleClick += FormFrog_DoubleClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}