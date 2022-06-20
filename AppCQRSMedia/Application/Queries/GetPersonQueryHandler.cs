using AppCQRS;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AppCQRSMedia.Queries
{
    //public class GetPersonQueryHandler : IRequestHandler<GetPersonaQuery, GetPersonaQueryResponse>
    //{
    //    private readonly AppDbContext _context;
    //    public GetPersonQueryHandler(AppDbContext context)
    //    {
    //        _context = context;
    //    }
    //    public async Task<GetPersonaQueryResponse> Handle(GetPersonaQuery request, CancellationToken cancellationToken)
    //    {
    //        var product = await _context.Persona.FindAsync(request.PersonId);

    //        return new GetPersonaQueryResponse
    //        {
    //            PersonId = product.PersonId,
    //            Name = product.Name,
    //            FirstName = product.FirstName,
    //            LastName = product.LastName,
    //            Age = product.Age
    //        };
    //    }
    //}
}
