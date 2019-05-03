﻿namespace PointOfSale.Views.Modulos.Catalogos
{
    partial class FrmEstaciones
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
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.CboIT = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CboIR = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CboIF = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CboINC = new System.Windows.Forms.ComboBox();
            this.TxtAlmacenId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(296, 345);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(148, 40);
            this.BtnCancelar.TabIndex = 8;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(143, 345);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(148, 40);
            this.BtnAceptar.TabIndex = 7;
            this.BtnAceptar.Text = "ACEPTAR";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.ForeColor = System.Drawing.Color.Black;
            this.TxtNombre.Location = new System.Drawing.Point(168, 74);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(131, 24);
            this.TxtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(165, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 133;
            this.label1.Text = "NOMBRE";
            // 
            // TxtClave
            // 
            this.TxtClave.BackColor = System.Drawing.SystemColors.Window;
            this.TxtClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtClave.ForeColor = System.Drawing.Color.Black;
            this.TxtClave.Location = new System.Drawing.Point(12, 74);
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.Size = new System.Drawing.Size(131, 24);
            this.TxtClave.TabIndex = 0;
            this.TxtClave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtClave_KeyDown);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitulo.Location = new System.Drawing.Point(-1, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(118, 25);
            this.lblTitulo.TabIndex = 129;
            this.lblTitulo.Text = "Estaciones";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label14.Location = new System.Drawing.Point(1, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(453, 10);
            this.label14.TabIndex = 128;
            // 
            // CboIT
            // 
            this.CboIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.CboIT.FormattingEnabled = true;
            this.CboIT.Location = new System.Drawing.Point(12, 137);
            this.CboIT.Name = "CboIT";
            this.CboIT.Size = new System.Drawing.Size(433, 26);
            this.CboIT.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 18);
            this.label2.TabIndex = 137;
            this.label2.Text = "IMPRESORA TICKETS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(12, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 18);
            this.label3.TabIndex = 139;
            this.label3.Text = "IMPRESORA REMISIONES";
            // 
            // CboIR
            // 
            this.CboIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.CboIR.FormattingEnabled = true;
            this.CboIR.Location = new System.Drawing.Point(12, 192);
            this.CboIR.Name = "CboIR";
            this.CboIR.Size = new System.Drawing.Size(433, 26);
            this.CboIR.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(12, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 18);
            this.label4.TabIndex = 141;
            this.label4.Text = "IMPRESORA FACTURAS";
            // 
            // CboIF
            // 
            this.CboIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.CboIF.FormattingEnabled = true;
            this.CboIF.Location = new System.Drawing.Point(12, 251);
            this.CboIF.Name = "CboIF";
            this.CboIF.Size = new System.Drawing.Size(433, 26);
            this.CboIF.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(12, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 18);
            this.label5.TabIndex = 143;
            this.label5.Text = "IMPRESORA NOTAS CRÉDITO";
            // 
            // CboINC
            // 
            this.CboINC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.CboINC.FormattingEnabled = true;
            this.CboINC.Location = new System.Drawing.Point(12, 304);
            this.CboINC.Name = "CboINC";
            this.CboINC.Size = new System.Drawing.Size(433, 26);
            this.CboINC.TabIndex = 6;
            // 
            // TxtAlmacenId
            // 
            this.TxtAlmacenId.BackColor = System.Drawing.SystemColors.Window;
            this.TxtAlmacenId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtAlmacenId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAlmacenId.ForeColor = System.Drawing.Color.Black;
            this.TxtAlmacenId.Location = new System.Drawing.Point(313, 74);
            this.TxtAlmacenId.Name = "TxtAlmacenId";
            this.TxtAlmacenId.Size = new System.Drawing.Size(131, 24);
            this.TxtAlmacenId.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(310, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 18);
            this.label7.TabIndex = 145;
            this.label7.Text = "♥ALMACEN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(12, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 18);
            this.label6.TabIndex = 146;
            this.label6.Text = "♥CLAVE";
            // 
            // FrmEstaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 397);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtAlmacenId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CboINC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CboIF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CboIR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CboIT);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtClave);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label14);
            this.Name = "FrmEstaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEstaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox CboIT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboIR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CboIF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CboINC;
        private System.Windows.Forms.TextBox TxtAlmacenId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}