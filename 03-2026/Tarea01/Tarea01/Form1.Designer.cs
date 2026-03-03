namespace Tarea01
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
            btnLeerVector = new Button();
            btnMostrarVector = new Button();
            btnSumaVector = new Button();
            btnMostrarPares = new Button();
            btnMostrarPrimeraPosicion = new Button();
            SuspendLayout();
            // 
            // btnLeerVector
            // 
            btnLeerVector.Location = new Point(106, 98);
            btnLeerVector.Name = "btnLeerVector";
            btnLeerVector.Size = new Size(228, 89);
            btnLeerVector.TabIndex = 0;
            btnLeerVector.Text = "Leer Vector";
            btnLeerVector.UseVisualStyleBackColor = true;
            btnLeerVector.Click += btnLeerVector_Click;
            // 
            // btnMostrarVector
            // 
            btnMostrarVector.Location = new Point(437, 98);
            btnMostrarVector.Name = "btnMostrarVector";
            btnMostrarVector.Size = new Size(228, 89);
            btnMostrarVector.TabIndex = 1;
            btnMostrarVector.Text = "Mostrar Vector";
            btnMostrarVector.UseVisualStyleBackColor = true;
            btnMostrarVector.Click += btnMostrarVector_Click;
            // 
            // btnSumaVector
            // 
            btnSumaVector.Location = new Point(106, 270);
            btnSumaVector.Name = "btnSumaVector";
            btnSumaVector.Size = new Size(228, 89);
            btnSumaVector.TabIndex = 2;
            btnSumaVector.Text = "Mostrar Suma Vector";
            btnSumaVector.UseVisualStyleBackColor = true;
            btnSumaVector.Click += btnSumaVector_Click;
            // 
            // btnMostrarPares
            // 
            btnMostrarPares.Location = new Point(437, 270);
            btnMostrarPares.Name = "btnMostrarPares";
            btnMostrarPares.Size = new Size(228, 89);
            btnMostrarPares.TabIndex = 3;
            btnMostrarPares.Text = "Mostrar Pares Vector";
            btnMostrarPares.UseVisualStyleBackColor = true;
            btnMostrarPares.Click += btnMostrarPares_Click;
            // 
            // btnMostrarPrimeraPosicion
            // 
            btnMostrarPrimeraPosicion.Location = new Point(106, 439);
            btnMostrarPrimeraPosicion.Name = "btnMostrarPrimeraPosicion";
            btnMostrarPrimeraPosicion.Size = new Size(228, 89);
            btnMostrarPrimeraPosicion.TabIndex = 4;
            btnMostrarPrimeraPosicion.Text = "Mostrar Primera Posición Valor";
            btnMostrarPrimeraPosicion.UseVisualStyleBackColor = true;
            btnMostrarPrimeraPosicion.Click += btnMostrarPrimeraPosicion_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 744);
            Controls.Add(btnMostrarPrimeraPosicion);
            Controls.Add(btnMostrarPares);
            Controls.Add(btnSumaVector);
            Controls.Add(btnMostrarVector);
            Controls.Add(btnLeerVector);
            Name = "Form1";
            Text = "Tarea 1 - Vectores";
            ResumeLayout(false);
        }

        #endregion

        private Button btnLeerVector;
        private Button btnMostrarVector;
        private Button btnSumaVector;
        private Button btnMostrarPares;
        private Button btnMostrarPrimeraPosicion;
    }
}
