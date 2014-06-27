namespace WindowsFormsApplication5
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
            this.btnConectarDB = new System.Windows.Forms.Button();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.dgvTables = new System.Windows.Forms.DataGridView();
            this.btnCrearDocs = new System.Windows.Forms.Button();
            this.TABLE_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkDoc = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtOutPutFolder = new System.Windows.Forms.TextBox();
            this.btnOutPutFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTables)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConectarDB
            // 
            this.btnConectarDB.Location = new System.Drawing.Point(430, 36);
            this.btnConectarDB.Name = "btnConectarDB";
            this.btnConectarDB.Size = new System.Drawing.Size(119, 23);
            this.btnConectarDB.TabIndex = 0;
            this.btnConectarDB.Text = "Conectar a DB";
            this.btnConectarDB.UseVisualStyleBackColor = true;
            this.btnConectarDB.Click += new System.EventHandler(this.btnConectarDB_Click);
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(36, 38);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(369, 20);
            this.txtConnectionString.TabIndex = 1;
            // 
            // dgvTables
            // 
            this.dgvTables.AllowUserToDeleteRows = false;
            this.dgvTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TABLE_NAME,
            this.Columnas,
            this.chkDoc});
            this.dgvTables.Location = new System.Drawing.Point(12, 103);
            this.dgvTables.Name = "dgvTables";
            this.dgvTables.Size = new System.Drawing.Size(722, 174);
            this.dgvTables.TabIndex = 2;
            // 
            // btnCrearDocs
            // 
            this.btnCrearDocs.Location = new System.Drawing.Point(568, 35);
            this.btnCrearDocs.Name = "btnCrearDocs";
            this.btnCrearDocs.Size = new System.Drawing.Size(119, 23);
            this.btnCrearDocs.TabIndex = 3;
            this.btnCrearDocs.Text = "Crear Documento(s)";
            this.btnCrearDocs.UseVisualStyleBackColor = true;
            this.btnCrearDocs.Click += new System.EventHandler(this.btnCrearDocs_Click);
            // 
            // TABLE_NAME
            // 
            this.TABLE_NAME.HeaderText = "Tablas";
            this.TABLE_NAME.Name = "TABLE_NAME";
            this.TABLE_NAME.ReadOnly = true;
            // 
            // Columnas
            // 
            this.Columnas.HeaderText = "Columnas";
            this.Columnas.Name = "Columnas";
            this.Columnas.ReadOnly = true;
            // 
            // chkDoc
            // 
            this.chkDoc.FalseValue = "False";
            this.chkDoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkDoc.HeaderText = "Crear Doc";
            this.chkDoc.IndeterminateValue = "False";
            this.chkDoc.Name = "chkDoc";
            this.chkDoc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.chkDoc.TrueValue = "True";
            // 
            // txtOutPutFolder
            // 
            this.txtOutPutFolder.Enabled = false;
            this.txtOutPutFolder.Location = new System.Drawing.Point(36, 65);
            this.txtOutPutFolder.Name = "txtOutPutFolder";
            this.txtOutPutFolder.Size = new System.Drawing.Size(369, 20);
            this.txtOutPutFolder.TabIndex = 4;
            // 
            // btnOutPutFolder
            // 
            this.btnOutPutFolder.Location = new System.Drawing.Point(430, 65);
            this.btnOutPutFolder.Name = "btnOutPutFolder";
            this.btnOutPutFolder.Size = new System.Drawing.Size(119, 23);
            this.btnOutPutFolder.TabIndex = 5;
            this.btnOutPutFolder.Text = "Folder de Salida";
            this.btnOutPutFolder.UseVisualStyleBackColor = true;
            this.btnOutPutFolder.Click += new System.EventHandler(this.btnOutPutFolder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 289);
            this.Controls.Add(this.btnOutPutFolder);
            this.Controls.Add(this.txtOutPutFolder);
            this.Controls.Add(this.btnCrearDocs);
            this.Controls.Add(this.dgvTables);
            this.Controls.Add(this.txtConnectionString);
            this.Controls.Add(this.btnConectarDB);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConectarDB;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.DataGridView dgvTables;
        private System.Windows.Forms.Button btnCrearDocs;
        private System.Windows.Forms.DataGridViewTextBoxColumn TABLE_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkDoc;
        private System.Windows.Forms.TextBox txtOutPutFolder;
        private System.Windows.Forms.Button btnOutPutFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

