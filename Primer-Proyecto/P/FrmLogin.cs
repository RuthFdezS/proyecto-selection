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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuarios usuario = new Usuarios();

                usuario.nomusuario = txtUsuario.Text.Trim();
                usuario.pass = txtClave.Text.Trim();

                List<pa_VerificarLogin_Result> lstresultados = LN.Logica.VerificarUsuario(usuario);

                if (lstresultados.Count > 0) //SI trae resultados consulta es valida
                {
                    FrmMenu frm = new FrmMenu(); //Instancia al formulario por abrir

                    frm.ATBNOMUSUARIO = txtUsuario.Text.Trim();
                    frm.CargarMenu();

                    frm.Show();
                    this.Hide(); //Se esconde el formulario actual
                }
                else
                    MessageBox.Show("Usuario y/o contraseña invalidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
