using System.ComponentModel;

namespace Preparcial
{
    partial class Cliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonpedidos = new System.Windows.Forms.Button();
            this.buttonHistorial = new System.Windows.Forms.Button();
            this.crearUsuario1 = new Preparcial.CrearUsuario();
            this.SuspendLayout();
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(-1, 0);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(179, 51);
            this.buttonRegister.TabIndex = 0;
            this.buttonRegister.Text = "Crear Usuario";
            this.buttonRegister.UseVisualStyleBackColor = true;
            // 
            // buttonpedidos
            // 
            this.buttonpedidos.Location = new System.Drawing.Point(184, 0);
            this.buttonpedidos.Name = "buttonpedidos";
            this.buttonpedidos.Size = new System.Drawing.Size(181, 51);
            this.buttonpedidos.TabIndex = 1;
            this.buttonpedidos.Text = "Realizar pedido";
            this.buttonpedidos.UseVisualStyleBackColor = true;
            // 
            // buttonHistorial
            // 
            this.buttonHistorial.Location = new System.Drawing.Point(371, 0);
            this.buttonHistorial.Name = "buttonHistorial";
            this.buttonHistorial.Size = new System.Drawing.Size(168, 51);
            this.buttonHistorial.TabIndex = 2;
            this.buttonHistorial.Text = "Historial de pedidos";
            this.buttonHistorial.UseVisualStyleBackColor = true;
            // 
            // crearUsuario1
            // 
            this.crearUsuario1.Location = new System.Drawing.Point(-1, 48);
            this.crearUsuario1.Name = "crearUsuario1";
            this.crearUsuario1.Size = new System.Drawing.Size(548, 351);
            this.crearUsuario1.TabIndex = 3;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 398);
            this.Controls.Add(this.crearUsuario1);
            this.Controls.Add(this.buttonHistorial);
            this.Controls.Add(this.buttonpedidos);
            this.Controls.Add(this.buttonRegister);
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonHistorial;
        private System.Windows.Forms.Button buttonpedidos;
        private System.Windows.Forms.Button buttonRegister;
        private Preparcial.CrearUsuario crearUsuario1;

        #endregion
    }
}