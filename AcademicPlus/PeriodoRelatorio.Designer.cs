namespace AcademicPlus
{
    partial class PeriodoRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeriodoRelatorio));
            this.DataFinal = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.DataInicial = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.autolabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.BtnCadastro = new Syncfusion.Windows.Forms.ButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.DataFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataInicial)).BeginInit();
            this.SuspendLayout();
            // 
            // DataFinal
            // 
            this.DataFinal.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.DataFinal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.DataFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DataFinal.CalendarSize = new System.Drawing.Size(189, 176);
            this.DataFinal.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.DataFinal.DropDownImage = null;
            this.DataFinal.DropDownNormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.DataFinal.DropDownPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.DataFinal.DropDownSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(191)))), ((int)(((byte)(237)))));
            this.DataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataFinal.Location = new System.Drawing.Point(265, 46);
            this.DataFinal.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.DataFinal.MinValue = new System.DateTime(((long)(0)));
            this.DataFinal.Name = "DataFinal";
            this.DataFinal.ShowCheckBox = false;
            this.DataFinal.Size = new System.Drawing.Size(232, 20);
            this.DataFinal.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.DataFinal.TabIndex = 0;
            this.DataFinal.Value = new System.DateTime(2018, 2, 12, 11, 29, 57, 320);
            // 
            // DataInicial
            // 
            this.DataInicial.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.DataInicial.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.DataInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DataInicial.CalendarSize = new System.Drawing.Size(189, 176);
            this.DataInicial.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.DataInicial.DropDownImage = null;
            this.DataInicial.DropDownNormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.DataInicial.DropDownPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.DataInicial.DropDownSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(191)))), ((int)(((byte)(237)))));
            this.DataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataInicial.Location = new System.Drawing.Point(12, 46);
            this.DataInicial.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.DataInicial.MinValue = new System.DateTime(((long)(0)));
            this.DataInicial.Name = "DataInicial";
            this.DataInicial.ShowCheckBox = false;
            this.DataInicial.Size = new System.Drawing.Size(232, 20);
            this.DataInicial.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.DataInicial.TabIndex = 1;
            this.DataInicial.Value = new System.DateTime(2018, 2, 12, 11, 29, 59, 187);
            // 
            // autolabel1
            // 
            this.autolabel1.DY = -17;
            this.autolabel1.LabeledControl = this.DataInicial;
            this.autolabel1.Location = new System.Drawing.Point(12, 29);
            this.autolabel1.Name = "autolabel1";
            this.autolabel1.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            this.autolabel1.Size = new System.Drawing.Size(60, 13);
            this.autolabel1.TabIndex = 2;
            this.autolabel1.Text = "Data Inicial";
            // 
            // autoLabel2
            // 
            this.autoLabel2.DY = -17;
            this.autoLabel2.LabeledControl = this.DataFinal;
            this.autoLabel2.Location = new System.Drawing.Point(265, 29);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            this.autoLabel2.Size = new System.Drawing.Size(55, 13);
            this.autoLabel2.TabIndex = 3;
            this.autoLabel2.Text = "Data Final";
            // 
            // BtnCadastro
            // 
            this.BtnCadastro.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.BtnCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.BtnCadastro.BeforeTouchSize = new System.Drawing.Size(113, 23);
            this.BtnCadastro.ForeColor = System.Drawing.Color.White;
            this.BtnCadastro.IsBackStageButton = false;
            this.BtnCadastro.Location = new System.Drawing.Point(384, 86);
            this.BtnCadastro.Name = "BtnCadastro";
            this.BtnCadastro.Size = new System.Drawing.Size(113, 23);
            this.BtnCadastro.TabIndex = 20;
            this.BtnCadastro.Text = "Gerar Relatório";
            this.BtnCadastro.UseVisualStyle = true;
            this.BtnCadastro.Click += new System.EventHandler(this.BtnCadastro_Click);
            // 
            // PeriodoRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 111);
            this.Controls.Add(this.BtnCadastro);
            this.Controls.Add(this.autoLabel2);
            this.Controls.Add(this.autolabel1);
            this.Controls.Add(this.DataInicial);
            this.Controls.Add(this.DataFinal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PeriodoRelatorio";
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PeriodoRelatorio";
           ((System.ComponentModel.ISupportInitialize)(this.DataFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataInicial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv DataFinal;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv DataInicial;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autolabel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.ButtonAdv BtnCadastro;
    }
}