using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void AddItem_Button_Click(object sender, EventArgs e)
        {
            AddItemPopup addItemPopup = new AddItemPopup();
            addItemPopup.ShowDialog();
            termekek.AddRange(addItemPopup.ujTermekek);
            kiir();
        }

        public void kiir()
        {
            label1.Text = "";
            for (int i = 0; i < termekek.Count; i++)
            {
                label1.Text += termekek[i].Nev + ";" + termekek[i].Cikkszam + ";" + termekek[i].Vonalkod + ";" + termekek[i].Marka + +termekek[i].Darabszam + termekek[i].MinDarabszam + ";" + termekek[i].Ar + "\n";
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
