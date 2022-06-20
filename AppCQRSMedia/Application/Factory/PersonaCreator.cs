using AppCQRSMedia.Domain.AggregatesModel.PersonaAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppCQRSMedia.CQRS.Application.Factory
{
    public class PersonaCreator : IPersona
    {
        private readonly IPersonaRepository _personaRepository;

        public PersonaCreator(IPersonaRepository personaRepository)
        {
            _personaRepository = personaRepository;
        }

        public void GenerateRequestPersona(PersonaParams persona)
        {
            var personaCreate = new PersonaEjercicio
            {
                Name = persona.Name,
                LastName = persona.LastName,
                FirstName = persona.FirstName,
                Age = persona.Age
            };

            _personaRepository.Add(personaCreate);
        }

        public void UpdateRequestPersona(PersonaEjercicio oldPersona)
        {
            _personaRepository.Update(oldPersona);
        }

        public void RemoveRequestPersona(PersonaEjercicio oldPersona)
        {
            _personaRepository.Remove(oldPersona);
        }

        public void GeneratePersona(string Name, string LastName, string FirstName, int Age)
        {
            throw new NotImplementedException();
        }

        public void UpdatePersona(PersonaEjercicio persona, PersonaParams personaParams)
        {
            throw new NotImplementedException();
        }

        public void RemovePersona(PersonaEjercicio persona, int PersonId)
        {
            _personaRepository.Remove(persona);
        }
    }
}
