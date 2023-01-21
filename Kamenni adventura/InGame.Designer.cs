namespace Kamenni_adventura
{
    partial class InGame
    {
        /// <summary> 
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód vygenerovaný pomocí Návrháře komponent

        /// <summary> 
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxEnemy = new System.Windows.Forms.PictureBox();
            this.pictureBoxPostava = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPostava)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.pictureBoxEnemy);
            this.panel1.Controls.Add(this.pictureBoxPostava);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 357);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(0, 351);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(889, 155);
            this.panel2.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBoxEnemy
            // 
            this.pictureBoxEnemy.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEnemy.Image = global::Kamenni_adventura.Properties.Resources.WalterZijiciResized;
            this.pictureBoxEnemy.Location = new System.Drawing.Point(751, 261);
            this.pictureBoxEnemy.Name = "pictureBoxEnemy";
            this.pictureBoxEnemy.Size = new System.Drawing.Size(71, 93);
            this.pictureBoxEnemy.TabIndex = 1;
            this.pictureBoxEnemy.TabStop = false;
            // 
            // pictureBoxPostava
            // 
            this.pictureBoxPostava.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPostava.Image = global::Kamenni_adventura.Properties.Resources.hank2;
            this.pictureBoxPostava.Location = new System.Drawing.Point(226, 234);
            this.pictureBoxPostava.Name = "pictureBoxPostava";
            this.pictureBoxPostava.Size = new System.Drawing.Size(55, 120);
            this.pictureBoxPostava.TabIndex = 0;
            this.pictureBoxPostava.TabStop = false;
            // 
            // InGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "InGame";
            this.Size = new System.Drawing.Size(889, 506);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPostava)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxPostava;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBoxEnemy;
    }
}
