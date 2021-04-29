
namespace presentacion
{
    partial class frmPokemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPokemo));
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblURLimagen = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtURLimgane = new System.Windows.Forms.TextBox();
            this.numNumero = new System.Windows.Forms.NumericUpDown();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numNumero)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(50, 26);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 18);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(50, 65);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(64, 18);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "Numero";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(21, 101);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(93, 18);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblURLimagen
            // 
            this.lblURLimagen.AutoSize = true;
            this.lblURLimagen.Location = new System.Drawing.Point(20, 139);
            this.lblURLimagen.Name = "lblURLimagen";
            this.lblURLimagen.Size = new System.Drawing.Size(94, 18);
            this.lblURLimagen.TabIndex = 3;
            this.lblURLimagen.Text = "URL Imagen";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(74, 179);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(40, 18);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Tipo";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.Location = new System.Drawing.Point(53, 222);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(88, 42);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(192, 222);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 42);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(136, 23);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(186, 25);
            this.txtNombre.TabIndex = 7;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(136, 98);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(186, 25);
            this.txtDescripcion.TabIndex = 8;
            // 
            // txtURLimgane
            // 
            this.txtURLimgane.Location = new System.Drawing.Point(136, 136);
            this.txtURLimgane.Name = "txtURLimgane";
            this.txtURLimgane.Size = new System.Drawing.Size(186, 25);
            this.txtURLimgane.TabIndex = 9;
            // 
            // numNumero
            // 
            this.numNumero.Location = new System.Drawing.Point(136, 63);
            this.numNumero.Name = "numNumero";
            this.numNumero.Size = new System.Drawing.Size(186, 25);
            this.numNumero.TabIndex = 10;
            this.numNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(136, 176);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(186, 26);
            this.cboTipo.TabIndex = 11;
            // 
            // frmPokemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 292);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.numNumero);
            this.Controls.Add(this.txtURLimgane);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblURLimagen);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblNombre);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(392, 331);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(392, 331);
            this.Name = "frmPokemo";
            this.Text = "Pokedex - Agregar Pokemon";
            ((System.ComponentModel.ISupportInitialize)(this.numNumero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblURLimagen;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtURLimgane;
        private System.Windows.Forms.NumericUpDown numNumero;
        private System.Windows.Forms.ComboBox cboTipo;
    }
}