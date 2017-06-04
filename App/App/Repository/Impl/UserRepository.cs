﻿using App.Context;
using App.Entity;
using App.Utils;
using System.Collections.Generic;
using System.Linq;

namespace App.Repository.Impl
{
    /// <summary>
    /// 
    /// User Repository
    /// Author : Catalin Radoiu
    /// Author : Claudiu Nicola
    /// Author: Dezsi Razvan
    /// 
    /// </summary>
    public class UserRepository : AbstractRepository<User>, IUserRepository
    {
        public UserRepository(AppContext context) : base(context)
        {
        }

        public User FindUserByEmail(string email)
        {
            return Context.Users.SingleOrDefault(user => user.Email == email);
        }

        public List<Role> GetRoles(User user)
        {
            var queryRole = from item in Context.Roles
                            where item.UserRoles.Any(x => x.UserId == user.UserId)
                            select item;
            return queryRole.ToList();

        }
        public void ChangePassword(string email,string password)
        {
            var encrypt = new EncryptDecrypt();
            if (email != null)
            {
                User userImplicated = Context.Users.SingleOrDefault(user => user.Email == email);
                if (userImplicated != null) {
                    userImplicated.Password = encrypt.encryptPassword(password);
                    Context.SaveChanges(); }
            }
        }
    }
}
