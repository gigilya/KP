﻿using Infrastucture.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastucture.Mappers
{
    public class DoctorMapper
    {
        public static DoctorViewModel Map(DoctorEntity entity)
        {
            var viewModel = new DoctorViewModel
            {
                Id = entity.Doctorld,
                Name = entity.Name,
                Lastname = entity.Lastname,
                Middlename = entity.Middlename,
                Contactinfo = entity.Contactinfo,
                Specialization = entity.Specialization_.Name,
            };
            return viewModel;
        }
        public static List<DoctorViewModel> Map(List<DoctorEntity> entities)
        {
            var viewModels = entities.Select(x => Map(x)).ToList();
            return viewModels;
        }
        public static DoctorEntity Map(DoctorViewModel entity)
        {
            var doctorEntity = new DoctorEntity
            {
                //Id = entity.Doctorld,
                Name = entity.Name,
                Lastname = entity.Lastname,
                Middlename = entity.Middlename,
                Contactinfo = entity.Contactinfo,
                Specialization_ = entity.Specialization_,   //возможно нужны изминения
            };
            return doctorEntity;
        }
        public static List<DoctorEntity> Map(List<DoctorViewModel> entities)
        {
            var doctorEntity = entities.Select(x => Map(x)).ToList();
            return doctorEntity;
        }
    }
}