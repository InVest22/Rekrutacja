
namespace Rekrutacja
{
    partial class email_control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.email_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // email_button
            // 
            this.email_button.Location = new System.Drawing.Point(3, 3);
            this.email_button.Name = "email_button";
            this.email_button.Size = new System.Drawing.Size(75, 23);
            this.email_button.TabIndex = 0;
            this.email_button.Text = "Dodaj";
            this.email_button.UseVisualStyleBackColor = true;
            this.email_button.Click += new System.EventHandler(this.email_button_Click);
            // 
            // email_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.email_button);
            this.Name = "email_control";
            this.Size = new System.Drawing.Size(208, 150);
            this.Load += new System.EventHandler(this.email_control_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button email_button;
    }
}
