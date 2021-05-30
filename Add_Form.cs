using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Rekrutacja
{
    public partial class Add_Form : Form
    {
        Phone_control phone_ctrl;
        email_control email_ctrl;
        
        
        bool name = false;
        bool last_name = false;
        bool industry = false;
        bool credit = false;
        bool status = false;

        



        public Add_Form()
        {
            InitializeComponent();

            RekrutacjaEntitie db = new RekrutacjaEntitie();
            

            foreach (branza br in db.branza.ToArray())
            {
                comboBox_industry.Items.Add(br.nazwa);
            }

            comboBox_status.Items.Add("Obecny");
            comboBox_status.Items.Add("Potencjalny");

            phone_ctrl = new Phone_control();
            Phone_panel.Controls.Add(phone_ctrl);

            email_ctrl = new email_control();
            email_panel.Controls.Add(email_ctrl);

            textBox_credit.MaxLength = 9;
            save_button.Enabled = false;
        }

        private void Add_Form_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Phone_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void save_button_Click(object sender, EventArgs e)
        {
            List<int> phone_numbers = new List<int>();
            List<string> emails = new List<string>();

            using (var context = new RekrutacjaEntitie())
            {
                int id_client = check_value_client();
                var br = new klient { id = id_client, imie = textBox_name.Text, nazwisko = textBox_lastname.Text, limit_kredytowy = int.Parse(textBox_credit.Text), status = comboBox_status.Text, branza_id = check_industry(comboBox_industry.Text) };
                context.klient.Add(br);
                context.SaveChanges();

                var phone_elems = phone_ctrl.Controls.OfType<TextBox>();

                if (phone_elems.Count() == 0)
                {
                    var phone = new telefon { id = check_value_email(), numer =000000000 , klient_id = id_client };
                    context.telefon.Add(phone);
                    context.SaveChanges();
                }


                foreach (Control ctrl in phone_elems)
                {
                    int number;
                    bool result = int.TryParse(ctrl.Text, out number);
                    if (ctrl.Text.Length == 9 && result == true)
                    {
                        var phone = new telefon {id = check_value_phone(), numer = int.Parse(ctrl.Text), klient_id = id_client };
                        context.telefon.Add(phone);
                        context.SaveChanges();
                    }else
                    {
                        var phone = new telefon { id = check_value_email(), numer = 000000000, klient_id = id_client };
                        context.telefon.Add(phone);
                        context.SaveChanges();
                    }
                }

                var email_elems = email_ctrl.Controls.OfType<TextBox>();

                if(email_elems.Count() == 0)
                {
                    var email = new email { id = check_value_email(), email1 = "brak", klient_id = id_client };
                    context.email.Add(email);
                    context.SaveChanges();
                }

                foreach (Control ctrl in email_elems)
                {
                    if (!string.IsNullOrEmpty(ctrl.Text))
                    {
                        var email = new email { id = check_value_email(), email1 = ctrl.Text, klient_id = id_client };
                        context.email.Add(email);
                        context.SaveChanges();
                    }
                    else
                    {
                        var email = new email { id = check_value_email(), email1 = "brak", klient_id = id_client };
                        context.email.Add(email);
                        context.SaveChanges();
                    }

                }
            }
        }

        private static int check_value_client()
        {
            RekrutacjaEntitie db = new RekrutacjaEntitie();
            int index = 1;

            foreach (klient b in db.klient)
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

        private static int check_value_phone()
        {
            RekrutacjaEntitie db = new RekrutacjaEntitie();
            int index = 1;

            foreach (telefon t in db.telefon)
            {
                if (t.id == index)
                {
                    index++;
                }
                else
                    return index;
            }
            return index;
        }
        private static int check_value_email()
        {
            RekrutacjaEntitie db = new RekrutacjaEntitie();
            int index = 1;

            foreach (email e in db.email)
            {
                if (e.id == index)
                {
                    index++;
                }
                else
                    return index;
            }
            return index;
        }

        private static int check_industry(string industry)
        {
            RekrutacjaEntitie db = new RekrutacjaEntitie();

            foreach(branza b in db.branza)
            {
                if(b.nazwa == industry)
                {
                    return b.id;
                }
            }
            return 0;
        }

        private void textBox_credit_TextChanged(object sender, EventArgs e)
        {
            decimal number;
            if(decimal.TryParse(textBox_credit.Text, out number) == false)
            {
                textBox_credit.Clear();
                string message = "Błędna wartość.";
                MessageBox.Show(message);
            }

            credit = check(textBox_credit);

            is_enabled();

        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {
            name = check(textBox_name);

            is_enabled();
        }

        private void textBox_lastname_TextChanged(object sender, EventArgs e)
        {

         last_name = check(textBox_lastname);

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
            save_button.Enabled = (name == true && last_name == true && industry == true && credit == true && status == true);
        }
    }
}
