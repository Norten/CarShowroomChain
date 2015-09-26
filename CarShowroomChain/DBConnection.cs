using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;

namespace CarShowroomChain {
    public class DBConnection {
        private MySqlConnection connection;
        private MySqlTransaction transaction;

        public DBConnection() {
            String connectionString;
            using (var reader = new StreamReader("dbParams//dbConnectionParams.txt"))
                connectionString = reader.ReadLine();
            this.connection = new MySqlConnection(connectionString);
        }

        public void OpenConnection() {
            this.connection.Close();
            this.connection.Open();
            this.transaction = this.connection.BeginTransaction();
        }

        public void CloseConnection() {
            this.transaction.Commit();
            this.connection.Close();
        }

        public void TransactionError() {
            this.transaction.Rollback();
            this.connection.Close();
        }

        public void ExecuteNonQuery(string sql) {
            var cmd = new MySqlCommand(sql, this.connection);
            cmd.ExecuteNonQuery();
        }

        public MySqlDataReader ExecuteQuery(string sql) {
            var cmd = new MySqlCommand(sql, this.connection);
            cmd.CommandTimeout = 300;
            return cmd.ExecuteReader();
        }

        public object ExecuteScalar(string sql) {
            var cmd = new MySqlCommand(sql, this.connection);
            cmd.CommandTimeout = 300;
            return cmd.ExecuteScalar();
        }

        public void FillGrid(string sql, ref DataGridView gridView) {
            var cmd = new MySqlCommand(sql, this.connection);
            cmd.CommandTimeout = 300;
            var adapter = new MySqlDataAdapter(cmd);
            var dataTable = new DataTable();
            adapter.Fill(dataTable);
            var bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            gridView.DataSource = bindingSource;
            adapter.Update(dataTable);
        }
    }
}
