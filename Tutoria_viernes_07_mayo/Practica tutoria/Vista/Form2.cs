using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practica_tutoria.Modelo;
using Practica_tutoria.Controlador;

namespace Practica_tutoria.Vista
{
    public partial class Form2 : Form
    {
        private List<ColorModel> colorList;
        private List<Prima> primasList;
        public Form2()
        {
            InitializeComponent();
            primasList = new List<Prima>();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                primasList.Add(new Prima(textBox1.Text, Int32.Parse(textBox2.Text)));
                dataGridView1.DataSource = dataForDataGridView();
            }
            else
                MessageBox.Show("No deje campos vacios pinche menso");
        }
        private DataTable dataForDataGridView()
        {
            DataTable dt = new DataTable();
            DataColumn dc1;
            DataRow dr;
            dc1 = new DataColumn();
            dc1.DataType = System.Type.GetType("System.String");
            dc1.ColumnName = "Primas";
            dc1.ReadOnly = true;

            DataColumn dc2;
            dc2 = new DataColumn();
            dc2.DataType = System.Type.GetType("System.Int32");
            dc2.ColumnName = "Edad";
            dc2.ReadOnly = true;

            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);

            primasList.ForEach(prima =>
            {
                dr = dt.NewRow();
                dr["Primas"] = prima.prima;
                dr["Edad"] = prima.edad;
                dt.Rows.Add(dr);
            });

            return dt;
        }
        private void declarateColorList()
        {
            colorList = new List<ColorModel>();
            colorList.Add(new ColorModel("Negro", Color.FromArgb(0, 0, 0)));
            colorList.Add(new ColorModel("Blanco", Color.FromArgb(255, 255, 255)));
            colorList.Add(new ColorModel("Rojo", Color.FromArgb(255, 0, 0)));
            colorList.Add(new ColorModel("Azul", Color.FromArgb(0, 60, 255)));
        }

        private void LoadComboBoxList(ComboBox cmb)
        {
            cmb.DataSource = null;
            cmb.ValueMember = "Color";
            cmb.DisplayMember = "ColorName";
            cmb.DataSource = colorList;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            declarateColorList();
            LoadComboBoxList(comboBox1);
            dataGridView1.DataSource = dataForDataGridView();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ColorModel colorSeleccioando = (ColorModel)comboBox1.SelectedItem;
            if(colorSeleccioando != null)
                label3.ForeColor = colorSeleccioando.Color;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                OptionsControler.backGroundColor = colorList[1].Color;
            else if(radioButton2.Checked)
                OptionsControler.backGroundColor = colorList[0].Color;
            else if (radioButton5.Checked)
                OptionsControler.backGroundColor = colorList[3].Color;
            else
                OptionsControler.backGroundColor = colorList[2].Color;

            this.BackColor = OptionsControler.backGroundColor;
            ColorModel colorSeleccioando = (ColorModel)comboBox1.SelectedItem;
            if (colorSeleccioando != null)
                OptionsControler.fontColor = colorSeleccioando.Color;
        }
    }
}
