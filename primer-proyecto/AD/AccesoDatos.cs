using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E;
using System.Data.SqlClient;
using System.Data;

namespace AD
{
    public class AccesoDatos
    {
        private string strconexion = Properties.Settings.Default.StrConexion;
        private SqlConnection objconexion;

        public AccesoDatos()
        {
            try
            {
                objconexion = new SqlConnection(strconexion);
                this.ABRIR();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }
        }

        private void ABRIR()
        {
            if (objconexion.State == System.Data.ConnectionState.Closed)
                objconexion.Open();
        }
        private void CERRAR()
        {
            if (objconexion.State == System.Data.ConnectionState.Open)
                objconexion.Close();
        }

        //METODOS DE EJECUCION CONTRA BASE DE DATOS
        public int Ejecutar(SQLSentencia psentencia)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = objconexion;
                cmd.CommandText = psentencia.SENTENCIASQL;

                if(psentencia.LSTPARAMETROS != null)
                    if (psentencia.LSTPARAMETROS.Count > 0)
                        cmd.Parameters.AddRange(psentencia.LSTPARAMETROS.ToArray());

                cmd.Connection.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }
        }

        public List<pa_VerificarLogin_Result> Consultar_VerificarUsuario(SQLSentencia psentencia)
        {
            List<pa_VerificarLogin_Result> lstresultados = new List<pa_VerificarLogin_Result>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = objconexion;
                cmd.CommandText = psentencia.SENTENCIASQL;

                if (psentencia.LSTPARAMETROS != null)
                    if (psentencia.LSTPARAMETROS.Count > 0)
                        cmd.Parameters.AddRange(psentencia.LSTPARAMETROS.ToArray());

                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);

                foreach (DataRow item in dt.Rows)
                {
                    pa_VerificarLogin_Result g = new pa_VerificarLogin_Result();
                    
                    g.nicknameUsuario = item.ItemArray[0].ToString();
                    
                    lstresultados.Add(g);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }

            return lstresultados;
        }

        public List<pa_ObtenerPerfilesUsuario_Result> Consultar_ObtenerPerfilesPorUsuario(SQLSentencia psentencia)
        {
            List<pa_ObtenerPerfilesUsuario_Result> lstresultados = new List<pa_ObtenerPerfilesUsuario_Result>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = objconexion;
                cmd.CommandText = psentencia.SENTENCIASQL;

                if (psentencia.LSTPARAMETROS != null)
                    if (psentencia.LSTPARAMETROS.Count > 0)
                        cmd.Parameters.AddRange(psentencia.LSTPARAMETROS.ToArray());

                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);

                foreach (DataRow item in dt.Rows)
                {
                    pa_ObtenerPerfilesUsuario_Result g = new pa_ObtenerPerfilesUsuario_Result();
                   
                    g.nicknameUsuario = item.ItemArray[0].ToString();
                    g.nomperfil = item.ItemArray[1].ToString();

                    lstresultados.Add(g);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }

            return lstresultados;
        }

        public List<pa_ObtenerNombreUsuario_Result> Consultar_ObtenerNombrePorUsuario(SQLSentencia psentencia)
        {
            List<pa_ObtenerNombreUsuario_Result> lstresultados = new List<pa_ObtenerNombreUsuario_Result>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = objconexion;
                cmd.CommandText = psentencia.SENTENCIASQL;

                if (psentencia.LSTPARAMETROS != null)
                    if (psentencia.LSTPARAMETROS.Count > 0)
                        cmd.Parameters.AddRange(psentencia.LSTPARAMETROS.ToArray());

                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);

                foreach (DataRow item in dt.Rows)
                {
                    pa_ObtenerNombreUsuario_Result g = new pa_ObtenerNombreUsuario_Result();

                    g.nomusuario = item.ItemArray[0].ToString();
                    lstresultados.Add(g);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }

            return lstresultados;
        }

        public List<pa_ObtenerExpediente_Result> Obtener_Expedientes(SQLSentencia psentencia)
        {
            List<pa_ObtenerExpediente_Result> lstresultados = new List<pa_ObtenerExpediente_Result>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = objconexion;
                cmd.CommandText = psentencia.SENTENCIASQL;

                if (psentencia.LSTPARAMETROS != null)
                    if (psentencia.LSTPARAMETROS.Count > 0)
                        cmd.Parameters.AddRange(psentencia.LSTPARAMETROS.ToArray());

                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);

                foreach (DataRow item in dt.Rows)
                {
                    pa_ObtenerExpediente_Result e = new pa_ObtenerExpediente_Result();
                    //SE ASIGNAN LOS CAMPOS EN LA TABLA - Mariliz
                    e.identificacion = item.ItemArray[0].ToString();
                    e.promedioprueba = item.ItemArray[1].ToString();
                    e.fechanacimiento = Convert.ToDateTime(item.ItemArray[2].ToString()); //SE REALIZA LA CONVERSION - Mariliz
                    e.nombre = item.ItemArray[3].ToString();
                    e.apellido = item.ItemArray[4].ToString();
                    e.correoelectronico = item.ItemArray[5].ToString();
                    e.genero = item.ItemArray[6].ToString();
                    e.estadocivil = item.ItemArray[7].ToString();
                    e.idioma = item.ItemArray[8].ToString();
                    e.certificacion = item.ItemArray[9].ToString();
                    e.titulo = item.ItemArray[10].ToString();
                    e.ubicacion = item.ItemArray[11].ToString();


                    lstresultados.Add(e);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }

            return lstresultados;
        }



    }
}

