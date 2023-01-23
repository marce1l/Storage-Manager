using System;
using System.Windows.Forms;
using Prius_Service.Data;

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
            FormatString(costItemsCountData_label, HandleData.Instance.costItemsCount, " db");
            FormatString(soldItemsCountData_label, HandleData.Instance.soldItemsCount, " db");
            //legjobbTermekData_label.Text = ;

            FormatString(costItemsData_label, HandleData.Instance.costSum, " Ft");
            FormatString(soldItemsData_label, HandleData.Instance.soldSum, " Ft");
            FormatString(profitData_label, (HandleData.Instance.soldSum - HandleData.Instance.costSum), " Ft");
            
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
