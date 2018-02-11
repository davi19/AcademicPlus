namespace AcademicPlus
{
    partial class BuscaAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscaAluno));
            this.BtnBuscar = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.TextBuscar = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.GridAluno = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TextBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.BtnBuscar.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.IsBackStageButton = false;
            this.BtnBuscar.Location = new System.Drawing.Point(474, 30);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 22;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyle = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnCadastro_Click);
            // 
            // label1
            // 
            this.label1.DY = -17;
            this.label1.LabeledControl = this.TextBuscar;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nome Aluno";
            // 
            // TextBuscar
            // 
            this.TextBuscar.BeforeTouchSize = new System.Drawing.Size(456, 20);
            this.TextBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBuscar.Location = new System.Drawing.Point(12, 30);
            this.TextBuscar.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.TextBuscar.Name = "TextBuscar";
            this.TextBuscar.Size = new System.Drawing.Size(456, 20);
            this.TextBuscar.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.TextBuscar.TabIndex = 20;
            this.TextBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBuscar_KeyPress);
            // 
            // GridAluno
            // 
            this.GridAluno.AllowUserToAddRows = false;
            this.GridAluno.AllowUserToDeleteRows = false;
            this.GridAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAluno.Location = new System.Drawing.Point(12, 56);
            this.GridAluno.Name = "GridAluno";
            this.GridAluno.ReadOnly = true;
            this.GridAluno.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.GridAluno.Size = new System.Drawing.Size(537, 193);
            this.GridAluno.TabIndex = 23;
            this.GridAluno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridAluno_CellContentClick);
            // 
            // BuscaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 261);
            this.Controls.Add(this.GridAluno);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuscaAluno";
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscaAluno";
            ((System.ComponentModel.ISupportInitialize)(this.TextBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.ButtonAdv BtnBuscar;
        private Syncfusion.Windows.Forms.Tools.AutoLabel label1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TextBuscar;
        private System.Windows.Forms.DataGridView GridAluno;
    }
}