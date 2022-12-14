using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZH_V0X5BZ
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if(this.ValidateChildren()==true) this.DialogResult = DialogResult.OK;
        }

        private void textBoxFogasnev_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxFogasnev.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxFogasnev, "Nem lehet üres");

            }
        }

        private void textBoxFogasnev_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxFogasnev, String.Empty);
        }

        private void textBoxleiras_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("^[a-zA-Z]+$");
            if(!regex.IsMatch(textBoxleiras.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxleiras, "(Könnyű,Közepes,Nehéz), szám és ékezet nem lehet benne");

            }
        }

        private void textBoxleiras_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxleiras, String.Empty);
        }
    }
}
