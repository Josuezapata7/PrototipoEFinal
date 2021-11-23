
namespace CapaVistaPolizaF
{
    partial class cuentasContables
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
            this.lblIdCuenta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTipoCuenta = new System.Windows.Forms.ComboBox();
            this.lblTipoCuenta = new System.Windows.Forms.Label();
            this.txtIdCuenta = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblAbono = new System.Windows.Forms.Label();
            this.txtxNombreCuenta = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtAbono = new System.Windows.Forms.TextBox();
            this.lblActivo = new System.Windows.Forms.Label();
            this.dgvCuentas = new System.Windows.Forms.DataGridView();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.lblDet = new System.Windows.Forms.Label();
            this.btnDarBaja = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdCuenta
            // 
            this.lblIdCuenta.AutoSize = true;
            this.lblIdCuenta.Location = new System.Drawing.Point(34, 86);
            this.lblIdCuenta.Name = "lblIdCuenta";
            this.lblIdCuenta.Size = new System.Drawing.Size(55, 13);
            this.lblIdCuenta.TabIndex = 1;
            this.lblIdCuenta.Text = "ID Cuenta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre Cuenta";
            // 
            // cbxTipoCuenta
            // 
            this.cbxTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoCuenta.FormattingEnabled = true;
            this.cbxTipoCuenta.Location = new System.Drawing.Point(37, 263);
            this.cbxTipoCuenta.Name = "cbxTipoCuenta";
            this.cbxTipoCuenta.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoCuenta.TabIndex = 5;
            // 
            // lblTipoCuenta
            // 
            this.lblTipoCuenta.AutoSize = true;
            this.lblTipoCuenta.Location = new System.Drawing.Point(37, 239);
            this.lblTipoCuenta.Name = "lblTipoCuenta";
            this.lblTipoCuenta.Size = new System.Drawing.Size(65, 13);
            this.lblTipoCuenta.TabIndex = 6;
            this.lblTipoCuenta.Text = "Tipo Cuenta";
            // 
            // txtIdCuenta
            // 
            this.txtIdCuenta.Location = new System.Drawing.Point(37, 102);
            this.txtIdCuenta.Name = "txtIdCuenta";
            this.txtIdCuenta.Size = new System.Drawing.Size(100, 20);
            this.txtIdCuenta.TabIndex = 7;
            this.txtIdCuenta.Tag = "idCuenta";
            this.txtIdCuenta.TextChanged += new System.EventHandler(this.txtIdCuenta_TextChanged);
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(37, 308);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 9;
            this.lblCargo.Text = "Cargo";
            // 
            // lblAbono
            // 
            this.lblAbono.AutoSize = true;
            this.lblAbono.Location = new System.Drawing.Point(38, 378);
            this.lblAbono.Name = "lblAbono";
            this.lblAbono.Size = new System.Drawing.Size(38, 13);
            this.lblAbono.TabIndex = 11;
            this.lblAbono.Text = "Abono";
            // 
            // txtxNombreCuenta
            // 
            this.txtxNombreCuenta.Location = new System.Drawing.Point(37, 188);
            this.txtxNombreCuenta.Name = "txtxNombreCuenta";
            this.txtxNombreCuenta.Size = new System.Drawing.Size(100, 20);
            this.txtxNombreCuenta.TabIndex = 12;
            this.txtxNombreCuenta.Tag = "nombre";
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(37, 336);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(100, 20);
            this.txtCargo.TabIndex = 14;
            this.txtCargo.Tag = "cargo";
            // 
            // txtAbono
            // 
            this.txtAbono.Location = new System.Drawing.Point(37, 406);
            this.txtAbono.Name = "txtAbono";
            this.txtAbono.Size = new System.Drawing.Size(100, 20);
            this.txtAbono.TabIndex = 15;
            this.txtAbono.Tag = "abono";
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Location = new System.Drawing.Point(298, 206);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(42, 13);
            this.lblActivo.TabIndex = 17;
            this.lblActivo.Text = "Estatus";
            // 
            // dgvCuentas
            // 
            this.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuentas.Location = new System.Drawing.Point(450, 116);
            this.dgvCuentas.Name = "dgvCuentas";
            this.dgvCuentas.Size = new System.Drawing.Size(612, 376);
            this.dgvCuentas.TabIndex = 20;
            // 
            // txtEstatus
            // 
            this.txtEstatus.Location = new System.Drawing.Point(272, 232);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(100, 20);
            this.txtEstatus.TabIndex = 21;
            // 
            // lblDet
            // 
            this.lblDet.AutoSize = true;
            this.lblDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDet.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDet.Location = new System.Drawing.Point(539, 38);
            this.lblDet.Name = "lblDet";
            this.lblDet.Size = new System.Drawing.Size(108, 29);
            this.lblDet.TabIndex = 22;
            this.lblDet.Text = "Cuentas";
            // 
            // btnDarBaja
            // 
            this.btnDarBaja.FlatAppearance.BorderSize = 0;
            this.btnDarBaja.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnDarBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDarBaja.Location = new System.Drawing.Point(605, 555);
            this.btnDarBaja.Name = "btnDarBaja";
            this.btnDarBaja.Size = new System.Drawing.Size(103, 44);
            this.btnDarBaja.TabIndex = 25;
            this.btnDarBaja.Text = "Dar Baja";
            this.btnDarBaja.UseVisualStyleBackColor = true;
            this.btnDarBaja.Click += new System.EventHandler(this.btnDarBaja_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(496, 555);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(103, 44);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Location = new System.Drawing.Point(387, 555);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(103, 44);
            this.btnIngresar.TabIndex = 23;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(697, 555);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(103, 44);
            this.btnLimpiar.TabIndex = 26;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cuentasContables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1187, 611);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnDarBaja);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblDet);
            this.Controls.Add(this.txtEstatus);
            this.Controls.Add(this.dgvCuentas);
            this.Controls.Add(this.lblActivo);
            this.Controls.Add(this.txtAbono);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtxNombreCuenta);
            this.Controls.Add(this.lblAbono);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.txtIdCuenta);
            this.Controls.Add(this.lblTipoCuenta);
            this.Controls.Add(this.cbxTipoCuenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIdCuenta);
            this.Name = "cuentasContables";
            this.Text = "cuentasContables";
            this.Load += new System.EventHandler(this.cuentasContables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblIdCuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTipoCuenta;
        private System.Windows.Forms.Label lblTipoCuenta;
        private System.Windows.Forms.TextBox txtIdCuenta;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblAbono;
        private System.Windows.Forms.TextBox txtxNombreCuenta;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtAbono;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.DataGridView dgvCuentas;
        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.Label lblDet;
        private System.Windows.Forms.Button btnDarBaja;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}