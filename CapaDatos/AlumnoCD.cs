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
    public class AlumnoCD
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        public bool InsertarAlumno(AlumnoCE Alumno)
        {
            con.Open();
            string sql = "insert into alumno values (@aluNom,@aluApe,@AluDni,@AluEdad)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@aluNom", System.Data.SqlDbType.VarChar).Value = Alumno.ALuNom;
            cmd.Parameters.Add("@aluApe", System.Data.SqlDbType.VarChar).Value = Alumno.AluApe;
            cmd.Parameters.Add("@AluDni", System.Data.SqlDbType.VarChar).Value = Alumno.AluDni;
            cmd.Parameters.Add("@AluEdad", System.Data.SqlDbType.Int).Value = Alumno.AluEdad;
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return (res == 1);
        }

        public AlumnoCE ObtenerCAlumnoId(int id)
        {
            AlumnoCE Alum = null;
            //SqlConnection con = new SqlConnection(cadenaConexion);
            con.Open();
            string sql = "select * from alumno where aluId=@aluId";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@aluId", System.Data.SqlDbType.NVarChar).Value = id;
            SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            if (reader.Read())
            {
                Alum = new AlumnoCE();
                Alum.AluId = id;
                Alum.ALuNom = reader.GetString(1);
                Alum.AluApe = reader.GetString(2);
                Alum.AluDni = reader.GetString(3);
                Alum.AluEdad = reader.GetInt32(4);
            }
            reader.Close();
            return Alum;
        }


        public List<AlumnoCE> ObtenerAlumno()
        {
            List<AlumnoCE> lista = new List<AlumnoCE>();
            try
            {
                con.Open();
                string sql = "select * from alumno";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    AlumnoCE Alum = new AlumnoCE();
                    Alum = new AlumnoCE();
                    Alum.AluId = reader.GetInt32(0);
                    Alum.ALuNom = reader.GetString(1);
                    Alum.AluApe = reader.GetString(2);
                    Alum.AluDni = reader.GetString(3);
                    Alum.AluEdad = reader.GetInt32(4);
                    lista.Add(Alum);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                lista = null;
            }
            return lista;
        }

        public bool EliminarAlumno(int id)
        {
            con.Open();
            string sql = "delete from alumno where aluId=@aluId";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@aluId", System.Data.SqlDbType.Int).Value = id;
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return (res == 1);
        }

        public bool ActualizarAlumno(AlumnoCE cli)
        {
            con.Open();
            string sql = "update alumno set AluNom=@AluNom, AluApe=@AluApe, AluDni=@AluDni,AluEdad=@AluEdad  where Aluid=@Aluid";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@AluNom", System.Data.SqlDbType.VarChar).Value = cli.ALuNom;
            cmd.Parameters.Add("@AluApe", System.Data.SqlDbType.VarChar).Value = cli.AluApe;
            cmd.Parameters.Add("@AluDni", System.Data.SqlDbType.VarChar).Value = cli.AluDni;
            cmd.Parameters.Add("@AluEdad", System.Data.SqlDbType.VarChar).Value = cli.AluEdad;
            cmd.Parameters.Add("@Aluid", System.Data.SqlDbType.Int).Value = cli.AluId;
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return (res == 1);
        }
    }
}
