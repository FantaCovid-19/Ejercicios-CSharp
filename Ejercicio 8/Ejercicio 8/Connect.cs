using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ejercicio_8
{

    internal class Connect
    {
        private SqlCommand _cmd;
        private SqlConnection _conn;
        private SqlDataReader _read;

        public void Conn(String host, String database)
        {
            try
            {
                // Data Source=195.62.47.122;Initial Catalog=Ejercicios;User ID=SA;Password=FantaCovid-19
                _conn = new SqlConnection(@"Data Source = " + host + "; Initial Catalog = " + database + "; Integrated Security = True");
                _conn.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al conectar con la base de datos \n" + ex.Message);
            }
        }

        public DataTable fill_data(String table)
        {
            DataTable dt = new DataTable();
            _cmd = new SqlCommand();
            _cmd.Connection = this._conn;
            _cmd.CommandText = "SELECT * FROM " + table;
            _read = _cmd.ExecuteReader();
            dt.Load(_read);

            return dt;
        }

        public void insert(string table, int id, string run, string name, string last_name, float hours, string grade, int status)
        {
            _cmd = new SqlCommand();
            _cmd.Connection = this._conn;
            _cmd.CommandText = "INSERT INTO " + table + " (id, run, name, last_name , hours , grade , status) VALUES (" + id + ", '" + run + "', '"+ name + "', '" + last_name + "', " + hours + ", '" + grade + "', " + status + ")";
            _cmd.ExecuteNonQuery();
        }

        public void update(string table, string run, string name, string last_name, float hours, string grade, int status, int id)
        {
            _cmd = new SqlCommand();
            _cmd.Connection = this._conn;
            _cmd.CommandText = "UPDATE " + table + " SET run = '" + run + "', name = '" + name + "', last_name = '" + last_name + "', hours = " + hours + ", grade = '" + grade + "', status = " + status + " WHERE id = " + id;
            _cmd.ExecuteNonQuery();
        }

        public void delete(string table, int id) 
        {
            _cmd=new SqlCommand();
            _cmd.Connection=this._conn;
            _cmd.CommandText = "DELETE FROM " + table + " WHERE id = " + id;
            _cmd.ExecuteNonQuery();
        }
    }
}
