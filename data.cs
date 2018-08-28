using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace ATM
{
    class data
    {
        public static string con = "data source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Niro\\Desktop\\27\\atm-ban-asp\\ATM_db\\ATM.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
        
        SqlConnection con1 = new SqlConnection(con);
    }
}
