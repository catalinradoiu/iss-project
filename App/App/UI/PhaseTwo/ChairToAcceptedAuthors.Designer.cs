﻿namespace App.UI.PhaseTwo
{
    partial class ChairToAcceptedAuthors
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
            this.sendEmailsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sendEmailsButton
            // 
            this.sendEmailsButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.sendEmailsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sendEmailsButton.Location = new System.Drawing.Point(83, 48);
            this.sendEmailsButton.Name = "sendEmailsButton";
            this.sendEmailsButton.Size = new System.Drawing.Size(129, 43);
            this.sendEmailsButton.TabIndex = 0;
            this.sendEmailsButton.Text = "Send emails";
            this.sendEmailsButton.UseVisualStyleBackColor = false;
            this.sendEmailsButton.Click += new System.EventHandler(this.sendEmailsButton_Click);
            // 
            // ChairToAcceptedAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 162);
            this.Controls.Add(this.sendEmailsButton);
            this.Name = "ChairToAcceptedAuthors";
            this.Text = "ChairToAcceptedAuthors";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sendEmailsButton;
    }
}