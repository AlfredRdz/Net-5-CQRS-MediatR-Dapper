using AppCQRS;
using AppCQRS.Domain;
using AppCQRSMedia.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AppCQRSMedia.Application.Queries.GetPersonas
{
    //public class GetPersonasQueryHandler : IRequestHandler<GetPersonasQuery, List<PersonaEjercicio>>
    //{
    //    //private readonly AppDbContext _context;

    //    //public GetPersonasQueryHandler(AppDbContext context)
    //    //{
    //    //    _context = context;
    //    //}

    //    public async Task<List<PersonaEjercicio>> Handle(GetPersonasQuery request, CancellationToken cancellationToken)
    //    {
    //        return await _context.Persona.ToListAsync();
    //    }

    //}
}
