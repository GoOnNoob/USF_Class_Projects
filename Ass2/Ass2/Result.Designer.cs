﻿namespace Ass2
{
    partial class Result
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
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(137, 73);
            label1.Name = "label1";
            label1.Size = new Size(232, 46);
            label1.TabIndex = 0;
            label1.Text = "Initial balance:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(484, 73);
            label2.Name = "label2";
            label2.Size = new Size(74, 46);
            label2.TabIndex = 1;
            label2.Text = "$10";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(137, 150);
            label3.Name = "label3";
            label3.Size = new Size(211, 46);
            label3.TabIndex = 2;
            label3.Text = "Total missed:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(137, 224);
            label4.Name = "label4";
            label4.Size = new Size(239, 46);
            label4.TabIndex = 3;
            label4.Text = "Total matched:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.Location = new Point(137, 292);
            label5.Name = "label5";
            label5.Size = new Size(263, 46);
            label5.TabIndex = 4;
            label5.Text = "Current Balance:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F);
            label6.Location = new Point(484, 150);
            label6.Name = "label6";
            label6.Size = new Size(56, 46);
            label6.TabIndex = 5;
            label6.Text = "$0";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20F);
            label7.Location = new Point(484, 224);
            label7.Name = "label7";
            label7.Size = new Size(56, 46);
            label7.TabIndex = 6;
            label7.Text = "$0";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20F);
            label8.Location = new Point(484, 292);
            label8.Name = "label8";
            label8.Size = new Size(56, 46);
            label8.TabIndex = 7;
            label8.Text = "$0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 20F);
            label9.Location = new Point(362, 150);
            label9.Name = "label9";
            label9.Size = new Size(38, 46);
            label9.TabIndex = 8;
            label9.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 20F);
            label10.Location = new Point(382, 224);
            label10.Name = "label10";
            label10.Size = new Size(38, 46);
            label10.TabIndex = 9;
            label10.Text = "0";
            // 
            // Result
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Result";
            Text = "Result";
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
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}