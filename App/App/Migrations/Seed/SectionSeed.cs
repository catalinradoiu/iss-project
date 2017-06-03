﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Context;
using App.Entity;

namespace App.Migrations.Seed
{
    /// <summary>
    /// 
    /// Class SectionSeed
    /// 
    /// Author : Claudiu Nicola
    /// 
    /// </summary>
    public class SectionSeed
    {
        /// <summary>
        /// This method is used at startup of App
        /// for populate db with dummy data.
        /// Usage: ProposalSeed.Seed()
        /// 
        /// </summary>
        public static void Seed()
        {
            using (var db = new AppContext())
            {
                if (!db.Sections.Any())
                {
                    var sectionLeader = db.Users.Find(1);
                    List<Topic> topics = new List<Topic>();
                    topics.Add(db.Topics.Find(1));
                    topics.Add(db.Topics.Find(4));
                    topics.Add(db.Topics.Find(5));
                    List<User> listeners = new List<User>();
                    List<User> authors = new List<User>();
                    authors.Add(db.Users.Find(2));
                    authors.Add(db.Users.Find(3));
                    db.Sections.Add(
                        new Section("Web", sectionLeader, topics, listeners, authors, "Aula", new Dictionary<string, Proposal>())
                    );

                    sectionLeader = db.Users.Find(5);
                    topics = new List<Topic>();
                    topics.Add(db.Topics.Find(2));
                    topics.Add(db.Topics.Find(3));
                    listeners = new List<User>();
                    authors = new List<User>();
                    authors.Add(db.Users.Find(4));
                    db.Sections.Add(
                        new Section("Desktop", sectionLeader, topics, listeners, authors, "Mare", new Dictionary<string, Proposal>())
                    );

                    db.SaveChanges();
                }
            }
        }
    }
}
