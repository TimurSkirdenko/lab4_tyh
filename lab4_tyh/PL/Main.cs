using System;
using System.Windows.Forms;
using lab4_tyh.BL;

namespace lab4_tyh
{
    public partial class Main : Form
    {
        static public int selInd;
        public Main()
        {
            InitializeComponent();
            MainBL main = new MainBL();
            main.MainFunc(comboBox1, comboBox2);
            comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Authorization form = new Authorization();
            form.Show();
        }   
        private void Button1_Click(object sender, EventArgs e)
        {
            MainBL main = new MainBL();
            label7.Text = main.Button1_Click(comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox4.Text);
        }
        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            if (true)
            {
                if (MessageBox.Show("Do you want to exit?", "My Application", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainBL main = new MainBL();
            main.comboBox1_SelectedIndexChanged(ref comboBox1, ref comboBox2, ref comboBox3);
            foreach (string region in MainBL.district_)
            {
                comboBox2.Items.Add(region);
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainBL main = new MainBL();
            main.comboBox2_SelectedIndexChanged(ref comboBox2, ref comboBox3, comboBox2.SelectedIndex + 1);

            foreach (string region in MainBL.city_)
            {
                comboBox3.Items.Add(region);
            }
        }
    }
}
