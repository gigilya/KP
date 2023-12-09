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
        public SpecializationViewModel Update(SpecializationViewModel entry)
        {
            using (var context = new Context())
            {
                int countG = context.Specialization_.ToList().Count;

                context.Specialization_.AddOrUpdate(SpecializationMapper.Map(entry));

                if (context.Specialization_.ToList().Count != countG)
                {
                    Delete(context.Specialization_.Last().Specializationld);
                    return null;
                }
                else
                {
                    context.SaveChanges();
                    return new SpecializationViewModel();
                }
            }
        }
        public SpecializationViewModel Delete(long id)
        {
            using (var context = new Context())
            {
                if (context.Specialization_.Remove(context.Specialization_.Find(id)) == null)
                {
                    return null;
                }
                else
                {
                    context.SaveChanges();
                    return new SpecializationViewModel();
                }
            }
        }
        public SpecializationViewModel Add(SpecializationViewModel entry)
        {
            using (var context = new Context())
            {
                SpecializationEntity specialisationEntity = SpecializationMapper.Map(entry);

                if (context.Specialization_.Add(specialisationEntity) == null)
                {
                    return null;
                }
                else
                {
                    context.SaveChanges();
                    return new SpecializationViewModel();
                }
            }
        }
    }
}
