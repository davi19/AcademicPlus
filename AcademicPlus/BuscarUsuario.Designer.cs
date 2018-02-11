namespace AcademicPlus
{
    partial class BuscarUsuario
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
            this.GridAluno = new System.Windows.Forms.DataGridView();
            this.BtnBuscar = new Syncfusion.Windows.Forms.ButtonAdv();
            this.TextBuscar = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            ((System.ComponentModel.ISupportInitialize)(this.GridAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // GridAluno
            // 
            this.GridAluno.AllowUserToAddRows = false;
            this.GridAluno.AllowUserToDeleteRows = false;
            this.GridAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAluno.Location = new System.Drawing.Point(12, 59);
            this.GridAluno.Name = "GridAluno";
            this.GridAluno.ReadOnly = true;
            this.GridAluno.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.GridAluno.Size = new System.Drawing.Size(537, 193);
            this.GridAluno.TabIndex = 26;
            this.GridAluno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridAluno_CellContentClick);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.BtnBuscar.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.IsBackStageButton = false;
            this.BtnBuscar.Location = new System.Drawing.Point(474, 33);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 25;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyle = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TextBuscar
            // 
            this.TextBuscar.BeforeTouchSize = new System.Drawing.Size(456, 20);
            this.TextBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBuscar.Location = new System.Drawing.Point(12, 33);
            this.TextBuscar.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.TextBuscar.Name = "TextBuscar";
            this.TextBuscar.Size = new System.Drawing.Size(456, 20);
            this.TextBuscar.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.TextBuscar.TabIndex = 24;
            this.TextBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBuscar_KeyPress);
            // 
            // BuscarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 264);
            this.Controls.Add(this.GridAluno);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TextBuscar);
            this.Name = "BuscarUsuario";
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.GridAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridAluno;
        private Syncfusion.Windows.Forms.ButtonAdv BtnBuscar;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TextBuscar;
    }
}