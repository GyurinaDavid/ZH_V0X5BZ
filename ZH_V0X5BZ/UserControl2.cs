using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZH_V0X5BZ
{
    public partial class UserControl2 : UserControl
    {
        Models.EtkezesContext etkezesContext=new Models.EtkezesContext();

        public UserControl2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            if(form2.ShowDialog()==DialogResult.OK)
            {
                Models.Fogasok fogasok = new Models.Fogasok();
                fogasok.FogasNev = form2.textBoxFogasnev.Text;
                fogasok.Leiras = form2.textBoxleiras.Text;

                etkezesContext.Add(fogasok);

                try
                {
                    etkezesContext.SaveChanges();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }




            }

            fogasokBindingSource.DataSource = etkezesContext.Fogasoks.ToList();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            fogasokBindingSource.DataSource = etkezesContext.Fogasoks.ToList();
        }
    }
}
