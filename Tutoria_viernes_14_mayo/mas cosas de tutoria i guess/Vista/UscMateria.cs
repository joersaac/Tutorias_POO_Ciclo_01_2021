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

namespace mas_cosas_de_tutoria_i_guess.Vista
{
    public partial class UscMateria : UserControl
    {
        public UscMateria()
        {
            InitializeComponent();
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            try
            {
                ListControler.subjectsList.ForEach(subject =>
                {
                    if (subject.ToUpper().Equals(txbName.Text.ToUpper()))
                        throw new AlreadyAddedSubjectException("Esta materia ya fue agregada");
                });
                ListControler.subjectsList.Add(txbName.Text);
            }
            catch(AlreadyAddedSubjectException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
