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
    public partial class Phone_control : UserControl
    {
        int i = 1;
        public Phone_control()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var number = new TextBox();
            number.MaxLength = 9;
            number.Top = i * 27;
            number.Left = 3 ;
            this.Controls.Add(number);
            i++;
            if (i == 5)
                button1.Enabled = false;
        }

        private void Phone_control_Load(object sender, EventArgs e)
        {

        }
    }
}
