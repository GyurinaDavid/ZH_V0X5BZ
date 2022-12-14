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
    public partial class UserControl3 : UserControl
    {

        Models.EtkezesContext etkezesContext = new Models.EtkezesContext();

        public UserControl3()
        {
            InitializeComponent();
            Fogászürés();
            FogásListázás();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Fogászürés();
        }

        private void Fogászürés()
        {
            var szuresfogas = from x in etkezesContext.Fogasoks
                              where x.FogasNev.Contains(textBoxfogás.Text)
                              select x;
            listBoxfogas.DataSource = szuresfogas.ToList();
            listBoxfogas.DisplayMember = "FogasNev";
        }

        private void FogásListázás()
        {
            if (listBoxfogas.SelectedItem == null) return;

            var kivalasztottfogas = (Models.Fogasok)listBoxfogas.SelectedItem;

            var listazottfogas = from x in etkezesContext.Recepteks
                                 where x.FogasId == kivalasztottfogas.FogasId
                                 select new Hozzávalók
                                 {
                                     ReceptId = x.ReceptId,
                                     FogasId = x.FogasId,
                                     Mennyiseg4fo = x.Mennyiseg4fo,
                                     NyersanyagNév = x.Nyersanyag.NyersanyagNev,
                                     EgységNév = x.Nyersanyag.MennyisegiEgyseg.EgysegNev,
                                     Ár = (double)x.Mennyiseg4fo * (double)x.Nyersanyag.Egysegar

                                 };

            listBox1.DataSource = listazottfogas.ToList();
            listBox1.DisplayMember = "NyersanyagNév";
        }

        private void listBoxfogas_SelectedIndexChanged(object sender, EventArgs e)
        {
            FogásListázás();
        }
    }
}
