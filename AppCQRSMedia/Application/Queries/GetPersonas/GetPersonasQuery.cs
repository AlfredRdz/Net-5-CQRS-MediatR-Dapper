using AppCQRS.Domain;
using AppCQRSMedia.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppCQRSMedia.Application.Queries.GetPersonas
{
    public class GetPersonasQuery : IRequest<List<PersonaEjercicio>>
    {
    }
}
