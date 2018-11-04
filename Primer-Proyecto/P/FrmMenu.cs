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

        public string ATBNOMUSUARIO
        {
            set { this.atbnomusuario = value; }
            get { return this.atbnomusuario; }
        }
        
        public FrmMenu()
        {
            InitializeComponent();
        }

        public void CargarMenu()
        {
            try
            {
                tssl_usuario.Text = this.atbnomusuario; //Colocando es el nombre de usuario en la barra

                //Aqui deshabilito opciones del menu 
                mantenimientoToolStripMenuItem.Visible = false;
                consultasToolStripMenuItem.Visible = false;
                procesosToolStripMenuItem.Visible = false;

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
                            case "CONSULTA": { this.consultasToolStripMenuItem.Visible = true; } break;
                            case "PROCESOS": { this.procesosToolStripMenuItem.Visible = true; } break;
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
    }
}
