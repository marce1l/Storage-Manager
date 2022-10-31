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
