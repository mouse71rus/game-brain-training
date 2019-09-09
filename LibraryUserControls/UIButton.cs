using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryUserControls
{
    public partial class UIButton : UserControl
    {
        public UIButton()
        {
            InitializeComponent();
        }

        public string btnName
        {
            get
            {
                return Caption.Text;
            }
            set
            {
                Caption.Text = value;
            }
        }
    }
}
