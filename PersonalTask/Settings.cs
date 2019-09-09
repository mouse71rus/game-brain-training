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
    public partial class Settings : Form
    {
        private int Num = new Int32();
        private int NumSec = new Int32();

        public Settings()
        {
            InitializeComponent();
            Num = Properties.Settings.Default.Difficult.GetHashCode();
            NumSec = Properties.Settings.Default.TimeoutInSeconds;
            SelectionRadioButton(Num);
            SelectionTimeout(NumSec);
            DifficultyPanel.Controls["pb_" + Num].BackColor = Color.Lime;
        }

        private void SetDifficult()
        {
            switch(Num)
            {
                case 8:
                    {
                        Properties.Settings.Default.Difficult = Difficulty.Easy;
                        break;
                    }
                case 12:
                    {
                        Properties.Settings.Default.Difficult = Difficulty.Normal;
                        break;
                    }
                case 16:
                    {
                        Properties.Settings.Default.Difficult = Difficulty.Hard;
                        break;
                    }
                case 20:
                    {
                        Properties.Settings.Default.Difficult = Difficulty.OnlyHard;
                        break;
                    }
                default:
                    break;
            }
            Properties.Settings.Default.Save();
            Application.Restart();
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.TimeoutInSeconds != NumSec)
            {
                Properties.Settings.Default.TimeoutInSeconds = NumSec;
                Properties.Settings.Default.Save();
                MainForm.Game.SetTimeout(Properties.Settings.Default.TimeoutInSeconds);
            }
            if ((int)Properties.Settings.Default.Difficult != Num)
            {
                MessageBox.Show("Приложение будет перезапущено.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetDifficult();
            }
            this.Close();
        }   

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectionRadioButton(int n)
        {
            switch (n)
            {
                case 8:
                    {
                        rb_Easy.Checked = true;
                        break;
                    }
                case 12:
                    {
                        rb_Normal.Checked = true;
                        break;
                    }
                case 16:
                    {
                        rb_Hard.Checked = true;
                        break;
                    }
                case 20:
                    {
                        rb_OnlyHard.Checked = true;
                        break;
                    }
                default:
                    break;
            }
        }

        private void SelectionTimeout(int n)
        {
            switch (n)
            {
                case 3:
                    {
                        Timeout3.Checked = true;
                        break;
                    }
                case 5:
                    {
                        Timeout5.Checked = true;
                        break;
                    }
                case 7:
                    {
                        Timeout7.Checked = true;
                        break;
                    }
                case 10:
                    {
                        Timeout10.Checked = true;
                        break;
                    }
                default:
                    break;
            }
        }


        private void Timeout_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            NumSec = Convert.ToInt32(rb.Tag);
        }

        private void EditDifficulty(object sender, EventArgs e)
        {
            PictureBox obj = (PictureBox)sender;
            if (Convert.ToInt32(obj.Tag) == Num)//если была выбрана та же самая сложность 
                return;
            obj.BackColor = Color.Lime;
            DifficultyPanel.Controls["pb_" + Num].BackColor = Color.Transparent;
            Num = Convert.ToInt32(obj.Tag);
            SelectionRadioButton(Num);
        }

        private void EditDifficulty_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton obj = (RadioButton)sender;
            if (Convert.ToInt32(obj.Tag) == Num)//если была выбрана та же самая сложность 
                return;
            DifficultyPanel.Controls["pb_" + Convert.ToInt32(obj.Tag)].BackColor = Color.Lime;
            DifficultyPanel.Controls["pb_" + Num].BackColor = Color.Transparent;
            Num = Convert.ToInt32(obj.Tag);
        }

        private void btn_GetInfoAboutit1_Click(object sender, EventArgs e)
        {
            Info info = new Info((int)Information.Settings);
            info.ShowInTaskbar = false;

            info.ShowDialog();
        }
    }
}