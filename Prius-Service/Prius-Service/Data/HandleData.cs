﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Prius_Service.Data
{
    public class HandleData
    {
        private static readonly HandleData instance = new HandleData();

        public List<Item> items = new List<Item>();
        private List<Item> itemsBackUp = new List<Item>();

        private static HandleJson handleJson = new HandleJson();

        public bool InOut { get; private set; }

        public Dictionary<string, int> soldItemsRanking = new Dictionary<string, int>();
        public int costItemsCount;
        public int soldItemsCount;
        public decimal costSum;
        public decimal soldSum;

        private HandleData()
        {

        }

        public static HandleData Instance
        {
            get
            {
                return instance;
            }
        }

        public void SetMalfunctioningBarcodeReader(bool value)
        {
            Settings.Instance.MalfunctioningBarcodeReader = value;
        }
        public void SetInOut(bool value)
        {
            InOut = value;
        }

        public void LoadItems()
        {
            string fileName = "adatok.txt";
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Raktár App", fileName);

            if (File.Exists(filePath))
            {
                StreamReader sr = new StreamReader(filePath);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] splitLine = line.Split(';');
                    Item i = new Item(splitLine[0], splitLine[1], splitLine[2], splitLine[3], Convert.ToInt32(splitLine[4]), Convert.ToInt32(splitLine[5]), Convert.ToInt32(splitLine[6]), Convert.ToInt32(splitLine[7]));
                    items.Add(i);
                }

                sr.Close();
            }
        }
        public void SaveItems()
        {
            string fileName = "adatok.txt";
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Raktár App/Data");
            
            StreamWriter sw;

            if (items.Count != 0)
            {
                try
                {
                    sw = new StreamWriter(Path.Combine(filePath, fileName), false, Encoding.UTF8);
                }
                catch (System.IO.DirectoryNotFoundException)
                {
                    Directory.CreateDirectory(filePath);
                    sw = new StreamWriter(Path.Combine(filePath, fileName));
                }

            
                foreach (var item in items)
                {
                    sw.Write(item.Name + ";" + item.ItemNumber + ";" + item.Manufacturer + ";" + item.Barcode + ";" + item.Quantity + ";" + item.MinQuantity + ";" + item.CostPrice + ";" + item.SellPrice + "\n");
                }

                sw.Close();
            }
        }

        public void ImportFromCsv()
        {
            TemporarySaveProducts();

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Importálás";
                ofd.Filter = "Excel files (*.csv)|*.csv";
                ofd.FilterIndex = 1;
                ofd.RestoreDirectory = true;
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                ofd.CheckPathExists = true;
                ofd.CheckFileExists = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Stream stream;

                    try
                    {
                        stream = File.Open(ofd.FileName, FileMode.Open);
                    }
                    catch (IOException)
                    {
                        throw;
                    }

                    StreamReader sr = new StreamReader(stream, Encoding.UTF8);

                    bool wrongDataFormat = false;
                    int quantity;
                    int minQuantity;
                    int costPrice;
                    int sellPrice;

                    string headerLine = sr.ReadLine();

                    if (!headerLine.Equals("Név;Cikkszám;Márka;Vonalkód;Darabszám;Minimum Darabszám;Beszerzesi Ár;Eladási Ár"))
                    {
                        string[] splitLine = headerLine.Split(';');

                        (quantity, wrongDataFormat) = IntegerFormatChecking(splitLine[4], wrongDataFormat);
                        (minQuantity, wrongDataFormat) = IntegerFormatChecking(splitLine[5], wrongDataFormat);
                        (costPrice, wrongDataFormat) = IntegerFormatChecking(splitLine[6], wrongDataFormat);
                        (sellPrice, wrongDataFormat) = IntegerFormatChecking(splitLine[7], wrongDataFormat);

                        if (wrongDataFormat)
                        {
                            MessageBox.Show(
                                String.Format("A következő sor néhány adata nem a megfelelő formátumban van(nak), ezért üresen kerül(nek) a raktárba\n{0};{1};{2};{3};{4};{5};{6};{7}", splitLine[0], splitLine[1], splitLine[2], splitLine[3], splitLine[4], splitLine[5], splitLine[6], splitLine[7])
                                , "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        items.Clear();

                        Item i = new Item(splitLine[0], splitLine[1], splitLine[2], splitLine[3], quantity, minQuantity, costPrice, sellPrice);
                        items.Add(i);
                    }
                    else
                    {
                        items.Clear();
                    }

                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] splitLine = line.Split(';');

                        (quantity, wrongDataFormat) = IntegerFormatChecking(splitLine[4], wrongDataFormat);
                        (minQuantity, wrongDataFormat) = IntegerFormatChecking(splitLine[5], wrongDataFormat);
                        (costPrice, wrongDataFormat) = IntegerFormatChecking(splitLine[6], wrongDataFormat);
                        (sellPrice, wrongDataFormat) = IntegerFormatChecking(splitLine[7], wrongDataFormat);

                        if (wrongDataFormat)
                        {
                            MessageBox.Show(
                                String.Format("A következő sor néhány adata nem a megfelelő formátumban van(nak), ezért üresen kerül(nek) a raktárba\n{0} ; {1} ; {2} ; {3} ; {4} ; {5} ; {6} ; {7}", splitLine[0], splitLine[1], splitLine[2], splitLine[3], splitLine[4], splitLine[5], splitLine[6], splitLine[7])
                                , "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        Item i = new Item(splitLine[0], splitLine[1], splitLine[2], splitLine[3], quantity, minQuantity, costPrice, sellPrice);
                        items.Add(i);
                    }

                    sr.Close();

                    MessageBox.Show("Sikeres importálás", "Sikeres művelet!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Rossz importálás esetén az alkalmazás bezárásáig még van lehetőséged visszaállítani az előző raktárat!\nEhhez a beállításokban válaszd ki a 'Raktár visszaállítás' menüpontot", "Figyelmeztetés!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Menu.Instance.itemsBackup_ToolStripMenuItem.Enabled = true;

                    DisplayFunctions.Instance.FewItemCountNotification();
                }
            }
        }
        private (int, bool) IntegerFormatChecking(string data, bool dataError)
        {
            int number = 0;

            try
            {
                number = Convert.ToInt32(data);
            }
            catch (FormatException)
            {
                dataError = true;
            }

            return (number, dataError);
        }
        private void TemporarySaveProducts()
        {
            itemsBackUp = items.ConvertAll(i => new Item(i.Name, i.ItemNumber, i.Manufacturer, i.Barcode, i.Quantity, i.MinQuantity, i.CostPrice, i.SellPrice));
        }
        public void RestoreStorage()
        {
            items = itemsBackUp.ConvertAll(i => new Item(i.Name, i.ItemNumber, i.Manufacturer, i.Barcode, i.Quantity, i.MinQuantity, i.CostPrice, i.SellPrice));
            DisplayFunctions.Instance.FewItemCountNotification();
        }
        public void ExportToCsv()
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Exportálás";
                sfd.Filter = "Excel files (*.csv)|*.csv|All files (*.*)|*.*";
                sfd.FilterIndex = 1;
                sfd.RestoreDirectory = true;
                sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                sfd.CheckPathExists = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Stream stream;

                    try
                    {
                        File.Delete(sfd.FileName);
                        stream = File.Open(sfd.FileName, FileMode.OpenOrCreate);
                    }
                    catch (IOException)
                    {
                        throw;
                    }

                    StreamWriter sw = new StreamWriter(stream, Encoding.UTF8);

                    sw.Write("Név;Cikkszám;Márka;Vonalkód;Darabszám;Minimum Darabszám;Beszerzesi Ár;Eladási Ár\n");

                    foreach (var item in items)
                    {
                        sw.Write(item.Name + ";" + item.ItemNumber + ";" + item.Manufacturer + ";" + item.Barcode + ";" + item.Quantity + ";" + item.MinQuantity + ";" + item.CostPrice + ";" + item.SellPrice + "\n");
                    }

                    sw.Close();

                    MessageBox.Show("A csv fájl sikeresen elkészült", "Sikeres művelet!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void StoreToReport(Item ujTermek, int? quantity = null)
        {
            if (quantity != null)
            {
                ReportSupport(ujTermek, quantity.Value);
            }
            //olyan kivitelnél ami meghaladná a raktáron lévő darabokat
            else if (quantity == null)
            {
                ReportSupport(ujTermek, ujTermek.Quantity);
            }
        }
        private void ReportSupport(Item ujTermek, int quantity)
        {
            if (InOut)
            {
                costSum += ujTermek.CostPrice * quantity;
                costItemsCount += quantity;
            }
            else
            {
                soldSum += ujTermek.SellPrice * quantity;
                soldItemsCount += quantity;

                //később egyedi generált azonosítók
                //nincs lekezelve ha nem lenne vonalkódja a terméknek
                if (soldItemsRanking.ContainsKey(ujTermek.Barcode))
                {
                    soldItemsRanking[ujTermek.Barcode] += quantity;
                }
                else
                {
                    soldItemsRanking.Add(ujTermek.Barcode, quantity);
                }
            }
        }

        public void WriteSettingsToJson()
        {
            /*
            Item i = new Item(
                name: "a",
                itemNumber: "a",
                manufacturer: "a",
                barcode: "a",
                quantity: 0,
                minQuantity: 0,
                costPrice: 0,
                sellPrice: 0
                );
            */
            string fileName = "settings.json";
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Raktár App/Settings");

            handleJson.WriteToJson(Settings.Instance, fileName, filePath);
        }
        public void ReadSettingsFromJson()
        {
            string fileName = "settings.json";
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Raktár App/Settings", fileName);

            var settingsJson = handleJson.ReadFromJson(filePath);
            
            if (settingsJson != null)
            {
                try
                {
                    var result = settingsJson.RootElement.GetProperty("MalfunctioningBarcodeReader").GetBoolean();
                    SetMalfunctioningBarcodeReader(result);
                }
                catch (KeyNotFoundException)
                {
                }
                catch (InvalidOperationException)
                {
                }
            }
        }
    }
}
