
namespace VeterinarioBasico
{
    partial class VentanaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaLogin));
            this.boton_Entrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.Contraseña = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // boton_Entrar
            // 
            this.boton_Entrar.BackColor = System.Drawing.Color.Turquoise;
            this.boton_Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_Entrar.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_Entrar.Location = new System.Drawing.Point(133, 226);
            this.boton_Entrar.Name = "boton_Entrar";
            this.boton_Entrar.Size = new System.Drawing.Size(171, 55);
            this.boton_Entrar.TabIndex = 4;
            this.boton_Entrar.Text = "ENTRAR";
            this.boton_Entrar.UseVisualStyleBackColor = false;
            this.boton_Entrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(130, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "¿Olvidó su contraseña?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Turquoise;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(133, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 59);
            this.button2.TabIndex = 6;
            this.button2.Text = "REGISTRARME";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 90);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox1.Location = new System.Drawing.Point(241, 187);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(70, 18);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Mostrar";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Usuario
            // 
            this.Usuario.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Usuario.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Usuario.Location = new System.Drawing.Point(140, 82);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(171, 22);
            this.Usuario.TabIndex = 9;
            this.Usuario.Text = "Ingrese su usuario";
            this.Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Contraseña
            // 
            this.Contraseña.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Contraseña.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contraseña.Location = new System.Drawing.Point(140, 152);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(171, 22);
            this.Contraseña.TabIndex = 10;
            this.Contraseña.Text = "Ingrese su contraseña";
            this.Contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // VentanaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(378, 426);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boton_Entrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "VentanaLogin";
            this.Text = "VentanaLogin";
            this.Load += new System.EventHandler(this.VentanaLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button boton_Entrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.TextBox Contraseña;
    }
}