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
    public partial class Edit_delete_Form : Form
    {
        
        public Edit_delete_Form()
        {
            InitializeComponent();

            RekrutacjaEntitie db = new RekrutacjaEntitie();
            foreach (branza br in db.branza.ToArray())
            {
                industry_comboBox.Items.Add(br.nazwa);
            }

            Edit_button.Enabled = false;
            Delete_button.Enabled = false;
        }

        private void Edit_delete_Form_Load(object sender, EventArgs e)
        {

        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            using (var context = new RekrutacjaEntitie())
            {
                var br = context.branza.Find(check_value(industry_comboBox.Text));
               
                br.nazwa = Industry_textBox.Text;
                context.branza.Add(br);
                context.branza.Attach(br);
                context.Entry(br).State = EntityState.Modified;
                context.SaveChanges();
            }

            refresh();
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (check_clients(industry_comboBox.Text) == true)
            {
                string message = "Nie mozna usunąć wybranej branzy.";
                MessageBox.Show(message);

            }
            else
            {
                using (var context = new RekrutacjaEntitie())
                {
                    var br = context.branza.Find(check_value(industry_comboBox.Text));
                    context.branza.Attach(br);
                    context.branza.Remove(br);
                    context.SaveChanges();
                }
                refresh();
            }
        }


        private void industry_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (industry_comboBox.Text != null && !string.IsNullOrWhiteSpace(industry_comboBox.Text))
            {
                Delete_button.Enabled = true;
            }
            else
                Delete_button.Enabled = false;
        }


        private void Industry_textBox_TextChanged(object sender, EventArgs e)
        {
            if (Industry_textBox.Text!= null && !string.IsNullOrWhiteSpace(Industry_textBox.Text) && industry_comboBox.Text != null && !string.IsNullOrWhiteSpace(industry_comboBox.Text))
            {
                Edit_button.Enabled = true;
            }
            else
                Edit_button.Enabled = false;
            
        }

        private static int check_value(string industry)
        {
            RekrutacjaEntitie db = new RekrutacjaEntitie();
            foreach (branza b in db.branza)
            {
                if (b.nazwa == industry)
                {
                    return b.id;
                }
            }

            return 0;
        }


        private static bool check_clients(string industry)
        {
            
            int index = check_value(industry);

            RekrutacjaEntitie db = new RekrutacjaEntitie();
            foreach (klient k in db.klient)
                {
                if (k.branza_id == index)
                {
                    return true;
                }
            }

            return false;
            
        }

        private void refresh()
        {
            RekrutacjaEntitie re = new RekrutacjaEntitie();
            industry_comboBox.Items.Clear();
            foreach (branza br in re.branza.ToArray())
            {
                industry_comboBox.Items.Add(br.nazwa);
            }

            Edit_button.Enabled = false;
            Delete_button.Enabled = false;
        }
    }
}
