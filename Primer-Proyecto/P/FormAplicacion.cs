using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LN;
using E;

namespace P
{
    public partial class FormAplicacion : Form
    {
        private string atbnomusuario;
        private string atbNickNameUsuario;
        private FrmLogin formLogin; //atributo para poder acceder al menu de Login

        public string ATBNOMUSUARIO
        {
            set { this.atbnomusuario = value; }
            get { return this.atbnomusuario; }
        }

        public string ATBNICKNAMEUSURIO
        {
            set { this.atbNickNameUsuario = value; }
            get { return this.atbNickNameUsuario; }
        }

        public FrmLogin FORMLOGIN
        {
            set { this.formLogin = value; }
            get { return this.formLogin; }
        }

        #region INICI METODOS
        public FormAplicacion(FrmLogin p_formLogin)
        {
            this.formLogin = p_formLogin;
            InitializeComponent();
        }

        public void CargarMenu()
        {
            try
            {

                this.btn_Candidato.Visible = false;
                this.btn_Mantenimiento.Visible = false;
                this.btn_Estadistica.Visible = false;
                this.btn_Admin.Visible = false;

                TabSistemaSeleccion.TabPages.Remove(tabAdmin);
                TabSistemaSeleccion.TabPages.Remove(tabMantenimiento);
                TabSistemaSeleccion.TabPages.Remove(tabEstadistica);
                TabSistemaSeleccion.TabPages.Remove(tabCandidato);
            

                //Cargo perfiles del usuario
                Usuarios u = new Usuarios();
                u.nicknameUsuario = this.atbNickNameUsuario;

                List<pa_ObtenerPerfilesUsuario_Result> lstresultados = Logica.ObtenerPerfilesPorUsuario(u);
                List<pa_ObtenerNombreUsuario_Result> lstresultados2 = Logica.ObtenerNombrePorUsuario(u);


                if (lstresultados.Count > 0)
                {
                    foreach (pa_ObtenerPerfilesUsuario_Result item in lstresultados)
                    { 
                       //Aqui habilito opciones segun perfil
                        switch (item.nomperfil.ToUpper())
                        {
                            case "ADMINISTRADOR":
                                {
                                    this.btn_Admin.Visible = true;
                                    this.btn_Candidato.Visible = true;
                                    this.btn_Mantenimiento.Visible = true;
                                    this.btn_Estadistica.Visible = true;
                                    TabSistemaSeleccion.TabPages.Add(tabAdmin);
                                    TabSistemaSeleccion.TabPages.Add(tabMantenimiento);
                                    TabSistemaSeleccion.TabPages.Add(tabEstadistica);
                                    TabSistemaSeleccion.TabPages.Add(tabCandidato);

                                } break;

                            case "MANTENIMIENTO":
                                {
                                    this.btn_Mantenimiento.Visible = true;
                                    TabSistemaSeleccion.TabPages.Add(tabMantenimiento);
                                    TabSistemaSeleccion.TabPages.Remove(tabEstadistica);
                                    TabSistemaSeleccion.TabPages.Remove(tabAdmin);
                                    TabSistemaSeleccion.TabPages.Remove(tabCandidato);
                                    this.btn_Mantenimiento.Location = new Point(10, 10);
                                }
                                break;

                            case "ESTADÍSTICO":
                                {
                                    this.btn_Estadistica.Visible = true;
                                    TabSistemaSeleccion.TabPages.Add(tabEstadistica);
                                    TabSistemaSeleccion.TabPages.Remove(tabMantenimiento);
                                    TabSistemaSeleccion.TabPages.Remove(tabAdmin);
                                    TabSistemaSeleccion.TabPages.Remove(tabCandidato);
                                    this.btn_Estadistica.Location = new Point(10, 10);

                                }
                                break;

                            case "CANDIDATOS":
                                {
                                    this.btn_Candidato.Visible = true;
                                    TabSistemaSeleccion.TabPages.Add(tabCandidato);
                                    TabSistemaSeleccion.TabPages.Remove(tabMantenimiento);
                                    TabSistemaSeleccion.TabPages.Remove(tabAdmin);
                                    TabSistemaSeleccion.TabPages.Remove(tabEstadistica);
                                    this.btn_Candidato.Location = new Point(10, 10);
                                }
                                break;

                        }
                    }

                    foreach (pa_ObtenerNombreUsuario_Result item in lstresultados2)
                    {
                        Console.Write(item.nomusuario);
                        tssl_usuario.Text = item.nomusuario;  //Colocando es el nombre de usuario en la barra segun el nickname
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        #endregion

        #region INICIA EVENTOS DE LOS BOTONES

        private void cerrarSesónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.formLogin.Show(); // Se manda a llamar el menu de Login y se muestra

            this.Hide();
        }

        private void cerrarSistemaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Admin_CheckedChanged(object sender, EventArgs e)
        {
            TabSistemaSeleccion.SelectTab(tabAdmin);
        }

        private void btn_Mantenimiento_CheckedChanged(object sender, EventArgs e)
        {
            TabSistemaSeleccion.SelectTab(tabMantenimiento);
        }

        private void btn_Estadistica_CheckedChanged(object sender, EventArgs e)
        {
            TabSistemaSeleccion.SelectTab(tabEstadistica);
        }

        private void btn_Candidato_CheckedChanged(object sender, EventArgs e)
        {
            TabSistemaSeleccion.SelectTab(tabCandidato);
        }
        #endregion

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void FormAplicacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'seleccionBDDataSet.Perfiles' Puede moverla o quitarla según sea necesario.
            this.perfilesTableAdapter.Fill(this.seleccionBDDataSet.Perfiles);

        }

        private void btn_actualizarPerfil_Click(object sender, EventArgs e)
        {
            try
            {
                Usuarios usuario = new Usuarios();

                usuario.nicknameUsuario = txt_nickNameUsuario.Text.Trim();
                //usuario.pass = txtClave.Text.Trim();

                //List<pa_ModificarPermisosPerfil_Result> lstresultados = LN.Logica.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
