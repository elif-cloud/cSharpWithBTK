using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MySqlServer mysql = new MySqlServer();
            mysql.Add();
            Console.ReadLine();
        }

        class Database
        {
            public virtual void Add()
            {
                Console.WriteLine("Added by default");
            }

            public virtual void Delete()
            {
                Console.WriteLine("Deleted by default");
            }
        }

        class SqlServer:Database
        {
            public override void Add() //virtual: üstteki (Add) methodu geçersiz kılar
            {
                Console.WriteLine("Added by Sql Code"); //override: geçersiz kılmak
                //base.Add();
            }
        }

        class MySqlServer:Database
        {
            public override void Add()
            {
                Console.WriteLine("Added by Mysql Code");
            }
        }
    }
}
