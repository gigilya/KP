using Infrastucture.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastucture.Mappers
{
    public class ProcedureMapper
    {
        public static ProcedureViewModel Map(ProcedureEntity entity)
        {
            var viewModel = new ProcedureViewModel()
            {
                Id = entity.Procedureld,
                Doctorfio = entity.Doctor.Lastname,
                Assistantfio = entity.Assistant_.Lastname,
                Description = entity.Proceduredescription,
                Price = entity.Price,
            };
            return viewModel;
        }
        public static List<ProcedureEntity> Map(List<ProcedureViewModel> entities)
        {
            var viewModels = entities.Select(x => Map(x)).ToList();
            return viewModels;
        }        
        public static ProcedureEntity Map(ProcedureViewModel entity)
        {
            var procedureEntity = new ProcedureEntity()
            {
                Procedureld = entity.Id,
                Doctor = entity.Doctor,
                Assistant_ = entity.Assistant_,
                Proceduredescription = entity.Description,
                Price = entity.Price,
            };
            return procedureEntity;
        }
        public static List<ProcedureViewModel> Map(List<ProcedureEntity> entities)
        {
            var viewModels = entities.Select(x => Map(x)).ToList();
            return viewModels;
        }
    }
}
