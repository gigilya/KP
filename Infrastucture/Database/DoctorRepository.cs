using Infrastucture.Mappers;
using Infrastucture.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastucture.Database
{
    public class DoctorRepository : IBaseRepository<DoctorViewModel>
    {
        public List<DoctorViewModel> GetList()
        {
           using (var context = new Context())
            {
                var items = context.Doctor.ToList();
                return DoctorMapper.Map(items);
            }
        }
        public DoctorViewModel GetById(long id)
        {
            using (var context = new Context())
            {
                var item = context.Doctor.FirstOrDefault(x => x.Doctorld == id);
                return DoctorMapper.Map(item);
            }
        }
    }
}
