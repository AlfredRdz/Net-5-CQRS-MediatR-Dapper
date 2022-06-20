using AppCQRSMedia.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCQRSMedia.Domain.AggregatesModel.PersonaAggregate
{
    public interface IPersonaRepository : IRepository<PersonaEjercicio>
    {
        void Add(PersonaEjercicio persona);
        void Update(PersonaEjercicio persona);
        Task<PersonaEjercicio> FindByIdAsync(int id);
        void Remove(PersonaEjercicio persona);
    }
}
