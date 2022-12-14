namespace ZH_V0X5BZ
{
    partial class UserControl2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fogasIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fogasNevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kepDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.leirasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recepteksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fogasokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fogasokBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fogasIdDataGridViewTextBoxColumn,
            this.fogasNevDataGridViewTextBoxColumn,
            this.kepDataGridViewImageColumn,
            this.leirasDataGridViewTextBoxColumn,
            this.recepteksDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fogasokBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(36, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(444, 385);
            this.dataGridView1.TabIndex = 0;
            // 
            // fogasIdDataGridViewTextBoxColumn
            // 
            this.fogasIdDataGridViewTextBoxColumn.DataPropertyName = "FogasId";
            this.fogasIdDataGridViewTextBoxColumn.HeaderText = "FogasId";
            this.fogasIdDataGridViewTextBoxColumn.Name = "fogasIdDataGridViewTextBoxColumn";
            // 
            // fogasNevDataGridViewTextBoxColumn
            // 
            this.fogasNevDataGridViewTextBoxColumn.DataPropertyName = "FogasNev";
            this.fogasNevDataGridViewTextBoxColumn.HeaderText = "FogasNev";
            this.fogasNevDataGridViewTextBoxColumn.Name = "fogasNevDataGridViewTextBoxColumn";
            // 
            // kepDataGridViewImageColumn
            // 
            this.kepDataGridViewImageColumn.DataPropertyName = "Kep";
            this.kepDataGridViewImageColumn.HeaderText = "Kep";
            this.kepDataGridViewImageColumn.Name = "kepDataGridViewImageColumn";
            // 
            // leirasDataGridViewTextBoxColumn
            // 
            this.leirasDataGridViewTextBoxColumn.DataPropertyName = "Leiras";
            this.leirasDataGridViewTextBoxColumn.HeaderText = "Leiras";
            this.leirasDataGridViewTextBoxColumn.Name = "leirasDataGridViewTextBoxColumn";
            // 
            // recepteksDataGridViewTextBoxColumn
            // 
            this.recepteksDataGridViewTextBoxColumn.DataPropertyName = "Recepteks";
            this.recepteksDataGridViewTextBoxColumn.HeaderText = "Recepteks";
            this.recepteksDataGridViewTextBoxColumn.Name = "recepteksDataGridViewTextBoxColumn";
            this.recepteksDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fogasokBindingSource
            // 
            this.fogasokBindingSource.DataSource = typeof(ZH_V0X5BZ.Models.Fogasok);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(563, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 148);
            this.button1.TabIndex = 1;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fogásaink adatbázisa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(563, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Új fogás felvétele:";
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(872, 617);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fogasokBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn fogasIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fogasNevDataGridViewTextBoxColumn;
        private DataGridViewImageColumn kepDataGridViewImageColumn;
        private DataGridViewTextBoxColumn leirasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn recepteksDataGridViewTextBoxColumn;
        private BindingSource fogasokBindingSource;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}
