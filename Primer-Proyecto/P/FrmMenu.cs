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
    public partial class FrmMenu : Form
    {
        private string atbnomusuario;
        private FrmLogin formLogin;

        public string ATBNOMUSUARIO
        {
            set { this.atbnomusuario = value; }
            get { return this.atbnomusuario; }
        }

        public FrmLogin FORMLOGIN
        {
            set { this.formLogin = value; }
            get { return this.formLogin; }
        }
        
        public FrmMenu(FrmLogin p_formLogin)
        {
            this.formLogin = p_formLogin;
            InitializeComponent();
        }

        public void CargarMenu()
        {
            try
            {
                tssl_usuario.Text = this.atbnomusuario; //Colocando es el nombre de usuario en la barra

                //Aqui deshabilito opciones del menu 
                mantenimientoToolStripMenuItem.Visible = false;
                candidatosToolStripMenuItem.Visible = false;
                estadisticasToolStripMenuItem.Visible = false;

                //Cargo perfiles del usuario
                Usuarios u = new Usuarios();
                u.nomusuario = this.atbnomusuario;

                List<pa_ObtenerPerfilesUsuario_Result> lstresultados = Logica.ObtenerPerfilesPorUsuario(u);

                if(lstresultados.Count > 0)
                {
                    foreach (pa_ObtenerPerfilesUsuario_Result item in lstresultados)
                    {
                        //Aqui habilito opciones segun perfil
                        switch(item.nomperfil.ToUpper())
                        {
                            case "MANTENIMIENTO": { this.mantenimientoToolStripMenuItem.Visible = true; } break;
                            case "ESTADÍSTICO": { this.estadisticasToolStripMenuItem.Visible = true; } break;
                            case "CANDIDATOS": { this.candidatosToolStripMenuItem.Visible = true; } break;
                            case "ADMINISTRADOR": {
                                    this.mantenimientoToolStripMenuItem.Visible = true;
                                    this.candidatosToolStripMenuItem.Visible = true;
                                    this.estadisticasToolStripMenuItem.Visible = true;
                                } break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void cerrarSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.formLogin.Show();
            this.Hide();
        }

        private void estadisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void expedientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
