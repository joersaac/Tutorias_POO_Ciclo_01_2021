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
    public partial class UscConsultar : UserControl
    {
        public UscConsultar()
        {
            InitializeComponent();
        }

        private void UscConsultar_Load(object sender, EventArgs e)
        {
            WhenLoad();
        }

        public void WhenLoad()
        {
            dgvEnrollData.DataSource = null;
            dgvEnrollData.DataSource = dataForDataGridView();
        }

        private DataTable dataForDataGridView()
        {
            DataTable dt = new DataTable();
            DataColumn dc1;
            DataRow dr;
            dc1 = new DataColumn();
            dc1.DataType = System.Type.GetType("System.String");
            dc1.ColumnName = "Estudiante";
            dc1.ReadOnly = true;

            DataColumn dc2;
            dc2 = new DataColumn();
            dc2.DataType = System.Type.GetType("System.String");
            dc2.ColumnName = "Materia inscrita";
            dc2.ReadOnly = true;

            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);

            ListControler.studentsList.ForEach(student =>
            {
                student.enrolledSubjects.ForEach(subject =>
                {
                    dr = dt.NewRow();
                    dr["Estudiante"] = student.name;
                    dr["Materia inscrita"] = subject;
                    dt.Rows.Add(dr);
                });
            });

            return dt;
        }
    }
}
