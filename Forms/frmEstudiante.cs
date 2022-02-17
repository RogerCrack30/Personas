using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class frmEstudiante : Form
    {
        List<Ingenieria> lista = new List<Ingenieria>();

        Ingenieria ing;

        int i = 0;



        public frmEstudiante()
        {
            InitializeComponent();
            lista = new List<Ingenieria>();

        }

        public void guardar1()
        {

            ing = new Ingenieria(txtNombreyApellido.Text, int.Parse(txtEdad.Text), comboBox1.Text, txtCarnet.Text, cbNivelAcademico.Text,
                txtUniversidad.Text, cbCarrera.Text, cbMateriasInscritas.Text, int.Parse(txtNotas.Text), txtCUM.Text,
                txtNombreProyecto.Text, int.Parse(txtHoraTotales.Text), int.Parse(txtHoraCompletadas.Text));



            lista.Add(ing);


            dgvPersona.DataSource = null;
            dgvPersona.DataSource = lista;




        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            guardar1();


        }

        private void frmEstudiante_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvPersona_CellClick(object sender, DataGridViewCellEventArgs e)
        {





        }

        private void BtnPromedio_Click(object sender, EventArgs e)
        {

            int suma = 0;

            foreach (DataGridViewRow row in dgvPersona.Rows)

            {

                suma += Convert.ToInt32(row.Cells["Nota"].Value);

            }

            int total;



            label2.Text = dgvPersona.Rows.Count.ToString();

            total = Convert.ToInt32(label2.Text);

            int promedio = 0;

            promedio = suma / total;


            txtPromedio.Text = Convert.ToString(promedio);








        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < dgvPersona.RowCount; i++)
            {
                for(int j = 0; j<dgvPersona.RowCount-1; j++)
                {
                    
                }
            }

        }
    }
}
