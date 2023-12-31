﻿namespace MetodosOrdenamiento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblGraficoOrdenado = new System.Windows.Forms.Label();
            this.lblGraficoDesordenado = new System.Windows.Forms.Label();
            this.dgvMetodos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iteraciones1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Elementos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbResultados = new System.Windows.Forms.GroupBox();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblIteraciones = new System.Windows.Forms.Label();
            this.txtIteraciones = new System.Windows.Forms.TextBox();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.gbMetodo = new System.Windows.Forms.GroupBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.optMerge = new System.Windows.Forms.RadioButton();
            this.optQuick = new System.Windows.Forms.RadioButton();
            this.optBubble = new System.Windows.Forms.RadioButton();
            this.gbElementos = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblLongitud = new System.Windows.Forms.Label();
            this.grDesordenado = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grOrdenado = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetodos)).BeginInit();
            this.gbResultados.SuspendLayout();
            this.gbMetodo.SuspendLayout();
            this.gbElementos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDesordenado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grOrdenado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGraficoOrdenado
            // 
            this.lblGraficoOrdenado.AutoSize = true;
            this.lblGraficoOrdenado.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGraficoOrdenado.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblGraficoOrdenado.Location = new System.Drawing.Point(1081, 307);
            this.lblGraficoOrdenado.Name = "lblGraficoOrdenado";
            this.lblGraficoOrdenado.Size = new System.Drawing.Size(170, 20);
            this.lblGraficoOrdenado.TabIndex = 21;
            this.lblGraficoOrdenado.Text = "Elementos Ordenados";
            // 
            // lblGraficoDesordenado
            // 
            this.lblGraficoDesordenado.AutoSize = true;
            this.lblGraficoDesordenado.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGraficoDesordenado.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblGraficoDesordenado.Location = new System.Drawing.Point(1081, 22);
            this.lblGraficoDesordenado.Name = "lblGraficoDesordenado";
            this.lblGraficoDesordenado.Size = new System.Drawing.Size(196, 20);
            this.lblGraficoDesordenado.TabIndex = 20;
            this.lblGraficoDesordenado.Text = "Elementos Desordenados";
            // 
            // dgvMetodos
            // 
            this.dgvMetodos.AllowUserToAddRows = false;
            this.dgvMetodos.AllowUserToDeleteRows = false;
            this.dgvMetodos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMetodos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvMetodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMetodos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Iteraciones1,
            this.Tiempo,
            this.Elementos});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMetodos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvMetodos.Location = new System.Drawing.Point(378, 22);
            this.dgvMetodos.Name = "dgvMetodos";
            this.dgvMetodos.ReadOnly = true;
            this.dgvMetodos.RowHeadersWidth = 51;
            this.dgvMetodos.RowTemplate.Height = 24;
            this.dgvMetodos.Size = new System.Drawing.Size(611, 542);
            this.dgvMetodos.TabIndex = 19;
            this.dgvMetodos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMetodos_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Iteraciones1
            // 
            this.Iteraciones1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Iteraciones1.HeaderText = "Iteraciones ";
            this.Iteraciones1.MinimumWidth = 6;
            this.Iteraciones1.Name = "Iteraciones1";
            this.Iteraciones1.ReadOnly = true;
            // 
            // Tiempo
            // 
            this.Tiempo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tiempo.HeaderText = "Tiempo";
            this.Tiempo.MinimumWidth = 6;
            this.Tiempo.Name = "Tiempo";
            this.Tiempo.ReadOnly = true;
            // 
            // Elementos
            // 
            this.Elementos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Elementos.HeaderText = "Cantidad de Elementos";
            this.Elementos.MinimumWidth = 6;
            this.Elementos.Name = "Elementos";
            this.Elementos.ReadOnly = true;
            // 
            // gbResultados
            // 
            this.gbResultados.Controls.Add(this.lblTiempo);
            this.gbResultados.Controls.Add(this.lblIteraciones);
            this.gbResultados.Controls.Add(this.txtIteraciones);
            this.gbResultados.Controls.Add(this.txtTiempo);
            this.gbResultados.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResultados.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbResultados.Location = new System.Drawing.Point(20, 333);
            this.gbResultados.Name = "gbResultados";
            this.gbResultados.Size = new System.Drawing.Size(346, 121);
            this.gbResultados.TabIndex = 18;
            this.gbResultados.TabStop = false;
            this.gbResultados.Text = "Resultados";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Franklin Gothic Medium", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTiempo.Location = new System.Drawing.Point(18, 47);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(49, 17);
            this.lblTiempo.TabIndex = 8;
            this.lblTiempo.Text = "Tiempo";
            // 
            // lblIteraciones
            // 
            this.lblIteraciones.AutoSize = true;
            this.lblIteraciones.Font = new System.Drawing.Font("Franklin Gothic Medium", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIteraciones.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIteraciones.Location = new System.Drawing.Point(179, 45);
            this.lblIteraciones.Name = "lblIteraciones";
            this.lblIteraciones.Size = new System.Drawing.Size(69, 17);
            this.lblIteraciones.TabIndex = 9;
            this.lblIteraciones.Text = "Iteraciones";
            // 
            // txtIteraciones
            // 
            this.txtIteraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIteraciones.Location = new System.Drawing.Point(179, 66);
            this.txtIteraciones.Name = "txtIteraciones";
            this.txtIteraciones.ReadOnly = true;
            this.txtIteraciones.Size = new System.Drawing.Size(144, 22);
            this.txtIteraciones.TabIndex = 1;
            // 
            // txtTiempo
            // 
            this.txtTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiempo.Location = new System.Drawing.Point(16, 66);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.ReadOnly = true;
            this.txtTiempo.Size = new System.Drawing.Size(126, 22);
            this.txtTiempo.TabIndex = 0;
            // 
            // gbMetodo
            // 
            this.gbMetodo.Controls.Add(this.btnOrdenar);
            this.gbMetodo.Controls.Add(this.optMerge);
            this.gbMetodo.Controls.Add(this.optQuick);
            this.gbMetodo.Controls.Add(this.optBubble);
            this.gbMetodo.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMetodo.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbMetodo.Location = new System.Drawing.Point(20, 175);
            this.gbMetodo.Name = "gbMetodo";
            this.gbMetodo.Size = new System.Drawing.Size(346, 152);
            this.gbMetodo.TabIndex = 17;
            this.gbMetodo.TabStop = false;
            this.gbMetodo.Text = "Defina Metodo de Ordenamineto";
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnOrdenar.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOrdenar.Location = new System.Drawing.Point(224, 55);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(84, 33);
            this.btnOrdenar.TabIndex = 16;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = false;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // optMerge
            // 
            this.optMerge.AutoSize = true;
            this.optMerge.Font = new System.Drawing.Font("Franklin Gothic Medium", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optMerge.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.optMerge.Location = new System.Drawing.Point(30, 93);
            this.optMerge.Name = "optMerge";
            this.optMerge.Size = new System.Drawing.Size(89, 21);
            this.optMerge.TabIndex = 10;
            this.optMerge.TabStop = true;
            this.optMerge.Text = "Merge Sort";
            this.optMerge.UseVisualStyleBackColor = true;
            // 
            // optQuick
            // 
            this.optQuick.AutoSize = true;
            this.optQuick.Font = new System.Drawing.Font("Franklin Gothic Medium", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optQuick.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.optQuick.Location = new System.Drawing.Point(30, 67);
            this.optQuick.Name = "optQuick";
            this.optQuick.Size = new System.Drawing.Size(85, 21);
            this.optQuick.TabIndex = 9;
            this.optQuick.TabStop = true;
            this.optQuick.Text = "Quick Sort";
            this.optQuick.UseVisualStyleBackColor = true;
            // 
            // optBubble
            // 
            this.optBubble.AutoSize = true;
            this.optBubble.Font = new System.Drawing.Font("Franklin Gothic Medium", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optBubble.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.optBubble.Location = new System.Drawing.Point(30, 41);
            this.optBubble.Name = "optBubble";
            this.optBubble.Size = new System.Drawing.Size(93, 21);
            this.optBubble.TabIndex = 8;
            this.optBubble.TabStop = true;
            this.optBubble.Text = "Bubble Sort";
            this.optBubble.UseVisualStyleBackColor = true;
            // 
            // gbElementos
            // 
            this.gbElementos.Controls.Add(this.numericUpDown1);
            this.gbElementos.Controls.Add(this.btnGenerar);
            this.gbElementos.Controls.Add(this.lblLongitud);
            this.gbElementos.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbElementos.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbElementos.Location = new System.Drawing.Point(20, 22);
            this.gbElementos.Name = "gbElementos";
            this.gbElementos.Size = new System.Drawing.Size(346, 126);
            this.gbElementos.TabIndex = 16;
            this.gbElementos.TabStop = false;
            this.gbElementos.Text = "Defina Cantidad de elementos";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(16, 58);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown1.TabIndex = 4;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGenerar.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGenerar.Location = new System.Drawing.Point(227, 50);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(84, 33);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblLongitud
            // 
            this.lblLongitud.AutoSize = true;
            this.lblLongitud.Font = new System.Drawing.Font("Franklin Gothic Medium", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongitud.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLongitud.Location = new System.Drawing.Point(13, 35);
            this.lblLongitud.Name = "lblLongitud";
            this.lblLongitud.Size = new System.Drawing.Size(111, 17);
            this.lblLongitud.TabIndex = 3;
            this.lblLongitud.Text = "Longitud de Vector";
            // 
            // grDesordenado
            // 
            chartArea7.Name = "ChartArea1";
            this.grDesordenado.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.grDesordenado.Legends.Add(legend7);
            this.grDesordenado.Location = new System.Drawing.Point(1045, 45);
            this.grDesordenado.Name = "grDesordenado";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.grDesordenado.Series.Add(series7);
            this.grDesordenado.Size = new System.Drawing.Size(547, 247);
            this.grDesordenado.TabIndex = 22;
            this.grDesordenado.Text = "Elementos";
            // 
            // grOrdenado
            // 
            chartArea8.Name = "ChartArea1";
            this.grOrdenado.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.grOrdenado.Legends.Add(legend8);
            this.grOrdenado.Location = new System.Drawing.Point(1045, 330);
            this.grOrdenado.Name = "grOrdenado";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.grOrdenado.Series.Add(series8);
            this.grOrdenado.Size = new System.Drawing.Size(547, 234);
            this.grOrdenado.TabIndex = 23;
            this.grOrdenado.Text = "chart2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 464);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 121);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultados";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(235, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "limpiar gilla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "limpiar graficos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1623, 597);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grOrdenado);
            this.Controls.Add(this.grDesordenado);
            this.Controls.Add(this.lblGraficoOrdenado);
            this.Controls.Add(this.lblGraficoDesordenado);
            this.Controls.Add(this.dgvMetodos);
            this.Controls.Add(this.gbResultados);
            this.Controls.Add(this.gbMetodo);
            this.Controls.Add(this.gbElementos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetodos)).EndInit();
            this.gbResultados.ResumeLayout(false);
            this.gbResultados.PerformLayout();
            this.gbMetodo.ResumeLayout(false);
            this.gbMetodo.PerformLayout();
            this.gbElementos.ResumeLayout(false);
            this.gbElementos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDesordenado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grOrdenado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGraficoOrdenado;
        private System.Windows.Forms.Label lblGraficoDesordenado;
        private System.Windows.Forms.DataGridView dgvMetodos;
        private System.Windows.Forms.GroupBox gbResultados;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblIteraciones;
        private System.Windows.Forms.TextBox txtIteraciones;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.GroupBox gbMetodo;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.RadioButton optMerge;
        private System.Windows.Forms.RadioButton optQuick;
        private System.Windows.Forms.RadioButton optBubble;
        private System.Windows.Forms.GroupBox gbElementos;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label lblLongitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iteraciones1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Elementos;
        private System.Windows.Forms.DataVisualization.Charting.Chart grDesordenado;
        private System.Windows.Forms.DataVisualization.Charting.Chart grOrdenado;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}

