using lab4_tyh.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4_tyh
{
    public partial class NewPatient : Form
    {
        public NewPatient()
        {
            InitializeComponent();
            //Model model = new Model();
            //var diseases = model.Disease;
            //foreach (Disease disease in diseases)
            //{
            //    comboBox5.Items.Add(disease.Name);
            //}
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text == "" || textBox1.Text.Count() > 100 || comboBox2.Text == "" || comboBox3.Text == "" || comboBox4.Text == "")
            //{
            //    MessageBox.Show("Неправильні дані");
            //}
            //else
            //{
            //    try
            //    {
            //        NewPat newPat = new NewPat();
            //        if (!newPat.NewPatien(textBox1.Text, comboBox2.Text, comboBox3.Text, comboBox4.Text, comboBox5.Text, dateTimePicker1.Value))
            //        {
            //            throw new Exception();
            //        }
            //        Close();
            //        MessageBox.Show("ОК");
            //    }
            //    catch (Exception) { MessageBox.Show("Error!"); }
            //}
        }
    }
}
