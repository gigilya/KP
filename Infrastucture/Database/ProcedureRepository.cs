using Infrastucture.Mappers;
using Infrastucture.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastucture.Database
{
    public class ProcedureRepository : IBaseRepository<ProcedureViewModel>
    {
        public List<ProcedureViewModel> GetList() 
        {
            using (var context = new Context())
            {
                var item = context.Procedure.ToList();
                return ProcedureMapper.Map(item);
            }
        }
        public ProcedureViewModel GetById(long id)
        {
            using (var context = new Context())
            {
                var items = context.Procedure.FirstOrDefault(x => x.Procedureld == id);
                return ProcedureMapper.Map(items);
            }
        }
    }
}
