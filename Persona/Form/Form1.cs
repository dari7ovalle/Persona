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
            personas = new Personas();
            personas.Nombre = NombrestextBox.Text;
            personas.Fecha = FechadateTimePicker.Text;

            for (int i = 0; i >= TelefonosdataGridView.RowCount; i++)
            {
                personas.Detalles.Add(new TelefonosDetalles(TelefonosdataGridView.Rows[i].Cells[0].Value.ToString(), TelefonosdataGridView.Rows[i].Cells[1].Value.ToString()));

            }

            return personas;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Personas personas = PersonaBLL.Buscar(int.Parse(PersonaIdtextBox.Text));
            if (personas != null)
            {
                NombrestextBox.Text = personas.Nombre;
                FechadateTimePicker.Text = personas.Fecha;
                TelefonosdataGridView.DataSource = personas.Detalles;
            }
            else
            {
                MessageBox.Show("No Existe");
            }

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
