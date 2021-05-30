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
    public partial class email_form : Form
    {
        public email_form()
        {
            InitializeComponent();
            RekrutacjaEntitie db = new RekrutacjaEntitie();
            email_GridView.DataSource = db.select_mail.ToList();

            edit_button.Enabled = false;
            add_button.Enabled = false;

        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            if (email_GridView.SelectedRows.Count > 0)
            {
                var tmp = email_GridView.SelectedRows[0].DataBoundItem as select_mail;
                if (tmp.ID != null)
                {
                    using (var context = new RekrutacjaEntitie())
                    {
                        var br = context.email.Find(tmp.ID);
                        br.email1 = textBox_email.Text;
                        context.email.Add(br);
                        context.email.Attach(br);
                        context.Entry(br).State = EntityState.Modified;
                        context.SaveChanges();

                    }
                }
            }

            refresh();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (email_GridView.SelectedRows.Count > 0)
            {
                var tmp = email_GridView.SelectedRows[0].DataBoundItem as select_mail;

                if (tmp.ID != null)
                {
                    using (var context = new RekrutacjaEntitie())
                    {
                        var br = context.email.Find(tmp.ID);
                        context.email.Attach(br);
                        context.email.Remove(br);
                        context.SaveChanges();
                    }
                }
            }
            refresh();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (email_GridView.SelectedRows.Count > 0)
            {
                var tmp = email_GridView.SelectedRows[0].DataBoundItem as select_mail;

                using (var context = new RekrutacjaEntitie())
                {
                    var br = new email { id = check_value(), email1 = textBox_email.Text, klient_id = tmp.ID };
                    context.email.Add(br);
                    context.SaveChanges();
                }
            }

            refresh();
        }

        private void textBox_email_TextChanged(object sender, EventArgs e)
        {
            edit_button.Enabled = (!string.IsNullOrEmpty(textBox_email.Text));
            add_button.Enabled = (!string.IsNullOrEmpty(textBox_email.Text));
        }
        private int check_value()
        {
            RekrutacjaEntitie ch = new RekrutacjaEntitie();
            int index = 1;

            foreach (email b in ch.email)
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
            RekrutacjaEntitie db = new RekrutacjaEntitie();
            email_GridView.ClearSelection();
            email_GridView.DataSource = db.select_mail.ToList();
        }
    }
}
