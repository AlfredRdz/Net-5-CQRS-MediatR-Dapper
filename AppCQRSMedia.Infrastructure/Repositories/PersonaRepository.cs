using AppCQRSMedia.Domain.AggregatesModel.PersonaAggregate;
using AppCQRSMedia.Domain.SeedWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCQRSMedia.Infrastructure.Repositories
{
    public class PersonaRepository : IPersonaRepository
    {
        private readonly AppDbContext _context;

        public PersonaRepository(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IUnitOfWork UnitOfWork
        {
            get
            {
                return _context;
            }
        }

        public void Add(PersonaEjercicio persona)
        {
            _context.Persona.Add(persona);
        }

        public async Task<PersonaEjercicio> FindByIdAsync(int id)
        {
            var persona = await _context.Persona.FirstOrDefaultAsync(x => x.PersonId == id);
            return persona;
        }

        public void Remove(PersonaEjercicio persona)
        {
            _context.Persona.Remove(persona);
        }

        public void Update(PersonaEjercicio persona)
        {
            _context.Update(persona);
        }

        //public PersonaEjercicio Update(PersonaEjercicio persona)
        //{
        //    _context.Entry(persona).State = EntityState.Modified;
        //}
    }
}
