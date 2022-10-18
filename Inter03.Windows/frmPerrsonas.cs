using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inter03.Datos;
using Inter03.Entidades;

namespace Inter03.Windows
{
    public partial class frmPerrsonas : Form
    {
        public frmPerrsonas()
        {
            InitializeComponent();
        }

        private RepositorioPersonas repositorio = new RepositorioPersonas();
        private void btnClaseConcreta_Click(object sender, EventArgs e)
        {
            List<Persona>personas = repositorio.GetGente();
            foreach (var persona in personas)
            {
                var r = new DataGridViewRow();
                r.CreateCells(dataGridView1);
                SetearFila(r, persona);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dataGridView1.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Persona persona)
        {
            r.Cells[colNombre.Index].Value = persona.Nombre;
            r.Cells[colApellido.Index].Value = persona.Apellido;
            r.Cells[colFechaNac.Index].Value = persona.FechaNacimiento.ToShortDateString();

        }

        private void btnLimpiarGrilla_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void btnClaseAbstracta_Click(object sender, EventArgs e)
        {
            IEnumerable<Persona> personas = repositorio.GetGente();
            foreach (var persona in personas)
            {
                var r = new DataGridViewRow();
                r.CreateCells(dataGridView1);
                SetearFila(r, persona);
                AgregarFila(r);
            }

        }
    }
}
