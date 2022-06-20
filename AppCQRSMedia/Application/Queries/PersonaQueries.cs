using AppCQRS.Domain;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace AppCQRSMedia.CQRS.Application.Queries
{
    public class PersonaQueries : IPersonaQueries
    {
        private readonly string _connectionString = string.Empty;

        public PersonaQueries(string connectionString)
        {
            _connectionString = connectionString;
        }
        public async Task<IEnumerable<PersonaEjercicio>> GetPersonas()
        {
            SqlConnection connection = new(_connectionString);

            connection.Open();

            var resultPublications = await connection.QueryAsync<PersonaEjercicio>("SELECT * FROM PersonaEjercicio",
                commandType: CommandType.Text);

            return resultPublications;
        }

        public async Task<IEnumerable<PersonaEjercicio>> GetPersonasById(int PersonId)
        {
            SqlConnection connection = new(_connectionString);

            connection.Open();

            var resultPublications = await connection.QueryAsync<PersonaEjercicio>("SELECT * FROM PersonaEjercicio WHERE PersonId = @PersonId",
                new { PersonId },
                commandType: CommandType.Text);

            return resultPublications;
        }
    }
}
