using Infrastucture.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastucture.Mappers
{
    public static class PatientMapper
    {
        public static PatientViewModel Map(PatientEntity entity)
        {
            var viewModel = new PatientViewModel
            {
               // Id = entity.Patientld,
                Name = entity.Name,
                Lastname = entity.Lastname,
                Middlename = entity.Middlename,
                Gender = entity.Gender,
                Birthday = entity.Birthday,
                Address = entity.Address,
                Contactinfo = entity.Contactinfo,
                Userld = entity.Userld,
                //UserName = entity.User.Login,
            };
            return viewModel;
        }

        public static List<PatientViewModel> Map(List<PatientEntity> entities)
        {
            var viewModels = entities.Select(x => Map(x)).ToList();
            return viewModels;
        }

    }
}
