﻿using App.Controller;
using App.Entity;
using App.Factory;
using App.Utils;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Windows.Forms;

namespace App.UI.PhaseTwo
{
    /// <summary>
    /// Author : Diana Gociu
    /// </summary>
    public partial class ChairToAcceptedAuthors : Form
    {
        private ChairMain parent;
        private PhaseTwoController phaseTwoController;
        private MailSender mailSender;

        public ChairToAcceptedAuthors(ChairMain parent)
        {
            this.parent = parent;
            phaseTwoController = ApplicationFactory.getPhaseTwoController();
            mailSender = new MailSender();
            InitializeComponent();
        }

        private void sendEmailsButton_Click(object sender, EventArgs e)
        {
            List<Proposal> proposals;
            List<Review> reviews;
            List<User> authors = new List<User>();
            

            proposals = phaseTwoController.getProposals();
            foreach(Proposal proposal in proposals)
            {
                String result = "";
                reviews = phaseTwoController.getReviewsByProposalId(proposal.ProposalId);
                foreach(Review review in reviews)
                {
                    result += review.Qualifier + " " + review.Comment;
                }
                
                foreach(User author in proposal.Authors)
                {
                    authors.Add(author);
                }
                foreach(User author in authors)
                {
                    MailAddress senderM = new MailAddress("iss.cmsmailer@gmail.com");
                    MailAddress receiver = new MailAddress(author.Email);
                    string mailBody = "Thank you for your application. \n Here are your results: \n" + result;                    
                    string mailSubject = "Proposal Review";
                    mailSender.sendMail(receiver, mailBody, mailSubject);
                }
            }

            MessageBox.Show("Mails have been sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChairToAcceptedAuthors_FormClosing(object sender, FormClosingEventArgs e)
        {
            phaseTwoController.saveChanges();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            parent.Location = new System.Drawing.Point(Location.X, Location.Y);
            parent.Show();
            Close();
        }

        private void ChairToAcceptedAuthors_Load(object sender, EventArgs e)
        {

        }
    }
}
