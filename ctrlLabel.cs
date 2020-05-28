using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Globalization;
using System.Windows;
using System.Windows.Forms;

namespace BSP
{
    class ctrlLabel : System.Windows.Forms.Label
    {
        private string sText = "";
        private double dValue = 0;

        public string FormatText
        {
            get
            {
                return sText;
            }
            set
            {
                try
                {
                    dValue = Convert.ToDouble(value);
                    sText = dValue.ToString("N2", CultureInfo.InvariantCulture);
                    this.Text = sText;
                }
                catch
                {
                    this.Text = "0.00";
                }
            }
        }



    }
}
