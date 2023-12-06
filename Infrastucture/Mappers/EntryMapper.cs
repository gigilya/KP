using Infrastucture.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastucture.Mappers
{
    public class EntryMapper
    {
        public static EntryViewModel Map(EntryEntity entity)
        {
            var entryViewModel = new EntryViewModel
            {
                Name = entity.Patient.Name,
                Lastname = entity.Patient.Lastname,
                Middlename = entity.Patient.Middlename,
                Procedure = entity.Procedure.Proceduredescription,
                Datereceipt = entity.Datereceipt,
                Statusreceipt = entity.Statusreceipt,

            };
            return entryViewModel;
        }
        public static List<EntryViewModel> Map(List<EntryEntity> entities) 
        {
            var viewModel = entities.Select(x => Map(x)).ToList();
            return viewModel;
        }
    }
}
