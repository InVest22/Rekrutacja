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
    public partial class email_control : UserControl
    {
        int i = 1;
        public email_control()
        {
            InitializeComponent();
        }

        private void email_button_Click(object sender, EventArgs e)
        {
            var number = new TextBox();
            number.Top = i * 27;
            number.Left = 3;
            this.Controls.Add(number);
            i++;
            if (i == 5)
                email_button.Enabled = false;
        }

        private void email_control_Load(object sender, EventArgs e)
        {
        }
    }
}
