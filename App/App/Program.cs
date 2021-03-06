﻿using System;
using System.Windows.Forms;
using App.Entity;
using App.Migrations.Seed;
using App.UI.PhaseThree;

namespace App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Use this for dummy data
            UserContextSeed.Seed();
            TopicSeed.Seed();
            SectionSeed.Seed();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ConferenceDetails());
        }
    }
}
