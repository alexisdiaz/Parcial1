
namespace Parcial1
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
            this.LblDe = new System.Windows.Forms.Label();
            this.LblA = new System.Windows.Forms.Label();
            this.BtnConvertir = new System.Windows.Forms.Button();
            this.CboDeConversor = new System.Windows.Forms.ComboBox();
            this.CboAConversor = new System.Windows.Forms.ComboBox();
            this.TxtCantidadConversor = new System.Windows.Forms.TextBox();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.LblRespuesta = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.CboxTipo = new System.Windows.Forms.ComboBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblDe
            // 
            this.LblDe.AutoSize = true;
            this.LblDe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDe.Location = new System.Drawing.Point(91, 97);
            this.LblDe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDe.Name = "LblDe";
            this.LblDe.Size = new System.Drawing.Size(32, 19);
            this.LblDe.TabIndex = 0;
            this.LblDe.Text = "DE:";
            // 
            // LblA
            // 
            this.LblA.AutoSize = true;
            this.LblA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblA.Location = new System.Drawing.Point(91, 136);
            this.LblA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblA.Name = "LblA";
            this.LblA.Size = new System.Drawing.Size(23, 19);
            this.LblA.TabIndex = 1;
            this.LblA.Text = "A:";
            // 
            // BtnConvertir
            // 
            this.BtnConvertir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConvertir.Location = new System.Drawing.Point(112, 276);
            this.BtnConvertir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnConvertir.Name = "BtnConvertir";
            this.BtnConvertir.Size = new System.Drawing.Size(152, 79);
            this.BtnConvertir.TabIndex = 2;
            this.BtnConvertir.Text = "Convertir";
            this.BtnConvertir.UseVisualStyleBackColor = true;
            this.BtnConvertir.Click += new System.EventHandler(this.BtnConvertir_Click);
            // 
            // CboDeConversor
            // 
            this.CboDeConversor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboDeConversor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboDeConversor.FormattingEnabled = true;
            this.CboDeConversor.Location = new System.Drawing.Point(133, 94);
            this.CboDeConversor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CboDeConversor.Name = "CboDeConversor";
            this.CboDeConversor.Size = new System.Drawing.Size(149, 27);
            this.CboDeConversor.TabIndex = 3;
            // 
            // CboAConversor
            // 
            this.CboAConversor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboAConversor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboAConversor.FormattingEnabled = true;
            this.CboAConversor.Location = new System.Drawing.Point(133, 136);
            this.CboAConversor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CboAConversor.Name = "CboAConversor";
            this.CboAConversor.Size = new System.Drawing.Size(149, 27);
            this.CboAConversor.TabIndex = 4;
            // 
            // TxtCantidadConversor
            // 
            this.TxtCantidadConversor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidadConversor.Location = new System.Drawing.Point(148, 190);
            this.TxtCantidadConversor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtCantidadConversor.Name = "TxtCantidadConversor";
            this.TxtCantidadConversor.Size = new System.Drawing.Size(116, 26);
            this.TxtCantidadConversor.TabIndex = 5;
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.Location = new System.Drawing.Point(71, 190);
            this.LblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(67, 19);
            this.LblCantidad.TabIndex = 6;
            this.LblCantidad.Text = "Cantidad:";
            // 
            // LblRespuesta
            // 
            this.LblRespuesta.AutoSize = true;
            this.LblRespuesta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRespuesta.Location = new System.Drawing.Point(71, 238);
            this.LblRespuesta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRespuesta.Name = "LblRespuesta";
            this.LblRespuesta.Size = new System.Drawing.Size(85, 19);
            this.LblRespuesta.TabIndex = 7;
            this.LblRespuesta.Text = "Respuesta: ?";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(91, 46);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(36, 19);
            this.lblTipo.TabIndex = 8;
            this.lblTipo.Text = "Tipo";
            // 
            // CboxTipo
            // 
            this.CboxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxTipo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboxTipo.FormattingEnabled = true;
            this.CboxTipo.Items.AddRange(new object[] {
            "Superficie"});
            this.CboxTipo.Location = new System.Drawing.Point(133, 43);
            this.CboxTipo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CboxTipo.Name = "CboxTipo";
            this.CboxTipo.Size = new System.Drawing.Size(149, 27);
            this.CboxTipo.TabIndex = 9;
            this.CboxTipo.TextChanged += new System.EventHandler(this.CboxTipo_TextChanged);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(304, 283);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(95, 66);
            this.BtnSalir.TabIndex = 10;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.CboxTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.LblRespuesta);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.TxtCantidadConversor);
            this.Controls.Add(this.CboAConversor);
            this.Controls.Add(this.CboDeConversor);
            this.Controls.Add(this.BtnConvertir);
            this.Controls.Add(this.LblA);
            this.Controls.Add(this.LblDe);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblDe;
        private System.Windows.Forms.Label LblA;
        private System.Windows.Forms.Button BtnConvertir;
        private System.Windows.Forms.ComboBox CboDeConversor;
        private System.Windows.Forms.ComboBox CboAConversor;
        private System.Windows.Forms.TextBox TxtCantidadConversor;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.Label LblRespuesta;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox CboxTipo;
        private System.Windows.Forms.Button BtnSalir;
    }
}

