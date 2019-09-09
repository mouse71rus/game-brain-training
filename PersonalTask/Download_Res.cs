using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PersonalTask
{
    public partial class Download_Res : Form
    {
        public Download_Res()
        {
            InitializeComponent();
            textBox1.Text = link;
        }
        string link = "https://yadi.sk/d/ohNbYymg3YVgRf";
        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(textBox1.Text);
            MessageBox.Show("Ссылка скопирована в буфер обмена.");
            this.Close();
        }
    }
}
