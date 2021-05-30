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
    public partial class Industry_Form : Form
    {
        public Industry_Form()
        {
            InitializeComponent();
            RekrutacjaEntitie industry = new RekrutacjaEntitie();
            dataGridView1.DataSource = industry.branza.ToList();

            Add_button.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            using (var context = new RekrutacjaEntitie())
            {
                var br = new branza { id = check_value(), nazwa = add_indystry_textbox.Text };
                context.branza.Add(br);
                context.SaveChanges();
            }

            RekrutacjaEntitie db = new RekrutacjaEntitie();
            dataGridView1.DataSource = db.branza.ToList();

        }

        private void add_indystry_textbox_TextChanged(object sender, EventArgs e)
        {
            if (add_indystry_textbox.Text != null && !string.IsNullOrWhiteSpace(add_indystry_textbox.Text))
            {
                Add_button.Enabled = true;
            }
            else
                Add_button.Enabled = false;
        }

        private static int check_value()
        {
            RekrutacjaEntitie db = new RekrutacjaEntitie();
            int index = 1;

            foreach (branza b in db.branza)
            {
                if (b.id == index)
                {
                    index++;
                }
                else
                    return index;
            }
            return index;
        }

        private void Delete_industry_button_Click(object sender, EventArgs e)
        {
            
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            Edit_delete_Form form = new Edit_delete_Form();
            form.Show();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            RekrutacjaEntitie db = new RekrutacjaEntitie();
            dataGridView1.ClearSelection();
            dataGridView1.DataSource = db.branza.ToList();
        }
    }
}
