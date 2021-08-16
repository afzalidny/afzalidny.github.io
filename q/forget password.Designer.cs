namespace q
{
    partial class forget_password
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.vrf_btn = new System.Windows.Forms.Button();
            this.vrf_lbl = new System.Windows.Forms.Label();
            this.send = new System.Windows.Forms.Button();
            this.varifycode = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtto = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.sendsms = new System.Windows.Forms.Button();
            this.pass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.phon = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sendsms);
            this.groupBox2.Controls.Add(this.vrf_btn);
            this.groupBox2.Controls.Add(this.vrf_lbl);
            this.groupBox2.Controls.Add(this.send);
            this.groupBox2.Controls.Add(this.varifycode);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.phon);
            this.groupBox2.Controls.Add(this.pass);
            this.groupBox2.Controls.Add(this.name);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtto);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(859, 517);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // vrf_btn
            // 
            this.vrf_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(158)))), ((int)(((byte)(250)))));
            this.vrf_btn.Enabled = false;
            this.vrf_btn.FlatAppearance.BorderSize = 0;
            this.vrf_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.vrf_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.vrf_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vrf_btn.Font = new System.Drawing.Font("2  Farnaz", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.vrf_btn.Location = new System.Drawing.Point(110, 407);
            this.vrf_btn.Name = "vrf_btn";
            this.vrf_btn.Size = new System.Drawing.Size(293, 47);
            this.vrf_btn.TabIndex = 32;
            this.vrf_btn.Text = "ارسال";
            this.vrf_btn.UseVisualStyleBackColor = false;
            this.vrf_btn.Click += new System.EventHandler(this.vrf_btn_Click);
            // 
            // vrf_lbl
            // 
            this.vrf_lbl.AutoSize = true;
            this.vrf_lbl.Enabled = false;
            this.vrf_lbl.Font = new System.Drawing.Font("2  Farnaz", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.vrf_lbl.Location = new System.Drawing.Point(358, 357);
            this.vrf_lbl.Name = "vrf_lbl";
            this.vrf_lbl.Size = new System.Drawing.Size(45, 25);
            this.vrf_lbl.TabIndex = 31;
            this.vrf_lbl.Text = "ایمیل";
            // 
            // send
            // 
            this.send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(158)))), ((int)(((byte)(250)))));
            this.send.FlatAppearance.BorderSize = 0;
            this.send.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.send.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.send.Font = new System.Drawing.Font("2  Farnaz", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.send.Location = new System.Drawing.Point(606, 269);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(237, 47);
            this.send.TabIndex = 26;
            this.send.Text = "ارسال";
            this.send.UseVisualStyleBackColor = false;
            this.send.Click += new System.EventHandler(this.send_Click_1);
            // 
            // varifycode
            // 
            this.varifycode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.varifycode.Enabled = false;
            this.varifycode.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.varifycode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.varifycode.HintForeColor = System.Drawing.Color.Empty;
            this.varifycode.HintText = "";
            this.varifycode.isPassword = false;
            this.varifycode.LineFocusedColor = System.Drawing.Color.Blue;
            this.varifycode.LineIdleColor = System.Drawing.Color.Gray;
            this.varifycode.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.varifycode.LineThickness = 3;
            this.varifycode.Location = new System.Drawing.Point(125, 349);
            this.varifycode.Margin = new System.Windows.Forms.Padding(4);
            this.varifycode.Name = "varifycode";
            this.varifycode.Size = new System.Drawing.Size(226, 33);
            this.varifycode.TabIndex = 30;
            this.varifycode.Text = "bunifuMaterialTextbox1";
            this.varifycode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::q.Properties.Resources.FORGETPASS;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(123, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 167);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("2  Farnaz", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(798, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "ایمیل";
            // 
            // txtto
            // 
            this.txtto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtto.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtto.HintForeColor = System.Drawing.Color.Empty;
            this.txtto.HintText = "";
            this.txtto.isPassword = false;
            this.txtto.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtto.LineIdleColor = System.Drawing.Color.Gray;
            this.txtto.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtto.LineThickness = 3;
            this.txtto.Location = new System.Drawing.Point(621, 211);
            this.txtto.Margin = new System.Windows.Forms.Padding(4);
            this.txtto.Name = "txtto";
            this.txtto.Size = new System.Drawing.Size(170, 33);
            this.txtto.TabIndex = 18;
            this.txtto.Text = "bunifuMaterialTextbox1";
            this.txtto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // name
            // 
            this.name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.name.HintForeColor = System.Drawing.Color.Empty;
            this.name.HintText = "";
            this.name.isPassword = false;
            this.name.LineFocusedColor = System.Drawing.Color.Blue;
            this.name.LineIdleColor = System.Drawing.Color.Gray;
            this.name.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.name.LineThickness = 3;
            this.name.Location = new System.Drawing.Point(287, 213);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(170, 33);
            this.name.TabIndex = 18;
            this.name.Text = "bunifuMaterialTextbox1";
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("2  Farnaz", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(464, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "ایمیل";
            // 
            // sendsms
            // 
            this.sendsms.Location = new System.Drawing.Point(287, 269);
            this.sendsms.Name = "sendsms";
            this.sendsms.Size = new System.Drawing.Size(170, 47);
            this.sendsms.TabIndex = 33;
            this.sendsms.Text = "button1";
            this.sendsms.UseVisualStyleBackColor = true;
            this.sendsms.Click += new System.EventHandler(this.sendsms_Click);
            // 
            // pass
            // 
            this.pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pass.HintForeColor = System.Drawing.Color.Empty;
            this.pass.HintText = "";
            this.pass.isPassword = false;
            this.pass.LineFocusedColor = System.Drawing.Color.Blue;
            this.pass.LineIdleColor = System.Drawing.Color.Gray;
            this.pass.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.pass.LineThickness = 3;
            this.pass.Location = new System.Drawing.Point(54, 213);
            this.pass.Margin = new System.Windows.Forms.Padding(4);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(170, 33);
            this.pass.TabIndex = 18;
            this.pass.Text = "bunifuMaterialTextbox1";
            this.pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("2  Farnaz", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(231, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "ایمیل";
            // 
            // phon
            // 
            this.phon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phon.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.phon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.phon.HintForeColor = System.Drawing.Color.Empty;
            this.phon.HintText = "";
            this.phon.isPassword = false;
            this.phon.LineFocusedColor = System.Drawing.Color.Blue;
            this.phon.LineIdleColor = System.Drawing.Color.Gray;
            this.phon.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.phon.LineThickness = 3;
            this.phon.Location = new System.Drawing.Point(54, 269);
            this.phon.Margin = new System.Windows.Forms.Padding(4);
            this.phon.Name = "phon";
            this.phon.Size = new System.Drawing.Size(170, 33);
            this.phon.TabIndex = 18;
            this.phon.Text = "bunifuMaterialTextbox1";
            this.phon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("2  Farnaz", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(231, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "ایمیل";
            // 
            // forget_password
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(885, 479);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "forget_password";
            this.Text = " ";
            this.Load += new System.EventHandler(this.forget_password_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Button vrf_btn;
        private System.Windows.Forms.Label vrf_lbl;
        private Bunifu.Framework.UI.BunifuMaterialTextbox varifycode;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox name;
        private System.Windows.Forms.Button sendsms;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox phon;
        private Bunifu.Framework.UI.BunifuMaterialTextbox pass;

        #endregion

        //private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        //private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        //private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        //private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        //private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox2;
        //private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox3;
        //private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox4;
        //private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox5;
    }
}