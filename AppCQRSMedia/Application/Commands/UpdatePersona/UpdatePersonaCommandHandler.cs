using AppCQRS;
using AppCQRS.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AppCQRSMedia.Commands.UpdatePersona
{
    //public class UpdatePersonaCommandHandler : IRequestHandler<UpdatePersonaCommand, UpdatePersonaCommandResponse>
    //{ 
    //    //private readonly AppDbContext _context;
    //    //public UpdatePersonaCommandHandler(AppDbContext context)
    //    //{
    //    //    _context = context;
    //    //}

    //    public async Task<UpdatePersonaCommandResponse> Handle(UpdatePersonaCommand request, CancellationToken cancellationToken)
    //    {
    //        //var updatePersona = await _context.Persona.FindAsync(request.PersonId);

    //        //if (updatePersona == null)
    //        //{
    //        //    throw new Exception("No se encontro a la persona");
    //        //}
    //        //else
    //        //{
    //        //    updatePersona.Name = request.Name;
    //        //    updatePersona.FirstName = request.FirstName;
    //        //    updatePersona.LastName = request.LastName;
    //        //    updatePersona.Age = request.Age;

    //        //    //_context.Persona.Update(updatePersona);

    //        //    //await _context.SaveChangesAsync();

    //        //var newPersona = new UpdatePersonaCommandResponse
    //        //{
    //        //    PersonId = updatePersona.PersonId,
    //        //    Name = updatePersona.Name,
    //        //    FirstName = updatePersona.FirstName,
    //        //    LastName = updatePersona.LastName,
    //        //    Age = updatePersona.Age
    //        //};
    //        var newPersona = new UpdatePersonaCommandResponse
    //        {
    //            PersonId = 2,
    //            Name = "as",
    //            FirstName = "asd",
    //            LastName = "asd",
    //            Age = 23
    //        };
    //        return newPersona;
    //        //}
    //    }
    //}
}
