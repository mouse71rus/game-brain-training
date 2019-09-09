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
    public partial class lbl_SelectedLVL : UserControl
    {
        public lbl_SelectedLVL()
        {
            InitializeComponent();
        }


        public override string Text//Готово
        {
            get
            {
                return M_label.Text;
            }
            set
            {
                M_label.Text = value;
            }
        }

        public int Selected_Value
        {
            get
            {
                return Convert.ToInt32(M_label.Text);
            }
            set
            {
                M_label.Text = value.ToString();
            }
        }
        public int MinValue { get; set; } = 1;
        public int MaxValue { get; set; } = 100;


        public override Font Font
        {
            set
            {
                M_label.Font = value;
            }
        }


    }
}
