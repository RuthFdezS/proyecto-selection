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
     
        #region METODOS DEL MODULO SEGURIDAD
        public static int Modificar_PermisosPerfil(UsuariosPorPerfiles user_p)
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                ArrayList lstparametros = new ArrayList();

                sentencia.SENTENCIASQL = "EXEC pa_ModificarPermisosPerfil @NICKNAMEUSUARIO, @CODPERFIL";

                SqlParameter paramNICKNAME = new SqlParameter();
                paramNICKNAME.Value = user_p.nicknameUsuario;
                paramNICKNAME.SqlDbType = System.Data.SqlDbType.VarChar;
                paramNICKNAME.ParameterName = "@NICKNAMEUSUARIO";

                SqlParameter paramCODPERFIL = new SqlParameter();
                paramCODPERFIL.Value = user_p.codPerfil;
                paramCODPERFIL.SqlDbType = System.Data.SqlDbType.Int;
                paramCODPERFIL.ParameterName = "@CODPERFIL";

                //Lista de parametros
                lstparametros.Add(paramNICKNAME);
                lstparametros.Add(paramCODPERFIL);

                sentencia.LSTPARAMETROS = lstparametros;

                AccesoDatos objacceso = new AccesoDatos();
                return objacceso.Ejecutar(sentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
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

        #endregion


        #region METODOS DEL MODULO MATENIMIENTO

        public static int Agregar_Expediente(Expediente persona)
        {
            try
            {   //Se arma la sentencia por ejecutar en el objeto que se crea
                SQLSentencia sentencia = new SQLSentencia();

                sentencia.SENTENCIASQL = @"INSERT INTO Expediente VALUES ";
                sentencia.SENTENCIASQL += @"('" + persona.identificacion + "',";
                sentencia.SENTENCIASQL += @"'" + persona.promedioprueba + "',";
                sentencia.SENTENCIASQL += @"'" + persona.fechanacimiento + "',";
                sentencia.SENTENCIASQL += @"'" + persona.nombre + "',";
                sentencia.SENTENCIASQL += @"'" + persona.apellido + "',";
                sentencia.SENTENCIASQL += @"'" + persona.correoelectronico + "',";
                sentencia.SENTENCIASQL += @"'" + persona.genero + "',";
                sentencia.SENTENCIASQL += @"'" + persona.estadocivil + "',";
                sentencia.SENTENCIASQL += @"'" + persona.idioma + "',";
                sentencia.SENTENCIASQL += @"'" + persona.certificacion + "',";
                sentencia.SENTENCIASQL += @"'" + persona.titulo + "',";
                sentencia.SENTENCIASQL += @"'" + persona.ubicacion + "')";

                //Se envia a ejecutar la peticion
                AccesoDatos objacceso = new AccesoDatos();
                return objacceso.Ejecutar(sentencia);

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static List<pa_ObtenerExpediente_Result> Obtener_Expedientes()
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();

                sentencia.SENTENCIASQL = "EXEC pa_ObtenerExpediente";

                AccesoDatos objacceso = new AccesoDatos();
                return objacceso.Obtener_Expedientes(sentencia);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int Eliminar_Expediente(Expediente persona)
        {
            try
            {   //SE ARMA LA SENTENCIA QUE SE EJECUTARÁ - Mariliz
                SQLSentencia sentencia = new SQLSentencia();

                sentencia.SENTENCIASQL = @"DELETE FROM Expediente WHERE identificacion = '" + persona.identificacion + "'";

                //SE ENVIA LA PETICION - Mariliz
                AccesoDatos objacceso = new AccesoDatos();
                return objacceso.Ejecutar(sentencia);

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static int Modificar_Expediente(Expediente persona)
        {
            try
            {   //SE ARMA LA SENTENCIA - Mariliz
                SQLSentencia sentencia = new SQLSentencia();

                sentencia.SENTENCIASQL = @"UPDATE Expediente SET promedioprueba = '";
                sentencia.SENTENCIASQL += persona.promedioprueba + "', fechanacimiento = '";
                sentencia.SENTENCIASQL += persona.fechanacimiento + "', nombre = '";
                sentencia.SENTENCIASQL += persona.nombre + "', apellido = '";
                sentencia.SENTENCIASQL += persona.apellido + "', correoelectronico = '";
                sentencia.SENTENCIASQL += persona.correoelectronico + "', genero = '";
                sentencia.SENTENCIASQL += persona.genero + "', estadocivil = '";
                sentencia.SENTENCIASQL += persona.idioma + "', certificacion = '";
                sentencia.SENTENCIASQL += persona.certificacion + "', titulo = '";
                sentencia.SENTENCIASQL += persona.titulo + "', ubicacion = '";
                sentencia.SENTENCIASQL += persona.ubicacion + "' WHERE identificacion = '";
                sentencia.SENTENCIASQL += persona.identificacion + "'";


                //SE ENVIA LA PETICION - Mariliz
                AccesoDatos objacceso = new AccesoDatos();
                return objacceso.Ejecutar(sentencia);

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }




        #endregion

        #region METODOS DEL MODULO PERFIL
        public static int Agregar_Puesto(Puesto p_puesto)
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                ArrayList lstparametros = new ArrayList();

                sentencia.SENTENCIASQL = "EXEC pa_AgregarPuesto @CODPUESTO, @DISPO, @NOMPUESTO, @IDIOMA, @CERTFI, @TITULO";

                SqlParameter paramCODPUESTO = new SqlParameter();
                paramCODPUESTO.Value = p_puesto.codpuesto;
                paramCODPUESTO.SqlDbType = System.Data.SqlDbType.Int;
                paramCODPUESTO.ParameterName = "@CODPUESTO";

                SqlParameter paramDISPONIBILIDAD = new SqlParameter();
                paramDISPONIBILIDAD.Value = p_puesto.disponibilidad;
                paramDISPONIBILIDAD.SqlDbType = System.Data.SqlDbType.Int;
                paramDISPONIBILIDAD.ParameterName = "@DISPO";

                SqlParameter paramNOMPUESTO = new SqlParameter();
                paramNOMPUESTO.Value = p_puesto.nombrepuesto;
                paramNOMPUESTO.SqlDbType = System.Data.SqlDbType.VarChar;
                paramNOMPUESTO.ParameterName = "@NOMPUESTO";

                SqlParameter paramIDIOMA = new SqlParameter();
                paramIDIOMA.Value = p_puesto.idioma;
                paramIDIOMA.SqlDbType = System.Data.SqlDbType.VarChar; 
                paramIDIOMA.ParameterName = "@IDIOMA";

                SqlParameter paramCERTFI = new SqlParameter();
                paramCERTFI.Value = p_puesto.certificacion;
                paramCERTFI.SqlDbType = System.Data.SqlDbType.VarChar;
                paramCERTFI.ParameterName = "@CERTFI";

                SqlParameter paramTITULO = new SqlParameter();
                paramTITULO.Value = p_puesto.titulo;
                paramTITULO.SqlDbType = System.Data.SqlDbType.VarChar;
                paramTITULO.ParameterName = "@TITULO";

                //Lista de parametros
                lstparametros.Add(paramCODPUESTO);
                lstparametros.Add(paramDISPONIBILIDAD);
                lstparametros.Add(paramNOMPUESTO);
                lstparametros.Add(paramIDIOMA);
                lstparametros.Add(paramCERTFI);
                lstparametros.Add(paramTITULO);

                sentencia.LSTPARAMETROS = lstparametros;

                AccesoDatos objacceso = new AccesoDatos();
                return objacceso.Ejecutar(sentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}
