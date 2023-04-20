using System;
using System.Data.OleDb;
using System.Data;

namespace AutoDealer
{
    class BindDB
    {
        string connection = "Provider=Microsoft.Ace.OLEDB.12.0; Data Source=" +
            AppDomain.CurrentDomain.BaseDirectory + "\\candy.accdb";
        OleDbConnection connect;
        DataTable dataTable;

        public DataView BindGrid(string selectSQL)
        {
            connect = new OleDbConnection(connection);
            if (connect.State == ConnectionState.Open)
                connect.Open();

            OleDbCommand command = new OleDbCommand(selectSQL, connect);

            OleDbDataAdapter da = new OleDbDataAdapter(command);

            dataTable = new DataTable();
            da.Fill(dataTable);

            connect.Close();

            return dataTable.AsDataView();
        }

        public OleDbDataReader ReaderDB(string selectSQL)
        {
            connect = new OleDbConnection(connection);
            connect.Open();

            OleDbCommand command = new OleDbCommand(selectSQL, connect);

            OleDbDataReader reader = command.ExecuteReader();
            return reader;
        }

        public void RemoveRow(string deleteSQL)
        {
            connect = new OleDbConnection(connection);
            if (connect.State != ConnectionState.Open)
                connect.Open();

            OleDbCommand command = new OleDbCommand();
            command.Connection = connect;
            command.CommandText = deleteSQL;
            command.ExecuteNonQuery();
            connect.Close();
        }
    }
}
