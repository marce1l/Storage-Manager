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

        public Menu()
        {
            InitializeComponent();
        }

        private void AddItem_Button_Click(object sender, EventArgs e)
        {
            AddItemPopup addItemPopup = new AddItemPopup(termekek);
            addItemPopup.ShowDialog();
            termekek.AddRange(addItemPopup.ujTermekek);
        }

        private void keresesVonalkod_Button_Click(object sender, EventArgs e)
        {
            br = new BarcodeReader(termekek, true);

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
            ListProducts lr = new ListProducts(termekek);

            if (!MegVanNyitva(lr.GetType()))
            {
                if (keresve == -1)
                {
                    lr.Show();
                }
                else
                {
                    lr.Show();
                    lr.dataGridView.Rows[keresve].Selected = true;
                    lr.dataGridView.CurrentCell = lr.dataGridView.Rows[keresve].Cells[0];
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
            br = new BarcodeReader(termekek, true);
            
            br.ShowDialog();

            if (!br.bezartVagyHiba)
            {
                InOutItem inoutitem = new InOutItem(termekek, true, br.megtalaltSorszam);
                inoutitem.ShowDialog();
            }
        }

        private void Ki_Button_Click(object sender, EventArgs e)
        {
            br = new BarcodeReader(termekek, true);

            br.ShowDialog();
            if (!br.bezartVagyHiba)
            {
                InOutItem inoutitem = new InOutItem(termekek, false, br.megtalaltSorszam);
                inoutitem.ShowDialog();
            }
        }

        private void AdatBetoltes()
        {
            string name = "adatok";
            string path = Path.Combine("..", "..", "..", "Data", name);
            
            if (File.Exists(path+ ".txt"))
            {
                StreamReader sr = new StreamReader(path + ".txt");

                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    string[] bontottSor = sor.Split(';');
                    Termek t = new Termek(bontottSor[0], bontottSor[1], bontottSor[2], bontottSor[3], Convert.ToInt32(bontottSor[4]), Convert.ToInt32(bontottSor[5]), Convert.ToInt32(bontottSor[6]));
                    termekek.Add(t);
                }

                sr.Close();
            }
        }

        private void AdatMentes()
        {
            string name = "adatok";
            string path = Path.Combine("..", "..", "..", "Data", name);
            StreamWriter sw = new StreamWriter(path + ".txt");

            foreach (var termek in termekek)
            {
                sw.Write(termek.Nev + ";" + termek.Cikkszam + ";" + termek.Marka + ";" + termek.Vonalkod + ";" + termek.Darabszam + ";" + termek.MinDarabszam + ";" + termek.Ar + "\n");
            }

            sw.Close();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            AdatMentes();

            //e.Cancel = true;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            AdatBetoltes();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_label.Text = DateTime.Now.ToString("dddd, yyyy MMM dd, hh:mm:ss", new System.Globalization.CultureInfo("Hu"));
        }
    }
}
