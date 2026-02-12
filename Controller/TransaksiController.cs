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
    public class TransaksiController
    {
        Koneksi koneksi = new Koneksi();

        // Add Transaction
        public bool AddTransaction(TransactionModel transaksi)
        {
            string sql = "INSERT INTO transaksi (id_user, id_player, server_id, item, harga, tanggal, status, game) " +
                         "VALUES (@id_user, @id_player, @server_id, @item, @harga, @tanggal, @status, @game)";

            return koneksi.ExecuteQueryParam(
                sql,
                new MySqlParameter("@id_user", transaksi.IdUser),
                new MySqlParameter("@id_player", transaksi.IdPlayer),
                new MySqlParameter("@server_id", transaksi.ServerId),
                new MySqlParameter("@item", transaksi.Item),
                new MySqlParameter("@harga", transaksi.Harga),
                new MySqlParameter("@tanggal", transaksi.Tanggal),
                new MySqlParameter("@status", transaksi.Status),
                new MySqlParameter("@game", transaksi.Game)
            );
        }

        // Get All Transactions (For Admin)
        public DataTable GetAllTransactions()
        {
            string sql = "SELECT t.id_transaksi, u.username, t.game, t.item, t.harga, t.tanggal, t.status, t.id_player, t.server_id " +
                         "FROM transaksi t " +
                         "JOIN users u ON t.id_user = u.id_user " +
                         "ORDER BY t.tanggal DESC";
            return koneksi.ShowData(sql);
        }

        // Get Transactions by User
        public DataTable GetTransactionsByUser(int idUser)
        {
            string sql = "SELECT t.id_transaksi, t.game, t.item, t.harga, t.tanggal, t.status, t.id_player, t.server_id " +
                         "FROM transaksi t " +
                         "WHERE t.id_user = @id_user " +
                         "ORDER BY t.tanggal DESC";
            return koneksi.ShowDataParam(sql, new MySqlParameter("@id_user", idUser));
        }
    }
}
