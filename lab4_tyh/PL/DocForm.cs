using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4_tyh.BL
{
    public partial class DocForm : Form
    {
        public DocForm()
        {
            InitializeComponent();
        }

        private void DocForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB2DataSet.Patient". При необходимости она может быть перемещена или удалена.
            this.patientTableAdapter.Fill(this.dB2DataSet.Patient);

        }

        private void ДодатиПацієнтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPatient newPatient = new NewPatient();
            newPatient.Show();
        }
    }
}
