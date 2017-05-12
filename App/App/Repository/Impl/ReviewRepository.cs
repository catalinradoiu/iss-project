﻿using App.Context;
using App.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repository.Impl
{
    /// <summary>
    /// 
    /// Review Repository
    /// Author : Catalin Radoiu
    /// 
    /// </summary>
    class ReviewRepository : AbstractRepository<Review>, IReviewRepository
    {
        public ReviewRepository(AppContext context) : base(context)
        {

        }
    }
}
