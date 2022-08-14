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

        public Menu()
        {
            InitializeComponent();
            time_label.Text = DateTime.Now.ToString("dddd, yyyy MMM dd, hh:mm:ss", new System.Globalization.CultureInfo("Hu"));
        }

        public List<Termek> GetList()
        {
            return termekek;
        }

        private void AddItem_Button_Click(object sender, EventArgs e)
        {
            AddItemPopup addItemPopup = new AddItemPopup();
            addItemPopup.ShowDialog();
            termekek.AddRange(addItemPopup.ujTermekek);
        }

        private void keresesVonalkod_Button_Click(object sender, EventArgs e)
        {
            BarcodeReader br = new BarcodeReader();
            br.ShowDialog();

            int index = vonalkodKereses(br.barcode);
            
            if (index == -1)
            {

            }
            else if (index == -2)
            {
                MessageBox.Show("Nincs ilyen vonalkódú termék eltárolva!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                raktarListazas(index);
            }
        }

        private int vonalkodKereses(string vonalkod)
        {
            if (String.IsNullOrEmpty(vonalkod))
            {
                return -1;
            }
            else
            {
                for (int i = 0; i < termekek.Count; i++)
                {
                    if (termekek[i].Vonalkod == vonalkod)
                    {
                        return i;
                    }
                }
            }

            return -2;
        }

        private void raktarListazas_Button_Click(object sender, EventArgs e)
        {
            raktarListazas(-1);
        }

        private void raktarListazas(int keresve)
        {
            if (keresve != -1)
            {
                ListProducts lr = new ListProducts(termekek);
                lr.Show();
                lr.dataGridView.Rows[keresve].Selected = true;
                lr.dataGridView.CurrentCell = lr.dataGridView.Rows[keresve].Cells[0];
            }
            else
            {
                ListProducts lr = new ListProducts(termekek);
                lr.Show();
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
    }
}
