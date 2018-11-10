using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AD;
using E;
using System.Collections;

namespace LN
{
    public class Logica
    {
        //public static int Agregar_Expediente(Expediente pexpediente)
        //{
        //    try
        //    {
        //        SQLSentencia sentencia = new SQLSentencia();
        //        ArrayList lstparametros = new ArrayList();

        //        sentencia.SENTENCIASQL = "EXEC pa_AgregarExpediente @ID, @NOM, @APE, @EDAD, @GENERO, @ESTADOCIVIL";

        //        SqlParameter paramID = new SqlParameter();
        //        paramID.Value = pexpediente.identificacion;
        //        paramID.SqlDbType = System.Data.SqlDbType.VarChar;
        //        paramID.ParameterName = "@ID";

        //        SqlParameter paramNOM = new SqlParameter();
        //        paramNOM.Value = pexpediente.nombre;
        //        paramNOM.SqlDbType = System.Data.SqlDbType.VarChar;
        //        paramNOM.ParameterName = "@NOM";

        //        SqlParameter paramAPE = new SqlParameter();
        //        paramAPE.Value = pexpediente.apellidos;
        //        paramAPE.SqlDbType = System.Data.SqlDbType.VarChar;
        //        paramAPE.ParameterName = "@APE";

        //        SqlParameter paramEDAD= new SqlParameter();
        //        paramEDAD.Value = pexpediente.edad;
        //        paramEDAD.SqlDbType = System.Data.SqlDbType.Int;
        //        paramEDAD.ParameterName = "@EDAD";

        //        SqlParameter paramGEN = new SqlParameter();
        //        paramGEN.Value = pexpediente.codgenero;
        //        paramGEN.SqlDbType = System.Data.SqlDbType.Int;
        //        paramGEN.ParameterName = "@GENERO";

        //        SqlParameter paramESTCIV = new SqlParameter();
        //        paramESTCIV.Value = pexpediente.codestadocivil;
        //        paramESTCIV.SqlDbType = System.Data.SqlDbType.Int;
        //        paramESTCIV.ParameterName = "@ESTADOCIVIL";

        //        //Lista de parametros
        //        lstparametros.Add(paramID);
        //        lstparametros.Add(paramNOM);
        //        lstparametros.Add(paramAPE);
        //        lstparametros.Add(paramEDAD);
        //        lstparametros.Add(paramGEN);
        //        lstparametros.Add(paramESTCIV);

        //        sentencia.LSTPARAMETROS = lstparametros;

        //        AccesoDatos objacceso = new AccesoDatos();
        //        return objacceso.Ejecutar(sentencia);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public static List<pa_ConsultarExpedientes_Result> Obtener_Expedientes()
        //{
        //    try
        //    {
        //        SQLSentencia sentencia = new SQLSentencia();

        //        sentencia.SENTENCIASQL = "EXEC pa_ConsultarExpedientes";

        //        AccesoDatos objacceso = new AccesoDatos();
        //        return objacceso.Consultar_Expedientes(sentencia);

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public static List<EstadosCiviles> Obtener_EstadosCiviles()
        //{
        //    try
        //    {
        //        SQLSentencia sentencia = new SQLSentencia();

        //        sentencia.SENTENCIASQL = "SELECT codEstadocivil, nomestadocivil FROM EstadosCiviles";

        //        AccesoDatos objacceso = new AccesoDatos();
        //        return objacceso.Consultar_EstadosCiviles(sentencia);

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public static List<Generos> Obtener_Generos()
        //{
        //    try
        //    {
        //        SQLSentencia sentencia = new SQLSentencia();

        //        sentencia.SENTENCIASQL = "SELECT codgenero, nomgenero FROM Generos";

        //        AccesoDatos objacceso = new AccesoDatos();
        //        return objacceso.Consultar_Generos(sentencia);

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public static List<pa_ObtenerPerfilesUsuario_Result> ObtenerPerfilesPorUsuario(Usuarios usuarios)
        {
            SQLSentencia sentencia = new SQLSentencia();
            ArrayList lstparametros = new ArrayList();
            try
            {
                sentencia.SENTENCIASQL = @"EXEC pa_ObtenerPerfilesUsuario @nicknameUsuario";

                SqlParameter paramNomusuario = new SqlParameter();
                paramNomusuario.ParameterName = "@nicknameUsuario";
                paramNomusuario.SqlDbType = System.Data.SqlDbType.VarChar;
                paramNomusuario.Value = usuarios.nicknameUsuario;

                lstparametros.Add(paramNomusuario);
                sentencia.LSTPARAMETROS = lstparametros;

                AccesoDatos objacceso = new AccesoDatos();
                return objacceso.Consultar_ObtenerPerfilesPorUsuario(sentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<pa_VerificarLogin_Result> VerificarUsuario(Usuarios usuarios)
        {
            SQLSentencia sentencia = new SQLSentencia();
            ArrayList lstparametros = new ArrayList();
            try
            {
                sentencia.SENTENCIASQL = @"EXEC pa_VerificarLogin @nicknameUsuario, @pass";

                SqlParameter paramNomusuario = new SqlParameter();
                paramNomusuario.ParameterName = "@nicknameUsuario";
                paramNomusuario.SqlDbType = System.Data.SqlDbType.VarChar;
                paramNomusuario.Value = usuarios.nomusuario;

                SqlParameter paramPass = new SqlParameter();
                paramPass.ParameterName = "@pass";
                paramPass.SqlDbType = System.Data.SqlDbType.VarChar;
                paramPass.Value = usuarios.pass;

                lstparametros.Add(paramNomusuario);
                lstparametros.Add(paramPass);

                sentencia.LSTPARAMETROS = lstparametros;

                AccesoDatos objacceso = new AccesoDatos();
                return objacceso.Consultar_VerificarUsuario(sentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<pa_ObtenerNombreUsuario_Result> ObtenerNombrePorUsuario(Usuarios usuarios)
        {
            SQLSentencia sentencia = new SQLSentencia();
            ArrayList lstparametros = new ArrayList();
            try
            {
                sentencia.SENTENCIASQL = @"EXEC pa_ObtenerNombreUsuario @nicknameUsuario";

                SqlParameter paramNomusuario = new SqlParameter();
                paramNomusuario.ParameterName = "@nicknameUsuario";
                paramNomusuario.SqlDbType = System.Data.SqlDbType.VarChar;
                paramNomusuario.Value = usuarios.nicknameUsuario;

                lstparametros.Add(paramNomusuario);
                sentencia.LSTPARAMETROS = lstparametros;

                AccesoDatos objacceso = new AccesoDatos();
                return objacceso.Consultar_ObtenerNombrePorUsuario(sentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       
    }
}
