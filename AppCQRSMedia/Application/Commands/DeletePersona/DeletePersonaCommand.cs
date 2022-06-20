using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppCQRSMedia.Application.Commands.DeletePersona
{
    public class DeletePersonaCommand : IRequest<bool>
    {
        public int PersonId { get; set; }
    }
}
