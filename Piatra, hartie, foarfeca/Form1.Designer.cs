namespace Piatra__hartie__foarfeca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Piatra = new System.Windows.Forms.PictureBox();
            this.Hartie = new System.Windows.Forms.PictureBox();
            this.Foarfeca = new System.Windows.Forms.PictureBox();
            this.robotPicture = new System.Windows.Forms.PictureBox();
            this.playerPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.scorRr = new System.Windows.Forms.Label();
            this.scorJucat = new System.Windows.Forms.Label();
            this.rrJoc = new System.Windows.Forms.Button();
            this.evidenta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Piatra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hartie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Foarfeca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.robotPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // Piatra
            // 
            this.Piatra.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Piatra.Image = ((System.Drawing.Image)(resources.GetObject("Piatra.Image")));
            this.Piatra.Location = new System.Drawing.Point(628, 38);
            this.Piatra.Name = "Piatra";
            this.Piatra.Size = new System.Drawing.Size(100, 96);
            this.Piatra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Piatra.TabIndex = 0;
            this.Piatra.TabStop = false;
            this.Piatra.Click += new System.EventHandler(this.Piatra_Click);
            // 
            // Hartie
            // 
            this.Hartie.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Hartie.Image = ((System.Drawing.Image)(resources.GetObject("Hartie.Image")));
            this.Hartie.Location = new System.Drawing.Point(628, 169);
            this.Hartie.Name = "Hartie";
            this.Hartie.Size = new System.Drawing.Size(100, 96);
            this.Hartie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hartie.TabIndex = 1;
            this.Hartie.TabStop = false;
            this.Hartie.Click += new System.EventHandler(this.Hartie_Click);
            // 
            // Foarfeca
            // 
            this.Foarfeca.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Foarfeca.Image = ((System.Drawing.Image)(resources.GetObject("Foarfeca.Image")));
            this.Foarfeca.Location = new System.Drawing.Point(628, 297);
            this.Foarfeca.Name = "Foarfeca";
            this.Foarfeca.Size = new System.Drawing.Size(100, 96);
            this.Foarfeca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Foarfeca.TabIndex = 2;
            this.Foarfeca.TabStop = false;
            this.Foarfeca.Click += new System.EventHandler(this.Foarfeca_Click);
            // 
            // robotPicture
            // 
            this.robotPicture.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.robotPicture.Location = new System.Drawing.Point(142, 150);
            this.robotPicture.Name = "robotPicture";
            this.robotPicture.Size = new System.Drawing.Size(115, 115);
            this.robotPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.robotPicture.TabIndex = 3;
            this.robotPicture.TabStop = false;
            // 
            // playerPicture
            // 
            this.playerPicture.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.playerPicture.Location = new System.Drawing.Point(376, 150);
            this.playerPicture.Name = "playerPicture";
            this.playerPicture.Size = new System.Drawing.Size(114, 115);
            this.playerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerPicture.TabIndex = 4;
            this.playerPicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Scor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(308, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "-";
            // 
            // scorRr
            // 
            this.scorRr.AutoSize = true;
            this.scorRr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorRr.Location = new System.Drawing.Point(230, 353);
            this.scorRr.Name = "scorRr";
            this.scorRr.Size = new System.Drawing.Size(27, 29);
            this.scorRr.TabIndex = 7;
            this.scorRr.Text = "0";
            // 
            // scorJucat
            // 
            this.scorJucat.AutoSize = true;
            this.scorJucat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorJucat.Location = new System.Drawing.Point(371, 353);
            this.scorJucat.Name = "scorJucat";
            this.scorJucat.Size = new System.Drawing.Size(27, 29);
            this.scorJucat.TabIndex = 8;
            this.scorJucat.Text = "0";
            // 
            // rrJoc
            // 
            this.rrJoc.Location = new System.Drawing.Point(240, 434);
            this.rrJoc.Name = "rrJoc";
            this.rrJoc.Size = new System.Drawing.Size(158, 43);
            this.rrJoc.TabIndex = 9;
            this.rrJoc.Text = "Restart Joc";
            this.rrJoc.UseVisualStyleBackColor = true;
            this.rrJoc.Click += new System.EventHandler(this.rrJoc_Click_1);
            // 
            // evidenta
            // 
            this.evidenta.AutoSize = true;
            this.evidenta.Font = new System.Drawing.Font("Times", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evidenta.Location = new System.Drawing.Point(213, 74);
            this.evidenta.Name = "evidenta";
            this.evidenta.Size = new System.Drawing.Size(166, 37);
            this.evidenta.TabIndex = 10;
            this.evidenta.Text = "Castigator";
            this.evidenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.evidenta);
            this.Controls.Add(this.rrJoc);
            this.Controls.Add(this.scorJucat);
            this.Controls.Add(this.scorRr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playerPicture);
            this.Controls.Add(this.robotPicture);
            this.Controls.Add(this.Foarfeca);
            this.Controls.Add(this.Hartie);
            this.Controls.Add(this.Piatra);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Piatra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hartie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Foarfeca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.robotPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Piatra;
        private System.Windows.Forms.PictureBox Hartie;
        private System.Windows.Forms.PictureBox Foarfeca;
        private System.Windows.Forms.PictureBox robotPicture;
        private System.Windows.Forms.PictureBox playerPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label scorRr;
        private System.Windows.Forms.Label scorJucat;
        private System.Windows.Forms.Button rrJoc;
        private System.Windows.Forms.Label evidenta;
    }
}

