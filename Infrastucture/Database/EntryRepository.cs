using Infrastucture.Mappers;
using Infrastucture.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastucture.Database
{
    public class EntryRepository : IBaseRepository<EntryViewModel>
    {
        public List<EntryViewModel> GetList()
        {
            using(var context = new Context())
            {
                var items = context.Entry.ToList();
                return EntryMapper.Map(items);
            }
        }
        public EntryViewModel GetById(long id)
        {
            using(var context = new Context())
            {
                var item = context.Entry.FirstOrDefault(x => x.Entryld == id);
                return EntryMapper.Map(item);
            }
        }
    }
}
