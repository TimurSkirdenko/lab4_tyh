using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;

namespace lab4_tyh.BL
{
    class MainBL
    {
        private MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=ukraine;password=nokia3900;");
        static private List<int> id = new List<int>();
        static public List<string> region_ = new List<string>();
        static public List<string> district_ = new List<string>();
        static public List<string> city_ = new List<string>();
        static public List<string> disease_ = new List<string>();
        private string region;
        private string district;
        private string city;
        private string disease;
        public bool MainFunc(ComboBox comboBox1, ComboBox comboBox2)
        {
            connection.Open();
            string sqlCmd = "SELECT title FROM locality where id > 0 and id < 28;";
            MySqlCommand command = new MySqlCommand(sqlCmd, connection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                region_.Add(reader[0].ToString());
            }
            reader.Close();
            Model model = new Model();
            ModelRepository<Disease> modelRepository = new ModelRepository<Disease>(model);

            var diseases = modelRepository.Get();
            foreach (Disease disease in diseases)
            {
                disease_.Add(disease.Name);
            }
            return true;
        }
        public void comboBox1_SelectedIndexChanged(ref ComboBox comboBox1, ref ComboBox comboBox2, ref ComboBox comboBox3)
        {
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox2.Items.Clear();
            connection.Open();
            string selIndex = (comboBox1.SelectedIndex + 1).ToString();
            string sqlCmd = $"SELECT title, id FROM locality where parent_id = {selIndex} and type = 'Район';";
            MySqlCommand command = new MySqlCommand(sqlCmd, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                district_.Add(reader[0].ToString());
                id.Add(Convert.ToInt32(reader[1]));
            }
            reader.Close();
        }
        public void comboBox2_SelectedIndexChanged(ref ComboBox comboBox2, ref ComboBox comboBox3, int selIndex1)
        {
            connection.Open();
            comboBox3.Text = "";
            comboBox3.Items.Clear();
            string selIndex = id[selIndex1].ToString();
            string sqlCmd = $"SELECT title FROM locality where parent_id = {selIndex};";
            MySqlCommand command = new MySqlCommand(sqlCmd, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox3.Items.Add(reader[0].ToString());
            }
            reader.Close();
        }
        public string Button1_Click(string text1, string text2, string text3, string text4)
        {
            region = text1;
            district = text2;
            city = text3;
            disease = text4;
            Model model = new Model();
            int count;
            //count = model.Patient.Where(x => x.Region == region && x.District == district && x.City == city && x.Disease1 == disease).Count();
            return "0"; //count.ToString();
        }

    }
}
