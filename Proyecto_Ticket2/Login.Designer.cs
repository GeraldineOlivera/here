
namespace Proyecto_Ticket2
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txt_Contrasena = new System.Windows.Forms.TextBox();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Acceder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Contrasena
            // 
            this.txt_Contrasena.Location = new System.Drawing.Point(602, 141);
            this.txt_Contrasena.Name = "txt_Contrasena";
            this.txt_Contrasena.Size = new System.Drawing.Size(147, 20);
            this.txt_Contrasena.TabIndex = 11;
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(602, 80);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(147, 20);
            this.txt_Usuario.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lato Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(492, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lato Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(532, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Usuario";
            // 
            // btn_Acceder
            // 
            this.btn_Acceder.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Acceder.FlatAppearance.BorderSize = 0;
            this.btn_Acceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Acceder.Font = new System.Drawing.Font("Lato Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Acceder.Location = new System.Drawing.Point(573, 226);
            this.btn_Acceder.Name = "btn_Acceder";
            this.btn_Acceder.Size = new System.Drawing.Size(126, 37);
            this.btn_Acceder.TabIndex = 7;
            this.btn_Acceder.Text = "Acceder";
            this.btn_Acceder.UseVisualStyleBackColor = false;
            this.btn_Acceder.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lato Light", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(488, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 43);
            this.label1.TabIndex = 6;
            this.label1.Text = "Inicio de Sesión";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(760, 292);
            this.Controls.Add(this.txt_Contrasena);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Acceder);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Contrasena;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Acceder;
        private System.Windows.Forms.Label label1;
    }
}