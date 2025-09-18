namespace pryAstudilloCabaña
{
    partial class frmRegistroCabañas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroCabañas));
            grbTipoCabañas = new GroupBox();
            cmbDías = new ComboBox();
            lblDías = new Label();
            cmbPersonas = new ComboBox();
            lblPersonas = new Label();
            cmbTipo = new ComboBox();
            lblTipoCabaña = new Label();
            grbAdicionales = new GroupBox();
            chkAdicionales = new CheckedListBox();
            grbPago = new GroupBox();
            label1 = new Label();
            cmbTarjetas = new ComboBox();
            optTarjeta = new RadioButton();
            optEfectivo = new RadioButton();
            grbTitularReserva = new GroupBox();
            lblNombreVer = new Label();
            lblTélefono = new Label();
            txtNombre = new TextBox();
            mtbTelefono = new MaskedTextBox();
            lblNombremal = new Label();
            btnCancelar = new Button();
            btnRegistrar = new Button();
            lstRegistro = new ListBox();
            grbTipoCabañas.SuspendLayout();
            grbAdicionales.SuspendLayout();
            grbPago.SuspendLayout();
            grbTitularReserva.SuspendLayout();
            SuspendLayout();
            // 
            // grbTipoCabañas
            // 
            grbTipoCabañas.Controls.Add(cmbDías);
            grbTipoCabañas.Controls.Add(lblDías);
            grbTipoCabañas.Controls.Add(cmbPersonas);
            grbTipoCabañas.Controls.Add(lblPersonas);
            grbTipoCabañas.Controls.Add(cmbTipo);
            grbTipoCabañas.Controls.Add(lblTipoCabaña);
            grbTipoCabañas.Location = new Point(12, 12);
            grbTipoCabañas.Name = "grbTipoCabañas";
            grbTipoCabañas.Size = new Size(617, 100);
            grbTipoCabañas.TabIndex = 0;
            grbTipoCabañas.TabStop = false;
            grbTipoCabañas.Text = "Tipo de cabañas";
            // 
            // cmbDías
            // 
            cmbDías.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDías.FormattingEnabled = true;
            cmbDías.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cmbDías.Location = new Point(448, 45);
            cmbDías.Name = "cmbDías";
            cmbDías.Size = new Size(147, 23);
            cmbDías.TabIndex = 8;
            // 
            // lblDías
            // 
            lblDías.AutoSize = true;
            lblDías.Location = new Point(413, 50);
            lblDías.Name = "lblDías";
            lblDías.Size = new Size(29, 15);
            lblDías.TabIndex = 7;
            lblDías.Text = "Días";
            // 
            // cmbPersonas
            // 
            cmbPersonas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPersonas.FormattingEnabled = true;
            cmbPersonas.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            cmbPersonas.Location = new Point(260, 45);
            cmbPersonas.Name = "cmbPersonas";
            cmbPersonas.Size = new Size(147, 23);
            cmbPersonas.TabIndex = 6;
            cmbPersonas.SelectedIndexChanged += cmbPersonas_SelectedIndexChanged;
            // 
            // lblPersonas
            // 
            lblPersonas.AutoSize = true;
            lblPersonas.Location = new Point(198, 50);
            lblPersonas.Name = "lblPersonas";
            lblPersonas.Size = new Size(54, 15);
            lblPersonas.TabIndex = 3;
            lblPersonas.Text = "Personas";
            lblPersonas.Click += lblPersonas_Click;
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "A", "B" });
            cmbTipo.Location = new Point(45, 45);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(147, 23);
            cmbTipo.TabIndex = 5;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // lblTipoCabaña
            // 
            lblTipoCabaña.AutoSize = true;
            lblTipoCabaña.Location = new Point(6, 48);
            lblTipoCabaña.Name = "lblTipoCabaña";
            lblTipoCabaña.Size = new Size(33, 15);
            lblTipoCabaña.TabIndex = 4;
            lblTipoCabaña.Text = "Tipo ";
            // 
            // grbAdicionales
            // 
            grbAdicionales.Controls.Add(chkAdicionales);
            grbAdicionales.Location = new Point(12, 131);
            grbAdicionales.Name = "grbAdicionales";
            grbAdicionales.Size = new Size(159, 108);
            grbAdicionales.TabIndex = 0;
            grbAdicionales.TabStop = false;
            grbAdicionales.Text = "Adicionales";
            // 
            // chkAdicionales
            // 
            chkAdicionales.BackColor = SystemColors.Control;
            chkAdicionales.BorderStyle = BorderStyle.None;
            chkAdicionales.FormattingEnabled = true;
            chkAdicionales.Items.AddRange(new object[] { "Cocina", "Heladera", "Televisor" });
            chkAdicionales.Location = new Point(17, 31);
            chkAdicionales.Name = "chkAdicionales";
            chkAdicionales.Size = new Size(120, 54);
            chkAdicionales.TabIndex = 3;
            // 
            // grbPago
            // 
            grbPago.Controls.Add(label1);
            grbPago.Controls.Add(cmbTarjetas);
            grbPago.Controls.Add(optTarjeta);
            grbPago.Controls.Add(optEfectivo);
            grbPago.Location = new Point(214, 139);
            grbPago.Name = "grbPago";
            grbPago.Size = new Size(415, 100);
            grbPago.TabIndex = 0;
            grbPago.TabStop = false;
            grbPago.Text = "Tipo de pago";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(194, 50);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 5;
            label1.Text = "Tarjetas";
            // 
            // cmbTarjetas
            // 
            cmbTarjetas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTarjetas.FormattingEnabled = true;
            cmbTarjetas.Items.AddRange(new object[] { "Card Red", "Card Green", "Card Blue" });
            cmbTarjetas.Location = new Point(194, 68);
            cmbTarjetas.Name = "cmbTarjetas";
            cmbTarjetas.Size = new Size(199, 23);
            cmbTarjetas.TabIndex = 6;
            // 
            // optTarjeta
            // 
            optTarjeta.AutoSize = true;
            optTarjeta.Location = new Point(15, 48);
            optTarjeta.Name = "optTarjeta";
            optTarjeta.Size = new Size(59, 19);
            optTarjeta.TabIndex = 3;
            optTarjeta.TabStop = true;
            optTarjeta.Text = "Tarjeta";
            optTarjeta.UseVisualStyleBackColor = true;
            // 
            // optEfectivo
            // 
            optEfectivo.AutoSize = true;
            optEfectivo.Location = new Point(15, 23);
            optEfectivo.Name = "optEfectivo";
            optEfectivo.Size = new Size(67, 19);
            optEfectivo.TabIndex = 4;
            optEfectivo.TabStop = true;
            optEfectivo.Text = "Efectivo";
            optEfectivo.UseVisualStyleBackColor = true;
            // 
            // grbTitularReserva
            // 
            grbTitularReserva.Controls.Add(lblNombreVer);
            grbTitularReserva.Controls.Add(lblTélefono);
            grbTitularReserva.Controls.Add(txtNombre);
            grbTitularReserva.Controls.Add(mtbTelefono);
            grbTitularReserva.Location = new Point(18, 272);
            grbTitularReserva.Name = "grbTitularReserva";
            grbTitularReserva.Size = new Size(617, 100);
            grbTitularReserva.TabIndex = 0;
            grbTitularReserva.TabStop = false;
            grbTitularReserva.Text = "Titular de la Reserva";
            // 
            // lblNombreVer
            // 
            lblNombreVer.AutoSize = true;
            lblNombreVer.Location = new Point(17, 35);
            lblNombreVer.Name = "lblNombreVer";
            lblNombreVer.Size = new Size(51, 15);
            lblNombreVer.TabIndex = 13;
            lblNombreVer.Text = "Nombre";
            // 
            // lblTélefono
            // 
            lblTélefono.AutoSize = true;
            lblTélefono.Location = new Point(17, 71);
            lblTélefono.Name = "lblTélefono";
            lblTélefono.Size = new Size(52, 15);
            lblTélefono.TabIndex = 9;
            lblTélefono.Text = "Télefono";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(124, 27);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(253, 23);
            txtNombre.TabIndex = 11;
            // 
            // mtbTelefono
            // 
            mtbTelefono.Location = new Point(124, 63);
            mtbTelefono.Mask = "351-000-0000";
            mtbTelefono.Name = "mtbTelefono";
            mtbTelefono.Size = new Size(253, 23);
            mtbTelefono.TabIndex = 12;
            mtbTelefono.MaskInputRejected += mtbTelefono_MaskInputRejected;
            // 
            // lblNombremal
            // 
            lblNombremal.AutoSize = true;
            lblNombremal.ForeColor = Color.Black;
            lblNombremal.Location = new Point(6, 34);
            lblNombremal.Name = "lblNombremal";
            lblNombremal.Size = new Size(51, 15);
            lblNombremal.TabIndex = 10;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(435, 389);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(526, 389);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "&Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // lstRegistro
            // 
            lstRegistro.FormattingEnabled = true;
            lstRegistro.ItemHeight = 15;
            lstRegistro.Location = new Point(18, 436);
            lstRegistro.Name = "lstRegistro";
            lstRegistro.Size = new Size(611, 124);
            lstRegistro.TabIndex = 2;
            // 
            // frmRegistroCabañas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 572);
            Controls.Add(lstRegistro);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrar);
            Controls.Add(grbTitularReserva);
            Controls.Add(grbPago);
            Controls.Add(grbAdicionales);
            Controls.Add(grbTipoCabañas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(456, 451);
            Name = "frmRegistroCabañas";
            Text = "Reserva de Cabañas";
            Load += frmRegistroCabañas_Load;
            grbTipoCabañas.ResumeLayout(false);
            grbTipoCabañas.PerformLayout();
            grbAdicionales.ResumeLayout(false);
            grbPago.ResumeLayout(false);
            grbPago.PerformLayout();
            grbTitularReserva.ResumeLayout(false);
            grbTitularReserva.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbTipoCabañas;
        private GroupBox grbAdicionales;
        private GroupBox grbPago;
        private GroupBox grbTitularReserva;
        private Button btnCancelar;
        private Button btnRegistrar;
        private ListBox lstRegistro;
        private Label lblPersonas;
        private ComboBox cmbTipo;
        private Label lblTipoCabaña;
        private ComboBox cmbPersonas;
        private ComboBox cmbDías;
        private Label lblDías;
        private CheckedListBox chkAdicionales;
        private Label lblTélefono;
        private Label lblNombremal;
        private TextBox txtNombre;
        private MaskedTextBox mtbTelefono;
        private Label label1;
        private ComboBox cmbTarjetas;
        private RadioButton optTarjeta;
        private RadioButton optEfectivo;
        private Label lblNombreVer;
    }
}