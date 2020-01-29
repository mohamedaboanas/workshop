using System;

namespace DatabaseConnection
{
    public class SqlConn : DbConnection
    {
        public override void Open()
        {
            Console.WriteLine("Open Connection");
        }

        public override void Close()
        {
            Console.WriteLine("Close Connection");
        }
    }
}