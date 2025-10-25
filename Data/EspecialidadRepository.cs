using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class EspecialidadRepository
    {
        private readonly string _connectionString;

        public EspecialidadRepository()
        {
            _connectionString = new AcademiaContext().Database.GetConnectionString();
        }

        public IEnumerable<Especialidad> GetAll()
        {
            const string sql = "SELECT Id, DescEspecialidad FROM Especialidades";
            var list = new List<Especialidad>();

            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(sql, connection);

            connection.Open();
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Especialidad(
                    reader.GetInt32(0),
                    reader.GetString(1)
                ));
            }

            return list;
        }

        public Especialidad? Get(int id)
        {
            const string sql = "SELECT Id, DescEspecialidad FROM Especialidades WHERE Id = @Id";

            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Id", id);

            connection.Open();
            using var reader = command.ExecuteReader();

            if (reader.Read())
            {
                return new Especialidad(
                    reader.GetInt32(0),
                    reader.GetString(1)
                );
            }

            return null;
        }

        public void Add(Especialidad especialidad)
        {
            const string sql = @"
            INSERT INTO Especialidades (DescEspecialidad) 
            VALUES (@DescEspecialidad);
            SELECT SCOPE_IDENTITY();";

            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@DescEspecialidad", especialidad.DescEspecialidad);

            connection.Open();
            var insertedId = Convert.ToInt32(command.ExecuteScalar());

            especialidad.Id = insertedId; // Asignamos el ID generado
        }

        public bool Update(Especialidad especialidad)
        {
            const string sql = @"
            UPDATE Especialidades 
            SET DescEspecialidad = @DescEspecialidad 
            WHERE Id = @Id";

            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@DescEspecialidad", especialidad.DescEspecialidad);
            command.Parameters.AddWithValue("@Id", especialidad.Id);

            connection.Open();
            command.ExecuteNonQuery();

            return true;
        }

        public bool Delete(int id)
        {
            const string sql = "DELETE FROM Especialidades WHERE Id = @Id";

            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@Id", id);

            connection.Open();
            command.ExecuteNonQuery();

            return true;
        }
    }

}
