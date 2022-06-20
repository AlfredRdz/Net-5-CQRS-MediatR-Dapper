using AppCQRS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppCQRSMedia.CQRS.Application.Queries
{
    public interface IPersonaQueries
    {
        Task<IEnumerable<PersonaEjercicio>> GetPersonas();
        Task<IEnumerable<PersonaEjercicio>> GetPersonasById(int PersonId);
    }
}
