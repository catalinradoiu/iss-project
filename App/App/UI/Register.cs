﻿using App.Controller;
using App.Entity;
using App.Exception;
using App.Factory;
using App.Validators;
using System;
using System.Windows.Forms;

namespace App
{
    public partial class Register : Form
    {
        private PreliminaryPhaseController preliminaryController;
        private UserValidator userValidator;
        private Form parentForm;

        public Register(Form parentForm)
        {
            InitializeComponent();

            this.parentForm = parentForm;
            userValidator = new UserValidator();
            preliminaryController = ApplicationFactory.GetPreliminaryPhaseController();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (textPassword.Text != textConfirmPassword.Text)
                {
                    throw new ValidationException("Passwords do not match!");
                }

                var newUser = new User();
                newUser.FirstName = textFirstName.Text;
                newUser.LastName = textLastName.Text;
                newUser.Country = textCountry.Text;
                newUser.Email = textEmail.Text;
                newUser.Password = textPassword.Text;

                userValidator.Validate(newUser);

                preliminaryController.Register(newUser);

                MessageBox.Show("You have successfully created your account!\nYou can now log in into your account!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidEmailAddressException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            AcceptButton = buttonRegister;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Location = new System.Drawing.Point(Location.X, Location.Y);
            parentForm.Show();
        }
    }
}