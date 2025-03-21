using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace FundamentosCsharp.Models
{
    internal class CervezaBD
    {
        private string ConnectionString = "Host=localhost;Port=5432;Username=postgres;Password=popololo1;Database=cerveza;";

        public List<Cerveza> Get()
        {
            List<Cerveza> cervezas = new List<Cerveza>();

            string query = "SELECT nombre, marca, alcohol, cantidad FROM bebidas";


            using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionString))
            {
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                connection.Open();
                NpgsqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    int cantidad = reader.GetInt32(3);
                    string nombre = reader.GetString(0);
                    Cerveza cerveza = new Cerveza(cantidad, nombre);
                    cerveza.Alcohol = reader.GetInt32(2);
                    cerveza.Marca = reader.GetString(1);
                    cervezas.Add(cerveza);
                }
                reader.Close();
                connection.Close();

            }

            return cervezas;

        }
    }

}
