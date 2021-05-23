using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mas_cosas_de_tutoria_i_guess.Vista;

namespace mas_cosas_de_tutoria_i_guess
{
    public partial class frmMain : Form
    {
        private UserControl current;
        private UscEstudiante uscEstudiantes;
        private UscMateria uscMateria;
        private UscConsultar uscConsultar;
        private UscInscribir uscInscribir;
        public frmMain()
        {
            InitializeComponent();
            uscConsultar = new UscConsultar();
            uscEstudiantes = new UscEstudiante();
            uscInscribir = new UscInscribir();
            uscMateria = new UscMateria();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            current = uscEstudiantes;
            tableLayoutPanel1.Controls.Add(current, 0, 0);
            tableLayoutPanel1.SetRowSpan(current, 4);
            current.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void btnEstudiante_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = uscEstudiantes;
            tableLayoutPanel1.Controls.Add(current, 0, 0);
            tableLayoutPanel1.SetRowSpan(current, 4);
            current.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void btnMateria_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = uscMateria;
            tableLayoutPanel1.Controls.Add(current, 0, 0);
            tableLayoutPanel1.SetRowSpan(current, 4);
            current.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void btnInscripcion_Click(object sender, EventArgs e)
        {
            uscInscribir.LoadComboBoxList();
            tableLayoutPanel1.Controls.Remove(current);
            current = uscInscribir;
            tableLayoutPanel1.Controls.Add(current, 0, 0);
            tableLayoutPanel1.SetRowSpan(current, 4);
            current.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            uscConsultar.WhenLoad();
            tableLayoutPanel1.Controls.Remove(current);
            current = uscConsultar;
            tableLayoutPanel1.Controls.Add(current, 0, 0);
            tableLayoutPanel1.SetRowSpan(current, 4);
            current.Dock = System.Windows.Forms.DockStyle.Fill;
        }
    }
}
