using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ejemploprocedimientolenguaje
{
    public class ManipulaBD
    {
        public SqlConnection cn;
        SqlCommand cm;
        string cadena, proc, param,sql;
        public DataSet dt;
        SqlDataAdapter da;
        public void ConectarBD2()
        {
                cadena = "Data Source=DESKTOP-G5DM5QN\\SQLEXPRESS;Initial Catalog=GestionInventario;Integrated Security=True";
                cn = new SqlConnection(cadena);
                cn.Open();
        }
        public void ManipularBD(string proc,string param)
        {
            ConectarBD2();
            sql="" + proc + " " + param + "";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
        }
        public void ConsultarBD(string proc,string param) 
        {
            ConectarBD2();
            sql = "" + proc + " " + param + "";
            dt=new DataSet();
            da = new SqlDataAdapter(sql, cn);
            da.Fill(dt, "objeto1");
        }
    }
}
