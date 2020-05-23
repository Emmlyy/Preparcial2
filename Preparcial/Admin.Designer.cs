using System.ComponentModel;

namespace Preparcial
{
    partial class Admin
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
            this.buttonUsuario = new System.Windows.Forms.Button();
            this.buttonInventario = new System.Windows.Forms.Button();
            this.buttonviewdata = new System.Windows.Forms.Button();
            this.mantUsuario1 = new Preparcial.MantUsuario();
            this.SuspendLayout();
            // 
            // buttonUsuario
            // 
            this.buttonUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonUsuario.Location = new System.Drawing.Point(0, 0);
            this.buttonUsuario.Name = "buttonUsuario";
            this.buttonUsuario.Size = new System.Drawing.Size(181, 51);
            this.buttonUsuario.TabIndex = 0;
            this.buttonUsuario.Text = "Matenimiento Usuario";
            this.buttonUsuario.UseVisualStyleBackColor = true;
            this.buttonUsuario.Click += new System.EventHandler(this.buttonUsuario_Click);
            // 
            // buttonInventario
            // 
            this.buttonInventario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonInventario.Location = new System.Drawing.Point(180, 0);
            this.buttonInventario.Name = "buttonInventario";
            this.buttonInventario.Size = new System.Drawing.Size(196, 51);
            this.buttonInventario.TabIndex = 1;
            this.buttonInventario.Text = "Mantenimiento inventario";
            this.buttonInventario.UseVisualStyleBackColor = true;
            // 
            // buttonviewdata
            // 
            this.buttonviewdata.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonviewdata.Location = new System.Drawing.Point(375, 0);
            this.buttonviewdata.Name = "buttonviewdata";
            this.buttonviewdata.Size = new System.Drawing.Size(185, 51);
            this.buttonviewdata.TabIndex = 2;
            this.buttonviewdata.Text = "ver pedidos";
            this.buttonviewdata.UseVisualStyleBackColor = true;
            // 
            // mantUsuario1
            // 
            this.mantUsuario1.Location = new System.Drawing.Point(0, 47);
            this.mantUsuario1.Name = "mantUsuario1";
            this.mantUsuario1.Size = new System.Drawing.Size(568, 297);
            this.mantUsuario1.TabIndex = 3;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(569, 350);
            this.Controls.Add(this.mantUsuario1);
            this.Controls.Add(this.buttonviewdata);
            this.Controls.Add(this.buttonInventario);
            this.Controls.Add(this.buttonUsuario);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonInventario;
        private System.Windows.Forms.Button buttonUsuario;
        private System.Windows.Forms.Button buttonviewdata;
        private Preparcial.MantUsuario mantUsuario1;

        #endregion
    }
}