﻿using App.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Controller
{
    /// <summary>
    /// 
    /// The class ControllerServiceLogin for LoginForm
    /// 
    /// Author: Vancea Vlad
    /// </summary>
    /// 
    public class LoginController
    {
        public LoginController() { }

        public bool areCredentialsValid(string username, string password)
        {

            throw new NotImplementedException();

        }

        public bool isConferenceActive()
        {
            throw new NotImplementedException();
        }


        public IEnumerable<string> getUserRole(User user)
        {
            throw new NotImplementedException();
        }

        public User findByUsername(string username)
        {
            throw new NotImplementedException();
        }

        public Phase currentPhase()
        {
            throw new NotImplementedException();
        }

    }
}