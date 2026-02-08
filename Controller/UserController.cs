using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Proyek_besar_pbo_baihaqi_zidan.Model;

namespace Proyek_besar_pbo_baihaqi_zidan.Controller
{
    public class UserController
    {
        Koneksi koneksi = new Koneksi();

        // Ambil semua user
        public DataTable GetAll()
        {
            string sql = "SELECT id_user, username, password, role FROM users";
            return koneksi.ShowData(sql);
        }

        // Insert user
        public void Insert(UserModel user)
        {
            string sql = "INSERT INTO users (username, password, role) VALUES (@u, @p, @r)";
            koneksi.ExecuteQueryParam(
                sql,
                new MySqlParameter("@u", user.Username),
                new MySqlParameter("@p", user.Password),
                new MySqlParameter("@r", user.Role)
            );
        }

        // Update user
        public void Update(UserModel user)
        {
            string sql = "UPDATE users SET username=@u, password=@p, role=@r WHERE id_user=@id";
            koneksi.ExecuteQueryParam(
                sql,
                new MySqlParameter("@u", user.Username),
                new MySqlParameter("@p", user.Password),
                new MySqlParameter("@r", user.Role),
                new MySqlParameter("@id", user.IdUser)
            );
        }

        // Delete user
        public void Delete(int id)
        {
            string sql = "DELETE FROM users WHERE id_user=@id";
            koneksi.ExecuteQueryParam(
                sql,
                new MySqlParameter("@id", id)
            );
        }

        public DataTable Search(string keyword)
        {
            string sql = "SELECT id_user, username, password, role FROM users " +
                         "WHERE username LIKE @param OR role LIKE @param";

            return koneksi.ShowDataParam(
                sql,
                new MySqlParameter("@param", "%" + keyword + "%")
            );
        }

    }
}
