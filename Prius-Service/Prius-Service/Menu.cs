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
        private static readonly Menu instance = new Menu();

        private Menu()
        {
            InitializeComponent();
        }

        public static Menu Instance
        {
            get
            {
                return instance;
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Data.Instance.AdatBetoltes();
            DisplayFunctions.Instance.KevesDarabErtesites();

            System.Timers.Timer AutoSaveTimer = new System.Timers.Timer(180000);
            AutoSaveTimer.Elapsed += OnTimedEvent;
            AutoSaveTimer.Enabled = true;
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Data.Instance.AdatMentes();
            //e.Cancel = true; Biztosan ki szeretnél lépni? megvalósításához
        }

        private void OnTimedEvent(object sender, EventArgs e)
        {
            Data.Instance.AdatMentes();
        }

        private void AddItem_Button_Click(object sender, EventArgs e)
        {
            AddItemPopup addItemPopup = new AddItemPopup();
            addItemPopup.ShowDialog();
        }

        private void KeresesVonalkod_Button_Click(object sender, EventArgs e)
        {
            BarcodeReader br = new BarcodeReader(true);

            br.ShowDialog();

            if (!br.bezartVagyHiba)
            {
                RaktarListazas(br.megtalaltSorszam);
            }
        }

        private void RaktarListazas_Button_Click(object sender, EventArgs e)
        {
            //Nincsen keresve termék
            RaktarListazas(-1);
        }

        //A keresve keresett termék indexe
        private void RaktarListazas(int keresve)
        {
            ListProducts lp = new ListProducts();

            if (!MegVanNyitva(lp.GetType()))
            {
                if (keresve == -1)
                {
                    if (Data.Instance.termekek.Count == 0)
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
            BarcodeReader br = new BarcodeReader(true);
            
            br.ShowDialog();

            if (!br.bezartVagyHiba)
            {
                Data.Instance.SetBeKi(true);
                InOutItem inoutitem = new InOutItem(br.megtalaltSorszam);
                inoutitem.ShowDialog();
            }
        }

        private void Ki_Button_Click(object sender, EventArgs e)
        {
            BarcodeReader br = new BarcodeReader(true);

            br.ShowDialog();
            if (!br.bezartVagyHiba)
            {
                Data.Instance.SetBeKi(false);
                InOutItem inoutitem = new InOutItem(br.megtalaltSorszam);
                inoutitem.ShowDialog();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            time_label.Text = DateTime.Now.ToString("dddd, yyyy MMM dd, hh:mm:ss", new System.Globalization.CultureInfo("Hu"));
        }

        private void RosszVonalkodOlvaso_Setting_CheckedChanged(object sender, EventArgs e)
        {
            Settings_StripMenu.ShowDropDown();

            if (rosszVonalkodOlvaso_Setting.Checked)
            {
                Data.Instance.SetRosszVonlkodOlvaso(true);
            }
            else
            {
                Data.Instance.SetRosszVonlkodOlvaso(false);
            }
            
        }

        private void OmlesztettBe_button_Click(object sender, EventArgs e)
        {
            Data.Instance.SetBeKi(true);
            MultipleItemsInOut multipleItems = new MultipleItemsInOut();
            multipleItems.ShowDialog();
        }

        private void OmlesztettKi_button_Click(object sender, EventArgs e)
        {
            Data.Instance.SetBeKi(false);
            MultipleItemsInOut multipleItems = new MultipleItemsInOut();
            multipleItems.ShowDialog();
        }

        private void About_StripMenu_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void Importalas_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data.Instance.ImportFromCsv();
        }

        private void Exportalas_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data.Instance.ExportToCsv();
        }

        private void raktarVissza_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bizotsan visszaszeretnéd állítani az előző raktár állapotot?\nEzzel a jelenlegi raktárad elveszik!", "Figyelmeztetés", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                Data.Instance.RaktarVisszaalitas();
                raktarVissza_ToolStripMenuItem.Enabled = false;
            }
        }
    }
}
