using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCQRSMedia.Domain.AggregatesModel.PersonaAggregate
{
    public interface IPersona
    {
        void GeneratePersona(string Name, string LastName, string FirstName, int Age);
        void UpdatePersona(PersonaEjercicio persona, PersonaParams personaParams);
        void RemovePersona(PersonaEjercicio persona, int PersonId);
    }
}
