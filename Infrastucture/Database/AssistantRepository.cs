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
                var items = context.Assistant.ToList();
                return AssistantMapper.Map(items);
            }
        }
        public AssistantViewModel GetById(long id)
        {
            using (var context = new Context())
            {
                var item = context.Assistant.FirstOrDefault(x => x.Assistantld == id);
                return AssistantMapper.Map(item);
            }
        }
<<<<<<< Updated upstream
        public AssistantViewModel Update(AssistantViewModel assistant)
        {
            using (var context = new Context())
            {
                int countG = context.Assistant.ToList().Count;

                context.Assistant.AddOrUpdate(AssistantMapper.Map(assistant));

                if (context.Assistant.ToList().Count != countG)
                {
                    Delete(context.Assistant.Last().Assistantld);
=======
        public AssistantViewModel Update(AssistantViewModel entity)
        {
            using (var context = new Context())
            {
                var item = context.Assistant_.ToList().Count;

                context.Assistant_.AddOrUpdate(AssistantMapper.Map(entity));

                if (context.Assistant_.ToList().Count != item)
                {
                    Delete(context.Assistant_.Last().Assistantld);
>>>>>>> Stashed changes
                    return null;
                }
                else
                {
                    context.SaveChanges();
                    return new AssistantViewModel();
                }
            }
        }
<<<<<<< Updated upstream
=======

>>>>>>> Stashed changes
        public AssistantViewModel Delete(long id)
        {
            using (var context = new Context())
            {
<<<<<<< Updated upstream
                if (context.Assistant.Remove(context.Assistant.Find(id)) == null)
=======
                if (context.Assistant_.Remove(context.Assistant_.Find(id)) == null)
>>>>>>> Stashed changes
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

<<<<<<< Updated upstream
        public AssistantViewModel Add(AssistantViewModel assistant)
        {
            using (var context = new Context())
            {
                AssistantEntity assistantEntity = AssistantMapper.Map(assistant);

                if (context.Assistant.Add(assistantEntity) == null)
=======
        public AssistantViewModel Add(AssistantViewModel entity)
        {
            using (var context = new Context())
            {
                AssistantEntity assistant = AssistantMapper.Map(entity);

                if (context.Assistant_.Add(assistant) == null)
>>>>>>> Stashed changes
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
