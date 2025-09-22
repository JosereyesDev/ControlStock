using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace ControlStock
{
    public class Producto
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Notes { get; set; } = string.Empty;
        public string FechaCreacion { get; set; } = string.Empty;
        public string FechaPedido { get; set; } = string.Empty;
    }

    public class DatabaseHelper
    {
        private string connectionString;

        public DatabaseHelper(string dbPath)
        {
            connectionString = $"Data Source={dbPath}";
            Inicializar();
        }

        private void Inicializar()
        {
            using var conn = new SQLiteConnection(connectionString);
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                CREATE TABLE IF NOT EXISTS Fallas(
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Price REAL NOT NULL,
                    Notes TEXT,
                    FechaCreacion TEXT NOT NULL
                );
                CREATE TABLE IF NOT EXISTS Pedidos(
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Price REAL NOT NULL,
                    Notes TEXT,
                    FechaCreacion TEXT NOT NULL,
                    FechaPedido TEXT NOT NULL
                );";
            cmd.ExecuteNonQuery();
        }

        public void AgregarFalla(string name, decimal price, string notes)
        {
            using var conn = new SQLiteConnection(connectionString);
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO Fallas(Name,Price,Notes,FechaCreacion) VALUES($n,$p,$no,$f)";
            cmd.Parameters.AddWithValue("$n", name);
            cmd.Parameters.AddWithValue("$p", price);
            cmd.Parameters.AddWithValue("$no", notes);
            cmd.Parameters.AddWithValue("$f", DateTime.Now.ToShortDateString());
            cmd.ExecuteNonQuery();
        }

        public List<Producto> ObtenerFallas()
        {
            var lista = new List<Producto>();
            using var conn = new SQLiteConnection(connectionString);
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Id,Name,Price,Notes,FechaCreacion FROM Fallas Order by Id DESC";
            using var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                lista.Add(new Producto
                {
                    Id = rd.GetInt64(0),
                    Name = rd.GetString(1),
                    Price = rd.GetDecimal(2),
                    Notes = rd.IsDBNull(3) ? "" : rd.GetString(3),
                    FechaCreacion = rd.GetString(4)
                });
            }
            return lista;
        }

        public List<Producto> ObtenerPedidos()
        {
            var lista = new List<Producto>();
            using var conn = new SQLiteConnection(connectionString);
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Id,Name,Price,Notes,FechaCreacion,FechaPedido FROM Pedidos Order by Id DESC";
            using var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                lista.Add(new Producto
                {
                    Id = rd.GetInt64(0),
                    Name = rd.GetString(1),
                    Price = rd.GetDecimal(2),
                    Notes = rd.IsDBNull(3) ? "" : rd.GetString(3),
                    FechaCreacion = rd.GetString(4),
                    FechaPedido = rd.GetString(5)
                });
            }
            return lista;
        }

        public void PedirFalla(long id)
        {
            using var conn = new SQLiteConnection(connectionString);
            conn.Open();

            var tx = conn.BeginTransaction();

            var select = conn.CreateCommand();
            select.Transaction = tx;
            select.CommandText = "SELECT Name,Price,Notes,FechaCreacion FROM Fallas WHERE Id=$id";
            select.Parameters.AddWithValue("$id", id);
            using var rd = select.ExecuteReader();
            if (!rd.Read()) return;
            var name = rd.GetString(0);
            var price = rd.GetDecimal(1);
            var notes = rd.IsDBNull(2) ? "" : rd.GetString(2);
            var fechaCreacion = rd.GetString(3);
            rd.Close();

            var insert = conn.CreateCommand();
            insert.Transaction = tx;
            insert.CommandText = "INSERT INTO Pedidos(Name,Price,Notes,FechaCreacion,FechaPedido) VALUES($n,$p,$no,$fc,$fp)";
            insert.Parameters.AddWithValue("$n", name);
            insert.Parameters.AddWithValue("$p", price);
            insert.Parameters.AddWithValue("$no", notes);
            insert.Parameters.AddWithValue("$fc", fechaCreacion);
            insert.Parameters.AddWithValue("$fp", DateTime.Now.ToShortDateString());
            insert.ExecuteNonQuery();

            var delete = conn.CreateCommand();
            delete.Transaction = tx;
            delete.CommandText = "DELETE FROM Fallas WHERE Id=$id";
            delete.Parameters.AddWithValue("$id", id);
            delete.ExecuteNonQuery();

            tx.Commit();
        }
    }
}
