﻿
namespace CapaVistaSeguridadHSC
{
    partial class frmBitacora
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBitacora));
            this.pkIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moduloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aplicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conexionFechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conexionHoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnActualizarBitacora = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.verBitacora = new VistaBitacora.DGVBitacora();
            ((System.ComponentModel.ISupportInitialize)(this.verBitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // pkIdDataGridViewTextBoxColumn
            // 
            this.pkIdDataGridViewTextBoxColumn.DataPropertyName = "pkId";
            this.pkIdDataGridViewTextBoxColumn.HeaderText = "pkId";
            this.pkIdDataGridViewTextBoxColumn.Name = "pkIdDataGridViewTextBoxColumn";
            this.pkIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hostDataGridViewTextBoxColumn
            // 
            this.hostDataGridViewTextBoxColumn.DataPropertyName = "host";
            this.hostDataGridViewTextBoxColumn.HeaderText = "host";
            this.hostDataGridViewTextBoxColumn.Name = "hostDataGridViewTextBoxColumn";
            this.hostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ipDataGridViewTextBoxColumn
            // 
            this.ipDataGridViewTextBoxColumn.DataPropertyName = "ip";
            this.ipDataGridViewTextBoxColumn.HeaderText = "ip";
            this.ipDataGridViewTextBoxColumn.Name = "ipDataGridViewTextBoxColumn";
            this.ipDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moduloDataGridViewTextBoxColumn
            // 
            this.moduloDataGridViewTextBoxColumn.DataPropertyName = "modulo";
            this.moduloDataGridViewTextBoxColumn.HeaderText = "modulo";
            this.moduloDataGridViewTextBoxColumn.Name = "moduloDataGridViewTextBoxColumn";
            this.moduloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aplicacionDataGridViewTextBoxColumn
            // 
            this.aplicacionDataGridViewTextBoxColumn.DataPropertyName = "aplicacion";
            this.aplicacionDataGridViewTextBoxColumn.HeaderText = "aplicacion";
            this.aplicacionDataGridViewTextBoxColumn.Name = "aplicacionDataGridViewTextBoxColumn";
            this.aplicacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accionDataGridViewTextBoxColumn
            // 
            this.accionDataGridViewTextBoxColumn.DataPropertyName = "accion";
            this.accionDataGridViewTextBoxColumn.HeaderText = "accion";
            this.accionDataGridViewTextBoxColumn.Name = "accionDataGridViewTextBoxColumn";
            this.accionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // conexionFechaDataGridViewTextBoxColumn
            // 
            this.conexionFechaDataGridViewTextBoxColumn.DataPropertyName = "conexionFecha";
            this.conexionFechaDataGridViewTextBoxColumn.HeaderText = "conexionFecha";
            this.conexionFechaDataGridViewTextBoxColumn.Name = "conexionFechaDataGridViewTextBoxColumn";
            this.conexionFechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // conexionHoraDataGridViewTextBoxColumn
            // 
            this.conexionHoraDataGridViewTextBoxColumn.DataPropertyName = "conexionHora";
            this.conexionHoraDataGridViewTextBoxColumn.HeaderText = "conexionHora";
            this.conexionHoraDataGridViewTextBoxColumn.Name = "conexionHoraDataGridViewTextBoxColumn";
            this.conexionHoraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(494, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bitácora";
            // 
            // btnActualizarBitacora
            // 
            this.btnActualizarBitacora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarBitacora.BackColor = System.Drawing.Color.White;
            this.btnActualizarBitacora.FlatAppearance.BorderSize = 0;
            this.btnActualizarBitacora.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizarBitacora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarBitacora.Location = new System.Drawing.Point(1086, 13);
            this.btnActualizarBitacora.Name = "btnActualizarBitacora";
            this.btnActualizarBitacora.Size = new System.Drawing.Size(93, 36);
            this.btnActualizarBitacora.TabIndex = 2;
            this.btnActualizarBitacora.Text = "Actualizar";
            this.btnActualizarBitacora.UseVisualStyleBackColor = false;
            this.btnActualizarBitacora.Click += new System.EventHandler(this.btnActualizarBitacora_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(27, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1137, 465);
            this.panel1.TabIndex = 3;
            // 
            // verBitacora
            // 
            this.verBitacora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.verBitacora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.verBitacora.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.verBitacora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.verBitacora.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.verBitacora.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.verBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.verBitacora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.verBitacora.Location = new System.Drawing.Point(27, 77);
            this.verBitacora.MultiSelect = false;
            this.verBitacora.Name = "verBitacora";
            this.verBitacora.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.verBitacora.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.verBitacora.RowHeadersVisible = false;
            this.verBitacora.Size = new System.Drawing.Size(1137, 465);
            this.verBitacora.TabIndex = 0;
            // 
            // frmBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaVistaSeguridadHSC.Properties.Resources._90_Simple_Backgrounds_Edit_and_Download_Visual_Learning_Center;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1191, 568);
            this.Controls.Add(this.verBitacora);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnActualizarBitacora);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBitacora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "0011 Bitácora";
            this.Load += new System.EventHandler(this.frmBitacora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.verBitacora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnActualizarBitacora;
        private VistaBitacora.DGVBitacora dgvBitacora1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moduloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aplicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conexionFechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conexionHoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private VistaBitacora.DGVBitacora verBitacora;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hostDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn moduloDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aplicacionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn accionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn conexionFechaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn conexionHoraDataGridViewTextBoxColumn1;
    }
}