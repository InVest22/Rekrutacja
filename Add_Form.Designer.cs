
namespace Rekrutacja
{
    partial class Add_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_lastname = new System.Windows.Forms.TextBox();
            this.textBox_credit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_status = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.comboBox_industry = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Phone_panel = new System.Windows.Forms.Panel();
            this.save_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.email_panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(220, 43);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(120, 20);
            this.textBox_name.TabIndex = 0;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox_name_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Imie";
            // 
            // textBox_lastname
            // 
            this.textBox_lastname.Location = new System.Drawing.Point(220, 85);
            this.textBox_lastname.Name = "textBox_lastname";
            this.textBox_lastname.Size = new System.Drawing.Size(120, 20);
            this.textBox_lastname.TabIndex = 3;
            this.textBox_lastname.TextChanged += new System.EventHandler(this.textBox_lastname_TextChanged);
            // 
            // textBox_credit
            // 
            this.textBox_credit.Location = new System.Drawing.Point(220, 124);
            this.textBox_credit.Name = "textBox_credit";
            this.textBox_credit.Size = new System.Drawing.Size(120, 20);
            this.textBox_credit.TabIndex = 4;
            this.textBox_credit.TextChanged += new System.EventHandler(this.textBox_credit_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nazwisko";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Status";
            // 
            // comboBox_status
            // 
            this.comboBox_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_status.FormattingEnabled = true;
            this.comboBox_status.Location = new System.Drawing.Point(220, 164);
            this.comboBox_status.Name = "comboBox_status";
            this.comboBox_status.Size = new System.Drawing.Size(120, 21);
            this.comboBox_status.TabIndex = 8;
            this.comboBox_status.SelectedIndexChanged += new System.EventHandler(this.comboBox_status_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Limit kredytowy";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(39, 218);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(40, 13);
            this.label.TabIndex = 10;
            this.label.Text = "Branża";
            this.label.Click += new System.EventHandler(this.label5_Click);
            // 
            // comboBox_industry
            // 
            this.comboBox_industry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_industry.FormattingEnabled = true;
            this.comboBox_industry.Location = new System.Drawing.Point(220, 210);
            this.comboBox_industry.Name = "comboBox_industry";
            this.comboBox_industry.Size = new System.Drawing.Size(121, 21);
            this.comboBox_industry.TabIndex = 11;
            this.comboBox_industry.SelectedIndexChanged += new System.EventHandler(this.comboBox_industry_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Numer telefonu";
            // 
            // Phone_panel
            // 
            this.Phone_panel.AutoSize = true;
            this.Phone_panel.Location = new System.Drawing.Point(12, 269);
            this.Phone_panel.Name = "Phone_panel";
            this.Phone_panel.Size = new System.Drawing.Size(162, 136);
            this.Phone_panel.TabIndex = 14;
            this.Phone_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Phone_panel_Paint);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(12, 12);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 15;
            this.save_button.Text = "Zapisz";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "email";
            // 
            // email_panel
            // 
            this.email_panel.Location = new System.Drawing.Point(204, 269);
            this.email_panel.Name = "email_panel";
            this.email_panel.Size = new System.Drawing.Size(167, 136);
            this.email_panel.TabIndex = 17;
            // 
            // Add_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(383, 496);
            this.Controls.Add(this.email_panel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.Phone_panel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_industry);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_credit);
            this.Controls.Add(this.textBox_lastname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_name);
            this.MaximizeBox = false;
            this.Name = "Add_Form";
            this.Text = "Add_Form";
            this.Load += new System.EventHandler(this.Add_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_lastname;
        private System.Windows.Forms.TextBox textBox_credit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox comboBox_industry;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel Phone_panel;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel email_panel;
    }
}