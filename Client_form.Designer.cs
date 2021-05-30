
namespace Rekrutacja
{
    partial class Client_form
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
            this.client_view = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.addClient_button = new System.Windows.Forms.Button();
            this.phone_edit_button = new System.Windows.Forms.Button();
            this.button_email = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.client_view)).BeginInit();
            this.SuspendLayout();
            // 
            // client_view
            // 
            this.client_view.AllowDrop = true;
            this.client_view.AllowUserToAddRows = false;
            this.client_view.AllowUserToDeleteRows = false;
            this.client_view.AllowUserToResizeRows = false;
            this.client_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.client_view.Location = new System.Drawing.Point(12, 41);
            this.client_view.MultiSelect = false;
            this.client_view.Name = "client_view";
            this.client_view.Size = new System.Drawing.Size(769, 261);
            this.client_view.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Edytuj klienta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Edit_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(202, 12);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(92, 23);
            this.delete_button.TabIndex = 2;
            this.delete_button.Text = "Usuń klienta";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // addClient_button
            // 
            this.addClient_button.Location = new System.Drawing.Point(12, 12);
            this.addClient_button.Name = "addClient_button";
            this.addClient_button.Size = new System.Drawing.Size(88, 23);
            this.addClient_button.TabIndex = 3;
            this.addClient_button.Text = "Dodaj klienta";
            this.addClient_button.UseVisualStyleBackColor = true;
            this.addClient_button.Click += new System.EventHandler(this.addClient_button_Click);
            // 
            // phone_edit_button
            // 
            this.phone_edit_button.Location = new System.Drawing.Point(301, 12);
            this.phone_edit_button.Name = "phone_edit_button";
            this.phone_edit_button.Size = new System.Drawing.Size(80, 23);
            this.phone_edit_button.TabIndex = 4;
            this.phone_edit_button.Text = "Edytuj telefon";
            this.phone_edit_button.UseVisualStyleBackColor = true;
            this.phone_edit_button.Click += new System.EventHandler(this.phone_edit_button_Click);
            // 
            // button_email
            // 
            this.button_email.Location = new System.Drawing.Point(387, 12);
            this.button_email.Name = "button_email";
            this.button_email.Size = new System.Drawing.Size(80, 23);
            this.button_email.TabIndex = 5;
            this.button_email.Text = "Edytuj email";
            this.button_email.UseVisualStyleBackColor = true;
            this.button_email.Click += new System.EventHandler(this.button_email_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(473, 12);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(75, 23);
            this.button_refresh.TabIndex = 6;
            this.button_refresh.Text = "Odswiez";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // Client_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 314);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.button_email);
            this.Controls.Add(this.phone_edit_button);
            this.Controls.Add(this.addClient_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.client_view);
            this.MaximizeBox = false;
            this.Name = "Client_form";
            this.Text = "Edit_client";
            ((System.ComponentModel.ISupportInitialize)(this.client_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView client_view;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button addClient_button;
        private System.Windows.Forms.Button phone_edit_button;
        private System.Windows.Forms.Button button_email;
        private System.Windows.Forms.Button button_refresh;
    }
}