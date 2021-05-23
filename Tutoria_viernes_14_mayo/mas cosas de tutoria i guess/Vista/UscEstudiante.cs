using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mas_cosas_de_tutoria_i_guess.Controlador;
using mas_cosas_de_tutoria_i_guess.Modelo;

namespace mas_cosas_de_tutoria_i_guess.Vista
{
    public partial class UscEstudiante : UserControl
    {
        public UscEstudiante()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                ListControler.studentsList.ForEach(student =>
                {
                    if (student.name.ToUpper().Equals(txbName.Text.ToUpper()))
                        throw new AlreadyAddedStudentException("Este estudiante ya ha sido aceptado");
                });
                ListControler.studentsList.Add(new Estudiante(txbName.Text));
            }
            catch(AlreadyAddedStudentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
