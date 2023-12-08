using Infrastucture.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastucture.Mappers
{
    public class AssistantMapper
    {
        public static AssistantViewModel Map(AssistantEntity entity)
        {
            var viewModel = new AssistantViewModel 
            { 
                Name = entity.Name,
                Lastname = entity.Lastname,
                Middlename = entity.Middlename,
                Contactinfo = entity.Contactinfo,
                Specialization = entity.Specialization_.Name,
            };
            return viewModel;
        }
        public static List<AssistantViewModel> Map(List<AssistantEntity> entities)
        {
            var viewModels = entities.Select(x => Map(x)).ToList();
            return viewModels;

        }public static AssistantEntity Map( AssistantViewModel entity)
        {
            var assistantEntity = new AssistantEntity 
            { 
                Name = entity.Name,
                Lastname = entity.Lastname,
                Middlename = entity.Middlename,
                Contactinfo = entity.Contactinfo,
                Specialization_ = entity.Specialization_,
            };
            return assistantEntity;
        }
        public static List<AssistantEntity> Map(List<AssistantViewModel> entities)
        {
            var assistantEntity = entities.Select(x => Map(x)).ToList();
            return assistantEntity;
        }
    }
}
