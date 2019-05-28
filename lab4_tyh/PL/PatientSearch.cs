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
    public partial class PatientSearch : Form
    {
        static public Patient patient;
        public PatientSearch()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            //PatientSearchBL patientBL = new PatientSearchBL();
            //patient = patientBL.SearchPatient(textBox1.Text);
        }
    }
}
