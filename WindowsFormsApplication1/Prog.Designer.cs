﻿namespace WindowsFormsApplication1
{
    partial class Prog
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
            this.CurrentProb = new System.Windows.Forms.Button();
            this.SubProb = new System.Windows.Forms.Button();
            this.SolProb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CurrentProb
            // 
            this.CurrentProb.Location = new System.Drawing.Point(12, 12);
            this.CurrentProb.Name = "CurrentProb";
            this.CurrentProb.Size = new System.Drawing.Size(108, 23);
            this.CurrentProb.TabIndex = 0;
            this.CurrentProb.Text = "Current Problems";
            this.CurrentProb.UseVisualStyleBackColor = true;
            this.CurrentProb.Click += new System.EventHandler(this.CurrentProb_Click);
            // 
            // SubProb
            // 
            this.SubProb.Location = new System.Drawing.Point(12, 42);
            this.SubProb.Name = "SubProb";
            this.SubProb.Size = new System.Drawing.Size(108, 23);
            this.SubProb.TabIndex = 1;
            this.SubProb.Text = "Submit a Problem";
            this.SubProb.UseVisualStyleBackColor = true;
            this.SubProb.Click += new System.EventHandler(this.SubProb_Click);
            // 
            // SolProb
            // 
            this.SolProb.Location = new System.Drawing.Point(126, 12);
            this.SolProb.Name = "SolProb";
            this.SolProb.Size = new System.Drawing.Size(108, 23);
            this.SolProb.TabIndex = 3;
            this.SolProb.Text = "Solve a Problem";
            this.SolProb.UseVisualStyleBackColor = true;
            this.SolProb.Click += new System.EventHandler(this.SolProb_Click);
            // 
            // Prog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.SolProb);
            this.Controls.Add(this.SubProb);
            this.Controls.Add(this.CurrentProb);
            this.Name = "Prog";
            this.Text = "Prog";
            this.Load += new System.EventHandler(this.Prog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CurrentProb;
        private System.Windows.Forms.Button SubProb;
        private System.Windows.Forms.Button SolProb;
    }
}