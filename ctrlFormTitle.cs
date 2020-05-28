using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BSP
{
    public partial class ctrlFormTitle : UserControl
    {
        public ctrlFormTitle()
        {
            InitializeComponent();
        }

        [Description("Sets the Form title"), Category("Custom Cat"), DefaultValue("Title")]

        private string _title;
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
                lblTitle.Text = value;
            }
        }
    }
}
