using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Prius_Service
{
    public class Data
    {
        private static readonly Data instance = new Data();

        public List<Termek> termekek = new List<Termek>();
        public List<Termek> termekekBackUp = new List<Termek>();
        public bool rosszVonalkodOlvaso { get; private set; }
        public bool beKi;
        //To use with future money tracking
        public int toke;

        private Data()
        {

        }

        public static Data Instance
        {
            get
            {
                return instance;
            }
        }

        public void SetRosszVonlkodOlvaso(bool value)
        {
            rosszVonalkodOlvaso = value;
        }
        public void SetBeKi(bool value)
        {
            beKi = value;
        }

        public void AdatBetoltes()
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
        public void AdatMentes()
        {
            string name = "adatok.txt";
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Raktár App", name);

            StreamWriter sw;

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
        public void ImportFromCsv()
        {
            TemporarySaveProducts();
            termekek.Clear();

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel files (*.csv)|*.csv";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;
            ofd.InitialDirectory = @"C:\Desktop";
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

                bool hibasAdat = false;
                int darabszam;
                int minDarabszam;
                int beszerzesiAr;
                int eladasiAr;

                string headerSor = sr.ReadLine();

                if (!headerSor.Equals("Név;Cikkszám;Márka;Vonalkód;Darabszám;Minimum Darabszám;Beszerzesi Ár;Eladási Ár"))
                {
                    string[] bontottSor = headerSor.Split(';');

                    (darabszam, hibasAdat) = IntegerFormatChecking(bontottSor[4], hibasAdat);
                    (minDarabszam, hibasAdat) = IntegerFormatChecking(bontottSor[5], hibasAdat);
                    (beszerzesiAr, hibasAdat) = IntegerFormatChecking(bontottSor[6], hibasAdat);
                    (eladasiAr, hibasAdat) = IntegerFormatChecking(bontottSor[7], hibasAdat);

                    if (hibasAdat)
                    {
                        MessageBox.Show(
                            String.Format("A következő sor néhány adata nem a megfelelő formátumban van(nak), ezért üresen kerül(nek) a raktárba\n{0};{1};{2};{3};{4};{5};{6};{7}", bontottSor[0], bontottSor[1], bontottSor[2], bontottSor[3], bontottSor[4], bontottSor[5], bontottSor[6], bontottSor[7])
                            , "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    Termek t = new Termek(bontottSor[0], bontottSor[1], bontottSor[2], bontottSor[3], darabszam, minDarabszam, beszerzesiAr, eladasiAr);
                    termekek.Add(t);
                    
                }

                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    string[] bontottSor = sor.Split(';');

                    (darabszam, hibasAdat) = IntegerFormatChecking(bontottSor[4], hibasAdat);
                    (minDarabszam, hibasAdat) = IntegerFormatChecking(bontottSor[5], hibasAdat);
                    (beszerzesiAr, hibasAdat) = IntegerFormatChecking(bontottSor[6], hibasAdat);
                    (eladasiAr, hibasAdat) = IntegerFormatChecking(bontottSor[7], hibasAdat);

                    if (hibasAdat)
                    {
                        MessageBox.Show(
                            String.Format("A következő sor néhány adata nem a megfelelő formátumban van(nak), ezért üresen kerül(nek) a raktárba\n{0} ; {1} ; {2} ; {3} ; {4} ; {5} ; {6} ; {7}", bontottSor[0], bontottSor[1], bontottSor[2], bontottSor[3], bontottSor[4], bontottSor[5], bontottSor[6], bontottSor[7])
                            , "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    Termek t = new Termek(bontottSor[0], bontottSor[1], bontottSor[2], bontottSor[3], darabszam, minDarabszam, beszerzesiAr, eladasiAr);
                    termekek.Add(t);
                }

                sr.Close();

                MessageBox.Show("Sikeres importálás", "Sikeres művelet!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Rossz importálás esetén az alkalmazás bezárásáig még van lehetőséged visszaállítani az előző raktárat!\nEhhez a beállításokban válaszd ki a 'Raktár visszaállítás' menüpontot", "Figyelmeztetés!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Menu.Instance.raktarVissza_ToolStripMenuItem.Enabled = true;
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
            termekekBackUp = termekek.ConvertAll(t => new Termek(t.Nev, t.Cikkszam, t.Marka, t.Vonalkod, t.Darabszam, t.MinDarabszam, t.BeszerzesiAr, t.EladasiAr));
        }
        public void RaktarVisszaalitas()
        {
            termekek = termekekBackUp.ConvertAll(t => new Termek(t.Nev, t.Cikkszam, t.Marka, t.Vonalkod, t.Darabszam, t.MinDarabszam, t.BeszerzesiAr, t.EladasiAr));
        }
        public void ExportToCsv()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel files (*.csv)|*.csv|All files (*.*)|*.*";
            sfd.FilterIndex = 1;
            sfd.RestoreDirectory = true;
            sfd.InitialDirectory = @"C:\Desktop";
            sfd.CheckPathExists = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Stream stream;

                try
                {
                    stream = File.Open(sfd.FileName, FileMode.OpenOrCreate);
                }
                catch (IOException)
                {
                    throw;
                }
                
                StreamWriter sw = new StreamWriter(stream, Encoding.UTF8);

                sw.Write("Név;Cikkszám;Márka;Vonalkód;Darabszám;Minimum Darabszám;Beszerzesi Ár;Eladási Ár\n");

                foreach (var termek in termekek)
                {
                    sw.Write(termek.Nev + ";" + termek.Cikkszam + ";" + termek.Marka + ";" + termek.Vonalkod + ";" + termek.Darabszam + ";" + termek.MinDarabszam + ";" + termek.BeszerzesiAr + ";" + termek.EladasiAr + "\n");
                }

                sw.Close();

                MessageBox.Show("A csv fájl sikeresen elkészült", "Sikeres művelet!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
