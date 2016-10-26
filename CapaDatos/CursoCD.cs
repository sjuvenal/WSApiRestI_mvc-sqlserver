using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaEntidad;
using System.Configuration;

namespace CapaDatos
{
    public class CursoCD
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        public bool InsertarCurso(CursoCE Cur)
        {
            con.Open();
            string sql = "insert into Curso values (@CurNom,@CurCre)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@CurNom", System.Data.SqlDbType.VarChar).Value = Cur.curNom;
            cmd.Parameters.Add("@CurCre", System.Data.SqlDbType.Int).Value = Cur.curCred;
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return (res == 1);
        }

        public CursoCE ObtenerCursoId(int id)
        {
            CursoCE Cur = null;
            //SqlConnection con = new SqlConnection(cadenaConexion);
            con.Open();
            string sql = "select * from curso where CurId=@CurId";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@CurId", System.Data.SqlDbType.NVarChar).Value = id;
            SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            if (reader.Read())
            {
                Cur = new CursoCE();
                Cur.curId = id;
                Cur.curNom = reader.GetString(1);
                Cur.curCred = reader.GetInt32(2);

            }
            reader.Close();
            return Cur;
        }


        public List<CursoCE> ObtenerCurso()
        {
            List<CursoCE> lista = new List<CursoCE>();
            try
            {
                con.Open();
                string sql = "select * from curso";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    CursoCE Cur = new CursoCE();
                    Cur = new CursoCE();
                    Cur.curId = reader.GetInt32(0);
                    Cur.curNom = reader.GetString(1);
                    Cur.curCred = reader.GetInt32(2);
                    lista.Add(Cur);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                lista = null;
            }
            return lista;
        }

        public bool EliminarCurso(int id)
        {
            con.Open();
            string sql = "delete from CURSO where CurId=@curId";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@curId", System.Data.SqlDbType.Int).Value = id;
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return (res == 1);
        }

        public bool ActualizarCurso(CursoCE Cur)
        {
            con.Open();
            string sql = "update curso set CurNombre=@CurNombre, CurCred=@CurCred  where curId=@curId";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@CurNombre", System.Data.SqlDbType.VarChar).Value = Cur.curNom;
            cmd.Parameters.Add("@CurCred", System.Data.SqlDbType.VarChar).Value = Cur.curCred;
            cmd.Parameters.Add("@curId", System.Data.SqlDbType.Int).Value = Cur.curId;
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return (res == 1);
        }
    }
}
