using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DATABASE_PROJECT
{
    class ClassSqlConnection  //;Trust Server Certificate=True
    {
        public SqlConnection connection()
        {
            SqlConnection connect = new SqlConnection("Data Source=DESKTOP-JIRTUUF\\SQLEXPRESS;Initial Catalog=DATABASEPROJE1;Integrated Security=True");
            connect.Open();
            return connect;
        }

    }
}
