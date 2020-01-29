using System;
using System.Data.SqlClient;

namespace DatabaseConnection
{
    public abstract class DbConnection
    {
        private SqlConnection con;
        private TimeSpan timeOut;

        protected DbConnection()
        {
            con = new SqlConnection("Sql connection");
            if (String.IsNullOrEmpty(con.ToString()))
                throw new ArgumentNullException();

            timeOut = new TimeSpan();
        }

        public abstract void Open();

        public abstract void Close();

        public void TimeOut()
        {
            if(timeOut == TimeSpan.MaxValue)
                Console.WriteLine("The Connection will be closed");
            
        }
    }
}