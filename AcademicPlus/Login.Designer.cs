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
            this.TextSenha = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.TextUsuario = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.BtnEntrar = new Syncfusion.Windows.Forms.ButtonAdv();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TextSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // autoLabel2
            // 
            this.autoLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.autoLabel2.DY = -17;
            this.autoLabel2.LabeledControl = this.TextSenha;
            this.autoLabel2.Location = new System.Drawing.Point(12, 242);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            this.autoLabel2.Size = new System.Drawing.Size(38, 13);
            this.autoLabel2.TabIndex = 7;
            this.autoLabel2.Text = "Senha";
            // 
            // TextSenha
            // 
            this.TextSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TextSenha.BeforeTouchSize = new System.Drawing.Size(264, 20);
            this.TextSenha.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.TextSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextSenha.FocusBorderColor = System.Drawing.Color.Teal;
            this.TextSenha.Location = new System.Drawing.Point(12, 259);
            this.TextSenha.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.TextSenha.Name = "TextSenha";
            this.TextSenha.PasswordChar = '*';
            this.TextSenha.Size = new System.Drawing.Size(264, 20);
            this.TextSenha.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.TextSenha.TabIndex = 6;
            this.TextSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextSenha_KeyPress);
            // 
            // autoLabel1
            // 
            this.autoLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.autoLabel1.DY = -17;
            this.autoLabel1.LabeledControl = this.TextUsuario;
            this.autoLabel1.Location = new System.Drawing.Point(12, 200);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            this.autoLabel1.Size = new System.Drawing.Size(43, 13);
            this.autoLabel1.TabIndex = 5;
            this.autoLabel1.Text = "Usuário";
            // 
            // TextUsuario
            // 
            this.TextUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TextUsuario.BeforeTouchSize = new System.Drawing.Size(264, 20);
            this.TextUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.TextUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextUsuario.FocusBorderColor = System.Drawing.Color.Teal;
            this.TextUsuario.Location = new System.Drawing.Point(12, 217);
            this.TextUsuario.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.TextUsuario.Name = "TextUsuario";
            this.TextUsuario.Size = new System.Drawing.Size(264, 20);
            this.TextUsuario.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.TextUsuario.TabIndex = 4;
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.BtnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnEntrar.BeforeTouchSize = new System.Drawing.Size(123, 23);
            this.BtnEntrar.ForeColor = System.Drawing.Color.Black;
            this.BtnEntrar.IsBackStageButton = false;
            this.BtnEntrar.Location = new System.Drawing.Point(75, 285);
            this.BtnEntrar.MetroColor = System.Drawing.SystemColors.MenuHighlight;
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
            this.Controls.Add(this.TextSenha);
            this.Controls.Add(this.autoLabel1);
            this.Controls.Add(this.TextUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MetroColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "Login";
            this.ShowMaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.TextSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TextSenha;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TextUsuario;
        private Syncfusion.Windows.Forms.ButtonAdv BtnEntrar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}