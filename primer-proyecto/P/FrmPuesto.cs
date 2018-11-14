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
    public partial class FrmPuesto : Form
    {
        public FrmPuesto()
        {
            InitializeComponent();
        }


        private void Limpiar()
        {
            this.txt_codPuesto.Text = String.Empty;
            this.txt_nombrePuesto.Text = String.Empty;
            this.txt_disponible.Text = String.Empty;
            this.txt_codPuesto.Focus();
        }

        private void CargarLista()
        {
            try
            {
                DataTable dt = new DataTable();

                dt.Columns.Add("CodigoPuesto");
                dt.Columns.Add("Disponibilidad");
                dt.Columns.Add("NombrePuesto");
                dt.Columns.Add("Idioma");
                dt.Columns.Add("Certificacion");

                List<pa_ObtenerExpediente_Result> lstexpedientes = Logica.Obtener_Expedientes();

                foreach (pa_ObtenerExpediente_Result item in lstexpedientes)
                {
                    dt.Rows.Add(item.identificacion, item.promedioprueba, item.fechanacimiento, item.nombre,
                        item.apellido, item.correoelectronico, item.genero, item.estadocivil, item.idioma, item.certificacion, item.titulo, item.ubicacion);
                }

                //this.dgvDatos.DataSource = dt;
                //this.dgvDatos.Refresh();

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
                Puesto e = new Puesto();

                e.codpuesto = Convert.ToInt32(this.txt_codPuesto.Text.Trim());
                e.disponibilidad = Convert.ToInt32(this.txt_disponible.Text.Trim());
                e.nombrepuesto = this.txt_nombrePuesto.Text.Trim();
                e.idioma = this.cboIdioma.SelectedItem.ToString();
                e.certificacion = this.cboCertificacion.SelectedItem.ToString();
                e.titulo = this.cboTitulo.Text.Trim();

                Logica.Agregar_Puesto(e);
                MessageBox.Show("Puesto agregado con éxito");
                Limpiar();
                CargarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void FrmPuesto_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
            Limpiar();
        }
    }
}
