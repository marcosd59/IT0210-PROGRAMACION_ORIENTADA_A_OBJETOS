namespace PROYECTO_POO
{
    partial class Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1Nombre = new System.Windows.Forms.TextBox();
            this.textBox2Apellido = new System.Windows.Forms.TextBox();
            this.textBox3Edad = new System.Windows.Forms.TextBox();
            this.textBox5Dirreccion = new System.Windows.Forms.TextBox();
            this.comboBox1Genero = new System.Windows.Forms.ComboBox();
            this.button1Insertar = new System.Windows.Forms.Button();
            this.button2Limpiar = new System.Windows.Forms.Button();
            this.button3UActual = new System.Windows.Forms.Button();
            this.button4ULista = new System.Windows.Forms.Button();
            this.button5Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Genero";
            // 
            // textBox1Nombre
            // 
            this.textBox1Nombre.Location = new System.Drawing.Point(234, 75);
            this.textBox1Nombre.Name = "textBox1Nombre";
            this.textBox1Nombre.Size = new System.Drawing.Size(246, 22);
            this.textBox1Nombre.TabIndex = 4;
            // 
            // textBox2Apellido
            // 
            this.textBox2Apellido.Location = new System.Drawing.Point(234, 148);
            this.textBox2Apellido.Name = "textBox2Apellido";
            this.textBox2Apellido.Size = new System.Drawing.Size(246, 22);
            this.textBox2Apellido.TabIndex = 5;
            // 
            // textBox3Edad
            // 
            this.textBox3Edad.Location = new System.Drawing.Point(234, 218);
            this.textBox3Edad.Name = "textBox3Edad";
            this.textBox3Edad.Size = new System.Drawing.Size(246, 22);
            this.textBox3Edad.TabIndex = 6;
            // 
            // textBox5Dirreccion
            // 
            this.textBox5Dirreccion.Location = new System.Drawing.Point(234, 278);
            this.textBox5Dirreccion.Name = "textBox5Dirreccion";
            this.textBox5Dirreccion.Size = new System.Drawing.Size(246, 22);
            this.textBox5Dirreccion.TabIndex = 8;
            // 
            // comboBox1Genero
            // 
            this.comboBox1Genero.FormattingEnabled = true;
            this.comboBox1Genero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.comboBox1Genero.Location = new System.Drawing.Point(234, 336);
            this.comboBox1Genero.Name = "comboBox1Genero";
            this.comboBox1Genero.Size = new System.Drawing.Size(246, 24);
            this.comboBox1Genero.TabIndex = 9;
            // 
            // button1Insertar
            // 
            this.button1Insertar.Location = new System.Drawing.Point(215, 398);
            this.button1Insertar.Name = "button1Insertar";
            this.button1Insertar.Size = new System.Drawing.Size(75, 23);
            this.button1Insertar.TabIndex = 10;
            this.button1Insertar.Text = "Insertar";
            this.button1Insertar.UseVisualStyleBackColor = true;
            this.button1Insertar.Click += new System.EventHandler(this.button1Insertar_Click);
            // 
            // button2Limpiar
            // 
            this.button2Limpiar.Location = new System.Drawing.Point(321, 398);
            this.button2Limpiar.Name = "button2Limpiar";
            this.button2Limpiar.Size = new System.Drawing.Size(75, 23);
            this.button2Limpiar.TabIndex = 11;
            this.button2Limpiar.Text = "Limpiar";
            this.button2Limpiar.UseVisualStyleBackColor = true;
            this.button2Limpiar.Click += new System.EventHandler(this.button2Limpiar_Click);
            // 
            // button3UActual
            // 
            this.button3UActual.Location = new System.Drawing.Point(583, 142);
            this.button3UActual.Name = "button3UActual";
            this.button3UActual.Size = new System.Drawing.Size(160, 23);
            this.button3UActual.TabIndex = 12;
            this.button3UActual.Text = "Ver Usuario Actual";
            this.button3UActual.UseVisualStyleBackColor = true;
            this.button3UActual.Click += new System.EventHandler(this.button3UActual_Click);
            // 
            // button4ULista
            // 
            this.button4ULista.Location = new System.Drawing.Point(583, 232);
            this.button4ULista.Name = "button4ULista";
            this.button4ULista.Size = new System.Drawing.Size(160, 23);
            this.button4ULista.TabIndex = 13;
            this.button4ULista.Text = "Ver Lista de Usuarios";
            this.button4ULista.UseVisualStyleBackColor = true;
            this.button4ULista.Click += new System.EventHandler(this.button4ULista_Click);
            // 
            // button5Salir
            // 
            this.button5Salir.Location = new System.Drawing.Point(429, 398);
            this.button5Salir.Name = "button5Salir";
            this.button5Salir.Size = new System.Drawing.Size(75, 23);
            this.button5Salir.TabIndex = 14;
            this.button5Salir.Text = "Salir";
            this.button5Salir.UseVisualStyleBackColor = true;
            this.button5Salir.Click += new System.EventHandler(this.button5Salir_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5Salir);
            this.Controls.Add(this.button4ULista);
            this.Controls.Add(this.button3UActual);
            this.Controls.Add(this.button2Limpiar);
            this.Controls.Add(this.button1Insertar);
            this.Controls.Add(this.comboBox1Genero);
            this.Controls.Add(this.textBox5Dirreccion);
            this.Controls.Add(this.textBox3Edad);
            this.Controls.Add(this.textBox2Apellido);
            this.Controls.Add(this.textBox1Nombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cliente";
            this.Text = "Registro Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1Nombre;
        private System.Windows.Forms.TextBox textBox2Apellido;
        private System.Windows.Forms.TextBox textBox3Edad;
        private System.Windows.Forms.TextBox textBox5Dirreccion;
        private System.Windows.Forms.ComboBox comboBox1Genero;
        private System.Windows.Forms.Button button1Insertar;
        private System.Windows.Forms.Button button2Limpiar;
        private System.Windows.Forms.Button button3UActual;
        private System.Windows.Forms.Button button4ULista;
        private System.Windows.Forms.Button button5Salir;
    }
}