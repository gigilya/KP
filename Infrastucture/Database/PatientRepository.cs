using Infrastucture.Mappers;
using Infrastucture.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastucture.Database
{
    public class PatientRepository : IBaseRepository<PatientViewModel>
    {
        public List<PatientViewModel> GetList()
        {
            using (var context = new Context())
            {
                var items = context.Patient.ToList();
                return PatientMapper.Map(items);
            }
        }
        public PatientViewModel GetById(long id)
        {
            using (var context = new Context())
            {
                var item = context.Patient.FirstOrDefault(x => x.Patientld == id);
                return PatientMapper.Map(item);
            }
        }

    }
}
