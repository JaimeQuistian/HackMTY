namespace Work
{
    partial class frmConoceTuCuerpo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConoceTuCuerpo));
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.BackColor = System.Drawing.Color.Transparent;
            this.lblEdad.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.ForeColor = System.Drawing.Color.White;
            this.lblEdad.Location = new System.Drawing.Point(22, 72);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(53, 18);
            this.lblEdad.TabIndex = 0;
            this.lblEdad.Text = "Edad:";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(25, 104);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(307, 21);
            this.txtEdad.TabIndex = 1;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(25, 180);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(307, 21);
            this.txtAltura.TabIndex = 3;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.BackColor = System.Drawing.Color.Transparent;
            this.lblAltura.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.ForeColor = System.Drawing.Color.White;
            this.lblAltura.Location = new System.Drawing.Point(22, 148);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(94, 18);
            this.lblAltura.TabIndex = 2;
            this.lblAltura.Text = "Altura cm:";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(25, 262);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(307, 21);
            this.txtPeso.TabIndex = 5;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.BackColor = System.Drawing.Color.Transparent;
            this.lblPeso.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.ForeColor = System.Drawing.Color.White;
            this.lblPeso.Location = new System.Drawing.Point(22, 230);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(75, 18);
            this.lblPeso.TabIndex = 4;
            this.lblPeso.Text = "Peso Kg:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.BackColor = System.Drawing.Color.Transparent;
            this.lblSexo.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ForeColor = System.Drawing.Color.White;
            this.lblSexo.Location = new System.Drawing.Point(22, 317);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(52, 18);
            this.lblSexo.TabIndex = 6;
            this.lblSexo.Text = "Sexo:";
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbSexo.Location = new System.Drawing.Point(25, 352);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(307, 22);
            this.cbSexo.TabIndex = 8;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.Location = new System.Drawing.Point(122, 417);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(106, 43);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "   Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVolver.BackgroundImage")));
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(12, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(41, 28);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmConoceTuCuerpo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = global::Work.Properties.Resources.img7;
            this.ClientSize = new System.Drawing.Size(364, 505);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.lblEdad);
            this.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmConoceTuCuerpo";
            this.Text = "Conoce  tu cuerpo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnVolver;
    }
}