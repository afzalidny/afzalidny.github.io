namespace q
{
    partial class STRprogress
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pro = new System.Windows.Forms.ProgressBar();
            this.prg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.prg)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(414, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Matura MT Script Capitals", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(87, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 2;
            // 
            // pro
            // 
            this.pro.Location = new System.Drawing.Point(-4, 278);
            this.pro.Name = "pro";
            this.pro.Size = new System.Drawing.Size(569, 15);
            this.pro.TabIndex = 5;
            // 
            // prg
            // 
            this.prg.BackgroundImage = global::q.Properties.Resources.back;
            this.prg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prg.Location = new System.Drawing.Point(-4, 0);
            this.prg.Name = "prg";
            this.prg.Size = new System.Drawing.Size(569, 293);
            this.prg.TabIndex = 4;
            this.prg.TabStop = false;
            // 
            // STRprogress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(564, 291);
            this.Controls.Add(this.pro);
            this.Controls.Add(this.prg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "STRprogress";
            this.Text = "STRprogress";
            this.Load += new System.EventHandler(this.STRprogress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        //private Bunifu.Framework.UI.BunifuProgressBar prg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox prg;
        private System.Windows.Forms.ProgressBar pro;
    }
}