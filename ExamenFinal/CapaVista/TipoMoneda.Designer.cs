namespace CapaVista
{
    partial class TipoMoneda
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
            this.navegador1 = new CapaVistaNavegador.Navegador();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.lblSimbolo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtMoneda = new System.Windows.Forms.TextBox();
            this.txtSimbolo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.rbtnActivo = new System.Windows.Forms.RadioButton();
            this.rbtnInactivo = new System.Windows.Forms.RadioButton();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.Transparent;
            this.navegador1.Location = new System.Drawing.Point(55, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1059, 105);
            this.navegador1.TabIndex = 0;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.Location = new System.Drawing.Point(40, 186);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(46, 13);
            this.lblMoneda.TabIndex = 1;
            this.lblMoneda.Text = "Moneda";
            // 
            // lblSimbolo
            // 
            this.lblSimbolo.AutoSize = true;
            this.lblSimbolo.Location = new System.Drawing.Point(40, 221);
            this.lblSimbolo.Name = "lblSimbolo";
            this.lblSimbolo.Size = new System.Drawing.Size(101, 13);
            this.lblSimbolo.TabIndex = 2;
            this.lblSimbolo.Text = "Simbolo de Moneda";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(40, 250);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(40, 361);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(43, 153);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 10;
            this.lblId.Text = "Id";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(93, 147);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(76, 23);
            this.txtCodigo.TabIndex = 28;
            this.txtCodigo.Tag = "pk_id_tipo_moneda";
            // 
            // txtMoneda
            // 
            this.txtMoneda.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoneda.Location = new System.Drawing.Point(93, 180);
            this.txtMoneda.Margin = new System.Windows.Forms.Padding(2);
            this.txtMoneda.Name = "txtMoneda";
            this.txtMoneda.Size = new System.Drawing.Size(282, 23);
            this.txtMoneda.TabIndex = 29;
            this.txtMoneda.Tag = "moneda_tipo_moneda";
            this.txtMoneda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMoneda_KeyPress);
            // 
            // txtSimbolo
            // 
            this.txtSimbolo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSimbolo.Location = new System.Drawing.Point(158, 215);
            this.txtSimbolo.Margin = new System.Windows.Forms.Padding(2);
            this.txtSimbolo.Name = "txtSimbolo";
            this.txtSimbolo.Size = new System.Drawing.Size(282, 23);
            this.txtSimbolo.TabIndex = 30;
            this.txtSimbolo.Tag = "simbolo_tipo_moneda";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(122, 244);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(282, 95);
            this.txtDescripcion.TabIndex = 31;
            this.txtDescripcion.Tag = "descripcion_tipo_moneda";
            // 
            // rbtnActivo
            // 
            this.rbtnActivo.AutoSize = true;
            this.rbtnActivo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnActivo.Location = new System.Drawing.Point(93, 370);
            this.rbtnActivo.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnActivo.Name = "rbtnActivo";
            this.rbtnActivo.Size = new System.Drawing.Size(67, 21);
            this.rbtnActivo.TabIndex = 39;
            this.rbtnActivo.TabStop = true;
            this.rbtnActivo.Text = "Activo";
            this.rbtnActivo.UseVisualStyleBackColor = true;
            this.rbtnActivo.CheckedChanged += new System.EventHandler(this.rbtnActivo_CheckedChanged);
            // 
            // rbtnInactivo
            // 
            this.rbtnInactivo.AutoSize = true;
            this.rbtnInactivo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnInactivo.Location = new System.Drawing.Point(178, 370);
            this.rbtnInactivo.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnInactivo.Name = "rbtnInactivo";
            this.rbtnInactivo.Size = new System.Drawing.Size(76, 21);
            this.rbtnInactivo.TabIndex = 40;
            this.rbtnInactivo.TabStop = true;
            this.rbtnInactivo.Text = "Inactivo";
            this.rbtnInactivo.UseVisualStyleBackColor = true;
            this.rbtnInactivo.CheckedChanged += new System.EventHandler(this.rbtnInactivo_CheckedChanged);
            // 
            // txtEstado
            // 
            this.txtEstado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(353, 343);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(2);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(51, 23);
            this.txtEstado.TabIndex = 41;
            this.txtEstado.Tag = "estado_tipo_moneda";
            this.txtEstado.Visible = false;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(499, 147);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(602, 239);
            this.dgvDatos.TabIndex = 42;
            // 
            // TipoMoneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1170, 450);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.rbtnInactivo);
            this.Controls.Add(this.rbtnActivo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtSimbolo);
            this.Controls.Add(this.txtMoneda);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblSimbolo);
            this.Controls.Add(this.lblMoneda);
            this.Controls.Add(this.navegador1);
            this.Name = "TipoMoneda";
            this.Text = "TipoMoneda";
            this.Load += new System.EventHandler(this.TipoMoneda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CapaVistaNavegador.Navegador navegador1;
        private System.Windows.Forms.Label lblMoneda;
        private System.Windows.Forms.Label lblSimbolo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtMoneda;
        private System.Windows.Forms.TextBox txtSimbolo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.RadioButton rbtnActivo;
        private System.Windows.Forms.RadioButton rbtnInactivo;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.DataGridView dgvDatos;
    }
}