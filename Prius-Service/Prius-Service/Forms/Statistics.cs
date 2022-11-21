using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prius_Service
{
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            DisplayReport();
        }
        
        private void DisplayReport()
        {
            FormatString(costItemsCountData_label, Data.Instance.costItemsCount, " db");
            FormatString(soldItemsCountData_label, Data.Instance.soldItemsCount, " db");
            //legjobbTermekData_label.Text = ;

            FormatString(costItemsData_label, Data.Instance.costSum, " Ft");
            FormatString(soldItemsData_label, Data.Instance.soldSum, " Ft");
            FormatString(profitData_label, (Data.Instance.soldSum - Data.Instance.costSum), " Ft");
            
        }
        private void FormatString(Label label, decimal number, string extension)
        {
            string formatString = number.ToString("N0");
            label.Text = formatString + extension;
        }

        private void SaveReport()
        {

        }
        private void LoadReport()
        {

        }
    }
}
