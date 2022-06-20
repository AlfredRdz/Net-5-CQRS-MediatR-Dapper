using AppCQRS;
using AppCQRSMedia.CQRS.Application.Factory;
using AppCQRSMedia.Domain.AggregatesModel.PersonaAggregate;
using Dapper;
using MediatR;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AppCQRSMedia.Application.Commands.DeletePersona
{
    public class DeletePersonaCommandHandler : IRequestHandler<DeletePersonaCommand, bool>
    {
        private readonly IPersonaRepository _personaRepository;
        //private readonly string _connectionString = string.Empty;
        public DeletePersonaCommandHandler(IPersonaRepository personaRepository)
        {
            _personaRepository = personaRepository;
            //_connectionString = "Data Source=evaluatest-empresas-qa.database.windows.net;Initial Catalog=empresas-evaluatest-dev;Persist Security Info=True;User ID=AdminEmpresasEvt; Password=fwyJPlYET8N09MG1V35n";
        }

        public async Task<bool> Handle(DeletePersonaCommand request, CancellationToken cancellationToken)
        {
            PersonaEjercicio persona = await _personaRepository.FindByIdAsync(request.PersonId);

            if(persona != null)
            {
                PersonaCreator personaCreator = new PersonaCreator(_personaRepository);
                personaCreator.RemoveRequestPersona(persona);
            }

            await _personaRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);

            return true;
        }

        //public async Task<bool> Handle(DeletePersonaCommand request, CancellationToken cancellationToken)
        //{
        //    if (request.PersonId == 0)
        //        return false;

        //    PersonaEjercicio persona = await _personaRepository.FindByIdAsync(request.PersonId);

        //    if (persona != null)
        //    {
        //        SqlConnection connection = new(_connectionString);

        //        connection.Open();

        //        string sqlQuery = "DELETE FROM PersonaEjercicio WHERE PersonId = @PersonId";

        //        await connection.ExecuteAsync(sqlQuery, new
        //        {
        //            persona.PersonId
        //        });
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }

        //    return await _personaRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);

        //}



    }
}
