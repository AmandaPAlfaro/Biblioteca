using System;
using System.Data;
using Npgsql;

namespace LibraryApp
{
    public class ConectionBD
    {
        
        private static NpgsqlCommand GetConnection()
        {
            return new NpgsqlCommand(@"Server = localhost;Port=5432; User id = postgres; Password = Control123$; Database = Ejemplo");
        }
    }   
}
