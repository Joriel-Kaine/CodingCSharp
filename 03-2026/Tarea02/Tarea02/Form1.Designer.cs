namespace Tarea02
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
            btnLeerLibro = new Button();
            btnEliminarPorTitulo = new Button();
            btnEliminarPorPosicion = new Button();
            btnMostrarTodo = new Button();
            btnMostrarTitulos = new Button();
            btnAddValoracion = new Button();
            btnMejorMedia = new Button();
            btnOrdenarPorTitulo = new Button();
            OrdenarPorMedia = new Button();
            SuspendLayout();
            // 
            // btnLeerLibro
            // 
            btnLeerLibro.Location = new Point(70, 102);
            btnLeerLibro.Name = "btnLeerLibro";
            btnLeerLibro.Size = new Size(340, 100);
            btnLeerLibro.TabIndex = 0;
            btnLeerLibro.Text = "AddLibro";
            btnLeerLibro.UseVisualStyleBackColor = true;
            // 
            // btnEliminarPorTitulo
            // 
            btnEliminarPorTitulo.Location = new Point(478, 102);
            btnEliminarPorTitulo.Name = "btnEliminarPorTitulo";
            btnEliminarPorTitulo.Size = new Size(340, 100);
            btnEliminarPorTitulo.TabIndex = 1;
            btnEliminarPorTitulo.Text = "Eliminar por título";
            btnEliminarPorTitulo.UseVisualStyleBackColor = true;
            // 
            // btnEliminarPorPosicion
            // 
            btnEliminarPorPosicion.Location = new Point(70, 264);
            btnEliminarPorPosicion.Name = "btnEliminarPorPosicion";
            btnEliminarPorPosicion.Size = new Size(340, 100);
            btnEliminarPorPosicion.TabIndex = 2;
            btnEliminarPorPosicion.Text = "Eliminar por posicion";
            btnEliminarPorPosicion.UseVisualStyleBackColor = true;
            // 
            // btnMostrarTodo
            // 
            btnMostrarTodo.Location = new Point(478, 264);
            btnMostrarTodo.Name = "btnMostrarTodo";
            btnMostrarTodo.Size = new Size(340, 100);
            btnMostrarTodo.TabIndex = 3;
            btnMostrarTodo.Text = "Mostrar todo";
            btnMostrarTodo.UseVisualStyleBackColor = true;
            // 
            // btnMostrarTitulos
            // 
            btnMostrarTitulos.Location = new Point(70, 427);
            btnMostrarTitulos.Name = "btnMostrarTitulos";
            btnMostrarTitulos.Size = new Size(340, 100);
            btnMostrarTitulos.TabIndex = 4;
            btnMostrarTitulos.Text = "Mostrar títulos";
            btnMostrarTitulos.UseVisualStyleBackColor = true;
            // 
            // btnAddValoracion
            // 
            btnAddValoracion.Location = new Point(478, 427);
            btnAddValoracion.Name = "btnAddValoracion";
            btnAddValoracion.Size = new Size(340, 100);
            btnAddValoracion.TabIndex = 5;
            btnAddValoracion.Text = "Añadir Valoración Libro";
            btnAddValoracion.UseVisualStyleBackColor = true;
            // 
            // btnMejorMedia
            // 
            btnMejorMedia.Location = new Point(70, 582);
            btnMejorMedia.Name = "btnMejorMedia";
            btnMejorMedia.Size = new Size(340, 100);
            btnMejorMedia.TabIndex = 6;
            btnMejorMedia.Text = "Libro con mejor media";
            btnMejorMedia.UseVisualStyleBackColor = true;
            // 
            // btnOrdenarPorTitulo
            // 
            btnOrdenarPorTitulo.Location = new Point(478, 582);
            btnOrdenarPorTitulo.Name = "btnOrdenarPorTitulo";
            btnOrdenarPorTitulo.Size = new Size(340, 100);
            btnOrdenarPorTitulo.TabIndex = 7;
            btnOrdenarPorTitulo.Text = "Ordenar por título";
            btnOrdenarPorTitulo.UseVisualStyleBackColor = true;
            // 
            // OrdenarPorMedia
            // 
            OrdenarPorMedia.Location = new Point(70, 736);
            OrdenarPorMedia.Name = "OrdenarPorMedia";
            OrdenarPorMedia.Size = new Size(340, 100);
            OrdenarPorMedia.TabIndex = 8;
            OrdenarPorMedia.Text = "Ordenar por valoración media";
            OrdenarPorMedia.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 944);
            Controls.Add(OrdenarPorMedia);
            Controls.Add(btnOrdenarPorTitulo);
            Controls.Add(btnMejorMedia);
            Controls.Add(btnAddValoracion);
            Controls.Add(btnMostrarTitulos);
            Controls.Add(btnMostrarTodo);
            Controls.Add(btnEliminarPorPosicion);
            Controls.Add(btnEliminarPorTitulo);
            Controls.Add(btnLeerLibro);
            Name = "Form1";
            Text = "Tarea 2 - POO";
            ResumeLayout(false);
        }

        #endregion

        private Button btnLeerLibro;
        private Button btnEliminarPorTitulo;
        private Button btnEliminarPorPosicion;
        private Button btnMostrarTodo;
        private Button btnMostrarTitulos;
        private Button btnAddValoracion;
        private Button btnMejorMedia;
        private Button btnOrdenarPorTitulo;
        private Button OrdenarPorMedia;
    }
}
