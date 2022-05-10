
namespace WinFormsApp1Entornos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.b_Save = new System.Windows.Forms.Button();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.tListaSocios = new System.Windows.Forms.TextBox();
            this.tTelefono = new System.Windows.Forms.TextBox();
            this.tApellidos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_Save
            // 
            this.b_Save.Location = new System.Drawing.Point(707, 117);
            this.b_Save.Name = "b_Save";
            this.b_Save.Size = new System.Drawing.Size(176, 56);
            this.b_Save.TabIndex = 0;
            this.b_Save.Text = "Guardar";
            this.b_Save.UseVisualStyleBackColor = true;
            this.b_Save.Click += new System.EventHandler(this.button1_Click);
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(86, 34);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(189, 27);
            this.tNombre.TabIndex = 1;
            // 
            // tListaSocios
            // 
            this.tListaSocios.Location = new System.Drawing.Point(63, 117);
            this.tListaSocios.Multiline = true;
            this.tListaSocios.Name = "tListaSocios";
            this.tListaSocios.ReadOnly = true;
            this.tListaSocios.Size = new System.Drawing.Size(589, 279);
            this.tListaSocios.TabIndex = 2;
            // 
            // tTelefono
            // 
            this.tTelefono.Location = new System.Drawing.Point(707, 37);
            this.tTelefono.Name = "tTelefono";
            this.tTelefono.Size = new System.Drawing.Size(189, 27);
            this.tTelefono.TabIndex = 3;
            // 
            // tApellidos
            // 
            this.tApellidos.Location = new System.Drawing.Point(393, 34);
            this.tApellidos.Name = "tApellidos";
            this.tApellidos.Size = new System.Drawing.Size(189, 27);
            this.tApellidos.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(638, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Movil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Apellidos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tApellidos);
            this.Controls.Add(this.tTelefono);
            this.Controls.Add(this.tListaSocios);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.b_Save);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_Save;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.TextBox tListaSocios;
        private System.Windows.Forms.TextBox tTelefono;
        private System.Windows.Forms.TextBox tApellidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

