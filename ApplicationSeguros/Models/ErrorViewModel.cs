using com.sun.org.apache.bcel.@internal.generic;
using System.Data.SqlClient;

namespace ApplicationSeguros.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public string login { get; set; }
        public string senha { get; set; }

        public bool Login()
        {
            bool ret = false;
            string strConexao = "";
            string Query = "";
            int resultado = -1;

            SqlConnection con = new SqlConnection(strConexao);
            SqlCommand comando = new SqlCommand(Query, con);

            con.Open();
            resultado = Convert.ToInt32(comando.ExecuteScalar().ToString());
            con.Close();

            if (resultado > 0) ret = true;

            return ret;
        }
    }
}