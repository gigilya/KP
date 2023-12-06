using Infrastucture.Mappers;
using Infrastucture.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastucture.Database
{
    public class SpecializationRepository : IBaseRepository<SpecializationViewModel>
    {
        public List<SpecializationViewModel> GetList()
        {
            using (var context = new Context())
            {
                var items = context.Specialization_.ToList();
                return SpecializationMapper.Map(items);
            }
        }
        public SpecializationViewModel GetById(long id)
        {
            using (var context = new Context())
            {
                var item = context.Specialization_.FirstOrDefault(x => x.Specializationld == id);
                return SpecializationMapper.Map(item);
            }
        }
    }
}
