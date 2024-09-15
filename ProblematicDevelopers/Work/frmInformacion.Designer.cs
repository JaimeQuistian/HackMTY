namespace Work
{
    partial class frmInformacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInformacion));
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.btnActividades = new System.Windows.Forms.Button();
            this.btnCTC = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.pbMicrofone = new System.Windows.Forms.PictureBox();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMicrofone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVolver.BackgroundImage")));
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(2, 5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(41, 28);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.BackColor = System.Drawing.Color.Transparent;
            this.lblText.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.Color.White;
            this.lblText.Location = new System.Drawing.Point(12, 309);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(205, 30);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Workout Assistant";
            // 
            // btnActividades
            // 
            this.btnActividades.BackgroundImage = global::Work.Properties.Resources.img4;
            this.btnActividades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActividades.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActividades.ForeColor = System.Drawing.Color.White;
            this.btnActividades.Location = new System.Drawing.Point(0, 51);
            this.btnActividades.Name = "btnActividades";
            this.btnActividades.Size = new System.Drawing.Size(398, 66);
            this.btnActividades.TabIndex = 2;
            this.btnActividades.Text = "Actividades";
            this.btnActividades.UseVisualStyleBackColor = true;
            this.btnActividades.Click += new System.EventHandler(this.btnActividades_Click);
            // 
            // btnCTC
            // 
            this.btnCTC.BackgroundImage = global::Work.Properties.Resources.img4;
            this.btnCTC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCTC.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCTC.ForeColor = System.Drawing.Color.White;
            this.btnCTC.Location = new System.Drawing.Point(0, 123);
            this.btnCTC.Name = "btnCTC";
            this.btnCTC.Size = new System.Drawing.Size(398, 66);
            this.btnCTC.TabIndex = 3;
            this.btnCTC.Text = "Conoce tu cuerpo";
            this.btnCTC.UseVisualStyleBackColor = true;
            this.btnCTC.Click += new System.EventHandler(this.btnCTC_Click);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.BackgroundImage = global::Work.Properties.Resources.img4;
            this.btnEstadisticas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEstadisticas.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadisticas.ForeColor = System.Drawing.Color.White;
            this.btnEstadisticas.Location = new System.Drawing.Point(0, 195);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(398, 66);
            this.btnEstadisticas.TabIndex = 8;
            this.btnEstadisticas.Text = "Estadísticas\r\n¡Proximamente!";
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            // 
            // pbMicrofone
            // 
            this.pbMicrofone.BackColor = System.Drawing.Color.Transparent;
            this.pbMicrofone.Image = global::Work.Properties.Resources.forma_de_microfono_negro;
            this.pbMicrofone.Location = new System.Drawing.Point(221, 305);
            this.pbMicrofone.Name = "pbMicrofone";
            this.pbMicrofone.Size = new System.Drawing.Size(40, 37);
            this.pbMicrofone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMicrofone.TabIndex = 7;
            this.pbMicrofone.TabStop = false;
            // 
            // pbAvatar
            // 
            this.pbAvatar.BackColor = System.Drawing.Color.Transparent;
            this.pbAvatar.Image = global::Work.Properties.Resources.img3;
            this.pbAvatar.Location = new System.Drawing.Point(245, 257);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(153, 133);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvatar.TabIndex = 6;
            this.pbAvatar.TabStop = false;
            // 
            // frmInformacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(398, 402);
            this.Controls.Add(this.btnEstadisticas);
            this.Controls.Add(this.pbMicrofone);
            this.Controls.Add(this.pbAvatar);
            this.Controls.Add(this.btnCTC);
            this.Controls.Add(this.btnActividades);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnVolver);
            this.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmInformacion";
            this.Text = "Menu Workout Assistant";
            this.Load += new System.EventHandler(this.frmInformacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMicrofone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnActividades;
        private System.Windows.Forms.Button btnCTC;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.PictureBox pbMicrofone;
        private System.Windows.Forms.Button btnEstadisticas;
    }
}