using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyek_besar_pbo_baihaqi_zidan.Controller
{
    public class Koneksi
    {
        private MySqlConnection koneksi;

        public Koneksi()
        {
            string connectionString =
                "server=localhost;" +
                "database=topup_game_db;" +
                "uid=root;" +
                "pwd=;";

            koneksi = new MySqlConnection(connectionString);
        }

        public DataTable ShowDataParam(string query, params MySqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            koneksi.Open();
            MySqlCommand cmd = new MySqlCommand(query, koneksi);

            foreach (MySqlParameter p in parameters)
            {
                cmd.Parameters.Add(p);
            }

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            koneksi.Close();
            return dt;
        }


        public DataTable ShowData(string query)
        {
            MySqlDataAdapter adapter =
                new MySqlDataAdapter(query, koneksi);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public bool ExecuteQuery(string query)
        {
            try
            {
                koneksi.Open();
                MySqlCommand cmd = new MySqlCommand(query, koneksi);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                koneksi.Close();
            }
        }


        public bool ExecuteQueryParam(string query, params MySqlParameter[] parameters)
        {
            try
            {
                koneksi.Open();
                MySqlCommand cmd = new MySqlCommand(query, koneksi);

                foreach (MySqlParameter param in parameters)
                {
                    cmd.Parameters.Add(param);
                }

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                koneksi.Close();
            }
        }


    }
}