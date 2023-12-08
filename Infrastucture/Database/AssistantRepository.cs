using Infrastucture.Mappers;
using Infrastucture.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastucture.Database
{
    public class AssistantRepository : IBaseRepository<AssistantViewModel>
    {
        public List<AssistantViewModel> GetList()
        {
            using (var context = new Context())
            {
                var items = context.Assistant_.ToList();
                return AssistantMapper.Map(items);
            }
        }
        public AssistantViewModel GetById(long id)
        {
            using (var context = new Context())
            {
                var item = context.Assistant_.FirstOrDefault(x => x.Assistantld == id);
                return AssistantMapper.Map(item);
            }
        }
        public AssistantViewModel Update(AssistantViewModel assistant)
        {
            using (var context = new Context())
            {
                int countG = context.Assistant_.ToList().Count;

                context.Assistant_.AddOrUpdate(AssistantMapper.Map(assistant));

                if (context.Assistant_.ToList().Count != countG)
                {
                    Delete(context.Assistant_.Last().Assistantld);
                    return null;
                }
                else
                {
                    context.SaveChanges();
                    return new AssistantViewModel();
                }
            }
        }
        public AssistantViewModel Delete(long id)
        {
            using (var context = new Context())
            {
                if (context.Assistant_.Remove(context.Assistant_.Find(id)) == null)
                {
                    return null;
                }
                else
                {
                    context.SaveChanges();
                    return new AssistantViewModel();
                }
            }
        }

        public AssistantViewModel Add(AssistantViewModel assistant)
        {
            using (var context = new Context())
            {
                AssistantEntity assistantEntity = AssistantMapper.Map(assistant);

                if (context.Assistant_.Add(assistantEntity) == null)
                {
                    return null;
                }
                else
                {
                    context.SaveChanges();
                    return new AssistantViewModel();
                }
            }
        }
    }
}
