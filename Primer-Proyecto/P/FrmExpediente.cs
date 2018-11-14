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
    public partial class FrmExpediente : Form
    {
        public FrmExpediente()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            this.txtidentificacion.Text = String.Empty;
            this.txtnombre.Text = String.Empty;
            this.txtapellido.Text = String.Empty;
            this.txtcorreoelectronico.Text = String.Empty;
            this.txtubicacion.Text = String.Empty;
            this.txtpromedio.Text = String.Empty;
            this.txtidentificacion.Focus();
        }

        private void CargarLista()
        {
            try
            {
                DataTable dt = new DataTable();

                dt.Columns.Add("Identificacion");
                dt.Columns.Add("PromedioPrueba");
                dt.Columns.Add("FechaNacimiento");
                dt.Columns.Add("Nombre");
                dt.Columns.Add("Apellido");
                dt.Columns.Add("CorreoEletronico");
                dt.Columns.Add("Genero");
                dt.Columns.Add("EstadoCivil");
                dt.Columns.Add("Idioma");
                dt.Columns.Add("Certificacion");
                dt.Columns.Add("Titulo");
                dt.Columns.Add("Ubicacion");

                List<pa_ObtenerExpediente_Result> lstexpedientes = Logica.Obtener_Expedientes();

                foreach (pa_ObtenerExpediente_Result item in lstexpedientes)
                {
                    dt.Rows.Add(item.identificacion, item.promedioprueba, item.fechanacimiento, item.nombre,
                        item.apellido, item.correoelectronico, item.genero, item.estadocivil, item.idioma, item.certificacion, item.titulo, item.ubicacion);
                }

                this.dgvDatos.DataSource = dt;
                this.dgvDatos.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Agregar()
        {
            try
            {
                Expediente e = new Expediente();

                e.identificacion = this.txtidentificacion.Text.Trim();
                e.promedioprueba = this.txtpromedio.Text.Trim();
                e.fechanacimiento = this.dt.Value.Date;
                e.nombre = this.txtnombre.Text.Trim();
                e.apellido = this.txtapellido.Text.Trim();
                e.correoelectronico = this.txtcorreoelectronico.Text.Trim();
                e.idioma = this.cboIdioma.SelectedItem.ToString();
                e.certificacion = this.cboCertificacion.SelectedItem.ToString();
                e.titulo = this.cboTitulo.Text.Trim();
                e.ubicacion = this.txtubicacion.Text.Trim();
                e.genero = this.cboGenero.SelectedItem.ToString();
                e.estadocivil = this.cboEstadoCivil.SelectedItem.ToString();


                Logica.Agregar_Expediente(e);
                MessageBox.Show("Expediente agregado");
                Limpiar();
                CargarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
            Limpiar();
        }
        
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                //Armar objeto
                Expediente objusuario = new Expediente();
                objusuario.identificacion = txtidentificacion.Text;
                objusuario.promedioprueba = txtpromedio.Text;
                objusuario.fechanacimiento = dt.Value.Date;
                objusuario.nombre = txtnombre.Text;
                objusuario.apellido = txtapellido.Text;
                objusuario.correoelectronico = txtcorreoelectronico.Text;
                objusuario.genero = cboGenero.SelectedItem.ToString();
                objusuario.estadocivil = cboEstadoCivil.SelectedIndex.ToString();
                objusuario.idioma = cboIdioma.SelectedItem.ToString();
                objusuario.certificacion = cboCertificacion.SelectedItem.ToString();
                objusuario.titulo = cboTitulo.SelectedItem.ToString();
                objusuario.ubicacion = txtubicacion.Text;

                LN.Logica.Modificar_Expediente(objusuario);
                MessageBox.Show("Expediente modificado");
                CargarLista();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                //Armar objeto
                Expediente objusuario = new Expediente();
                objusuario.identificacion = txtidentificacion.Text;

                LN.Logica.Eliminar_Expediente(objusuario);
                MessageBox.Show("Expediente eliminado");
                CargarLista();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //SIN USO - Mariliz
        private void cboIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void comboboxUbicacion()
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void FrmExpediente_Load(object sender, EventArgs e)
        {
            //CargarCombos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtidentificacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboCertificacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        public void comboboxUbicacion ()
        {

        }
    }
}
