using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_232410101097_utspbo.core;
using A_232410101097_utspbo.MODEL;
using A_232410101097_utspbo.VIEW;

namespace A_232410101097_utspbo.context
{ 
  internal class TASK : databasewrapper
    {

    private static string table = "task";

        public static DataTable All()
        {
            string query = @"
        SELECT 
            t.id_tugas,
            t.tanggal_tugas,
            t.deadline,
            t.namatugas,
            t.person_id
        FROM 
            task t
        JOIN 
            person p ON t.person_id = p.person_id";

            DataTable dataMahasiswa = queryExecutor(query);
            return dataMahasiswa;
        }

        public static DataTable gettaskById(int id)
        {
            string query = @"
                SELECT 
                    t.id_tugas,
                    t.tanggal_tugas,
                    t.deadline,
                    t.namatugas,
                    t.person_id
                FROM 
                    task t
                JOIN 
                    person p ON t.person_id = p.person_id"";
                WHERE 
                    m.id = @id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer) { Value = id }
            };

            DataTable dataMahasiswa = queryExecutor(query, parameters);
            return dataMahasiswa;
        }


        public static void AddTask(Task taskbaru)
        {
            string query = $"INSERT INTO {table} (Tanggal_tugas, deadline, namatugas, person_id) VALUES(@Tanggal_tugas, @deadline, @namatugas, @person_id)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@tanggal_tugas", taskbaru.tanggal_tugas),
                new NpgsqlParameter("@deadline", taskbaru.deadline),
                new NpgsqlParameter("@namatugas", taskbaru.namatugas),
                new NpgsqlParameter("@person_id", taskbaru.person_id)
            };

            commandExecutor(query, parameters);
        }

        public static void UpdateTask(Task taskbaru)
        {
            string query = $"INSERT INTO {table} (Tanggal_tugas, deadline, namatugas, person_id) VALUES(@Tanggal_tugas, @deadline, @namatugas, @person_id)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@tanggal_tugas", taskbaru.tanggal_tugas),
                new NpgsqlParameter("@deadline", taskbaru.deadline),
                new NpgsqlParameter("@namatugas", taskbaru.namatugas),
                new NpgsqlParameter("@person_id", taskbaru.person_id)
            };

            commandExecutor(query, parameters);
        }

        public static void DeleteTask(int id)
        {
            string query = $"DELETE FROM {table} WHERE id = @id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", id)
            };

            commandExecutor(query, parameters);
        }
  }
}

