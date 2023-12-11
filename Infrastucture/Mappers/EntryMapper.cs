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
                Procedure = entity.Procedure,
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
        public static EntryEntity Map(EntryViewModel entity)
        {
            var entryEntity = new EntryEntity
            {
                //Name = entity.Patient.Name,
                //Lastname = entity.Patient.Lastname,
                //Middlename = entity.Patient.Middlename,
                Procedure = entity.Procedure,
                Datereceipt = entity.Datereceipt,
                Statusreceipt = entity.Statusreceipt,

            };
            return entryEntity;
        }
        public static List<EntryEntity> Map(List<EntryViewModel> entities) 
        {
            var entryEntity = entities.Select(x => Map(x)).ToList();
            return entryEntity;
        }
    }
}
