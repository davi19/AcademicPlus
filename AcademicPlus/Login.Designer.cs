namespace AcademicPlus
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.TextRua = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.TextNome = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.BtnEntrar = new Syncfusion.Windows.Forms.ButtonAdv();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TextRua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // autoLabel2
            // 
            this.autoLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.autoLabel2.DY = -17;
            this.autoLabel2.LabeledControl = this.TextRua;
            this.autoLabel2.Location = new System.Drawing.Point(12, 242);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            this.autoLabel2.Size = new System.Drawing.Size(38, 13);
            this.autoLabel2.TabIndex = 7;
            this.autoLabel2.Text = "Senha";
            // 
            // TextRua
            // 
            this.TextRua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TextRua.BeforeTouchSize = new System.Drawing.Size(264, 20);
            this.TextRua.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.TextRua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextRua.Location = new System.Drawing.Point(12, 259);
            this.TextRua.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.TextRua.Name = "TextRua";
            this.TextRua.Size = new System.Drawing.Size(264, 20);
            this.TextRua.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.TextRua.TabIndex = 6;
            // 
            // autoLabel1
            // 
            this.autoLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.autoLabel1.DY = -17;
            this.autoLabel1.LabeledControl = this.TextNome;
            this.autoLabel1.Location = new System.Drawing.Point(12, 200);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            this.autoLabel1.Size = new System.Drawing.Size(43, 13);
            this.autoLabel1.TabIndex = 5;
            this.autoLabel1.Text = "Usuário";
            // 
            // TextNome
            // 
            this.TextNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TextNome.BeforeTouchSize = new System.Drawing.Size(264, 20);
            this.TextNome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.TextNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextNome.Location = new System.Drawing.Point(12, 217);
            this.TextNome.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.TextNome.Name = "TextNome";
            this.TextNome.Size = new System.Drawing.Size(264, 20);
            this.TextNome.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.TextNome.TabIndex = 4;
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.BtnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnEntrar.BeforeTouchSize = new System.Drawing.Size(123, 23);
            this.BtnEntrar.ForeColor = System.Drawing.Color.Black;
            this.BtnEntrar.IsBackStageButton = false;
            this.BtnEntrar.Location = new System.Drawing.Point(75, 285);
            this.BtnEntrar.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(123, 23);
            this.BtnEntrar.TabIndex = 24;
            this.BtnEntrar.Text = "Entrar";
            this.BtnEntrar.UseVisualStyle = true;
            this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AcademicPlus.Properties.Resources.IMG_20150502_WA0002;
            this.pictureBox1.Location = new System.Drawing.Point(39, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 348);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnEntrar);
            this.Controls.Add(this.autoLabel2);
            this.Controls.Add(this.TextRua);
            this.Controls.Add(this.autoLabel1);
            this.Controls.Add(this.TextNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Name = "Login";
            this.ShowMaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.TextRua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TextRua;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TextNome;
        private Syncfusion.Windows.Forms.ButtonAdv BtnEntrar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}