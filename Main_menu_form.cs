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
    public partial class Main_menu_form : Form
    {
        public Main_menu_form()
        {
            InitializeComponent();


            RekrutacjaEntitie db = new RekrutacjaEntitie();

            dataGridView1.DataSource = db.select_branza.ToList();

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client_form form = new Client_form();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Industry_Form form = new Industry_Form();
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            RekrutacjaEntitie db = new RekrutacjaEntitie();
            dataGridView1.ClearSelection();
            dataGridView1.DataSource = db.select_branza.ToList();
        }
    }
}
