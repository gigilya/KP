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
                User = entity.User,
            };
            return viewModel;
        }

        public static List<PatientViewModel> Map(List<PatientEntity> entities)
        {
            var viewModels = entities.Select(x => Map(x)).ToList();
            return viewModels;
        } 
        public static PatientEntity Map(PatientViewModel entity)
        {
            var patientEntity = new PatientEntity
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
                User = entity.User,
            };
            return patientEntity;
        }

        public static List<PatientEntity> Map(List<PatientViewModel> entities)
        {
            var patientEntitys = entities.Select(x => Map(x)).ToList();
            return patientEntitys;
        }

    }
}
