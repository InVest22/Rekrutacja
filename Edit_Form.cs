using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rekrutacja
{
    public partial class Edit_Form : Form
    {
        int id;
        int id_branza;

        bool name = false;
        bool last_name = false;
        bool industry = false;
        bool credit = false;
        bool status = false;

        public Edit_Form(select_klient s)
        {
            InitializeComponent();

            textBox_name.Text = s.Imie;
            textBoxlastname.Text = s.Nazwisko;
            textBox_credit.Text = s.Limit_kredytowy.ToString();
            comboBox_status.Text = s.Status;
            comboBox_industry.Text = s.Branza;

            id = s.ID;

            RekrutacjaEntitie re = new RekrutacjaEntitie();

            foreach (branza br in re.branza.ToArray())
            {
                comboBox_industry.Items.Add(br.nazwa);
                if (br.nazwa == s.Branza)
                    id_branza = br.id;
            }

            comboBox_status.Items.Add("Obecny");
            comboBox_status.Items.Add("Potencjalny");

            button_save.Enabled = false;

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            using (var context = new RekrutacjaEntitie())
            {
                var br = context.klient.Find(id);
                br.imie = textBox_name.Text;
                br.nazwisko = textBoxlastname.Text;
                br.limit_kredytowy = int.Parse(textBox_credit.Text);
                br.status = comboBox_status.Text;
                br.id = id_branza;
                context.klient.Add(br);
                context.klient.Attach(br);
                context.Entry(br).State = EntityState.Modified;
                context.SaveChanges();
            }

            this.Close();
        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {
            name = check(textBox_name);
            is_enabled();
        }

        private void textBoxlastname_TextChanged(object sender, EventArgs e)
        {
            last_name = check(textBoxlastname);
            is_enabled();
        }

        private void textBox_credit_TextChanged(object sender, EventArgs e)
        {
            decimal number;
            if (decimal.TryParse(textBox_credit.Text, out number) == false)
            {
                textBox_credit.Clear();
                string message = "Błędna wartość.";
                MessageBox.Show(message);
            }

            credit = check(textBox_credit);
            is_enabled();
        }

        private void comboBox_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            status = check(comboBox_status);
            is_enabled();
        }

        private void comboBox_industry_SelectedIndexChanged(object sender, EventArgs e)
        {
            industry = check(comboBox_industry);
            is_enabled();
        }

        private bool check(Control ctrl)
        {
            return !string.IsNullOrWhiteSpace(ctrl.Text);
        }

        private void is_enabled()
        {
            button_save.Enabled = (name == true && last_name == true && industry == true && credit == true && status == true);
        }
    }
}
