using AppCQRSMedia.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCQRSMedia.Domain.AggregatesModel.PersonaAggregate
{
    public class PersonaEjercicio : Entity, IAggregateRoot
    {
        public string Name; 
        public string LastName;
        public string? FirstName;
        public int? Age;
    }
}
