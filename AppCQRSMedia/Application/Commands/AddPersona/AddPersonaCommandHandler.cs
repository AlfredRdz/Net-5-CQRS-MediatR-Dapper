using AppCQRSMedia.CQRS.Application.Factory;
using AppCQRSMedia.Domain.AggregatesModel.PersonaAggregate;
using Dapper;
using MediatR;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AppCQRSMedia.Commands.AddPersona
{
    public class AddPersonaCommandHandler : IRequestHandler<AddPersonaCommand, bool>
    {
        private readonly IPersonaRepository _personaRepository;
        //private readonly string _connectionString = string.Empty;

        public AddPersonaCommandHandler(IPersonaRepository personaRepository)
        {
            _personaRepository = personaRepository;
            //_connectionString = "Data Source=evaluatest-empresas-qa.database.windows.net;Initial Catalog=empresas-evaluatest-dev;Persist Security Info=True;User ID=AdminEmpresasEvt; Password=fwyJPlYET8N09MG1V35n";
        }

        public async Task<bool> Handle(AddPersonaCommand request, CancellationToken cancellationToken)
        {
            try
            {
                if (request != null)
                {
                    PersonaCreator personaCreator = new PersonaCreator(_personaRepository);

                    PersonaEjercicio oldPersona = await _personaRepository.FindByIdAsync(request.PersonId);

                    if(oldPersona == null || oldPersona.PersonId == 0)
                    {
                        oldPersona = new PersonaEjercicio();
                    }
                    PersonaParams personaParams = new()
                    {
                        Name = request.Name,
                        LastName = request.LastName,
                        FirstName = request.FirstName,
                        Age = request.Age
                    };

                    if(personaParams != null)
                    {
                        oldPersona.Name = personaParams.Name;
                        oldPersona.LastName = personaParams.LastName;
                        oldPersona.FirstName = personaParams.FirstName;
                        oldPersona.Age = personaParams.Age;
                    }
                    
                    

                    if (oldPersona == null)
                        personaCreator.GenerateRequestPersona(personaParams);
                    else
                        personaCreator.UpdateRequestPersona(oldPersona);
                }

                return await _personaRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //public async Task<bool> Handle(AddPersonaCommand request, CancellationToken cancellationToken)
        //{
        //    try
        //    {
        //        if (request != null)
        //        {
        //            PersonaEjercicio persona = await _personaRepository.FindByIdAsync(request.PersonId);

        //            SqlConnection connection = new (_connectionString);

        //            connection.Open();

        //            if (persona == null)
        //            {


        //                string sqlQuery = "INSERT INTO PersonaEjercicio(Name, LastName, FirstName, Age) VALUES (@Name, @LastName, @FirstName, @Age)";

        //                await connection.ExecuteAsync(sqlQuery, new {
        //                    Name = request.Name,
        //                    LastName = request.LastName,
        //                    FirstName = request.FirstName,
        //                    Age = request.Age
        //                });
        //                return true;
        //            }
        //            else
        //            {
        //                string sqlQuery = "UPDATE PersonaEjercicio SET Name = @Name, LastName = @LastName, FirstName = @FirstName, Age = @Age WHERE PersonId = @PersonId";

        //                var resultPublications = await connection.QueryAsync<PersonaEjercicio>(sqlQuery, request);
        //                return true;
        //            }
        //        }
        //        return await _personaRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //}

    }
}
