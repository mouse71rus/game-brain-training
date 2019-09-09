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
    public partial class btn_up : UserControl
    {
        public btn_up()
        {
            InitializeComponent();
        }


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = Properties.Resources.up_click;

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = Properties.Resources.up;
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }
        
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            var pt = pictureBox1.Location;//Где произошёл клик
            pt.Offset(e.Location);//Координата относительно всего контрола
                                  //аргумент события
            var mea = new MouseEventArgs(e.Button, e.Clicks, pt.X, pt.Y, e.Delta);
            //Вызываем MouseClick у контрола
            OnMouseClick(mea);
        }
        /*
        /// <summary>
        /// Лучший способ - создать свойство обработчика события click в пользовательском элементе управления. 
        /// Таким образом, каждый раз, когда вы добавляете/удаляете событие click для своего пользовательского элемента управления, 
        /// он автоматически добавляет/удаляет его во все элементы управления в пользовательском элементе управления.
        /// Статья: http://qaru.site/questions/771906/user-control-click-event-not-working-when-clicking-on-text-inside-control
        /// </summary>
        public new event EventHandler Click//можно привязать всем контролам событие клик
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
        }*/
    }
}
