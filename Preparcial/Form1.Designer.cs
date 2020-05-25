namespace Preparcial
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LoginUser = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxContra = new System.Windows.Forms.TextBox();
            this.Admi = new System.Windows.Forms.RadioButton();
            this.Cliente = new System.Windows.Forms.RadioButton();
            this.ButtonIngresar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.LoginUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.LoginUser, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-3, -7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(547, 327);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // LoginUser
            // 
            this.LoginUser.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.LoginUser, 2);
            this.LoginUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LoginUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LoginUser.Controls.Add(this.label1, 0, 1);
            this.LoginUser.Controls.Add(this.label2, 0, 2);
            this.LoginUser.Controls.Add(this.textBoxContra, 1, 2);
            this.LoginUser.Controls.Add(this.Admi, 0, 3);
            this.LoginUser.Controls.Add(this.Cliente, 1, 3);
            this.LoginUser.Controls.Add(this.ButtonIngresar, 0, 4);
            this.LoginUser.Controls.Add(this.comboBox1, 1, 1);
            this.LoginUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginUser.Location = new System.Drawing.Point(3, 52);
            this.LoginUser.Name = "LoginUser";
            this.LoginUser.RowCount = 6;
            this.LoginUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.LoginUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LoginUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LoginUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LoginUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.LoginUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.LoginUser.Size = new System.Drawing.Size(541, 272);
            this.LoginUser.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Usuario:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(3, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 68);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contrasenia:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxContra
            // 
            this.textBoxContra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxContra.Location = new System.Drawing.Point(348, 105);
            this.textBoxContra.Name = "textBoxContra";
            this.textBoxContra.PasswordChar = '*';
            this.textBoxContra.Size = new System.Drawing.Size(114, 20);
            this.textBoxContra.TabIndex = 3;
            // 
            // Admi
            // 
            this.Admi.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Admi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Admi.Location = new System.Drawing.Point(115, 152);
            this.Admi.Name = "Admi";
            this.Admi.Size = new System.Drawing.Size(152, 31);
            this.Admi.TabIndex = 4;
            this.Admi.TabStop = true;
            this.Admi.Text = "Administrador";
            this.Admi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Admi.UseVisualStyleBackColor = true;
            // 
            // Cliente
            // 
            this.Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Cliente.Location = new System.Drawing.Point(273, 152);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(152, 31);
            this.Cliente.TabIndex = 5;
            this.Cliente.TabStop = true;
            this.Cliente.Text = "Cliente";
            this.Cliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cliente.UseVisualStyleBackColor = true;
            // 
            // ButtonIngresar
            // 
            this.ButtonIngresar.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ButtonIngresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoginUser.SetColumnSpan(this.ButtonIngresar, 2);
            this.ButtonIngresar.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ButtonIngresar.Location = new System.Drawing.Point(177, 220);
            this.ButtonIngresar.Name = "ButtonIngresar";
            this.ButtonIngresar.Size = new System.Drawing.Size(186, 34);
            this.ButtonIngresar.TabIndex = 6;
            this.ButtonIngresar.Text = "Ingresar";
            this.ButtonIngresar.UseVisualStyleBackColor = true;
            this.ButtonIngresar.Click += new System.EventHandler(this.ButtonIngresar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(318, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(543, 319);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.LoginUser.ResumeLayout(false);
            this.LoginUser.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.RadioButton Admi;
        private System.Windows.Forms.Button ButtonIngresar;
        private System.Windows.Forms.RadioButton Cliente;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel LoginUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxContra;

        #endregion
    }
}