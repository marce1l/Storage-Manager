using System;
using System.Collections.Generic;
using System.Text;

namespace Prius_Service.Data
{
    public class Settings
    {
        private static readonly Settings instance = new Settings();
        private Settings()
        {

        }
        public static Settings Instance
        {
            get
            {
                return instance;
            }
        }

        private bool malfunctioningBarcodeReader;

        public bool MalfunctioningBarcodeReader { get => malfunctioningBarcodeReader; set => malfunctioningBarcodeReader = value; }

        
    }
}
