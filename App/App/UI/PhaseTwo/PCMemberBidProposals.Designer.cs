﻿namespace App.UI.PhaseTwo
{
    partial class PCMemberBidProposals
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
            this.proposalsDataGridView = new System.Windows.Forms.DataGridView();
            this.radioButtonDa = new System.Windows.Forms.RadioButton();
            this.radioButtonPot = new System.Windows.Forms.RadioButton();
            this.radioButtonNuVreau = new System.Windows.Forms.RadioButton();
            this.submitButton = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.proposalsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // proposalsDataGridView
            // 
            this.proposalsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proposalsDataGridView.Location = new System.Drawing.Point(13, 13);
            this.proposalsDataGridView.Name = "proposalsDataGridView";
            this.proposalsDataGridView.Size = new System.Drawing.Size(227, 483);
            this.proposalsDataGridView.TabIndex = 0;
            // 
            // radioButtonDa
            // 
            this.radioButtonDa.AutoSize = true;
            this.radioButtonDa.Location = new System.Drawing.Point(272, 43);
            this.radioButtonDa.Name = "radioButtonDa";
            this.radioButtonDa.Size = new System.Drawing.Size(54, 17);
            this.radioButtonDa.TabIndex = 1;
            this.radioButtonDa.TabStop = true;
            this.radioButtonDa.Text = "I want";
            this.radioButtonDa.UseVisualStyleBackColor = true;
            // 
            // radioButtonPot
            // 
            this.radioButtonPot.AutoSize = true;
            this.radioButtonPot.Location = new System.Drawing.Point(272, 82);
            this.radioButtonPot.Name = "radioButtonPot";
            this.radioButtonPot.Size = new System.Drawing.Size(49, 17);
            this.radioButtonPot.TabIndex = 2;
            this.radioButtonPot.TabStop = true;
            this.radioButtonPot.Text = "I can";
            this.radioButtonPot.UseVisualStyleBackColor = true;
            // 
            // radioButtonNuVreau
            // 
            this.radioButtonNuVreau.AutoSize = true;
            this.radioButtonNuVreau.Location = new System.Drawing.Point(272, 120);
            this.radioButtonNuVreau.Name = "radioButtonNuVreau";
            this.radioButtonNuVreau.Size = new System.Drawing.Size(80, 17);
            this.radioButtonNuVreau.TabIndex = 3;
            this.radioButtonNuVreau.TabStop = true;
            this.radioButtonNuVreau.Text = "I don\'t want";
            this.radioButtonNuVreau.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.SystemColors.Control;
            this.submitButton.Location = new System.Drawing.Point(272, 168);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(99, 37);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(272, 211);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(99, 37);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // PCMemberBidProposals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 508);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.radioButtonNuVreau);
            this.Controls.Add(this.radioButtonPot);
            this.Controls.Add(this.radioButtonDa);
            this.Controls.Add(this.proposalsDataGridView);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(404, 547);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(404, 547);
            this.Name = "PCMemberBidProposals";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PCMemberBidProposals";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PCMemberBidProposals_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.proposalsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView proposalsDataGridView;
        private System.Windows.Forms.RadioButton radioButtonDa;
        private System.Windows.Forms.RadioButton radioButtonPot;
        private System.Windows.Forms.RadioButton radioButtonNuVreau;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button buttonBack;
    }
}