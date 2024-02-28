using Dapper;
using Microsoft.Data.Sqlite;
using Newtonsoft.Json;
using Questao5.Domain.Entities;
using Questao5.Domain.Repositories;
using Questao5.Infrastructure.Sqlite;

namespace Questao5.Infrastructure.Repositories
{
    public class IdempotenciaRepository : IIdempotenciaRepository
    {
        private readonly DatabaseConfig dbConfig;
        SqliteConnection connection;

        public IdempotenciaRepository(DatabaseConfig dbConfig)
        {
            this.dbConfig = dbConfig;
            connection = new SqliteConnection(dbConfig.Name);
            connection.Open();
        }
        public async Task CreateIdempotencia(object request, string resultado)
        {
            try
            {
                var requisicao = JsonConvert.SerializeObject(request);
                Idempotencia idempotencia = new Idempotencia(requisicao, resultado);

                var insertSqlIdempotencia =
                    @"INSERT INTO Idempotencia (chave_idempotencia, requisicao, resultado) 
                     VALUES (@ChaveIdempotencia, @Requisicao, @Resultado);";

                await connection.ExecuteAsync(insertSqlIdempotencia, idempotencia);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                connection.Close();

            }
        }
    }
}
