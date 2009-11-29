namespace WindowsFormsApplication5
{
    partial class frmClientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.cbbEntrada = new System.Windows.Forms.ComboBox();
            this.cbbSalida = new System.Windows.Forms.ComboBox();
            this.cbbTipo = new System.Windows.Forms.ComboBox();
            this.cbbFormPago = new System.Windows.Forms.ComboBox();
            this.cbbJornadaInicio = new System.Windows.Forms.ComboBox();
            this.cbbJornadaFinal = new System.Windows.Forms.ComboBox();
            this.txtJefe = new System.Windows.Forms.TextBox();
            this.txtPuestoJefe = new System.Windows.Forms.TextBox();
            this.txtFechaI = new System.Windows.Forms.DateTimePicker();
            this.txtFechaD = new System.Windows.Forms.DateTimePicker();
            this.btnEmpresaN = new DevExpress.XtraEditors.SimpleButton();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.rdSexo = new DevExpress.XtraEditors.RadioGroup();
            this.ckdTarjetaSi = new DevExpress.XtraEditors.CheckEdit();
            this.ckdTarjetaNo = new DevExpress.XtraEditors.CheckEdit();
            this.txtTelefono = new DevExpress.XtraEditors.TextEdit();
            this.gcCliente = new DevExpress.XtraGrid.GridControl();
            this.gvCliente = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.txtDireccion = new DevExpress.XtraEditors.TextEdit();
            this.txtPuesto = new DevExpress.XtraEditors.TextEdit();
            this.cbbEmpresa = new System.Windows.Forms.ComboBox();
            this.txtSalario = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tbNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatos)).BeginInit();
            this.tbBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdSexo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckdTarjetaSi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckdTarjetaNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPuesto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalario.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(5, 12);
            this.xtraTabControl1.Size = new System.Drawing.Size(741, 540);
            // 
            // tbNuevo
            // 
            this.tbNuevo.Controls.Add(this.txtSalario);
            this.tbNuevo.Controls.Add(this.cbbEmpresa);
            this.tbNuevo.Controls.Add(this.txtPuesto);
            this.tbNuevo.Controls.Add(this.txtDireccion);
            this.tbNuevo.Controls.Add(this.txtNombre);
            this.tbNuevo.Controls.Add(this.rdSexo);
            this.tbNuevo.Controls.Add(this.ckdTarjetaSi);
            this.tbNuevo.Controls.Add(this.ckdTarjetaNo);
            this.tbNuevo.Controls.Add(this.label24);
            this.tbNuevo.Controls.Add(this.txtTelefono);
            this.tbNuevo.Controls.Add(this.label23);
            this.tbNuevo.Controls.Add(this.txtPuestoJefe);
            this.tbNuevo.Controls.Add(this.btnEmpresaN);
            this.tbNuevo.Controls.Add(this.txtFechaD);
            this.tbNuevo.Controls.Add(this.txtFechaI);
            this.tbNuevo.Controls.Add(this.txtJefe);
            this.tbNuevo.Controls.Add(this.cbbJornadaFinal);
            this.tbNuevo.Controls.Add(this.cbbJornadaInicio);
            this.tbNuevo.Controls.Add(this.cbbFormPago);
            this.tbNuevo.Controls.Add(this.cbbTipo);
            this.tbNuevo.Controls.Add(this.cbbSalida);
            this.tbNuevo.Controls.Add(this.cbbEntrada);
            this.tbNuevo.Controls.Add(this.label22);
            this.tbNuevo.Controls.Add(this.label20);
            this.tbNuevo.Controls.Add(this.label21);
            this.tbNuevo.Controls.Add(this.label19);
            this.tbNuevo.Controls.Add(this.label18);
            this.tbNuevo.Controls.Add(this.label17);
            this.tbNuevo.Controls.Add(this.label16);
            this.tbNuevo.Controls.Add(this.label15);
            this.tbNuevo.Controls.Add(this.label12);
            this.tbNuevo.Controls.Add(this.label13);
            this.tbNuevo.Controls.Add(this.label10);
            this.tbNuevo.Controls.Add(this.label11);
            this.tbNuevo.Size = new System.Drawing.Size(661, 531);
            this.tbNuevo.Controls.SetChildIndex(this.btnLimpiar, 0);
            this.tbNuevo.Controls.SetChildIndex(this.label11, 0);
            this.tbNuevo.Controls.SetChildIndex(this.label10, 0);
            this.tbNuevo.Controls.SetChildIndex(this.label13, 0);
            this.tbNuevo.Controls.SetChildIndex(this.label12, 0);
            this.tbNuevo.Controls.SetChildIndex(this.label15, 0);
            this.tbNuevo.Controls.SetChildIndex(this.label16, 0);
            this.tbNuevo.Controls.SetChildIndex(this.label17, 0);
            this.tbNuevo.Controls.SetChildIndex(this.label18, 0);
            this.tbNuevo.Controls.SetChildIndex(this.label19, 0);
            this.tbNuevo.Controls.SetChildIndex(this.label21, 0);
            this.tbNuevo.Controls.SetChildIndex(this.label20, 0);
            this.tbNuevo.Controls.SetChildIndex(this.label22, 0);
            this.tbNuevo.Controls.SetChildIndex(this.cbbEntrada, 0);
            this.tbNuevo.Controls.SetChildIndex(this.cbbSalida, 0);
            this.tbNuevo.Controls.SetChildIndex(this.cbbTipo, 0);
            this.tbNuevo.Controls.SetChildIndex(this.cbbFormPago, 0);
            this.tbNuevo.Controls.SetChildIndex(this.cbbJornadaInicio, 0);
            this.tbNuevo.Controls.SetChildIndex(this.cbbJornadaFinal, 0);
            this.tbNuevo.Controls.SetChildIndex(this.txtJefe, 0);
            this.tbNuevo.Controls.SetChildIndex(this.txtFechaI, 0);
            this.tbNuevo.Controls.SetChildIndex(this.txtFechaD, 0);
            this.tbNuevo.Controls.SetChildIndex(this.btnEmpresaN, 0);
            this.tbNuevo.Controls.SetChildIndex(this.txtPuestoJefe, 0);
            this.tbNuevo.Controls.SetChildIndex(this.label23, 0);
            this.tbNuevo.Controls.SetChildIndex(this.txtTelefono, 0);
            this.tbNuevo.Controls.SetChildIndex(this.label24, 0);
            this.tbNuevo.Controls.SetChildIndex(this.ckdTarjetaNo, 0);
            this.tbNuevo.Controls.SetChildIndex(this.ckdTarjetaSi, 0);
            this.tbNuevo.Controls.SetChildIndex(this.btnGuardar, 0);
            this.tbNuevo.Controls.SetChildIndex(this.rdSexo, 0);
            this.tbNuevo.Controls.SetChildIndex(this.txtNombre, 0);
            this.tbNuevo.Controls.SetChildIndex(this.txtDireccion, 0);
            this.tbNuevo.Controls.SetChildIndex(this.txtPuesto, 0);
            this.tbNuevo.Controls.SetChildIndex(this.cbbEmpresa, 0);
            this.tbNuevo.Controls.SetChildIndex(this.txtSalario, 0);
            // 
            // tbModificar
            // 
            this.tbModificar.Size = new System.Drawing.Size(661, 531);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(506, 27);
            this.btnGuardar.TabIndex = 33;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Controls.Add(this.gcCliente);
            this.tbBuscar.Size = new System.Drawing.Size(661, 531);
            this.tbBuscar.Controls.SetChildIndex(this.btnBuscar, 0);
            this.tbBuscar.Controls.SetChildIndex(this.gcCliente, 0);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.TabIndex = 34;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(538, 18);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Direccion :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Puesto :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Salario :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Jornada de Trabajo :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Jefe inmediato :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Fecha de ingreso :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 402);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Fecha del despido :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Nombre :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 499);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Tarjeta de Asistencia :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 463);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Fecha de Despido :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 426);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Fecha de Ingreso :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 388);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Puesto :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 353);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "Jefe Inmediato :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 319);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = "Jornada de trabajo :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(18, 266);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 13);
            this.label18.TabIndex = 8;
            this.label18.Text = "Salario :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(18, 230);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 13);
            this.label19.TabIndex = 9;
            this.label19.Text = "Horario :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(18, 186);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(46, 13);
            this.label20.TabIndex = 10;
            this.label20.Text = "Puesto :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(18, 149);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(54, 13);
            this.label21.TabIndex = 11;
            this.label21.Text = "Empresa :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(18, 77);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(55, 13);
            this.label22.TabIndex = 12;
            this.label22.Text = "Telefono :";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(732, 2);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(20, 468);
            this.vScrollBar1.TabIndex = 3;
            // 
            // cbbEntrada
            // 
            this.cbbEntrada.BackColor = System.Drawing.Color.White;
            this.cbbEntrada.FormattingEnabled = true;
            this.cbbEntrada.Items.AddRange(new object[] {
            "1:00",
            "2:00",
            "3:00",
            "4:00",
            "5:00",
            "6:00",
            "7:00",
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00",
            "24:00"});
            this.cbbEntrada.Location = new System.Drawing.Point(77, 227);
            this.cbbEntrada.Name = "cbbEntrada";
            this.cbbEntrada.Size = new System.Drawing.Size(92, 21);
            this.cbbEntrada.TabIndex = 20;
            this.cbbEntrada.Text = "Entrada";
            // 
            // cbbSalida
            // 
            this.cbbSalida.BackColor = System.Drawing.Color.White;
            this.cbbSalida.FormattingEnabled = true;
            this.cbbSalida.Items.AddRange(new object[] {
            "1:00",
            "2:00",
            "3:00",
            "4:00",
            "5:00",
            "6:00",
            "7:00",
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00",
            "24:00"});
            this.cbbSalida.Location = new System.Drawing.Point(207, 227);
            this.cbbSalida.Name = "cbbSalida";
            this.cbbSalida.Size = new System.Drawing.Size(92, 21);
            this.cbbSalida.TabIndex = 21;
            this.cbbSalida.Text = "Salida";
            // 
            // cbbTipo
            // 
            this.cbbTipo.BackColor = System.Drawing.Color.White;
            this.cbbTipo.FormattingEnabled = true;
            this.cbbTipo.Items.AddRange(new object[] {
            "m/n",
            "dlls"});
            this.cbbTipo.Location = new System.Drawing.Point(207, 263);
            this.cbbTipo.Name = "cbbTipo";
            this.cbbTipo.Size = new System.Drawing.Size(103, 21);
            this.cbbTipo.TabIndex = 23;
            this.cbbTipo.Text = "Tipo de Moneda";
            // 
            // cbbFormPago
            // 
            this.cbbFormPago.BackColor = System.Drawing.Color.White;
            this.cbbFormPago.FormattingEnabled = true;
            this.cbbFormPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta",
            "Cheques",
            "Nomina"});
            this.cbbFormPago.Location = new System.Drawing.Point(77, 289);
            this.cbbFormPago.Name = "cbbFormPago";
            this.cbbFormPago.Size = new System.Drawing.Size(100, 21);
            this.cbbFormPago.TabIndex = 24;
            this.cbbFormPago.Text = "Forma de Pago";
            // 
            // cbbJornadaInicio
            // 
            this.cbbJornadaInicio.BackColor = System.Drawing.Color.White;
            this.cbbJornadaInicio.FormattingEnabled = true;
            this.cbbJornadaInicio.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado",
            "Domingo"});
            this.cbbJornadaInicio.Location = new System.Drawing.Point(147, 316);
            this.cbbJornadaInicio.Name = "cbbJornadaInicio";
            this.cbbJornadaInicio.Size = new System.Drawing.Size(92, 21);
            this.cbbJornadaInicio.TabIndex = 25;
            this.cbbJornadaInicio.Text = "Inicio";
            // 
            // cbbJornadaFinal
            // 
            this.cbbJornadaFinal.BackColor = System.Drawing.Color.White;
            this.cbbJornadaFinal.FormattingEnabled = true;
            this.cbbJornadaFinal.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado",
            "Domingo"});
            this.cbbJornadaFinal.Location = new System.Drawing.Point(260, 316);
            this.cbbJornadaFinal.Name = "cbbJornadaFinal";
            this.cbbJornadaFinal.Size = new System.Drawing.Size(92, 21);
            this.cbbJornadaFinal.TabIndex = 26;
            this.cbbJornadaFinal.Text = "Final";
            // 
            // txtJefe
            // 
            this.txtJefe.BackColor = System.Drawing.Color.White;
            this.txtJefe.Location = new System.Drawing.Point(147, 350);
            this.txtJefe.Name = "txtJefe";
            this.txtJefe.Size = new System.Drawing.Size(267, 20);
            this.txtJefe.TabIndex = 27;
            // 
            // txtPuestoJefe
            // 
            this.txtPuestoJefe.BackColor = System.Drawing.Color.White;
            this.txtPuestoJefe.Location = new System.Drawing.Point(147, 385);
            this.txtPuestoJefe.Name = "txtPuestoJefe";
            this.txtPuestoJefe.Size = new System.Drawing.Size(295, 20);
            this.txtPuestoJefe.TabIndex = 28;
            // 
            // txtFechaI
            // 
            this.txtFechaI.Location = new System.Drawing.Point(149, 422);
            this.txtFechaI.Name = "txtFechaI";
            this.txtFechaI.Size = new System.Drawing.Size(224, 20);
            this.txtFechaI.TabIndex = 29;
            // 
            // txtFechaD
            // 
            this.txtFechaD.CalendarMonthBackground = System.Drawing.Color.White;
            this.txtFechaD.CalendarTitleForeColor = System.Drawing.Color.White;
            this.txtFechaD.Location = new System.Drawing.Point(147, 459);
            this.txtFechaD.Name = "txtFechaD";
            this.txtFechaD.Size = new System.Drawing.Size(224, 20);
            this.txtFechaD.TabIndex = 30;
            // 
            // btnEmpresaN
            // 
            this.btnEmpresaN.Location = new System.Drawing.Point(400, 144);
            this.btnEmpresaN.Name = "btnEmpresaN";
            this.btnEmpresaN.Size = new System.Drawing.Size(75, 23);
            this.btnEmpresaN.TabIndex = 18;
            this.btnEmpresaN.Text = "Nueva";
            this.btnEmpresaN.Click += new System.EventHandler(this.btnEmpresaN_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(18, 41);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(55, 13);
            this.label23.TabIndex = 34;
            this.label23.Text = "Direccion:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(18, 113);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(34, 13);
            this.label24.TabIndex = 36;
            this.label24.Text = "Sexo:";
            // 
            // rdSexo
            // 
            this.rdSexo.Location = new System.Drawing.Point(77, 105);
            this.rdSexo.Name = "rdSexo";
            this.rdSexo.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.rdSexo.Properties.Appearance.Options.UseBackColor = true;
            this.rdSexo.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("M", "Masculino"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("F", "Femenino")});
            this.rdSexo.Size = new System.Drawing.Size(202, 30);
            this.rdSexo.TabIndex = 16;
            // 
            // ckdTarjetaSi
            // 
            this.ckdTarjetaSi.Location = new System.Drawing.Point(147, 496);
            this.ckdTarjetaSi.Name = "ckdTarjetaSi";
            this.ckdTarjetaSi.Properties.Caption = "Si";
            this.ckdTarjetaSi.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1;
            this.ckdTarjetaSi.Size = new System.Drawing.Size(38, 22);
            this.ckdTarjetaSi.TabIndex = 31;
            this.ckdTarjetaSi.CheckedChanged += new System.EventHandler(this.ckdTarjetaSi_CheckedChanged);
            // 
            // ckdTarjetaNo
            // 
            this.ckdTarjetaNo.Location = new System.Drawing.Point(214, 497);
            this.ckdTarjetaNo.Name = "ckdTarjetaNo";
            this.ckdTarjetaNo.Properties.Caption = "No";
            this.ckdTarjetaNo.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1;
            this.ckdTarjetaNo.Size = new System.Drawing.Size(42, 22);
            this.ckdTarjetaNo.TabIndex = 32;
            this.ckdTarjetaNo.CheckedChanged += new System.EventHandler(this.ckdTarjetaNo_CheckedChanged);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(77, 74);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtTelefono.Properties.Appearance.Options.UseBackColor = true;
            this.txtTelefono.Properties.Mask.EditMask = "(999)000-00-00";
            this.txtTelefono.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtTelefono.Size = new System.Drawing.Size(296, 20);
            this.txtTelefono.TabIndex = 15;
            // 
            // gcCliente
            // 
            this.gcCliente.EmbeddedNavigator.Name = "";
            this.gcCliente.FormsUseDefaultLookAndFeel = false;
            this.gcCliente.Location = new System.Drawing.Point(3, 83);
            this.gcCliente.MainView = this.gvCliente;
            this.gcCliente.Name = "gcCliente";
            this.gcCliente.Size = new System.Drawing.Size(655, 445);
            this.gcCliente.TabIndex = 4;
            this.gcCliente.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCliente});
            // 
            // gvCliente
            // 
            this.gvCliente.GridControl = this.gcCliente;
            this.gvCliente.Name = "gvCliente";
            this.gvCliente.OptionsView.ColumnAutoWidth = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(78, 7);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(295, 20);
            this.txtNombre.TabIndex = 13;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(77, 38);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(295, 20);
            this.txtDireccion.TabIndex = 14;
            // 
            // txtPuesto
            // 
            this.txtPuesto.Location = new System.Drawing.Point(77, 183);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtPuesto.Properties.Appearance.Options.UseBackColor = true;
            this.txtPuesto.Properties.Mask.EditMask = "(999)000-00-00";
            this.txtPuesto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtPuesto.Size = new System.Drawing.Size(296, 20);
            this.txtPuesto.TabIndex = 19;
            // 
            // cbbEmpresa
            // 
            this.cbbEmpresa.BackColor = System.Drawing.Color.White;
            this.cbbEmpresa.FormattingEnabled = true;
            this.cbbEmpresa.Location = new System.Drawing.Point(77, 146);
            this.cbbEmpresa.Name = "cbbEmpresa";
            this.cbbEmpresa.Size = new System.Drawing.Size(296, 21);
            this.cbbEmpresa.TabIndex = 39;
            this.cbbEmpresa.Text = "- Escojer Empresa -";
            // 
            // txtSalario
            // 
            this.txtSalario.EditValue = "Cantidad $$";
            this.txtSalario.Location = new System.Drawing.Point(77, 260);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtSalario.Properties.Appearance.Options.UseBackColor = true;
            this.txtSalario.Properties.Mask.BeepOnError = true;
            this.txtSalario.Properties.Mask.EditMask = "c0";
            this.txtSalario.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 22;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 564);
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tbNuevo.ResumeLayout(false);
            this.tbNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatos)).EndInit();
            this.tbBuscar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.error_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdSexo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckdTarjetaSi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckdTarjetaNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPuesto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalario.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.ComboBox cbbTipo;
        private System.Windows.Forms.ComboBox cbbSalida;
        private System.Windows.Forms.ComboBox cbbEntrada;
        private System.Windows.Forms.ComboBox cbbJornadaFinal;
        private System.Windows.Forms.ComboBox cbbJornadaInicio;
        private System.Windows.Forms.ComboBox cbbFormPago;
        private System.Windows.Forms.DateTimePicker txtFechaD;
        private System.Windows.Forms.DateTimePicker txtFechaI;
        private System.Windows.Forms.TextBox txtPuestoJefe;
        private System.Windows.Forms.TextBox txtJefe;
        private DevExpress.XtraEditors.SimpleButton btnEmpresaN;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private DevExpress.XtraEditors.RadioGroup rdSexo;
        private DevExpress.XtraEditors.CheckEdit ckdTarjetaSi;
        private DevExpress.XtraEditors.CheckEdit ckdTarjetaNo;
        private DevExpress.XtraEditors.TextEdit txtTelefono;
        private DevExpress.XtraGrid.GridControl gcCliente;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCliente;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.TextEdit txtDireccion;
        private DevExpress.XtraEditors.TextEdit txtPuesto;
        private System.Windows.Forms.ComboBox cbbEmpresa;
        private DevExpress.XtraEditors.TextEdit txtSalario;
    }
}