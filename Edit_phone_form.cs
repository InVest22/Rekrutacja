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
    public partial class Edit_phone_form : Form
    {
        
        public Edit_phone_form()
        {
            InitializeComponent();
            RekrutacjaEntitie db = new RekrutacjaEntitie();
            phone_GridView.DataSource = db.select_number.ToList();

            edit_button.Enabled = false;
            add_button.Enabled = false;
            textBox_phone.MaxLength = 9;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int number;
            edit_button.Enabled = (textBox_phone.Text.Length == 9 && int.TryParse(textBox_phone.Text, out number));
            add_button.Enabled = (textBox_phone.Text.Length == 9 && int.TryParse(textBox_phone.Text, out number));

        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            if (phone_GridView.SelectedRows.Count > 0)
            {
                var tmp = phone_GridView.SelectedRows[0].DataBoundItem as select_number;
                if (tmp.ID != null)
                {
                    using (var context = new RekrutacjaEntitie())
                    {
                        var br = context.telefon.Find(tmp.ID);
                        br.numer = int.Parse(textBox_phone.Text);
                        context.telefon.Add(br);
                        context.telefon.Attach(br);
                        context.Entry(br).State = EntityState.Modified;
                        context.SaveChanges();

                    }
                }
            }

            refresh();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            
            if (phone_GridView.SelectedRows.Count > 0 )
            {
                var tmp = phone_GridView.SelectedRows[0].DataBoundItem as select_number;

                if (tmp.Numer != null)
                {
                    using (var context = new RekrutacjaEntitie())
                    {
                        var br = context.telefon.Find(tmp.ID);
                        context.telefon.Attach(br);
                        context.telefon.Remove(br);
                        context.SaveChanges();
                    }
                }


            }
            refresh();
        }

      

        private void add_button_phone_Click(object sender, EventArgs e)
        {
            if (phone_GridView.SelectedRows.Count > 0)
            {
                var tmp = phone_GridView.SelectedRows[0].DataBoundItem as select_number;

                using (var context = new RekrutacjaEntitie())
                {
                    var br = new telefon { id = check_value(), numer = int.Parse(textBox_phone.Text), klient_id = tmp.ID};
                    context.telefon.Add(br);
                    context.SaveChanges();
                }
            }

            refresh();
        }

        private int check_value()
        {
            RekrutacjaEntitie db = new RekrutacjaEntitie();
            int index = 1;

            foreach (telefon b in db.telefon)
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
        private void refresh()
        {
            RekrutacjaEntitie phone = new RekrutacjaEntitie();
            phone_GridView.ClearSelection();
            phone_GridView.DataSource = phone.select_number.ToList();
        }
    }  
}
