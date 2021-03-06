﻿namespace App.UI
{
    partial class CreateConference
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.labelCommitee = new System.Windows.Forms.Label();
            this.labelTopics = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.labelFee = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxFee = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.listBoxTopics = new System.Windows.Forms.ListBox();
            this.comboBoxCheckedListCreate = new App.UI.ComboBoxCheckedList();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(24, 394);
            this.buttonBack.MaximumSize = new System.Drawing.Size(86, 43);
            this.buttonBack.MinimumSize = new System.Drawing.Size(86, 43);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(86, 43);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(21, 18);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(41, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name: ";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(21, 53);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(58, 13);
            this.labelEndDate.TabIndex = 2;
            this.labelEndDate.Text = "End Date: ";
            // 
            // labelCommitee
            // 
            this.labelCommitee.AutoSize = true;
            this.labelCommitee.Location = new System.Drawing.Point(21, 84);
            this.labelCommitee.Name = "labelCommitee";
            this.labelCommitee.Size = new System.Drawing.Size(105, 13);
            this.labelCommitee.TabIndex = 3;
            this.labelCommitee.Text = "Commitee Members: ";
            // 
            // labelTopics
            // 
            this.labelTopics.AutoSize = true;
            this.labelTopics.Location = new System.Drawing.Point(21, 117);
            this.labelTopics.Name = "labelTopics";
            this.labelTopics.Size = new System.Drawing.Size(45, 13);
            this.labelTopics.TabIndex = 4;
            this.labelTopics.Text = "Topics: ";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(150, 394);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(203, 43);
            this.buttonCreate.TabIndex = 5;
            this.buttonCreate.Text = "Create Conference";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // labelFee
            // 
            this.labelFee.AutoSize = true;
            this.labelFee.Location = new System.Drawing.Point(21, 353);
            this.labelFee.Name = "labelFee";
            this.labelFee.Size = new System.Drawing.Size(89, 13);
            this.labelFee.TabIndex = 6;
            this.labelFee.Text = "Conference Fee: ";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(150, 15);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(203, 20);
            this.textBoxName.TabIndex = 7;
            // 
            // textBoxFee
            // 
            this.textBoxFee.Location = new System.Drawing.Point(150, 350);
            this.textBoxFee.Name = "textBoxFee";
            this.textBoxFee.Size = new System.Drawing.Size(203, 20);
            this.textBoxFee.TabIndex = 11;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(150, 46);
            this.dateTimePicker.MaxDate = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(2017, 5, 5, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(203, 20);
            this.dateTimePicker.TabIndex = 12;
            this.dateTimePicker.Value = new System.DateTime(2017, 5, 5, 18, 45, 22, 0);
            // 
            // listBoxTopics
            // 
            this.listBoxTopics.FormattingEnabled = true;
            this.listBoxTopics.Location = new System.Drawing.Point(150, 117);
            this.listBoxTopics.Name = "listBoxTopics";
            this.listBoxTopics.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxTopics.Size = new System.Drawing.Size(203, 212);
            this.listBoxTopics.TabIndex = 13;
            // 
            // comboBoxCheckedListCreate
            // 
            this.comboBoxCheckedListCreate.CheckOnClick = true;
            this.comboBoxCheckedListCreate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxCheckedListCreate.DropDownHeight = 1;
            this.comboBoxCheckedListCreate.FormattingEnabled = true;
            this.comboBoxCheckedListCreate.IntegralHeight = false;
            this.comboBoxCheckedListCreate.Location = new System.Drawing.Point(150, 81);
            this.comboBoxCheckedListCreate.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCheckedListCreate.Name = "comboBoxCheckedListCreate";
            this.comboBoxCheckedListCreate.Size = new System.Drawing.Size(203, 21);
            this.comboBoxCheckedListCreate.TabIndex = 15;
            this.comboBoxCheckedListCreate.ValueSeparator = ", ";
            // 
            // CreateConference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 449);
            this.Controls.Add(this.comboBoxCheckedListCreate);
            this.Controls.Add(this.listBoxTopics);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.textBoxFee);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelFee);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.labelTopics);
            this.Controls.Add(this.labelCommitee);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonBack);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(387, 488);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(387, 488);
            this.Name = "CreateConference";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Create a Conference";
            this.Load += new System.EventHandler(this.CreateConferenceUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label labelCommitee;
        private System.Windows.Forms.Label labelTopics;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label labelFee;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxFee;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ListBox listBoxTopics;
        private ComboBoxCheckedList comboBoxCheckedListCreate;
    }
}