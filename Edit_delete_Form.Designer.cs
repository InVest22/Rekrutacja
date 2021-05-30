
namespace Rekrutacja
{
    partial class Edit_delete_Form
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
            this.industry_comboBox = new System.Windows.Forms.ComboBox();
            this.Industry_textBox = new System.Windows.Forms.TextBox();
            this.Edit_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // industry_comboBox
            // 
            this.industry_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.industry_comboBox.FormattingEnabled = true;
            this.industry_comboBox.Location = new System.Drawing.Point(22, 42);
            this.industry_comboBox.Name = "industry_comboBox";
            this.industry_comboBox.Size = new System.Drawing.Size(121, 21);
            this.industry_comboBox.TabIndex = 0;
            this.industry_comboBox.SelectedIndexChanged += new System.EventHandler(this.industry_comboBox_SelectedIndexChanged);
            // 
            // Industry_textBox
            // 
            this.Industry_textBox.Location = new System.Drawing.Point(179, 42);
            this.Industry_textBox.Name = "Industry_textBox";
            this.Industry_textBox.Size = new System.Drawing.Size(121, 20);
            this.Industry_textBox.TabIndex = 1;
            this.Industry_textBox.TextChanged += new System.EventHandler(this.Industry_textBox_TextChanged);
            // 
            // Edit_button
            // 
            this.Edit_button.Location = new System.Drawing.Point(22, 89);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(121, 23);
            this.Edit_button.TabIndex = 2;
            this.Edit_button.Text = "Edytuj";
            this.Edit_button.UseVisualStyleBackColor = true;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(179, 89);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(121, 23);
            this.Delete_button.TabIndex = 3;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Edit_delete_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 155);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Edit_button);
            this.Controls.Add(this.Industry_textBox);
            this.Controls.Add(this.industry_comboBox);
            this.MaximizeBox = false;
            this.Name = "Edit_delete_Form";
            this.Text = "Edit_delete_Form";
            this.Load += new System.EventHandler(this.Edit_delete_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox industry_comboBox;
        private System.Windows.Forms.TextBox Industry_textBox;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Button Delete_button;
    }
}