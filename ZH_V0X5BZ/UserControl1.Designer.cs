namespace ZH_V0X5BZ
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBoxFogások = new System.Windows.Forms.ListBox();
            this.listBoxNyersanyagok = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.receptIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fogasIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mennyiseg4foDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nyersanyagNévDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egységNévDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.árDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hozzávalókBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxfogás = new System.Windows.Forms.TextBox();
            this.textBoxNyersanyag = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelmertekegyseg = new System.Windows.Forms.Label();
            this.textBoxmennyiseg = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hozzávalókBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxFogások
            // 
            this.listBoxFogások.FormattingEnabled = true;
            this.listBoxFogások.ItemHeight = 15;
            this.listBoxFogások.Location = new System.Drawing.Point(26, 107);
            this.listBoxFogások.Name = "listBoxFogások";
            this.listBoxFogások.Size = new System.Drawing.Size(247, 394);
            this.listBoxFogások.TabIndex = 0;
            this.listBoxFogások.SelectedIndexChanged += new System.EventHandler(this.listBoxFogások_SelectedIndexChanged);
            // 
            // listBoxNyersanyagok
            // 
            this.listBoxNyersanyagok.FormattingEnabled = true;
            this.listBoxNyersanyagok.ItemHeight = 15;
            this.listBoxNyersanyagok.Location = new System.Drawing.Point(967, 107);
            this.listBoxNyersanyagok.Name = "listBoxNyersanyagok";
            this.listBoxNyersanyagok.Size = new System.Drawing.Size(247, 394);
            this.listBoxNyersanyagok.TabIndex = 1;
            this.listBoxNyersanyagok.SelectedIndexChanged += new System.EventHandler(this.listBoxNyersanyagok_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.receptIdDataGridViewTextBoxColumn,
            this.fogasIdDataGridViewTextBoxColumn,
            this.mennyiseg4foDataGridViewTextBoxColumn,
            this.nyersanyagNévDataGridViewTextBoxColumn,
            this.egységNévDataGridViewTextBoxColumn,
            this.árDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hozzávalókBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(279, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(601, 394);
            this.dataGridView1.TabIndex = 2;
            // 
            // receptIdDataGridViewTextBoxColumn
            // 
            this.receptIdDataGridViewTextBoxColumn.DataPropertyName = "ReceptId";
            this.receptIdDataGridViewTextBoxColumn.HeaderText = "ReceptId";
            this.receptIdDataGridViewTextBoxColumn.Name = "receptIdDataGridViewTextBoxColumn";
            // 
            // fogasIdDataGridViewTextBoxColumn
            // 
            this.fogasIdDataGridViewTextBoxColumn.DataPropertyName = "FogasId";
            this.fogasIdDataGridViewTextBoxColumn.HeaderText = "FogasId";
            this.fogasIdDataGridViewTextBoxColumn.Name = "fogasIdDataGridViewTextBoxColumn";
            // 
            // mennyiseg4foDataGridViewTextBoxColumn
            // 
            this.mennyiseg4foDataGridViewTextBoxColumn.DataPropertyName = "Mennyiseg4fo";
            this.mennyiseg4foDataGridViewTextBoxColumn.HeaderText = "Mennyiseg4fo";
            this.mennyiseg4foDataGridViewTextBoxColumn.Name = "mennyiseg4foDataGridViewTextBoxColumn";
            // 
            // nyersanyagNévDataGridViewTextBoxColumn
            // 
            this.nyersanyagNévDataGridViewTextBoxColumn.DataPropertyName = "NyersanyagNév";
            this.nyersanyagNévDataGridViewTextBoxColumn.HeaderText = "NyersanyagNév";
            this.nyersanyagNévDataGridViewTextBoxColumn.Name = "nyersanyagNévDataGridViewTextBoxColumn";
            // 
            // egységNévDataGridViewTextBoxColumn
            // 
            this.egységNévDataGridViewTextBoxColumn.DataPropertyName = "EgységNév";
            this.egységNévDataGridViewTextBoxColumn.HeaderText = "EgységNév";
            this.egységNévDataGridViewTextBoxColumn.Name = "egységNévDataGridViewTextBoxColumn";
            // 
            // árDataGridViewTextBoxColumn
            // 
            this.árDataGridViewTextBoxColumn.DataPropertyName = "Ár";
            this.árDataGridViewTextBoxColumn.HeaderText = "Ár";
            this.árDataGridViewTextBoxColumn.Name = "árDataGridViewTextBoxColumn";
            // 
            // hozzávalókBindingSource
            // 
            this.hozzávalókBindingSource.DataSource = typeof(ZH_V0X5BZ.Hozzávalók);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(886, 216);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(886, 301);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "-";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxfogás
            // 
            this.textBoxfogás.Location = new System.Drawing.Point(26, 56);
            this.textBoxfogás.Name = "textBoxfogás";
            this.textBoxfogás.Size = new System.Drawing.Size(247, 23);
            this.textBoxfogás.TabIndex = 5;
            this.textBoxfogás.TextChanged += new System.EventHandler(this.textBoxfogás_TextChanged);
            // 
            // textBoxNyersanyag
            // 
            this.textBoxNyersanyag.Location = new System.Drawing.Point(967, 56);
            this.textBoxNyersanyag.Name = "textBoxNyersanyag";
            this.textBoxNyersanyag.Size = new System.Drawing.Size(247, 23);
            this.textBoxNyersanyag.TabIndex = 6;
            this.textBoxNyersanyag.TextChanged += new System.EventHandler(this.textBoxNyersanyag_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fogásnév:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(967, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nyersanyagnév:";
            // 
            // labelmertekegyseg
            // 
            this.labelmertekegyseg.AutoSize = true;
            this.labelmertekegyseg.Location = new System.Drawing.Point(1017, 513);
            this.labelmertekegyseg.Name = "labelmertekegyseg";
            this.labelmertekegyseg.Size = new System.Drawing.Size(20, 15);
            this.labelmertekegyseg.TabIndex = 9;
            this.labelmertekegyseg.Text = "kg";
            // 
            // textBoxmennyiseg
            // 
            this.textBoxmennyiseg.Location = new System.Drawing.Point(886, 510);
            this.textBoxmennyiseg.Name = "textBoxmennyiseg";
            this.textBoxmennyiseg.Size = new System.Drawing.Size(100, 23);
            this.textBoxmennyiseg.TabIndex = 10;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxmennyiseg);
            this.Controls.Add(this.labelmertekegyseg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNyersanyag);
            this.Controls.Add(this.textBoxfogás);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBoxNyersanyagok);
            this.Controls.Add(this.listBoxFogások);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1247, 686);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hozzávalókBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxFogások;
        private ListBox listBoxNyersanyagok;
        private DataGridView dataGridView1;
        private Button buttonAdd;
        private Button buttonDelete;
        private TextBox textBoxfogás;
        private TextBox textBoxNyersanyag;
        private Label label1;
        private Label label2;
        private Label labelmertekegyseg;
        private TextBox textBoxmennyiseg;
        private DataGridViewTextBoxColumn receptIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fogasIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mennyiseg4foDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nyersanyagNévDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn egységNévDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn árDataGridViewTextBoxColumn;
        private BindingSource hozzávalókBindingSource;
    }
}
