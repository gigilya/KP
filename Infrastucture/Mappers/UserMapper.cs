﻿using Infrastucture.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastucture.Mappers
{
    public class UserMapper
    {
        public static UserViewModel Map(UserEntity entity)
        {
            var viewModel = new UserViewModel
            {
                Id = entity.Userld,
                Login = entity.Login,
                Passworded = entity.Password,
            };
            return viewModel;
        }
        public static List<UserViewModel> Map(List<UserEntity> entities)
        {
            var viewModels = entities.Select(x => Map(x)).ToList();
            return viewModels;
        }
    }
}
