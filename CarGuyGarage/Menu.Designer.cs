namespace CarGuyGarage
{
    partial class Menu
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.battonFirma = new System.Windows.Forms.Button();
            this.buttonAuto = new System.Windows.Forms.Button();
            this.buttonAvailability = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarGuyGarage.Properties.Resources._96_963045_sun_closed_call_for_drop_offs_or_pick;
            this.pictureBox1.Location = new System.Drawing.Point(24, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // battonFirma
            // 
            this.battonFirma.BackColor = System.Drawing.Color.MidnightBlue;
            this.battonFirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.battonFirma.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.battonFirma.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.battonFirma.Location = new System.Drawing.Point(24, 136);
            this.battonFirma.Margin = new System.Windows.Forms.Padding(15);
            this.battonFirma.Name = "battonFirma";
            this.battonFirma.Size = new System.Drawing.Size(227, 34);
            this.battonFirma.TabIndex = 16;
            this.battonFirma.Text = "Фирма";
            this.battonFirma.UseVisualStyleBackColor = false;
            this.battonFirma.Click += new System.EventHandler(this.battonFirma_Click);
            // 
            // buttonAuto
            // 
            this.buttonAuto.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAuto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAuto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAuto.Location = new System.Drawing.Point(24, 200);
            this.buttonAuto.Margin = new System.Windows.Forms.Padding(15);
            this.buttonAuto.Name = "buttonAuto";
            this.buttonAuto.Size = new System.Drawing.Size(227, 34);
            this.buttonAuto.TabIndex = 17;
            this.buttonAuto.Text = "Автомобили";
            this.buttonAuto.UseVisualStyleBackColor = false;
            this.buttonAuto.Click += new System.EventHandler(this.buttonAuto_Click);
            // 
            // buttonAvailability
            // 
            this.buttonAvailability.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonAvailability.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAvailability.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAvailability.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAvailability.Location = new System.Drawing.Point(24, 264);
            this.buttonAvailability.Margin = new System.Windows.Forms.Padding(15);
            this.buttonAvailability.Name = "buttonAvailability";
            this.buttonAvailability.Size = new System.Drawing.Size(227, 34);
            this.buttonAvailability.TabIndex = 18;
            this.buttonAvailability.Text = "Наличие";
            this.buttonAvailability.UseVisualStyleBackColor = false;
            this.buttonAvailability.Click += new System.EventHandler(this.buttonAvailability_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(275, 318);
            this.Controls.Add(this.buttonAvailability);
            this.Controls.Add(this.buttonAuto);
            this.Controls.Add(this.battonFirma);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button battonFirma;
        private System.Windows.Forms.Button buttonAuto;
        private System.Windows.Forms.Button buttonAvailability;
    }
}