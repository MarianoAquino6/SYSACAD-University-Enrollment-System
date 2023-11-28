using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.BaseDeDatos
{
    public class ConexionBD
    {
        protected static SqlConnection connection;
        protected static SqlCommand command;
        protected static SqlDataReader reader;  

        static ConexionBD()
        {
            connection = new SqlConnection(@"Server = .; Database = TestSYSACAD; Trusted_Connection = True; Encrypt=False; TrustServerCertificate=True;");

            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
        }
    }
}
