using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prius_Service
{
    public partial class AddItemPopup : Form
    {
        private bool meghiusult;
        private List<Termek> termekek;
        private List<string> markak = new List<string>();
        public List<Termek> ujTermekek = new List<Termek>();
        

        public AddItemPopup(List<Termek> termekek)
        {
            this.termekek = termekek;
            InitializeComponent();
        }

        private void AddItemPopup_Load(object sender, EventArgs e)
        {
            BindingListToMarkaComboBox(termekek);
            AutoCompleteComboBox();
        }

        private void Mentes_Button_Click(object sender, EventArgs e)
        {
            meghiusult = false;

            Mentes();

            if (!meghiusult)
            {
                nev_TextBox.Text = "";
                cikkszam_TextBox.Text = "";
                vonalkod_textBox.Text = "";
                beszerzesiAr_textBox.Text = "";
                eladasiAr_Textbox.Text = "";
                marka_comboBox.Text = "";
                darabszam_TextBox.Text = "";
                minDarabszam_textBox.Text = "";

                BindingListToMarkaComboBox(ujTermekek);
                AutoCompleteComboBox();
            }

            nev_TextBox.Focus();
        }

        private void Mentes()
        {
            int darabszam = 0;
            int beszerzesiAr = 0;
            int eladasiAr = 0;
            int minDarabszam = 0;

            try
            {
                beszerzesiAr = Convert.ToInt32(beszerzesiAr_textBox.Text);
            }
            catch (FormatException)
            {
                if (beszerzesiAr_textBox.Text.Equals(""))
                {
                    beszerzesiAr = 0;
                }
                else
                {
                    MessageBox.Show("A Beszerzési Ár mezőnek számot adjon meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    beszerzesiAr_textBox.Text = "";
                    meghiusult = true;
                }
            }

            try
            {
                eladasiAr = Convert.ToInt32(eladasiAr_Textbox.Text);
            }
            catch (FormatException)
            {
                if (eladasiAr_Textbox.Text.Equals(""))
                {
                    eladasiAr = 0;
                }
                else
                {
                    MessageBox.Show("Az Eladási Ár mezőnek számot adjon meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    eladasiAr_Textbox.Text = "";
                    meghiusult = true;
                }
            }

            try
            {
                darabszam = Convert.ToInt32(darabszam_TextBox.Text);
            }
            catch (FormatException)
            {
                if (darabszam_TextBox.Text.Equals(""))
                {
                    darabszam = 0;
                }
                else
                {
                    MessageBox.Show("A darabszám mezőnek számot adjon meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    darabszam_TextBox.Text = "";
                    meghiusult = true;
                }
            }

            try
            {
                minDarabszam = Convert.ToInt32(minDarabszam_textBox.Text);
            }
            catch (FormatException)
            {
                if (minDarabszam_textBox.Text.Equals(""))
                {
                    minDarabszam = 0;
                }
                else
                {
                    MessageBox.Show("A minDarabszám mezőnek számot adjon meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    minDarabszam_textBox.Text = "";
                    meghiusult = true;
                }
            }

            if (String.IsNullOrEmpty(nev_TextBox.Text) || String.IsNullOrEmpty(cikkszam_TextBox.Text))
            {
                meghiusult = true;
                MessageBox.Show("A csillagos mezőket kötelező kitölteni!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool duplikalt = false;
                int termekIndex = -1;

                for (int i = 0; i < termekek.Count; i++)
                {
                    if (termekek[i].Vonalkod == vonalkod_textBox.Text)
                    {
                        duplikalt = true;
                        termekIndex = i;
                        break;
                    }
                }

                if (duplikalt)
                {
                    termekek[termekIndex].Darabszam += darabszam;
                }
                else
                {
                    Termek t = new Termek(nev_TextBox.Text, cikkszam_TextBox.Text, marka_comboBox.Text, vonalkod_textBox.Text, darabszam, minDarabszam, beszerzesiAr, eladasiAr);
                    ujTermekek.Add(t);
                }
            }
        }

        private void befejezes_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VonalkodBeolvas_Button_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            BarcodeReader br = new BarcodeReader(termekek, false, m.rosszVonalkodOlvaso);
            br.ShowDialog();

            vonalkod_textBox.Text = br.barcode.TrimEnd();
        }

        private void BindingListToMarkaComboBox(List<Termek> listToBind)
        {
            markak.AddRange(MarkakKinyerese(listToBind));
            markak = markak.Distinct().ToList();
            markak.Sort();

            BindingList<string> bindingList = new BindingList<string>(markak);
            var source = new BindingSource(bindingList, null);
            marka_comboBox.DataSource = source;

            marka_comboBox.Text = "";
        }

        private List<string> MarkakKinyerese(List<Termek> lista)
        {
            List<string> markak = new List<string>();

            foreach (var termek in lista)
            {
                if (!(markak.Contains(termek.Marka)))
                {
                    markak.Add(termek.Marka);
                }
            }

            return markak;
        }

        private void AutoCompleteComboBox()
        {
            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            autoComplete.AddRange(markak.ToArray());
            marka_comboBox.AutoCompleteCustomSource = autoComplete;
            marka_comboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            marka_comboBox.Text = "";
        }
    }
}
