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
    public partial class btn_GetInfoAboutit : UserControl
    {
        public btn_GetInfoAboutit()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Лучший способ - создать свойство обработчика события click в пользовательском элементе управления. 
        /// Таким образом, каждый раз, когда вы добавляете/удаляете событие click для своего пользовательского элемента управления, 
        /// он автоматически добавляет/удаляет его во все элементы управления в пользовательском элементе управления.
        /// Статья: http://qaru.site/questions/771906/user-control-click-event-not-working-when-clicking-on-text-inside-control
        /// </summary>
        public new event EventHandler Click
        {
            add
            {
                base.Click += value;
                foreach (Control control in Controls)
                {
                    control.Click += value;
                }
            }
            remove
            {
                base.Click -= value;
                foreach (Control control in Controls)
                {
                    control.Click -= value;
                }
            }
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.Get_Info;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.Image = Properties.Resources.Get_Info_Canvas;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox2.Image = Properties.Resources.Get_Info;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox2.Image = Properties.Resources.Get_Info_Click;
        }
    }
}
