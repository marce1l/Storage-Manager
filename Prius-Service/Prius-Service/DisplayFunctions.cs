using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prius_Service
{
    public class DisplayFunctions
    {
        private static readonly DisplayFunctions instance = new DisplayFunctions();

        static DisplayFunctions()
        {

        }
        private DisplayFunctions()
        {

        }

        public static DisplayFunctions Instance
        {
            get
            {
                return instance;
            }
        }

        public void Kilistaz(List<Termek> listToBind, DataGridView dataGridView)
        {
            BindingList<Termek> bindingList = new BindingList<Termek>(listToBind);
            var source = new BindingSource(bindingList, null);
            dataGridView.DataSource = source;

            dataGridView.Columns[0].HeaderText = "Név";
            dataGridView.Columns[1].HeaderText = "Cikkszám";
            dataGridView.Columns[2].HeaderText = "Márka";
            dataGridView.Columns[3].HeaderText = "Vonalkód";
            dataGridView.Columns[4].HeaderText = "Darabszám";
            dataGridView.Columns[5].HeaderText = "Minimum Darabszám";
            dataGridView.Columns[6].HeaderText = "Beszerzési Ár";
            dataGridView.Columns[7].HeaderText = "Eladási Ár";

            dataGridView.Columns[4].DefaultCellStyle.Format = "N0";
            dataGridView.Columns[5].DefaultCellStyle.Format = "N0";
            dataGridView.Columns[6].DefaultCellStyle.Format = "N0";
            dataGridView.Columns[7].DefaultCellStyle.Format = "N0";

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView.Rows[0].Height = 30;

            dataGridView.ClearSelection();
        }

        //OmlesztettKilistazas()?

        public void TextColor(RichTextBox rtbx, string text, Color color, Font font)
        {
            int start = rtbx.TextLength;
            rtbx.AppendText(text);
            int end = rtbx.TextLength;

            rtbx.Select(start, end - start);
            rtbx.SelectionColor = color;
            rtbx.SelectionFont = font;

            rtbx.Select(end, 0);
        }

        public void KevesDarabErtesites()
        {
            Menu.Instance.ertesitesek_richTextBox.Text = "";
            foreach (var termek in Data.Instance.termekek)
            {
                if (termek.Darabszam < termek.MinDarabszam)
                {
                    Menu.Instance.ertesitesek_richTextBox.AppendText("A(z) ");
                    TextColor(Menu.Instance.ertesitesek_richTextBox, termek.Nev, SystemColors.ControlText, new Font("Segoe UI", 11, FontStyle.Bold));
                    TextColor(Menu.Instance.ertesitesek_richTextBox, " termékből már csak ", SystemColors.ControlText, new Font("Segoe UI", 11, FontStyle.Regular));
                    TextColor(Menu.Instance.ertesitesek_richTextBox, String.Format("{0}", termek.Darabszam), Color.Red, new Font("Segoe UI", 11, FontStyle.Bold));
                    TextColor(Menu.Instance.ertesitesek_richTextBox, " darab van\n\n", SystemColors.ControlText, new Font("Segoe UI", 11, FontStyle.Regular));
                }
            }
        }
    }
}
