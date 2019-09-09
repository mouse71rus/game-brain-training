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
    public partial class UISelectedLevel : UserControl
    {
        public UISelectedLevel()
        {
            InitializeComponent();
        }

        /*public string YourText//Готово
        {
            get
            {
                return Caption0.Text;
            }
            set
            {
                Caption0.Text = value;
            }
        }*/

        public int Selected_Value
        {
            get
            {
                return Convert.ToInt32(SelectedValue.Text);
            }
            set
            {
                SelectedValue.Text = value.ToString();
            }
        }
        public int MinValue { get; set; } = 1;
        public int MaxValue { get; set; } = 100;


        public override Font Font
        {
            set
            {
                SelectedValue.Font = value;
            }
        }

        private void btn_Up_Click(object sender, EventArgs e)
        {
            if (Selected_Value == MaxValue)
            {
                return;
            }
            else
            {
                Selected_Value++;
            }
        }

        private void btn_Down_Click(object sender, EventArgs e)
        {
            if (Selected_Value == MinValue)
            {
                return;
            }
            else
            {
                Selected_Value--;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = Properties.Resources.up_click;

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = Properties.Resources.up;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox2.Image = Properties.Resources.Down_click;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox2.Image = Properties.Resources.Down;
        }
    }
}
