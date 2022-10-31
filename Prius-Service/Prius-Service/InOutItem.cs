using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prius_Service
{
    public partial class InOutItem : Form
    {
        private int index;
        public InOutItem(int index)
        {
            InitializeComponent();
            this.index = index;
        }

        private void InOutItem_Load(object sender, EventArgs e)
        {
            BeKiSetup();

            List<Termek> beKiVittTermek = new List<Termek>();
            beKiVittTermek.Add(Data.Instance.termekek[index]);

            DisplayFunctions.Instance.Kilistaz(beKiVittTermek, this.dataGridView);
        }

        private void BeKiSetup()
        {
            tLabel1.Visible = true;
            tLabel1.BringToFront();

            beKi_richTextBox.Text = "Hány darabot szeretnél ebből a termékből ";

            if (Data.Instance.beKi)
            {
                DisplayFunctions.Instance.TextColor(beKi_richTextBox, "bevinni?", Color.Green, new Font("Segoe UI", 12, FontStyle.Bold));
                this.Text = "Bevitel";
            }
            else
            {
                DisplayFunctions.Instance.TextColor(beKi_richTextBox, "kivinni?", Color.Red, new Font("Segoe UI", 12, FontStyle.Bold));
                this.Text = "Kivitel";
                confirm_label.Text = "Biztosan ki szeretnéd vinni?";
                confirm_label.Location = new Point(526, 36);
            }
        }

        private void Igen_button_Click(object sender, EventArgs e)
        {
            int beKiDarabszam = Convert.ToInt32(BeKiDarabszam_numericUpAndDown.Value);

            if (Data.Instance.beKi)
            {
                Data.Instance.termekek[index].Darabszam += beKiDarabszam;
            }
            else
            {
                if (Data.Instance.termekek[index].Darabszam < beKiDarabszam)
                {
                    MessageBox.Show("Nem lehet a " + Data.Instance.termekek[index].Nev + " termékből " + beKiDarabszam + " db-ot kivinni, mert csak " + Data.Instance.termekek[index].Darabszam + " db van belőle raktáron!\nEbből a termékből ezért csak " + Data.Instance.termekek[index].Darabszam + " db-ot vitt ki a rendszer", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Data.Instance.termekek[index].Darabszam = 0;
                }
                else
                {
                    Data.Instance.termekek[index].Darabszam -= beKiDarabszam;
                }
            }

            DisplayFunctions.Instance.KevesDarabErtesites();
        }
    }
}
