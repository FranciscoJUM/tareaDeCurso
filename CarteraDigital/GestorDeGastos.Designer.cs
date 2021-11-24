
namespace CarteraDigital
{
    partial class GestorDeGastos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestorDeGastos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.combobusquedagastos = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.CombobusquedaIngreso = new System.Windows.Forms.ComboBox();
            this.MostrarTodo = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.numMinimo = new System.Windows.Forms.NumericUpDown();
            this.numMaximo = new System.Windows.Forms.NumericUpDown();
            this.Buscar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.RichGasto = new System.Windows.Forms.RichTextBox();
            this.RichBusqueda = new System.Windows.Forms.RichTextBox();
            this.RichIngreso = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CrearIngreso = new System.Windows.Forms.Button();
            this.ComboIngreso = new System.Windows.Forms.ComboBox();
            this.FechaIngreso = new System.Windows.Forms.MonthCalendar();
            this.label8 = new System.Windows.Forms.Label();
            this.TextIngreso = new System.Windows.Forms.RichTextBox();
            this.NumIngreso = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CrearGasto = new System.Windows.Forms.Button();
            this.ComboGasto = new System.Windows.Forms.ComboBox();
            this.CalendarioGasto = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.TextGasto = new System.Windows.Forms.RichTextBox();
            this.NumGasto = new System.Windows.Forms.NumericUpDown();
            this.Suspender = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaximo)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumIngreso)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumGasto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.combobusquedagastos);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.CombobusquedaIngreso);
            this.groupBox1.Controls.Add(this.MostrarTodo);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.numMinimo);
            this.groupBox1.Controls.Add(this.numMaximo);
            this.groupBox1.Controls.Add(this.Buscar);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.RichGasto);
            this.groupBox1.Controls.Add(this.RichBusqueda);
            this.groupBox1.Controls.Add(this.RichIngreso);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 525);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mostrar";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(211, 451);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(170, 17);
            this.label15.TabIndex = 39;
            this.label15.Text = "Buscar gastos por Origen";
            // 
            // combobusquedagastos
            // 
            this.combobusquedagastos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobusquedagastos.FormattingEnabled = true;
            this.combobusquedagastos.Location = new System.Drawing.Point(310, 478);
            this.combobusquedagastos.Name = "combobusquedagastos";
            this.combobusquedagastos.Size = new System.Drawing.Size(109, 24);
            this.combobusquedagastos.TabIndex = 37;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(208, 475);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 39);
            this.button2.TabIndex = 38;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CombobusquedaIngreso
            // 
            this.CombobusquedaIngreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CombobusquedaIngreso.FormattingEnabled = true;
            this.CombobusquedaIngreso.Location = new System.Drawing.Point(316, 412);
            this.CombobusquedaIngreso.Name = "CombobusquedaIngreso";
            this.CombobusquedaIngreso.Size = new System.Drawing.Size(109, 24);
            this.CombobusquedaIngreso.TabIndex = 27;
            // 
            // MostrarTodo
            // 
            this.MostrarTodo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MostrarTodo.Location = new System.Drawing.Point(110, 475);
            this.MostrarTodo.Name = "MostrarTodo";
            this.MostrarTodo.Size = new System.Drawing.Size(95, 39);
            this.MostrarTodo.TabIndex = 34;
            this.MostrarTodo.Text = "Mostrar";
            this.MostrarTodo.UseVisualStyleBackColor = true;
            this.MostrarTodo.Click += new System.EventHandler(this.MostrarTodo_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(110, 455);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 17);
            this.label13.TabIndex = 33;
            this.label13.Text = "Mostrar todos";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(211, 389);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(175, 17);
            this.label14.TabIndex = 36;
            this.label14.Text = "Buscar ingreso por Origen";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(214, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 39);
            this.button1.TabIndex = 35;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(6, 384);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 17);
            this.label12.TabIndex = 32;
            this.label12.Text = "Busqueda por Rango";
            // 
            // numMinimo
            // 
            this.numMinimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numMinimo.DecimalPlaces = 2;
            this.numMinimo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.numMinimo.Location = new System.Drawing.Point(9, 449);
            this.numMinimo.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numMinimo.Name = "numMinimo";
            this.numMinimo.Size = new System.Drawing.Size(95, 22);
            this.numMinimo.TabIndex = 31;
            // 
            // numMaximo
            // 
            this.numMaximo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numMaximo.DecimalPlaces = 2;
            this.numMaximo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.numMaximo.Location = new System.Drawing.Point(9, 472);
            this.numMaximo.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numMaximo.Name = "numMaximo";
            this.numMaximo.Size = new System.Drawing.Size(95, 22);
            this.numMaximo.TabIndex = 30;
            // 
            // Buscar
            // 
            this.Buscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Buscar.Location = new System.Drawing.Point(9, 404);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(95, 39);
            this.Buscar.TabIndex = 29;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(6, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "Busqueda";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(6, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Gastos";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(6, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Ingresos";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // RichGasto
            // 
            this.RichGasto.Location = new System.Drawing.Point(6, 160);
            this.RichGasto.Name = "RichGasto";
            this.RichGasto.Size = new System.Drawing.Size(413, 99);
            this.RichGasto.TabIndex = 4;
            this.RichGasto.Text = "";
            this.RichGasto.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged);
            // 
            // RichBusqueda
            // 
            this.RichBusqueda.Location = new System.Drawing.Point(6, 282);
            this.RichBusqueda.Name = "RichBusqueda";
            this.RichBusqueda.Size = new System.Drawing.Size(413, 99);
            this.RichBusqueda.TabIndex = 3;
            this.RichBusqueda.Text = "";
            this.RichBusqueda.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // RichIngreso
            // 
            this.RichIngreso.Location = new System.Drawing.Point(6, 38);
            this.RichIngreso.Name = "RichIngreso";
            this.RichIngreso.Size = new System.Drawing.Size(413, 99);
            this.RichIngreso.TabIndex = 2;
            this.RichIngreso.Text = "";
            this.RichIngreso.TextChanged += new System.EventHandler(this.ged);
            // 
            // groupBox2
            // 
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Location = new System.Drawing.Point(430, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 525);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // backgroundWorker3
            // 
            this.backgroundWorker3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker3_DoWork);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.CrearIngreso);
            this.groupBox3.Controls.Add(this.ComboIngreso);
            this.groupBox3.Controls.Add(this.FechaIngreso);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.TextIngreso);
            this.groupBox3.Controls.Add(this.NumIngreso);
            this.groupBox3.Location = new System.Drawing.Point(443, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(457, 525);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ingresos";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(190, 461);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 39);
            this.button3.TabIndex = 27;
            this.button3.Text = "Limpiar todo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(52, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Origen :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Descripcion : ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(9, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Monto Total :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // CrearIngreso
            // 
            this.CrearIngreso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CrearIngreso.Location = new System.Drawing.Point(16, 463);
            this.CrearIngreso.Name = "CrearIngreso";
            this.CrearIngreso.Size = new System.Drawing.Size(95, 39);
            this.CrearIngreso.TabIndex = 23;
            this.CrearIngreso.Text = "Crear";
            this.CrearIngreso.UseVisualStyleBackColor = true;
            this.CrearIngreso.Click += new System.EventHandler(this.CrearIngreso_Click);
            // 
            // ComboIngreso
            // 
            this.ComboIngreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboIngreso.FormattingEnabled = true;
            this.ComboIngreso.Location = new System.Drawing.Point(123, 410);
            this.ComboIngreso.Name = "ComboIngreso";
            this.ComboIngreso.Size = new System.Drawing.Size(221, 24);
            this.ComboIngreso.TabIndex = 21;
            this.ComboIngreso.SelectedIndexChanged += new System.EventHandler(this.ComboIngreso_SelectedIndexChanged);
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.Location = new System.Drawing.Point(123, 191);
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.TabIndex = 22;
            this.FechaIngreso.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.FechaIngreso_DateChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(56, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Fecha :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // TextIngreso
            // 
            this.TextIngreso.Location = new System.Drawing.Point(123, 51);
            this.TextIngreso.Name = "TextIngreso";
            this.TextIngreso.Size = new System.Drawing.Size(290, 128);
            this.TextIngreso.TabIndex = 19;
            this.TextIngreso.Text = "";
            this.TextIngreso.TextChanged += new System.EventHandler(this.TextIngreso_TextChanged);
            // 
            // NumIngreso
            // 
            this.NumIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NumIngreso.DecimalPlaces = 2;
            this.NumIngreso.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.NumIngreso.Location = new System.Drawing.Point(123, 23);
            this.NumIngreso.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NumIngreso.Name = "NumIngreso";
            this.NumIngreso.Size = new System.Drawing.Size(221, 22);
            this.NumIngreso.TabIndex = 18;
            this.NumIngreso.ValueChanged += new System.EventHandler(this.NumIngreso_ValueChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox5.Controls.Add(this.Suspender);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.CrearGasto);
            this.groupBox5.Controls.Add(this.ComboGasto);
            this.groupBox5.Controls.Add(this.CalendarioGasto);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.TextGasto);
            this.groupBox5.Controls.Add(this.NumGasto);
            this.groupBox5.Location = new System.Drawing.Point(906, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(455, 525);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Gastos";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(51, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Origen :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(5, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Descripcion : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Monto Total :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CrearGasto
            // 
            this.CrearGasto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CrearGasto.Location = new System.Drawing.Point(15, 461);
            this.CrearGasto.Name = "CrearGasto";
            this.CrearGasto.Size = new System.Drawing.Size(95, 39);
            this.CrearGasto.TabIndex = 14;
            this.CrearGasto.Text = "Crear";
            this.CrearGasto.UseVisualStyleBackColor = true;
            this.CrearGasto.Click += new System.EventHandler(this.CrearGasto_Click);
            // 
            // ComboGasto
            // 
            this.ComboGasto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboGasto.FormattingEnabled = true;
            this.ComboGasto.Location = new System.Drawing.Point(108, 410);
            this.ComboGasto.Name = "ComboGasto";
            this.ComboGasto.Size = new System.Drawing.Size(221, 24);
            this.ComboGasto.TabIndex = 12;
            this.ComboGasto.SelectedIndexChanged += new System.EventHandler(this.ComboGasto_SelectedIndexChanged);
            // 
            // CalendarioGasto
            // 
            this.CalendarioGasto.Location = new System.Drawing.Point(108, 191);
            this.CalendarioGasto.Name = "CalendarioGasto";
            this.CalendarioGasto.TabIndex = 13;
            this.CalendarioGasto.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.CalendarioGasto_DateChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(55, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // TextGasto
            // 
            this.TextGasto.Location = new System.Drawing.Point(108, 51);
            this.TextGasto.Name = "TextGasto";
            this.TextGasto.Size = new System.Drawing.Size(290, 128);
            this.TextGasto.TabIndex = 9;
            this.TextGasto.Text = "";
            this.TextGasto.TextChanged += new System.EventHandler(this.TextGasto_TextChanged);
            // 
            // NumGasto
            // 
            this.NumGasto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NumGasto.DecimalPlaces = 2;
            this.NumGasto.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.NumGasto.Location = new System.Drawing.Point(108, 23);
            this.NumGasto.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NumGasto.Name = "NumGasto";
            this.NumGasto.Size = new System.Drawing.Size(221, 22);
            this.NumGasto.TabIndex = 8;
            this.NumGasto.ValueChanged += new System.EventHandler(this.NumGasto_ValueChanged);
            // 
            // Suspender
            // 
            this.Suspender.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Suspender.Location = new System.Drawing.Point(213, 463);
            this.Suspender.Name = "Suspender";
            this.Suspender.Size = new System.Drawing.Size(153, 39);
            this.Suspender.TabIndex = 28;
            this.Suspender.Text = "Suspender app";
            this.Suspender.UseVisualStyleBackColor = true;
            this.Suspender.Click += new System.EventHandler(this.Suspender_Click);
            // 
            // GestorDeGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1373, 549);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestorDeGastos";
            this.Text = "Cartera Digital";
            this.Load += new System.EventHandler(this.GestorDeGastos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaximo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumIngreso)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumGasto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox TextGasto;
        private System.Windows.Forms.NumericUpDown NumGasto;
        private System.Windows.Forms.MonthCalendar CalendarioGasto;
        private System.Windows.Forms.ComboBox ComboGasto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CrearGasto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button CrearIngreso;
        private System.Windows.Forms.ComboBox ComboIngreso;
        private System.Windows.Forms.MonthCalendar FechaIngreso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox TextIngreso;
        private System.Windows.Forms.NumericUpDown NumIngreso;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox RichGasto;
        private System.Windows.Forms.RichTextBox RichBusqueda;
        private System.Windows.Forms.RichTextBox RichIngreso;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numMinimo;
        private System.Windows.Forms.NumericUpDown numMaximo;
        private System.Windows.Forms.Button MostrarTodo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox CombobusquedaIngreso;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox combobusquedagastos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Suspender;
    }
}