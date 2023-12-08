using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastucture.ViewModels
{
    public class AssistantViewModel
    {
        public string Lastname { get; set; }
        public string Name { get; set; }
        public string Middlename { get; set; }
        public string Contactinfo { get; set; }
        public string Specialization { get; set; }
        public virtual SpecializationEntity Specialization_ { get; set; }
    }
}
