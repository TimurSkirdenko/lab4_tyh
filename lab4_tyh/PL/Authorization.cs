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
    public partial class Authorization : Form
    {
        static public int AdminDoctorForm;
        public Authorization()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //AuthorizationBL authorization = new AuthorizationBL();
            //if (authorization.Authoriz(checkBox1.Checked, textBox1.Text, textBox2.Text))
            //{
            //    if (!checkBox1.Checked)
            //    {
            //        AdminDoctorForm = 2;
            //        Close();
            //        DocForm form = new DocForm();
            //        form.Show();
            //    }
            //    else
            //    {
            //        AdminDoctorForm = 1;
            //        Close();
            //        AdminForm form = new AdminForm();
            //        form.Show();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Не вірний логін чи пароль!");
            //}
        }
    }
}
