using Infrastucture.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastucture.Mappers
{
    public class SpecializationMapper
    {
        public static SpecializationViewModel Map(SpecializationEntity entity)
        {
            var viewModel = new SpecializationViewModel
            {
                Name = entity.Name,
                Wages = entity.Wages,
                Workschedule = entity.Workschedule,
            };
            return viewModel;
        }
        public static List<SpecializationViewModel> Map(List<SpecializationEntity> entities) 
        { 
            var viewModel = entities.Select(x => Map(x)).ToList();
            return viewModel;
        }
    }
}
