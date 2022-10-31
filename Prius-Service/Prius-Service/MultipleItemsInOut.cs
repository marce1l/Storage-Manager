using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace Prius_Service
{
    public partial class MultipleItemsInOut : Form
    {
        private int index;
        private string barcode;
        private List<Termek> beKiVittTermekek = new List<Termek>();
        System.Windows.Forms.Timer _typingTimer;
        public MultipleItemsInOut()
        {
            InitializeComponent();
        }

        private void MultipleItemsInOut_Load(object sender, EventArgs e)
        {
            BeKiSetup();
        }

        private void BeKiSetup()
        {
            tLabel1.Visible = true;
            tLabel1.BringToFront();
            
            tLabel2.Visible = true;
            tLabel2.BringToFront();
            
            barcode_textBox.Focus();

            beKi_richTextBox.Text = "Eddig ";
            beKiConfirm_richTextBox.Text = "";

            if (Data.Instance.beKi)
            {
                DisplayFunctions.Instance.TextColor(beKi_richTextBox, "bevitt", Color.Green, new Font("Segoe UI", 16, FontStyle.Bold));
                DisplayFunctions.Instance.TextColor(beKiConfirm_richTextBox, "Be", Color.Green, new Font("Segoe UI", 12, FontStyle.Bold));
                this.Text = "Ömlesztett Bevitel";
                osszesAr_label.Location = new Point(580, 460);
                osszesAr_label.Text = "Összes beszerzési ára:";
            }
            else
            {
                DisplayFunctions.Instance.TextColor(beKi_richTextBox, "kivitt", Color.Red, new Font("Segoe UI", 16, FontStyle.Bold));
                DisplayFunctions.Instance.TextColor(beKiConfirm_richTextBox, "Ki", Color.Red, new Font("Segoe UI", 12, FontStyle.Bold));
                this.Text = "Ömlesztett Kivitel";
            }

            DisplayFunctions.Instance.TextColor(beKiConfirm_richTextBox, " szeretnéd vinni ezeket a termékeket?", Color.Black, new Font("Segoe UI", 12));
            DisplayFunctions.Instance.TextColor(beKi_richTextBox, " termékek", SystemColors.ControlText, new Font("Segoe UI", 16));
        }

        private void Kilistaz()
        {
            bool hasznaltE = HasznaltIndexE(index);

            if (!hasznaltE)
            {
                beKiVittTermekek.Add(new Termek(Data.Instance.termekek[index].Nev, Data.Instance.termekek[index].Cikkszam, Data.Instance.termekek[index].Marka, Data.Instance.termekek[index].Vonalkod, 1, Data.Instance.termekek[index].MinDarabszam, Data.Instance.termekek[index].BeszerzesiAr, Data.Instance.termekek[index].EladasiAr));
            }

            if (beKiVittTermekek.Count == 1)
            {
                beolvasFigyelmezteto_label.Visible = false;
            }

            BindingList<Termek> bindingList = new BindingList<Termek>(beKiVittTermekek);
            var source = new BindingSource(bindingList, null);
            dataGridView.DataSource = source;

            dataGridView.Columns.RemoveAt(3);
            dataGridView.Columns.RemoveAt(4);
            
            dataGridView.Columns[0].HeaderText = "Név";
            dataGridView.Columns[1].HeaderText = "Cikkszám";
            dataGridView.Columns[2].HeaderText = "Márka";

            if (Data.Instance.beKi)
            {
                dataGridView.Columns.RemoveAt(5);
                dataGridView.Columns[3].HeaderText = "Bevitt Darabszám";
                dataGridView.Columns[4].HeaderText = "Beszerzési Ár";
            }
            else
            {
                dataGridView.Columns.RemoveAt(4);
                dataGridView.Columns[3].HeaderText = "Kivitt Darabszám";
                dataGridView.Columns[4].HeaderText = "Eladási Ár";
            }

            dataGridView.Columns[4].DefaultCellStyle.Format = "N0";

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView.Rows[0].Height = 30;

            dataGridView.ClearSelection();

            OsszegSzamitas();
        }

        private void Barcode_textBox_TextChanged(object sender, EventArgs e)
        {
            if (_typingTimer == null)
            {
                _typingTimer = new Timer();
                _typingTimer.Interval = 300;
                _typingTimer.Tick += new EventHandler(this.HandleTypingTimerTimeout);
            }

            _typingTimer.Stop();
            _typingTimer.Tag = (sender as TextBox).Text;
            _typingTimer.Start();
        }

        private void HandleTypingTimerTimeout(object sender, EventArgs e)
        {
            var timer = sender as Timer;

            if (timer == null)
            {
                return;
            }

            barcode = barcode_textBox.Text;

            timer.Stop();

            if (!(barcode == ""))
            {
                if (VonalkodHibaKezeles())
                {
                    Kilistaz();
                }
            }
        }

        private bool VonalkodHibaKezeles()
        {
            int sorszam = VonalkodVan(barcode);

            if (sorszam == -2)
            {
                MessageBox.Show("Nincs ilyen vonalkódú termék eltárolva!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                barcode_textBox.Text = "";
                return false;
            }

            index = sorszam;
            barcode_textBox.Text = "";
            return true;
        }

        private int VonalkodVan(string vonalkod)
        {
            vonalkod = vonalkod.TrimEnd('\r', '\n');

            if (Data.Instance.rosszVonalkodOlvaso)
            {
                char[] karakterek = vonalkod.ToCharArray();

                for (int i = 0; i < karakterek.Length; i++)
                {
                    if (karakterek[i].Equals('ö'))
                    {
                        karakterek[i] = '0';
                    }
                }

                vonalkod = new string(karakterek);
            }

            for (int i = 0; i < Data.Instance.termekek.Count; i++)
            {
                if (Data.Instance.termekek[i].Vonalkod.Equals(vonalkod))
                {
                    return i;
                }
            }

            return -2;
        }
        //Hozzáadja a darabszámot ha már be lett olvasva a termék
        private bool HasznaltIndexE(int termekIndex)
        {
            if (beKiVittTermekek.Count == 0)
            {
                return false;
            }
            for (int i = 0; i < beKiVittTermekek.Count; i++)
            {
                if (beKiVittTermekek[i].Vonalkod == Data.Instance.termekek[termekIndex].Vonalkod)
                {
                    beKiVittTermekek[i].Darabszam += 1;
                    return true;
                }
            }

            return false;
        }

        private void OsszegSzamitas()
        {
            int osszeg = 0;

            foreach (Termek termek in beKiVittTermekek)
            {
                if (Data.Instance.beKi)
                {
                    osszeg += termek.BeszerzesiAr * termek.Darabszam;
                }
                else
                {
                    osszeg += termek.EladasiAr * termek.Darabszam;
                }
            }

            string osszegString = osszeg.ToString("N0");
            osszesArData_label.Text = osszegString + " Ft";
        }

        private void MultipleItemsInOut_FormClosing(object sender, FormClosingEventArgs e)
        {
            beKiVittTermekek.Clear();
        }

        private void Igen_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Data.Instance.termekek.Count; i++)
            {
                foreach (Termek termek in beKiVittTermekek)
                {
                    if (termek.Vonalkod == Data.Instance.termekek[i].Vonalkod)
                    {
                        if (Data.Instance.beKi)
                        {
                            Data.Instance.termekek[i].Darabszam += termek.Darabszam;
                        }
                        else
                        {
                            if (termek.Darabszam > Data.Instance.termekek[i].Darabszam)
                            {
                                MessageBox.Show("Nem lehet a " + termek.Nev + " termékből " + termek.Darabszam + " db-ot kivinni, mert csak " + Data.Instance.termekek[i].Darabszam + " db van belőle raktáron!\nEbből a termékből ezért csak " + Data.Instance.termekek[i].Darabszam + " db-ot vitt ki a rendszer", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Data.Instance.termekek[i].Darabszam = 0;
                            }
                            else
                            {
                                Data.Instance.termekek[i].Darabszam -= termek.Darabszam;
                            }
                        }
                    }
                }
            }

            DisplayFunctions.Instance.KevesDarabErtesites();
        }
    }
}
