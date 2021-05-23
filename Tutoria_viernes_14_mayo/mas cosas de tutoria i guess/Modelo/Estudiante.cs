using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mas_cosas_de_tutoria_i_guess.Controlador;
using System.Windows.Forms;

namespace mas_cosas_de_tutoria_i_guess.Modelo
{
    class Estudiante
    {
        public String name { get; }
        public List<String> enrolledSubjects { get; }
        public Estudiante(String name)
        {
            this.name = name;
            this.enrolledSubjects = new List<String>();
        }

        public void EnrollSubject(String newSubject)
        {
            try
            {
                enrolledSubjects.ForEach(sub =>
                {
                    if (sub.ToUpper().Equals(newSubject.ToUpper()))
                        throw new AlreadyEnrolledSubjectException("Este estudiante " +
                            "ya inscribio esta materia");
                });
                this.enrolledSubjects.Add(newSubject);
            }
            catch(AlreadyEnrolledSubjectException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
