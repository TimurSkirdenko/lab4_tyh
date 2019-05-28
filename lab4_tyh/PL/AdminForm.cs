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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB2DataSet.Doctor". При необходимости она может быть перемещена или удалена.
            this.doctorTableAdapter.Fill(this.dB2DataSet.Doctor);
        }

        private void ДодатиЛікаряToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewDoctor newDoctor = new NewDoctor();
            newDoctor.Show();
        }
    }
}
