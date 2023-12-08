﻿using Infrastucture.Mappers;
using Infrastucture.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastucture.Database
{
    public class UserRepository
    {
        public List<UserViewModel> GetList()
        {
            using (var context = new Context())
            {
                var items = context.User.ToList();
                return UserMapper.Map(items);
            }
        }
        public UserViewModel GetById(long id)
        {
            using (var context = new Context())
            {
                var item = context.User.FirstOrDefault(x => x.Userld == id);
                return UserMapper.Map(item);
            }
        }
    }
}