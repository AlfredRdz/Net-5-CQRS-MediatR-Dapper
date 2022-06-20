using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppCQRSMedia.Domain.AggregatesModel.PersonaAggregate
{
    public class PersonaParams
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
