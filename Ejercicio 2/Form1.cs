using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        public List<Estudiantes> listEstudiantes = new List<Estudiantes>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtNombres.Text) || string.IsNullOrEmpty(txtApellidos.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
            }

            else
            {
                int id = int.Parse(txtID.Text);
                string nombres = txtNombres.Text;
                string apellidos = txtApellidos.Text;
                listEstudiantes.Add(new Estudiantes()
                {
                    Id = id,
                    Nombres = nombres,
                    Apellidos = apellidos
                });
                MessageBox.Show("Su resgistro fue agregado con exito");
                txtID.Clear();
                txtNombres.Clear();
                txtApellidos.Clear();
            }
           
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            if (listEstudiantes.Count > 0)
            {
                //Enviar datos
                f2.listEstudiantes = this.listEstudiantes;
                f2.Show();
            }
            else
            {
                MessageBox.Show("Debe agregar al menos un registro ");
            }
        }
    }
}
