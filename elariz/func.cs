using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace myContact
{
    internal class func
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private string ConStr;

        public func()
        {
            ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elariz\Documents\ContactTbl.mdf;Integrated Security=True;Connect Timeout=30";
            Con = new SqlConnection(ConStr);
            Cmd = new SqlCommand();
            Cmd.Connection = Con;

            dt = new DataTable();
            sda = new SqlDataAdapter();
        }

        public DataTable GetData(string Query)
        {
            dt.Clear();
            using (SqlCommand command = new SqlCommand(Query, Con))
            {
                using (sda = new SqlDataAdapter(command))
                {
                    sda.Fill(dt);
                }
            }
            return dt;
        }

        public int SetData(string Query, List<SqlParameter> parameters)
        {
            int cnt = 0;
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }

            using (SqlCommand command = new SqlCommand(Query, Con))
            {
                command.Parameters.Clear();

        
                foreach (var parameter in parameters)
                {
                    command.Parameters.Add(parameter);
                }

                cnt = command.ExecuteNonQuery();
            }

            return cnt;
        }
    }
}
