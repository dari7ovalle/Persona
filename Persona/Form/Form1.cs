using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Persona.BLL;
using Persona.Entidad;

namespace Persona.Entidad
{
    public partial class FormRegistro : Form
    {
        Personas personas;
        public FormRegistro()
        {
            InitializeComponent();
            personas = new Personas();
            TipoTelefonoscomboBox.DataSource = Enum.GetValues(typeof(TipoTelefono.TipoT));
        }

        private void Limpiar()
        {
            TelefonotextBox.Clear();
        }

        private Personas LlenarClase()
        {
            bool retorno = true;
            if (NombrestextBox.Text.Length <= 0)
            {
                retorno = false;
            }
            else
            {
                personas.Nombre = NombrestextBox.Text;
                personas.Fecha = FechadateTimePicker.Text;
            }
            if (TelefonosdataGridView.Rows.Count > 0)
            {
                for (int i = 0; i < TelefonosdataGridView.RowCount; i++)
                {
                    personas.Detalles.Add(new TelefonosDetalles(TipoTelefonoscomboBox.SelectedIndex, TelefonotextBox.Text));
                }
            }
            else
            {
                retorno = false;
            }
            return personas;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TipoTelefonoscomboBox.SelectedItem.ToString());
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            TelefonosdataGridView.Rows.Add(TipoTelefonoscomboBox.SelectedItem.ToString(), TelefonotextBox.Text);
            TelefonotextBox.Clear();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            personas.Detalles.Clear();
            NombrestextBox.Clear();
            TelefonotextBox.Clear();
            TelefonosdataGridView.DataSource = String.Empty;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (PersonaBLL.Guardar(LlenarClase()))
            {
                MessageBox.Show("Guardo");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
