﻿using App.Controller;
using App.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.UI.PhaseTwo
{
    public partial class PCMemberBidProposals : Form
    {
        private List<Proposal> proposals;
        private User reviewer;
        private PhaseTwoController phaseTwoController;

        public PCMemberBidProposals(PhaseTwoController phaseTwoController, List<Proposal> proposals, User reviewer)
        {
            this.proposals = proposals;
            this.reviewer = reviewer;
            this.phaseTwoController = phaseTwoController;
            initProposalsDataGridView();
            InitializeComponent();
        }
        private void initProposalsDataGridView()
        {
            BindingList<Proposal> bindingList = new BindingList<Proposal>(proposals);
            BindingSource source = new BindingSource(bindingList, null);
            proposalsDataGridView.DataSource = source;
        }
        /// <summary>
        /// Author: Vancea Vladut
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitButton_Click(object sender, EventArgs e)
        {
            RadioButton checkedReviewButton = this.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            Proposal prop = phaseTwoController.findProposalById(int.Parse(proposalsDataGridView.CurrentRow.Cells[0].Value.ToString()));

            if (checkedReviewButton.Text.Equals("I want") || checkedReviewButton.Text.Equals("I can"))
            {
                //Real author: Andu Popa...
                Review review = phaseTwoController.findReviewByIdProposal(prop.ProposalId);
                review.Reviewer = reviewer;
                phaseTwoController.updateReview(review);
            }
            else
            {
                phaseTwoController.deleteProposalFromDB(prop);
            }


            

        }

        private void proposalsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //do nothing

        }
        private void proposalsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (phaseTwoController.findReviewByIdProposalIdReviewer(int.Parse(proposalsDataGridView.CurrentRow.Cells[0].Value.ToString()), reviewer.UserId))
            {
                submitButton.Enabled = false;
            }
        }

    }
}
