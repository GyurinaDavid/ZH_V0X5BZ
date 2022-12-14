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
    public partial class UserControl1 : UserControl
    {
        Models.EtkezesContext etkezesContext = new Models.EtkezesContext();
        public UserControl1()
        {
            InitializeComponent();
            Fogászürés();
            Nyersanyagszures();
            FogásListázás();
            NyersanyagLista();
        }

        private void Fogászürés()
        {
            var szuresfogas = from x in etkezesContext.Fogasoks
                              where x.FogasNev.Contains(textBoxfogás.Text)
                              select x;
            listBoxFogások.DataSource = szuresfogas.ToList();
            listBoxFogások.DisplayMember = "FogasNev";
        }

        private void Nyersanyagszures()
        {
            var nyersanyagszures = from x in etkezesContext.Nyersanyagoks
                                   where x.NyersanyagNev.Contains(textBoxNyersanyag.Text)
                                   select x;
            listBoxNyersanyagok.DataSource = nyersanyagszures.ToList();
            listBoxNyersanyagok.DisplayMember = "NyersanyagNev";
        }

        private void FogásListázás()
        {
            if (listBoxFogások.SelectedItem == null) return;

            var kivalasztottfogas = (Models.Fogasok)listBoxFogások.SelectedItem;

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

            hozzávalókBindingSource.DataSource = listazottfogas.ToList();
        }


        private void NyersanyagLista()
        {
            var kivalasztottnyers = (Models.Nyersanyagok)listBoxNyersanyagok.SelectedItem;

            var listázottnyers = (from x in etkezesContext.MennyisegiEgysegeks
                                  where x.MennyisegiEgysegId == kivalasztottnyers.MennyisegiEgysegId
                                  select x).FirstOrDefault();

            labelmertekegyseg.Text = listázottnyers.EgysegNev;
        }

        private void textBoxfogás_TextChanged(object sender, EventArgs e)
        {
            Fogászürés();
        }

        private void textBoxNyersanyag_TextChanged(object sender, EventArgs e)
        {
            Nyersanyagszures();
        }

        private void listBoxFogások_SelectedIndexChanged(object sender, EventArgs e)
        {
            FogásListázás();

        }

        private void listBoxNyersanyagok_SelectedIndexChanged(object sender, EventArgs e)
        {
            NyersanyagLista();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Models.Receptek r = new Models.Receptek();
            var kivalasztottfogas = (Models.Fogasok)listBoxFogások.SelectedItem;
            var kivalasztottnyers = (Models.Nyersanyagok)listBoxNyersanyagok.SelectedItem;

            r.FogasId = kivalasztottfogas.FogasId;
            r.NyersanyagId = kivalasztottnyers.NyersanyagId;
            double m;
            if (!double.TryParse(textBoxmennyiseg.Text, out m)) return;
            r.Mennyiseg4fo = m;

            etkezesContext.Add(r);

            try
            {
                etkezesContext.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            FogásListázás();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var receptid = ((Hozzávalók)hozzávalókBindingSource.Current).ReceptId;

            var törlendő = (from x in etkezesContext.Recepteks
                            where x.ReceptId == receptid
                            select x).FirstOrDefault();
            if(MessageBox.Show("Are you sure you want to delete this record?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                etkezesContext.Recepteks.Remove(törlendő);

                try
                {
                    etkezesContext.SaveChanges();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }


            }

            FogásListázás();

        }
    }
}
