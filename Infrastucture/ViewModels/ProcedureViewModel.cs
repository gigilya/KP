using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastucture.ViewModels
{
    public class ProcedureViewModel
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public long Price { get; set; }
        public AssistantEntity Assistant_ { get; set; }
        public DoctorEntity Doctor { get; set; }
        public List<EntryEntity> Entry { get; set; }

    }
}
