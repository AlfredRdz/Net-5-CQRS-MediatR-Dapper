using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppCQRSMedia.Queries
{
    public class GetPersonaQuery : IRequest<GetPersonaQueryResponse>
    {
        public int PersonId { get; set; }
    }
}
