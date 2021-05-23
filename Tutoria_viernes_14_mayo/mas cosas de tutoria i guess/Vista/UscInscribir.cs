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
    public partial class UscInscribir : UserControl
    {
        public UscInscribir()
        {
            InitializeComponent();
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            Estudiante selectedStudent = (Estudiante)cmbStudent.SelectedItem;
            String selectedSubject = (String)cmbSubject.SelectedItem;

            ListControler.studentsList.ForEach(student =>
           {
               if (student.name.Equals(selectedStudent.name))
               {
                   student.EnrollSubject(selectedSubject);
                   return;
               }
           });
        }

        private void UscInscribir_Load(object sender, EventArgs e)
        {
            LoadComboBoxList();
        }

        public void LoadComboBoxList()
        {
            cmbStudent.DataSource = null;
            cmbStudent.ValueMember = "name";
            cmbStudent.DisplayMember = "name";
            cmbStudent.DataSource = ListControler.studentsList;

            cmbSubject.DataSource = null;
            cmbSubject.DataSource = ListControler.subjectsList;
        }
    }
}
