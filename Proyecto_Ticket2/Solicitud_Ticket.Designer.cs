
namespace Proyecto_Ticket2
{
    partial class Solicitud_Ticket
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
            this.btn_Enviar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtxt_Descripcion = new System.Windows.Forms.RichTextBox();
            this.txt_Asunto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbx_Categoria = new System.Windows.Forms.ComboBox();
            this.rbt_Exterior = new System.Windows.Forms.RadioButton();
            this.rbt_Interno = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Correo = new System.Windows.Forms.TextBox();
            this.txt_Department = new System.Windows.Forms.TextBox();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Enviar
            // 
            this.btn_Enviar.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Enviar.FlatAppearance.BorderSize = 0;
            this.btn_Enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Enviar.Font = new System.Drawing.Font("Lato Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enviar.Location = new System.Drawing.Point(212, 626);
            this.btn_Enviar.Name = "btn_Enviar";
            this.btn_Enviar.Size = new System.Drawing.Size(134, 42);
            this.btn_Enviar.TabIndex = 12;
            this.btn_Enviar.Text = "Enviar";
            this.btn_Enviar.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rtxt_Descripcion);
            this.groupBox2.Controls.Add(this.txt_Asunto);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbx_Categoria);
            this.groupBox2.Controls.Add(this.rbt_Exterior);
            this.groupBox2.Controls.Add(this.rbt_Interno);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Lato Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(43, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 334);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Solicitud";
            // 
            // rtxt_Descripcion
            // 
            this.rtxt_Descripcion.Location = new System.Drawing.Point(139, 186);
            this.rtxt_Descripcion.Name = "rtxt_Descripcion";
            this.rtxt_Descripcion.Size = new System.Drawing.Size(306, 119);
            this.rtxt_Descripcion.TabIndex = 11;
            this.rtxt_Descripcion.Text = "";
            // 
            // txt_Asunto
            // 
            this.txt_Asunto.Location = new System.Drawing.Point(139, 132);
            this.txt_Asunto.Name = "txt_Asunto";
            this.txt_Asunto.Size = new System.Drawing.Size(263, 27);
            this.txt_Asunto.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Descripción";
            // 
            // cbx_Categoria
            // 
            this.cbx_Categoria.FormattingEnabled = true;
            this.cbx_Categoria.Location = new System.Drawing.Point(139, 78);
            this.cbx_Categoria.Name = "cbx_Categoria";
            this.cbx_Categoria.Size = new System.Drawing.Size(293, 28);
            this.cbx_Categoria.TabIndex = 8;
            // 
            // rbt_Exterior
            // 
            this.rbt_Exterior.AutoSize = true;
            this.rbt_Exterior.Location = new System.Drawing.Point(263, 26);
            this.rbt_Exterior.Name = "rbt_Exterior";
            this.rbt_Exterior.Size = new System.Drawing.Size(139, 24);
            this.rbt_Exterior.TabIndex = 7;
            this.rbt_Exterior.TabStop = true;
            this.rbt_Exterior.Text = "Servicio Exterior";
            this.rbt_Exterior.UseVisualStyleBackColor = true;
            // 
            // rbt_Interno
            // 
            this.rbt_Interno.AutoSize = true;
            this.rbt_Interno.Location = new System.Drawing.Point(94, 26);
            this.rbt_Interno.Name = "rbt_Interno";
            this.rbt_Interno.Size = new System.Drawing.Size(136, 24);
            this.rbt_Interno.TabIndex = 6;
            this.rbt_Interno.TabStop = true;
            this.rbt_Interno.Text = "Servicio Interno";
            this.rbt_Interno.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Categoria";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Asunto";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_Correo);
            this.groupBox1.Controls.Add(this.txt_Department);
            this.groupBox1.Controls.Add(this.txt_Usuario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Lato Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(42, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 156);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion Personal";
            // 
            // txt_Correo
            // 
            this.txt_Correo.Location = new System.Drawing.Point(132, 117);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(210, 27);
            this.txt_Correo.TabIndex = 6;
            // 
            // txt_Department
            // 
            this.txt_Department.Location = new System.Drawing.Point(132, 75);
            this.txt_Department.Name = "txt_Department";
            this.txt_Department.Size = new System.Drawing.Size(210, 27);
            this.txt_Department.TabIndex = 5;
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(132, 34);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(210, 27);
            this.txt_Usuario.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Departamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Correo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lato Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 43);
            this.label1.TabIndex = 9;
            this.label1.Text = "Solicitud para Soporte";
            // 
            // Solicitud_Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_Ticket2.Properties.Resources.FondoVertical;
            this.ClientSize = new System.Drawing.Size(548, 680);
            this.Controls.Add(this.btn_Enviar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Solicitud_Ticket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitud_Ticket";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Enviar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtxt_Descripcion;
        private System.Windows.Forms.TextBox txt_Asunto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbx_Categoria;
        private System.Windows.Forms.RadioButton rbt_Exterior;
        private System.Windows.Forms.RadioButton rbt_Interno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Correo;
        private System.Windows.Forms.TextBox txt_Department;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}