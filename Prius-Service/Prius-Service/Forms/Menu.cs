using System;
using System.Linq;
using System.Windows.Forms;
using Prius_Service.Data;

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
            HandleData.Instance.LoadItems();
            ModifyBasedOnUserSettings();
            DisplayFunctions.Instance.FewItemCountNotification();
            
            System.Timers.Timer AutoSaveTimer = new System.Timers.Timer(180000);
            AutoSaveTimer.Elapsed += OnTimedEvent;
            AutoSaveTimer.Enabled = true;
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            HandleData.Instance.SaveItems();
            HandleData.Instance.WriteSettingsToJson();
            //e.Cancel = true; Biztosan ki szeretnél lépni? megvalósításához
        }

        private void OnTimedEvent(object sender, EventArgs e)
        {
            HandleData.Instance.SaveItems();
        }

        private void ModifyBasedOnUserSettings()
        {
            HandleData.Instance.ReadSettingsFromJson();

            rosszVonalkodOlvaso_Setting.Checked = Settings.Instance.MalfunctioningBarcodeReader;
        }

        private void AddItem_Button_Click(object sender, EventArgs e)
        {
            using (AddItemPopup addItemPopup = new AddItemPopup())
            {
                addItemPopup.ShowDialog();
            }
        }

        private void KeresesVonalkod_Button_Click(object sender, EventArgs e)
        {
            using (BarcodeReader br = new BarcodeReader(true))
            {
                br.ShowDialog();

                if (!br.closedOrError)
                {
                    ListItems(br.FoundItemIndex);
                }
            }
        }

        private void RaktarListazas_Button_Click(object sender, EventArgs e)
        {
            //Nincsen keresve termék
            ListItems(-1);
        }

        //A keresett termék indexe
        private void ListItems(int searchedForIndex)
        {
            ListItems lp = new ListItems();

            if (!isOpened(lp.GetType()))
            {
                //nincs keresve termék
                if (searchedForIndex == -1)
                {
                    if (HandleData.Instance.items.Count == 0)
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
                    lp.search_textBox.Text = HandleData.Instance.items[searchedForIndex].Name;
                }
            }
        }

        private bool isOpened(Type type)
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
            using (BarcodeReader br = new BarcodeReader(true))
            {
                br.ShowDialog();

                if (!br.closedOrError)
                {
                    HandleData.Instance.SetInOut(true);

                    using (InOutItem inoutitem = new InOutItem(br.FoundItemIndex))
                    {
                        inoutitem.ShowDialog();
                    }
                }
            }
        }

        private void Ki_Button_Click(object sender, EventArgs e)
        {
            using (BarcodeReader br = new BarcodeReader(true))
            {
                br.ShowDialog();
                if (!br.closedOrError)
                {
                    HandleData.Instance.SetInOut(false);

                    using (InOutItem inoutitem = new InOutItem(br.FoundItemIndex))
                    {
                        inoutitem.ShowDialog();
                    }
                }
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            time_label.Text = DateTime.Now.ToString("dddd, yyyy MMM dd, HH:mm:ss", new System.Globalization.CultureInfo("Hu"));
        }

        private void RosszVonalkodOlvaso_Setting_CheckedChanged(object sender, EventArgs e)
        {
            Settings_StripMenu.ShowDropDown();
            
            if (rosszVonalkodOlvaso_Setting.Checked)
            {
                HandleData.Instance.SetMalfunctioningBarcodeReader(true);
            }
            else
            {
                HandleData.Instance.SetMalfunctioningBarcodeReader(false);
            }
            
        }

        private void OmlesztettBe_button_Click(object sender, EventArgs e)
        {
            HandleData.Instance.SetInOut(true);

            using (MultipleItemsInOut multipleItems = new MultipleItemsInOut())
            {
                multipleItems.ShowDialog();
            }
        }

        private void OmlesztettKi_button_Click(object sender, EventArgs e)
        {
            HandleData.Instance.SetInOut(false);

            using (MultipleItemsInOut multipleItems = new MultipleItemsInOut())
            {
                multipleItems.ShowDialog();
            }
        }

        private void About_StripMenu_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void Importalas_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HandleData.Instance.ImportFromCsv();
        }

        private void Exportalas_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HandleData.Instance.ExportToCsv();
        }

        private void raktarVissza_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bizotsan visszaszeretnéd állítani az előző raktár állapotot?\nEzzel a jelenlegi raktárad elveszik!", "Figyelmeztetés", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                HandleData.Instance.RestoreStorage();
                itemsBackup_ToolStripMenuItem.Enabled = false;
            }
        }

        private void kimutatasok_StripMenu_Click(object sender, EventArgs e)
        {
            Statistics sc = new Statistics();
            sc.Show();
        }
    }
}
