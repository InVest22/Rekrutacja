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
    public partial class Client_form : Form
    {

        public Client_form()
        {
            
            InitializeComponent();
            RekrutacjaEntitie db = new RekrutacjaEntitie();
            client_view.DataSource = db.select_klient.ToList();


            client_view.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            client_view.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            client_view.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (client_view.SelectedRows.Count > 0)
            {
                var tmp = client_view.SelectedRows[0].DataBoundItem as select_klient;
                Edit_Form form = new Edit_Form(tmp);
                form.Show();
            }

        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (client_view.SelectedRows.Count > 0)
            {
                var tmp = client_view.SelectedRows[0].DataBoundItem as select_klient;

                RekrutacjaEntitie db = new RekrutacjaEntitie();

                foreach (telefon t in db.telefon)
                {
                    if (t.klient_id == tmp.ID)
                        Delete_numbers(t.id);
                }


                foreach (email email in db.email)
                {
                    if (email.klient_id == tmp.ID)
                        Delete_email(email.id);
                }

                Delete_client(tmp.ID);

                refresh();
            }
        }

        private void addClient_button_Click(object sender, EventArgs e)
        {
            Add_Form form = new Add_Form();
            form.Show();

        }

        private void phone_edit_button_Click(object sender, EventArgs e)
        {

            Edit_phone_form form = new Edit_phone_form();
            form.Show();

        }

        private void Delete_numbers(int id)
        {
            using (var context = new RekrutacjaEntitie())
            {
                var br = context.telefon.Find(id);
                context.telefon.Attach(br);
                context.telefon.Remove(br);
                context.SaveChanges();
            }

        }

        private void Delete_email(int id_mail)
        {

            using (var context = new RekrutacjaEntitie())
            {
                var br = context.email.Find(id_mail);
                context.email.Attach(br);
                context.email.Remove(br);
                context.SaveChanges();
            }
        }

        private void Delete_client(int id)
        {
            using (var context = new RekrutacjaEntitie())
            {
                var br = context.klient.Find(id);
                context.klient.Attach(br);
                context.klient.Remove(br);
                context.SaveChanges();
            }
        }

        private void refresh()
        {
            RekrutacjaEntitie db = new RekrutacjaEntitie();
            client_view.ClearSelection();
            client_view.DataSource = db.select_klient.ToList();
        }

        private void button_email_Click(object sender, EventArgs e)
        {
            email_form form = new email_form();
            form.Show();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
