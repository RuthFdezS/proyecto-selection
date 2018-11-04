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
            this.txtAPE.Text = String.Empty;
            this.txtNOM.Text = String.Empty;
            this.txtID.Text = String.Empty;
            this.txtEDAD.Text = String.Empty;
            this.cboGenero.SelectedIndex = 0;
            this.cboEstadoCivil.SelectedIndex = 0;
            this.txtID.Focus();
        }
        private void CargarCombos()
        {
            try
            {
                List<EstadosCiviles> lstestadosciviles = Logica.Obtener_EstadosCiviles();
                List<Generos> lstgeneros = Logica.Obtener_Generos();

                this.cboGenero.DataSource = lstgeneros;
                this.cboGenero.DisplayMember = "nomgenero";
                this.cboGenero.ValueMember = "codgenero";

                this.cboEstadoCivil.DataSource = lstestadosciviles;
                this.cboEstadoCivil.DisplayMember = "nomestadocivil";
                this.cboEstadoCivil.ValueMember = "codestadocivil";

                CargarLista();
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

                e.identificacion = this.txtID.Text.Trim();
                e.nombre = this.txtNOM.Text.Trim();
                e.apellidos = this.txtAPE.Text.Trim();
                e.edad = Convert.ToInt32(this.txtEDAD.Text.Trim());
                e.codgenero = Convert.ToInt32(this.cboGenero.SelectedValue.ToString());
                e.codestadocivil = Convert.ToInt32(this.cboEstadoCivil.SelectedValue.ToString());

                Logica.Agregar_Expediente(e);
                MessageBox.Show("Usuario guardado");
                Limpiar();
                CargarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CargarLista()
        {
            try
            {
                DataTable dt = new DataTable();

                dt.Columns.Add("Identificacion");
                dt.Columns.Add("Nombres");
                dt.Columns.Add("Apellidos");
                dt.Columns.Add("Edad");
                dt.Columns.Add("CodGenero");
                dt.Columns.Add("Genero");
                dt.Columns.Add("CodEstadoCivil");
                dt.Columns.Add("EstadoCivil");

                List<pa_ConsultarExpedientes_Result> lstexpedientes = Logica.Obtener_Expedientes();

                foreach (pa_ConsultarExpedientes_Result item in lstexpedientes)
                {
                    dt.Rows.Add(item.identificacion, item.nombre, item.apellidos, item.edad, 
                        item.codgenero, item.genero, item.codestadocivil, item.estadocivil);
                }

                this.dgvDatos.DataSource = dt;
                this.dgvDatos.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmExpediente_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }
    }
}
