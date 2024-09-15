namespace Work
{
    partial class frmActividad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActividad));
            this.pbMicrofone = new System.Windows.Forms.PictureBox();
            this.lblText = new System.Windows.Forms.Label();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.pbAct1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbMicrofone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAct1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMicrofone
            // 
            this.pbMicrofone.BackColor = System.Drawing.Color.Transparent;
            this.pbMicrofone.Image = global::Work.Properties.Resources.forma_de_microfono_negro;
            this.pbMicrofone.Location = new System.Drawing.Point(221, 15);
            this.pbMicrofone.Name = "pbMicrofone";
            this.pbMicrofone.Size = new System.Drawing.Size(40, 37);
            this.pbMicrofone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMicrofone.TabIndex = 9;
            this.pbMicrofone.TabStop = false;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.BackColor = System.Drawing.Color.Transparent;
            this.lblText.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.Color.White;
            this.lblText.Location = new System.Drawing.Point(12, 19);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(205, 30);
            this.lblText.TabIndex = 8;
            this.lblText.Text = "Workout Assistant";
            // 
            // pbAvatar
            // 
            this.pbAvatar.BackColor = System.Drawing.Color.Transparent;
            this.pbAvatar.Image = global::Work.Properties.Resources.img3;
            this.pbAvatar.Location = new System.Drawing.Point(297, 396);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(153, 133);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvatar.TabIndex = 10;
            this.pbAvatar.TabStop = false;
            // 
            // pbAct1
            // 
            this.pbAct1.Image = global::Work.Properties.Resources.jump;
            this.pbAct1.Location = new System.Drawing.Point(123, 145);
            this.pbAct1.Name = "pbAct1";
            this.pbAct1.Size = new System.Drawing.Size(204, 200);
            this.pbAct1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAct1.TabIndex = 11;
            this.pbAct1.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Image = global::Work.Properties.Resources.play;
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStart.Location = new System.Drawing.Point(27, 473);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(78, 36);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Start";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // frmActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Work.Properties.Resources.img8;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(450, 528);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbAct1);
            this.Controls.Add(this.pbAvatar);
            this.Controls.Add(this.pbMicrofone);
            this.Controls.Add(this.lblText);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmActividad";
            this.Text = "Actividad";
            this.Load += new System.EventHandler(this.frmActividad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMicrofone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAct1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMicrofone;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.PictureBox pbAct1;
        private System.Windows.Forms.Button btnStart;
    }
}