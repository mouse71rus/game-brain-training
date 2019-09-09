using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
namespace PersonalTask
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        bool FirstOpening = false;
        public Menu(bool FirstOpening)
        {
            InitializeComponent();
            this.FirstOpening = FirstOpening;
        }

        public Menu(int NowLvL)
        {
            InitializeComponent();
            buttonBack.Visible = false;
            HideLVL = NowLvL;
        }

        private int HideLVL;
        private void SelectedLVL_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            MainForm.Game.SetLVL(Convert.ToInt32(btn.Tag));
            if (MainForm.Game.Cancel)
                return;
            MainForm.Game.Start(ref MainForm.PicBox);
            this.Close();
        }

        /*
        Thread thread2;
         * thread2 = new Thread(potok2);
            thread2.Start();
         */

        private void Menu_Load(object sender, EventArgs e)
        {

            switch(HideLVL)
            {
                case 0://если был запущен резервный уровень
                    {
                        break;
                    }
                case -1://если был запущен пользовательский уровень
                    {
                        LVL_Custom.Enabled = false;
                        break;
                    }
                default://если был запущен любой уровень
                    {
                        this.Controls["LVL" + HideLVL].Enabled = false;
                        break;
                    }
            }
        }


        #region Выход
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void buttonExit_MouseDown(object sender, MouseEventArgs e)
        {
            buttonExit.Image = Properties.Resources.btn_exit_Click;
        }

        private void buttonExit_MouseUp(object sender, MouseEventArgs e)
        {
            buttonExit.Image = Properties.Resources.btn_exit;
        }

        private void buttonExit_MouseMove(object sender, MouseEventArgs e)
        {
            buttonExit.Image = Properties.Resources.btn_exit_Canvas;
        }

        private void buttonExit_MouseLeave(object sender, EventArgs e)
        {
            buttonExit.Image = Properties.Resources.btn_exit;
        }
        #endregion

        #region Назад
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


        #region Настройки
        private void pb_Settings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowInTaskbar = false;

            settings.ShowDialog();
        }

        private void pb_Settings_MouseDown(object sender, MouseEventArgs e)
        {
            pb_Settings.Image = Properties.Resources.btn_settings_Click;
        }

        private void pb_Settings_MouseUp(object sender, MouseEventArgs e)
        {
            pb_Settings.Image = Properties.Resources.btn_settings;
        }

        private void pb_Settings_MouseMove(object sender, MouseEventArgs e)
        {
            pb_Settings.Image = Properties.Resources.btn_settings_Canvas;
        }

        private void pb_Settings_MouseLeave(object sender, EventArgs e)
        {
            pb_Settings.Image = Properties.Resources.btn_settings;
        }
        #endregion



        #region Справка
        private void btnInfo_Click(object sender, EventArgs e)
        {
            Info ThisInfo = new Info();
            ThisInfo.ShowInTaskbar = false;

            ThisInfo.ShowDialog();
        }

        private void btnInfo_MouseDown(object sender, MouseEventArgs e)
        {
            btnInfo.Image = Properties.Resources.btn_info_Click;
        }

        private void btnInfo_MouseUp(object sender, MouseEventArgs e)
        {
            btnInfo.Image = Properties.Resources.btn_info;
        }

        private void btnInfo_MouseMove(object sender, MouseEventArgs e)
        {
            btnInfo.Image = Properties.Resources.btn_info_Canvas;
        }

        private void btnInfo_MouseLeave(object sender, EventArgs e)
        {
            btnInfo.Image = Properties.Resources.btn_info;
        }
        #endregion



        #region Рекорд
        private void pb_Score_Click(object sender, EventArgs e)
        {
            Info ThisInfo = new Info((int)Information.Score);
            ThisInfo.ShowInTaskbar = false;

            ThisInfo.ShowDialog();
        }

        private void pb_Score_MouseDown(object sender, MouseEventArgs e)
        {
            pb_Score.Image = Properties.Resources.btn_Score_Click;
        }

        private void pb_Score_MouseUp(object sender, MouseEventArgs e)
        {
            pb_Score.Image = Properties.Resources.btn_Score;
        }

        private void pb_Score_MouseMove(object sender, MouseEventArgs e)
        {
            pb_Score.Image = Properties.Resources.btn_Score_Canvas;
        }

        private void pb_Score_MouseLeave(object sender, EventArgs e)
        {
            pb_Score.Image = Properties.Resources.btn_Score;
        }




        #endregion

        private void Menu_Shown(object sender, EventArgs e)
        {
            if (FirstOpening)
            {
                //Ровняем форму по центру экрана
                Size st = Screen.PrimaryScreen.WorkingArea.Size;
                this.Location = new Point((st.Width - this.Size.Width) / 2, (st.Height - this.Size.Height) / 2);
                buttonBack.Visible = false;
                if (Properties.Settings.Default.FirstRunning)
                {
                    Properties.Settings.Default.FirstRunning = false;
                    Properties.Settings.Default.Save();
                    var first = MessageBox.Show("Здравствуй! Впервые играешь? Тогда для тебя подготовлена справка! \nОткрыть?", "Добро пожаловать в мою игру!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (first == DialogResult.Yes)
                    {

                        Info FirstInfo = new Info((int)Information.GameRules);
                        FirstInfo.ShowInTaskbar = false;

                        FirstInfo.Show();
                    }
                }
            }
        }
    }
}
