using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace wearther_desktop
{
    class DB
    {
        public static SqlConnection GetSQL()
        {
            return new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ivana\Documents\weartherdb.mdf;Integrated Security=True;Connect Timeout=30");
        }

    }
}
