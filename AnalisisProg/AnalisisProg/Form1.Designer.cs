namespace AnalisisProg
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.gbRegistros = new System.Windows.Forms.GroupBox();
            this.lbOrdenadosMerge = new System.Windows.Forms.ListBox();
            this.lbOrdenados = new System.Windows.Forms.ListBox();
            this.lbDatos = new System.Windows.Forms.ListBox();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblFin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCantidadRegistros = new System.Windows.Forms.TextBox();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblInicio1 = new System.Windows.Forms.Label();
            this.lblFin1 = new System.Windows.Forms.Label();
            this.lblDuracion1 = new System.Windows.Forms.Label();
            this.btnOrdenarMergeSort = new System.Windows.Forms.Button();
            this.lblDuracion2 = new System.Windows.Forms.Label();
            this.lblFin2 = new System.Windows.Forms.Label();
            this.lblInicio2 = new System.Windows.Forms.Label();
            this.lblDuracion4 = new System.Windows.Forms.Label();
            this.lblFin4 = new System.Windows.Forms.Label();
            this.lblInicio4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBusquedaInterpolada = new System.Windows.Forms.Button();
            this.btnJumpSearch = new System.Windows.Forms.Button();
            this.tbTextoBuscar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbRegistros.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(36, 167);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(6);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(288, 121);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar numeros";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(356, 167);
            this.btnOrdenar.Margin = new System.Windows.Forms.Padding(6);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(276, 121);
            this.btnOrdenar.TabIndex = 1;
            this.btnOrdenar.Text = "Ordenar (Selection sort)";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // gbRegistros
            // 
            this.gbRegistros.Controls.Add(this.lbOrdenadosMerge);
            this.gbRegistros.Controls.Add(this.lbOrdenados);
            this.gbRegistros.Controls.Add(this.lbDatos);
            this.gbRegistros.Location = new System.Drawing.Point(14, 321);
            this.gbRegistros.Margin = new System.Windows.Forms.Padding(6);
            this.gbRegistros.Name = "gbRegistros";
            this.gbRegistros.Padding = new System.Windows.Forms.Padding(6);
            this.gbRegistros.Size = new System.Drawing.Size(1583, 490);
            this.gbRegistros.TabIndex = 2;
            this.gbRegistros.TabStop = false;
            this.gbRegistros.Text = "Registros: 0";
            this.gbRegistros.Enter += new System.EventHandler(this.gbRegistros_Enter);
            // 
            // lbOrdenadosMerge
            // 
            this.lbOrdenadosMerge.FormattingEnabled = true;
            this.lbOrdenadosMerge.ItemHeight = 25;
            this.lbOrdenadosMerge.Location = new System.Drawing.Point(626, 36);
            this.lbOrdenadosMerge.Margin = new System.Windows.Forms.Padding(6);
            this.lbOrdenadosMerge.Name = "lbOrdenadosMerge";
            this.lbOrdenadosMerge.Size = new System.Drawing.Size(292, 429);
            this.lbOrdenadosMerge.TabIndex = 2;
            // 
            // lbOrdenados
            // 
            this.lbOrdenados.FormattingEnabled = true;
            this.lbOrdenados.ItemHeight = 25;
            this.lbOrdenados.Location = new System.Drawing.Point(322, 37);
            this.lbOrdenados.Margin = new System.Windows.Forms.Padding(6);
            this.lbOrdenados.Name = "lbOrdenados";
            this.lbOrdenados.Size = new System.Drawing.Size(292, 429);
            this.lbOrdenados.TabIndex = 1;
            this.lbOrdenados.SelectedIndexChanged += new System.EventHandler(this.lbOrdenados_SelectedIndexChanged);
            // 
            // lbDatos
            // 
            this.lbDatos.FormattingEnabled = true;
            this.lbDatos.ItemHeight = 25;
            this.lbDatos.Location = new System.Drawing.Point(14, 38);
            this.lbDatos.Margin = new System.Windows.Forms.Padding(6);
            this.lbDatos.Name = "lbDatos";
            this.lbDatos.Size = new System.Drawing.Size(292, 429);
            this.lbDatos.TabIndex = 0;
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(14, 825);
            this.lblInicio.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(265, 25);
            this.lblInicio.TabIndex = 3;
            this.lblInicio.Text = "Tiempo de inicio: 00:00:00";
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Location = new System.Drawing.Point(14, 881);
            this.lblFin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(238, 25);
            this.lblFin.TabIndex = 4;
            this.lblFin.Text = "Tiempo de fin: 00:00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cantidad de registros";
            // 
            // tbCantidadRegistros
            // 
            this.tbCantidadRegistros.Location = new System.Drawing.Point(274, 75);
            this.tbCantidadRegistros.Margin = new System.Windows.Forms.Padding(6);
            this.tbCantidadRegistros.Name = "tbCantidadRegistros";
            this.tbCantidadRegistros.Size = new System.Drawing.Size(354, 31);
            this.tbCantidadRegistros.TabIndex = 6;
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(14, 929);
            this.lblDuracion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(237, 25);
            this.lblDuracion.TabIndex = 7;
            this.lblDuracion.Text = "Duracioón: 0 Segundos";
            // 
            // lblInicio1
            // 
            this.lblInicio1.AutoSize = true;
            this.lblInicio1.Location = new System.Drawing.Point(331, 817);
            this.lblInicio1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblInicio1.Name = "lblInicio1";
            this.lblInicio1.Size = new System.Drawing.Size(265, 25);
            this.lblInicio1.TabIndex = 8;
            this.lblInicio1.Text = "Tiempo de inicio: 00:00:00";
            // 
            // lblFin1
            // 
            this.lblFin1.AutoSize = true;
            this.lblFin1.Location = new System.Drawing.Point(331, 857);
            this.lblFin1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFin1.Name = "lblFin1";
            this.lblFin1.Size = new System.Drawing.Size(238, 25);
            this.lblFin1.TabIndex = 9;
            this.lblFin1.Text = "Tiempo de fin: 00:00:00";
            // 
            // lblDuracion1
            // 
            this.lblDuracion1.AutoSize = true;
            this.lblDuracion1.Location = new System.Drawing.Point(331, 895);
            this.lblDuracion1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDuracion1.Name = "lblDuracion1";
            this.lblDuracion1.Size = new System.Drawing.Size(237, 25);
            this.lblDuracion1.TabIndex = 10;
            this.lblDuracion1.Text = "Duracioón: 0 Segundos";
            this.lblDuracion1.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnOrdenarMergeSort
            // 
            this.btnOrdenarMergeSort.Location = new System.Drawing.Point(644, 167);
            this.btnOrdenarMergeSort.Margin = new System.Windows.Forms.Padding(6);
            this.btnOrdenarMergeSort.Name = "btnOrdenarMergeSort";
            this.btnOrdenarMergeSort.Size = new System.Drawing.Size(276, 121);
            this.btnOrdenarMergeSort.TabIndex = 11;
            this.btnOrdenarMergeSort.Text = "Ordenar (Merge sort)";
            this.btnOrdenarMergeSort.UseVisualStyleBackColor = true;
            this.btnOrdenarMergeSort.Click += new System.EventHandler(this.btnOrdenarMergeSort_Click);
            // 
            // lblDuracion2
            // 
            this.lblDuracion2.AutoSize = true;
            this.lblDuracion2.Location = new System.Drawing.Point(649, 895);
            this.lblDuracion2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDuracion2.Name = "lblDuracion2";
            this.lblDuracion2.Size = new System.Drawing.Size(237, 25);
            this.lblDuracion2.TabIndex = 16;
            this.lblDuracion2.Text = "Duracioón: 0 Segundos";
            // 
            // lblFin2
            // 
            this.lblFin2.AutoSize = true;
            this.lblFin2.Location = new System.Drawing.Point(649, 857);
            this.lblFin2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFin2.Name = "lblFin2";
            this.lblFin2.Size = new System.Drawing.Size(238, 25);
            this.lblFin2.TabIndex = 15;
            this.lblFin2.Text = "Tiempo de fin: 00:00:00";
            // 
            // lblInicio2
            // 
            this.lblInicio2.AutoSize = true;
            this.lblInicio2.Location = new System.Drawing.Point(649, 817);
            this.lblInicio2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblInicio2.Name = "lblInicio2";
            this.lblInicio2.Size = new System.Drawing.Size(265, 25);
            this.lblInicio2.TabIndex = 14;
            this.lblInicio2.Text = "Tiempo de inicio: 00:00:00";
            // 
            // lblDuracion4
            // 
            this.lblDuracion4.AutoSize = true;
            this.lblDuracion4.Location = new System.Drawing.Point(955, 895);
            this.lblDuracion4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDuracion4.Name = "lblDuracion4";
            this.lblDuracion4.Size = new System.Drawing.Size(237, 25);
            this.lblDuracion4.TabIndex = 19;
            this.lblDuracion4.Text = "Duracioón: 0 Segundos";
            // 
            // lblFin4
            // 
            this.lblFin4.AutoSize = true;
            this.lblFin4.Location = new System.Drawing.Point(955, 857);
            this.lblFin4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFin4.Name = "lblFin4";
            this.lblFin4.Size = new System.Drawing.Size(238, 25);
            this.lblFin4.TabIndex = 18;
            this.lblFin4.Text = "Tiempo de fin: 00:00:00";
            // 
            // lblInicio4
            // 
            this.lblInicio4.AutoSize = true;
            this.lblInicio4.Location = new System.Drawing.Point(955, 817);
            this.lblInicio4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblInicio4.Name = "lblInicio4";
            this.lblInicio4.Size = new System.Drawing.Size(265, 25);
            this.lblInicio4.TabIndex = 17;
            this.lblInicio4.Text = "Tiempo de inicio: 00:00:00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1259, 895);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Duracioón: 0 Segundos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1259, 857);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Tiempo de fin: 00:00:00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1259, 817);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(265, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Tiempo de inicio: 00:00:00";
            // 
            // btnBusquedaInterpolada
            // 
            this.btnBusquedaInterpolada.Location = new System.Drawing.Point(1248, 167);
            this.btnBusquedaInterpolada.Margin = new System.Windows.Forms.Padding(6);
            this.btnBusquedaInterpolada.Name = "btnBusquedaInterpolada";
            this.btnBusquedaInterpolada.Size = new System.Drawing.Size(276, 121);
            this.btnBusquedaInterpolada.TabIndex = 13;
            this.btnBusquedaInterpolada.Text = "Busqueda Interpolada";
            this.btnBusquedaInterpolada.UseVisualStyleBackColor = true;
            this.btnBusquedaInterpolada.Click += new System.EventHandler(this.btnBusquedaInterpolada_Click);
            // 
            // btnJumpSearch
            // 
            this.btnJumpSearch.Location = new System.Drawing.Point(944, 167);
            this.btnJumpSearch.Margin = new System.Windows.Forms.Padding(6);
            this.btnJumpSearch.Name = "btnJumpSearch";
            this.btnJumpSearch.Size = new System.Drawing.Size(276, 121);
            this.btnJumpSearch.TabIndex = 12;
            this.btnJumpSearch.Text = "Busqueda por saltos (Jump Search)";
            this.btnJumpSearch.UseVisualStyleBackColor = true;
            this.btnJumpSearch.Click += new System.EventHandler(this.btnJumpSearch_Click_1);
            // 
            // tbTextoBuscar
            // 
            this.tbTextoBuscar.Location = new System.Drawing.Point(1018, 81);
            this.tbTextoBuscar.Margin = new System.Windows.Forms.Padding(6);
            this.tbTextoBuscar.Name = "tbTextoBuscar";
            this.tbTextoBuscar.Size = new System.Drawing.Size(354, 31);
            this.tbTextoBuscar.TabIndex = 23;

            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(789, 81);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = "Item a buscar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1726, 994);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbTextoBuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblDuracion4);
            this.Controls.Add(this.lblFin4);
            this.Controls.Add(this.lblInicio4);
            this.Controls.Add(this.lblDuracion2);
            this.Controls.Add(this.lblFin2);
            this.Controls.Add(this.lblInicio2);
            this.Controls.Add(this.btnBusquedaInterpolada);
            this.Controls.Add(this.btnJumpSearch);
            this.Controls.Add(this.btnOrdenarMergeSort);
            this.Controls.Add(this.lblDuracion1);
            this.Controls.Add(this.lblFin1);
            this.Controls.Add(this.lblInicio1);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.tbCantidadRegistros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFin);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.gbRegistros);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnGenerar);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbRegistros.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.GroupBox gbRegistros;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCantidadRegistros;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.ListBox lbDatos;
        private System.Windows.Forms.ListBox lbOrdenados;
        private System.Windows.Forms.Label lblInicio1;
        private System.Windows.Forms.Label lblFin1;
        private System.Windows.Forms.Label lblDuracion1;
        private System.Windows.Forms.ListBox lbOrdenadosMerge;
        private System.Windows.Forms.Button btnOrdenarMergeSort;
        private System.Windows.Forms.Label lblDuracion2;
        private System.Windows.Forms.Label lblFin2;
        private System.Windows.Forms.Label lblInicio2;
        private System.Windows.Forms.Label lblDuracion4;
        private System.Windows.Forms.Label lblFin4;
        private System.Windows.Forms.Label lblInicio4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBusquedaInterpolada;
        private System.Windows.Forms.Button btnJumpSearch;
        private System.Windows.Forms.TextBox tbTextoBuscar;
        private System.Windows.Forms.Label label8;
    }
}

