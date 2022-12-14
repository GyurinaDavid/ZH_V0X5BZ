namespace ZH_V0X5BZ
{
    partial class Form2
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
            this.textBoxFogasnev = new System.Windows.Forms.TextBox();
            this.textBoxleiras = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFogasnev
            // 
            this.textBoxFogasnev.Location = new System.Drawing.Point(76, 68);
            this.textBoxFogasnev.Name = "textBoxFogasnev";
            this.textBoxFogasnev.Size = new System.Drawing.Size(144, 23);
            this.textBoxFogasnev.TabIndex = 0;
            this.textBoxFogasnev.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxFogasnev_Validating);
            this.textBoxFogasnev.Validated += new System.EventHandler(this.textBoxFogasnev_Validated);
            // 
            // textBoxleiras
            // 
            this.textBoxleiras.Location = new System.Drawing.Point(76, 150);
            this.textBoxleiras.Name = "textBoxleiras";
            this.textBoxleiras.Size = new System.Drawing.Size(144, 23);
            this.textBoxleiras.TabIndex = 1;
            this.textBoxleiras.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxleiras_Validating);
            this.textBoxleiras.Validated += new System.EventHandler(this.textBoxleiras_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fogásnév:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Leírás(Nehézségi szint):";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(91, 297);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(215, 104);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.CausesValidation = false;
            this.buttonCancel.Location = new System.Drawing.Point(371, 297);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(215, 104);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxleiras);
            this.Controls.Add(this.textBoxFogasnev);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public TextBox textBoxFogasnev;
        public TextBox textBoxleiras;
        private Label label1;
        private Label label2;
        private Button buttonOk;
        private Button buttonCancel;
        private ErrorProvider errorProvider1;
    }
}