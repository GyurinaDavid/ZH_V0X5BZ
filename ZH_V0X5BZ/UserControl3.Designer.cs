namespace ZH_V0X5BZ
{
    partial class UserControl3
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
            this.listBoxfogas = new System.Windows.Forms.ListBox();
            this.textBoxfogás = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxfogas
            // 
            this.listBoxfogas.FormattingEnabled = true;
            this.listBoxfogas.ItemHeight = 15;
            this.listBoxfogas.Location = new System.Drawing.Point(47, 69);
            this.listBoxfogas.Name = "listBoxfogas";
            this.listBoxfogas.Size = new System.Drawing.Size(283, 319);
            this.listBoxfogas.TabIndex = 0;
            this.listBoxfogas.SelectedIndexChanged += new System.EventHandler(this.listBoxfogas_SelectedIndexChanged);
            // 
            // textBoxfogás
            // 
            this.textBoxfogás.Location = new System.Drawing.Point(47, 31);
            this.textBoxfogás.Name = "textBoxfogás";
            this.textBoxfogás.Size = new System.Drawing.Size(283, 23);
            this.textBoxfogás.TabIndex = 1;
            this.textBoxfogás.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fogásnév:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(424, 69);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(284, 319);
            this.listBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(422, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "NyersanyagNév:";
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxfogás);
            this.Controls.Add(this.listBoxfogas);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(835, 501);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxfogas;
        private TextBox textBoxfogás;
        private Label label1;
        private ListBox listBox1;
        private Label label2;
    }
}
