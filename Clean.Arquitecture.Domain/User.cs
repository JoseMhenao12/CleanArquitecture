using Clean.Arquitecture.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Arquitecture.Domain
{
    public class User: Audit
    {
        public string Names { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string SecondLastName { get; set; } = default!;
        public int DocumentType { get; set; } 
        public string DocumentNumber { get; set; } = default!;
        public DateTime BirthDate { get; set; } 


    }
}
