﻿
namespace ReportesBasicosMunicipios
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoDeptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoMunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDeptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.municipioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRead = new System.Windows.Forms.Button();
            this.codMun = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.munInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pieChart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnChart = new System.Windows.Forms.Button();
            this.municipioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipioBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipioBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 11);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(340, 22);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDeptDataGridViewTextBoxColumn,
            this.codigoMunDataGridViewTextBoxColumn,
            this.nombreDeptDataGridViewTextBoxColumn,
            this.nombreMunDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.municipioBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 50);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(608, 628);
            this.dataGridView1.TabIndex = 2;
            // 
            // codigoDeptDataGridViewTextBoxColumn
            // 
            this.codigoDeptDataGridViewTextBoxColumn.DataPropertyName = "CodigoDept";
            this.codigoDeptDataGridViewTextBoxColumn.HeaderText = "Codigo Departamento";
            this.codigoDeptDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoDeptDataGridViewTextBoxColumn.Name = "codigoDeptDataGridViewTextBoxColumn";
            this.codigoDeptDataGridViewTextBoxColumn.Width = 125;
            // 
            // codigoMunDataGridViewTextBoxColumn
            // 
            this.codigoMunDataGridViewTextBoxColumn.DataPropertyName = "CodigoMun";
            this.codigoMunDataGridViewTextBoxColumn.HeaderText = "Código Municipio";
            this.codigoMunDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoMunDataGridViewTextBoxColumn.Name = "codigoMunDataGridViewTextBoxColumn";
            this.codigoMunDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDeptDataGridViewTextBoxColumn
            // 
            this.nombreDeptDataGridViewTextBoxColumn.DataPropertyName = "NombreDept";
            this.nombreDeptDataGridViewTextBoxColumn.HeaderText = "Nombre Departamento";
            this.nombreDeptDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDeptDataGridViewTextBoxColumn.Name = "nombreDeptDataGridViewTextBoxColumn";
            this.nombreDeptDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreMunDataGridViewTextBoxColumn
            // 
            this.nombreMunDataGridViewTextBoxColumn.DataPropertyName = "NombreMun";
            this.nombreMunDataGridViewTextBoxColumn.HeaderText = "Nombre Municipio";
            this.nombreMunDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreMunDataGridViewTextBoxColumn.Name = "nombreMunDataGridViewTextBoxColumn";
            this.nombreMunDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.Width = 125;
            // 
            // municipioBindingSource
            // 
            this.municipioBindingSource.DataSource = typeof(Model.Municipio);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(357, 10);
            this.btnRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 3;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // codMun
            // 
            this.codMun.Location = new System.Drawing.Point(754, 11);
            this.codMun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.codMun.Name = "codMun";
            this.codMun.Size = new System.Drawing.Size(119, 22);
            this.codMun.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(890, 11);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "|      Filtrar por Código DANE del Municipio";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.munInfo);
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(561, 121);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del Municipio";
            // 
            // munInfo
            // 
            this.munInfo.AutoSize = true;
            this.munInfo.Location = new System.Drawing.Point(7, 22);
            this.munInfo.Name = "munInfo";
            this.munInfo.Size = new System.Drawing.Size(0, 17);
            this.munInfo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(637, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 148);
            this.panel1.TabIndex = 9;
            // 
            // pieChart1
            // 
            chartArea1.Name = "ChartArea1";
            this.pieChart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.pieChart1.Legends.Add(legend1);
            this.pieChart1.Location = new System.Drawing.Point(637, 206);
            this.pieChart1.Margin = new System.Windows.Forms.Padding(4);
            this.pieChart1.Name = "pieChart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.pieChart1.Series.Add(series1);
            this.pieChart1.Size = new System.Drawing.Size(594, 470);
            this.pieChart1.TabIndex = 10;
            this.pieChart1.Text = "chart1";
            // 
            // btnChart
            // 
            this.btnChart.Enabled = false;
            this.btnChart.Location = new System.Drawing.Point(1011, 12);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(221, 23);
            this.btnChart.TabIndex = 11;
            this.btnChart.Text = "Generate chart on new window";
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // municipioBindingSource1
            // 
            this.municipioBindingSource1.DataSource = typeof(Model.Municipio);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 689);
            this.Controls.Add(this.btnChart);
            this.Controls.Add(this.pieChart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.codMun);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Reportes Municipales";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipioBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pieChart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipioBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource municipioBindingSource;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDeptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoMunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDeptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox codMun;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource municipioBindingSource1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label munInfo;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieChart1;
        private System.Windows.Forms.Button btnChart;
    }
}

