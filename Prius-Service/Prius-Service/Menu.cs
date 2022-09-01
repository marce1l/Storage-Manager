using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prius_Service
{
    public partial class Menu : Form
    {
        public List<Termek> termekek = new List<Termek>();
        private BarcodeReader br;
        public bool rosszVonalkodOlvaso { get; private set; }

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            AdatBetoltes();
            KevesDarabErtesites();

            System.Timers.Timer AutoSaveTimer = new System.Timers.Timer(180000);
            AutoSaveTimer.Elapsed += OnTimedEvent;
            AutoSaveTimer.Enabled = true;
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            AdatMentes();
            //e.Cancel = true;
        }

        private void OnTimedEvent(object sender, EventArgs e)
        {
            AdatMentes();
        }

        private void AddItem_Button_Click(object sender, EventArgs e)
        {
            AddItemPopup addItemPopup = new AddItemPopup(termekek);
            addItemPopup.ShowDialog();
            termekek.AddRange(addItemPopup.ujTermekek);
            
            KevesDarabErtesites();
        }

        private void keresesVonalkod_Button_Click(object sender, EventArgs e)
        {
            br = new BarcodeReader(termekek, true, rosszVonalkodOlvaso);

            br.ShowDialog();

            if (!br.bezartVagyHiba)
            {
                raktarListazas(br.megtalaltSorszam);
            }
        }

        private void raktarListazas_Button_Click(object sender, EventArgs e)
        {
            raktarListazas(-1);
        }

        private void raktarListazas(int keresve)
        {
            ListProducts lp = new ListProducts(termekek);

            if (!MegVanNyitva(lp.GetType()))
            {
                if (keresve == -1)
                {
                    if (termekek.Count == 0)
                    {
                        MessageBox.Show("Még nincsen egy termék sem eltárolva", "Megjegyzés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        lp.Show();
                    }
                }
                else
                {
                    lp.Show();
                    lp.dataGridView.Rows[keresve].Selected = true;
                    lp.dataGridView.CurrentCell = lp.dataGridView.Rows[keresve].Cells[0];
                }
            }
        }

        private bool MegVanNyitva(Type type)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == type)
                {
                    form.Activate();
                    return true;
                }
            }
            return false;
        }

        private void Be_Button_Click(object sender, EventArgs e)
        {
            br = new BarcodeReader(termekek, true, rosszVonalkodOlvaso);
            
            br.ShowDialog();

            if (!br.bezartVagyHiba)
            {
                InOutItem inoutitem = new InOutItem(termekek, true, br.megtalaltSorszam);
                inoutitem.ShowDialog();

                KevesDarabErtesites();
            }
        }

        private void Ki_Button_Click(object sender, EventArgs e)
        {
            br = new BarcodeReader(termekek, true, rosszVonalkodOlvaso);

            br.ShowDialog();
            if (!br.bezartVagyHiba)
            {
                InOutItem inoutitem = new InOutItem(termekek, false, br.megtalaltSorszam);
                inoutitem.ShowDialog();

                KevesDarabErtesites();
            }
        }

        private void AdatBetoltes()
        {
            string name = "adatok.txt";
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Raktár App", name);

            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path);

                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    string[] bontottSor = sor.Split(';');
                    Termek t = new Termek(bontottSor[0], bontottSor[1], bontottSor[2], bontottSor[3], Convert.ToInt32(bontottSor[4]), Convert.ToInt32(bontottSor[5]), Convert.ToInt32(bontottSor[6]), Convert.ToInt32(bontottSor[7]));
                    termekek.Add(t);
                }

                sr.Close();
            }
        }

        private void AdatMentes()
        {
            StreamWriter sw = null;

            string name = "adatok.txt";
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Raktár App", name);
            
            try
            {
                sw = new StreamWriter(path, false, Encoding.UTF8);
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Raktár App"));
                sw = new StreamWriter(path);
            }
            
            foreach (var termek in termekek)
            {
                sw.Write(termek.Nev + ";" + termek.Cikkszam + ";" + termek.Marka + ";" + termek.Vonalkod + ";" + termek.Darabszam + ";" + termek.MinDarabszam + ";" + termek.BeszerzesiAr + ";" + termek.EladasiAr + "\n");
            }

            sw.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_label.Text = DateTime.Now.ToString("dddd, yyyy MMM dd, hh:mm:ss", new System.Globalization.CultureInfo("Hu"));
        }

        private void rosszVonalkodOlvaso_Setting_CheckedChanged(object sender, EventArgs e)
        {
            Settings_StripMenu.ShowDropDown();

            if (rosszVonalkodOlvaso_Setting.Checked)
            {
                rosszVonalkodOlvaso = true;
            }
            else
            {
                rosszVonalkodOlvaso = false;
            }
            
        }

        private void omlesztettBe_button_Click(object sender, EventArgs e)
        {
            br = new BarcodeReader(termekek, true, rosszVonalkodOlvaso);

            br.ShowDialog();

            if (!br.bezartVagyHiba)
            {
                MultipleItemsInOut multipleItems = new MultipleItemsInOut(termekek, true);
                multipleItems.ShowDialog();

                KevesDarabErtesites();
            }
        }

        private void omlesztettKi_button_Click(object sender, EventArgs e)
        {
            br = new BarcodeReader(termekek, true, rosszVonalkodOlvaso);

            br.ShowDialog();

            if (!br.bezartVagyHiba)
            {
                MultipleItemsInOut multipleItems = new MultipleItemsInOut(termekek, false);
                multipleItems.ShowDialog();

                KevesDarabErtesites();
            }
        }

        public void KevesDarabErtesites()
        {
            foreach (var termek in termekek)
            {
                if (termek.Darabszam < termek.MinDarabszam+5)
                {
                    ertesitesek_richTextBox.AppendText("A(z) ");
                    TextColor(ertesitesek_richTextBox, termek.Nev, SystemColors.ControlText, new Font("Segoe UI", 11, FontStyle.Bold));
                    TextColor(ertesitesek_richTextBox, " termékből már csak ", SystemColors.ControlText, new Font("Segoe UI", 11, FontStyle.Regular));
                    TextColor(ertesitesek_richTextBox, String.Format("{0}", termek.Darabszam), Color.Red, new Font("Segoe UI", 11, FontStyle.Bold));
                    TextColor(ertesitesek_richTextBox, " darab van\n\n", SystemColors.ControlText, new Font("Segoe UI", 11, FontStyle.Regular));
                }
            }
        }

        private void TextColor(RichTextBox rtbx, string text, Color color, Font font)
        {
            int start = rtbx.TextLength;
            rtbx.AppendText(text);
            int end = rtbx.TextLength;

            rtbx.Select(start, end - start);
            rtbx.SelectionColor = color;
            rtbx.SelectionFont = font;

            rtbx.Select(end, 0);
        }

        private void About_StripMenu_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void importalas_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel files (*.csv)|*.csv";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;
            ofd.InitialDirectory = @"C:\Desktop";
            ofd.CheckPathExists = true;
            ofd.CheckFileExists = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void exportalas_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel files (*.csv)|*.csv|All files (*.*)|*.*";
            sfd.FilterIndex = 1;
            sfd.RestoreDirectory = true;
            sfd.InitialDirectory = @"C:\Desktop";
            sfd.CheckPathExists = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Stream stream = File.Open(sfd.FileName, FileMode.CreateNew);
                StreamWriter sw = new StreamWriter(stream, Encoding.UTF8);

                foreach (var termek in termekek)
                {
                    sw.Write(termek.Nev + ";" + termek.Cikkszam + ";" + termek.Marka + ";" + termek.Vonalkod + ";" + termek.Darabszam + ";" + termek.MinDarabszam + ";" + termek.BeszerzesiAr + ";" + termek.EladasiAr + "\n");
                }

                sw.Close();
            }
        }
    }
}
