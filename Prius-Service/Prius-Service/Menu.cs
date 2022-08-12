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
        private List<Termek> termekek = new List<Termek>();

        public Menu()
        {
            InitializeComponent();
        }

        private void AddItem_Button_Click(object sender, EventArgs e)
        {
            AddItemPopup addItemPopup = new AddItemPopup();
            addItemPopup.ShowDialog();

            var nev = addItemPopup.Nev;
            var cikkszam = addItemPopup.Cikkszam;
        }
    }
}
