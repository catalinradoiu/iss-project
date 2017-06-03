﻿using App.Context;
using App.Entity;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace App.Repository.Impl
{
    /// <summary>
    /// 
    /// Proposal Repository
    /// Author : Catalin Radoiu
    /// Author : Ioan Ovidiu Enache
    /// 
    /// </summary>
    public class ProposalRepository : AbstractRepository<Proposal>, IProposalRepository
    {
        public ProposalRepository(AppContext context) : base(context)
        {
        }

        public List<Proposal> getProposalsBindingSource()
        {
            return Context.Proposals.ToList();
        }

        public void saveChanges()
        {
            Context.SaveChanges();
        }

        public Proposal FindProposalByName(string name)
        {
            return Context.Proposals.SingleOrDefault(p => p.Title == name);
        }
    }
}
