using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace PersonalTask
{
    public enum Difficulty
    {
        Easy = 8,//8 - 4x2 - 726; 457
        Normal = 12,//12 - 4x3 - 726; 627
        Hard = 16,//16 - 4x4 - 726; 797
        OnlyHard = 20//невозможно 20 - 5x4 - 896; 797
    };
    public class MyGame
    {
        #region Поля
        public bool Cancel;
        private bool Error { get; set; }
        public bool IsStatus { get; set; }//1 - запущена // 0 - не запущена
        public Difficulty Difficult { get; set; }
        public Bitmap []Pictures { get; set; }
        public int NowLVL { get; set; }
        private Random rand = new Random(DateTime.Now.Millisecond);
        private PictureBox Clicked;
        private bool[] Enambled;
        private System.Windows.Forms.Timer MainTimer;
        public DateTime Time;
        public TimeSpan BestScore;
        public int Timeout { get; set; }
        /*
        //идея
        bool empty()
        {
            return cnt == 0;
        }*/
        #endregion

        #region Конструкторы
        public MyGame()
        {
            Error = false;
            IsStatus = false;
            Difficult = Difficulty.Easy;
            Timeout = 3000;
            NowLVL = 1;
        }
        public MyGame(Difficulty dif, int Timeout)
        {
            Error = false;
            IsStatus = false;
            Difficult = dif;
            SetTimeout(Timeout);
        }
        #endregion

        #region Функции настройки
        public void SettingSizeScreen(ref Size SizeWindow, ref Size SizePanel)
        {
            switch (Difficult)
            {
                case Difficulty.Easy:
                    {
                        SizeWindow = new Size(726, 457);
                        SizePanel = new Size(680, 350);
                        break;
                    }
                case Difficulty.Normal:
                    {
                        SizeWindow = new Size(726, 627);
                        SizePanel = new Size(680, 520);//SizeWindow.Y(629) - SizeWindow.Y(453) + SizePanel(336)
                        break;
                    }
                case Difficulty.Hard:
                    {
                        SizeWindow = new Size(726, 797);
                        SizePanel = new Size(680, 690);//SizeWindow.Y(792) - SizeWindow.Y(629) + SizePanel(512)
                        break;
                    }
                case Difficulty.OnlyHard:
                    {
                        SizeWindow = new Size(896, 797);
                        SizePanel = new Size(850, 690);//SizeWindow.Y(792) - SizeWindow.Y(453) + SizePanel(336)
                        break;
                    }
                default: break;
            }
        }

        private int GenNumber(bool[]mas)
        {
            bool flag = false;
            int k;
            do
            {
                k = rand.Next((int)Difficult);
                if (mas[k] == true)
                {
                    flag = true;
                    mas[k] = false;
                }
            } while (flag == false);
            return k;
        }

        private string PathLVL; 

        /// <summary>
        /// Генерация различных чисел
        /// </summary>
        /// <param name="n">Число элементов</param>
        /// <param name="a">Левая граница</param>
        /// <param name="b">Правая граница</param>
        /// <param name="mas">Массив, который необходимо обработать</param>
        private void gen_razl(int n, int a, int b, int[] mas)
        {
            int i = 1;
            mas[0] = rand.Next(a, b + 1);
            while (i < n)
            {
                mas[i] = rand.Next(a, b + 1);
                if (razl(mas[i], mas, i))
                    i++;
            }
            return;
        }
        private bool razl(int el, int[] mas, int n)
        {
            for (int i = 0; i < n; i++)
                if (el == mas[i])
                    return false;
            return true;
        }
        private void Exe_Exception()
        {
            if(Error == true)
            {
                MessageBox.Show("Приложение будет закрыто.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
                return;
            }
        }
        public bool IsError()
        {
            return Error;
        }
        private void GetScoreFromFile(string Path)
        {
            StreamReader fp;
            try
            {
                int[] mas = new int[4];
                fp = new StreamReader(Path + "Score" + (int)Difficult + ".txt");
                for (int i = 0; !fp.EndOfStream; i++)
                {
                    mas[i] = Convert.ToInt32(fp.ReadLine());
                }
                BestScore = new TimeSpan(0, mas[0], mas[1], mas[2], mas[3]);
                fp.Close();
            }
            catch
            {
                //ошибка
                BestScore = new TimeSpan(0, 23, 59, 59, 999);
            }
        }
        public void SetLVL(int Now_lvl)
        {
            Cancel = false;
            int ch = -1;
            string Path = Directory.GetCurrentDirectory();
            //обрабатываем массив изображений
            switch(Now_lvl)
            {
                case 0:
                    {
                        Bitmap bm;
                        Pictures = new Bitmap[(int)Difficult];
                        bool[] mas = new bool[(int)Difficult];
                        int[] KolPic = new int[((int)Difficult) / 2];
                        for (int i = 0; i < (int)Difficult; i++)
                        {
                            mas[i] = true;
                        }
                        const int Kol_rez = 10;
                        gen_razl(((int)Difficult) / 2, 1, Kol_rez, KolPic);
                        for (int i = 0, k; i < ((int)Difficult) / 2; i++)
                        {
                            switch(KolPic[i])
                            {
                                case 1:
                                    {
                                        bm = new Bitmap(Properties.Resources.Pic1);
                                        break;
                                    }
                                case 2:
                                    {
                                        bm = new Bitmap(Properties.Resources.Pic2);
                                        break;
                                    }
                                case 3:
                                    {
                                        bm = new Bitmap(Properties.Resources.Pic3);
                                        break;
                                    }
                                case 4:
                                    {
                                        bm = new Bitmap(Properties.Resources.Pic4);
                                        break;
                                    }
                                case 5:
                                    {
                                        bm = new Bitmap(Properties.Resources.Pic5);
                                        break;
                                    }
                                case 6:
                                    {
                                        bm = new Bitmap(Properties.Resources.Pic6);
                                        break;
                                    }
                                case 7:
                                    {
                                        bm = new Bitmap(Properties.Resources.Pic7);
                                        break;
                                    }
                                case 8:
                                    {
                                        bm = new Bitmap(Properties.Resources.Pic8);
                                        break;
                                    }
                                case 9:
                                    {
                                        bm = new Bitmap(Properties.Resources.Pic9);
                                        break;
                                    }
                                case 10:
                                    {
                                        bm = new Bitmap(Properties.Resources.Pic10);
                                        break;
                                    }
                                default: bm = null; break;//иначе орёт, что bm не описана
                            }

                            //генерировать различные числа
                            k = GenNumber(mas);
                            Pictures[k] = bm;

                            k = GenNumber(mas);
                            Pictures[k] = bm;
                        }
                        break;
                    }

                case 1:
                    {
                        string dopPath = @"\LVL\lvl1\";
                        int rez = SettingsStream(Path, ref dopPath, ref ch, Now_lvl);
                        if (rez == 1 || rez == 0)
                        {
                            return;
                        }
                        PathLVL = Path + dopPath;
                        SettingsLVL(ch, PathLVL);
                        #region Comments
                        /*Bitmap bm; //= new Bitmap(Properties.Resources.Pic1);
                        Pictures = new Bitmap[(int)Difficult];
                        bool[] mas = new bool[(int)Difficult];
                        int[] KolPic = new int[((int)Difficult) / 2];
                        for (int i = 0; i < (int)Difficult; i++)
                        {
                            mas[i] = true;
                        }
                        gen_razl(((int)Difficult) / 2, 1, ch, KolPic);
                        for (int i = 0, k; i < ((int)Difficult) / 2; i++) 
                        {
                            string fname = "Pic" + KolPic[i] + ".png";
                            bm = new Bitmap((Path + @"\..\..\LVL\lvl1\" + fname));

                            //генерировать различные числа
                            k = GenNumber(mas);
                            Pictures[k] = bm;

                            k = GenNumber(mas);
                            Pictures[k] = bm;
                        }*/
                        #endregion
                        GetScoreFromFile(PathLVL);
                        break;
                    }
                case 2:
                    {
                        string dopPath = @"\LVL\lvl2\";//ДОБАВИТЬ
                        int rez = SettingsStream(Path, ref dopPath, ref ch, Now_lvl);
                        if (rez == 1 || rez == 0)
                        {
                            return;
                        }
                        PathLVL = Path + dopPath;
                        SettingsLVL(ch, PathLVL);
                        GetScoreFromFile(PathLVL);
                        break;
                    }
                case 3:
                    {
                        string dopPath = @"\LVL\lvl3\";//ДОБАВИТЬ
                        int rez = SettingsStream(Path, ref dopPath, ref ch, Now_lvl);
                        if (rez == 1 || rez == 0)
                        {
                            return;
                        }
                        PathLVL = Path + dopPath;
                        SettingsLVL(ch, PathLVL);
                        GetScoreFromFile(PathLVL);
                        break;
                    }
                case 4:
                    {
                        string dopPath = @"\LVL\lvl4\";//ДОБАВИТЬ
                        int rez = SettingsStream(Path, ref dopPath, ref ch, Now_lvl);
                        if (rez == 1 || rez == 0)
                        {
                            return;
                        }
                        PathLVL = Path + dopPath;
                        SettingsLVL(ch, PathLVL);
                        GetScoreFromFile(PathLVL);
                        break;
                    }
                case 5:
                    {
                        string dopPath = @"\LVL\lvl5\";//ДОБАВИТЬ
                        int rez = SettingsStream(Path, ref dopPath, ref ch, Now_lvl);
                        if (rez == 1 || rez == 0)
                        {
                            return;
                        }
                        PathLVL = Path + dopPath;
                        SettingsLVL(ch, PathLVL);
                        GetScoreFromFile(PathLVL);
                        break;
                    }
                case 6:
                    {
                        string dopPath = @"\LVL\lvl6\";//ДОБАВИТЬ
                        int rez = SettingsStream(Path, ref dopPath, ref ch, Now_lvl);
                        if (rez == 1 || rez == 0)
                        {
                            return;
                        }
                        PathLVL = Path + dopPath;
                        SettingsLVL(ch, PathLVL);
                        GetScoreFromFile(PathLVL);
                        break;
                    }
                case 7:
                    {
                        string dopPath = @"\LVL\lvl7\";//ДОБАВИТЬ
                        int rez = SettingsStream(Path, ref dopPath, ref ch, Now_lvl);
                        if (rez == 1 || rez == 0)
                        {
                            return;
                        }
                        PathLVL = Path + dopPath;
                        SettingsLVL(ch, PathLVL);
                        GetScoreFromFile(PathLVL);
                        break;
                    }
                case -1:
                    {
                        string dopPath = @"\LVL\Customs\";//ДОБАВИТЬ
                        int rez = SettingsStream(Path, ref dopPath, ref ch, Now_lvl);
                        if (rez == 1 || rez == 0)
                        {
                            return;
                        }
                        PathLVL = Path + dopPath;
                        SettingsLVL(ch, PathLVL);
                        GetScoreFromFile(PathLVL);
                        break;
                    }
                default:
                    {
                        Exe_Exception();
                        return;
                    }
            }
            NowLVL = Now_lvl;
        }
        /// <summary>
        ///Настройка уровней
        /// </summary>
        /// <param name="kol">Кол-во картинок</param>
        /// <param name="Path">Путь к папке с уровнем</param>
        private void SettingsLVL(int kol, string Path)
        {
            Bitmap bm;
            Pictures = new Bitmap[(int)Difficult];
            bool[] mas = new bool[(int)Difficult];
            int[] KolPic = new int[((int)Difficult) / 2];
            for (int i = 0; i < (int)Difficult; i++)
            {
                mas[i] = true;
            }
            try
            {
                gen_razl(((int)Difficult) / 2, 1, kol, KolPic);
            
                for (int i = 0, k; i < ((int)Difficult) / 2; i++)
                {
                    string fname = "Pic" + KolPic[i] + ".png";
                    bm = new Bitmap(Path + fname);

                    //генерировать различные числа
                    k = GenNumber(mas);
                    Pictures[k] = bm;

                    k = GenNumber(mas);
                    Pictures[k] = bm;
                }
            }
            catch
            {
                var msgbx = MessageBox.Show("Данные уровня отсутствуют или повреждены.\nОткрыть справку?", "Ошибка!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (msgbx == DialogResult.Yes)
                {
                    Info thisinfo = new Info((int)Information.Level);
                    thisinfo.ShowInTaskbar = false;

                    thisinfo.ShowDialog();
                }
                Cancel = true;
                return;
            }
        }
        /// <summary>
        /// Работа с потоком
        /// </summary>
        /// <param name="Path">Путь к exe файлу</param>
        /// <param name="dopPath">Путь к определенному уровню</param>
        /// <param name="ch">Число картинок</param>
        /// <param name="lvl">Присваиваемый уровень</param>
        /// <returns></returns>
        private int SettingsStream(string Path, ref string dopPath, ref int ch, int lvl)
        {
            StreamReader fp;
            try
            {
                fp = new StreamReader(Path + dopPath + "info.txt");
                ch = Convert.ToInt32(fp.ReadLine());
                fp.Close();
            }
            catch
            {
                try//если запускаем в проекте
                {
                    dopPath = @"\..\.." + dopPath;
                    fp = new StreamReader(Path + dopPath + "info.txt");
                    ch = Convert.ToInt32(fp.ReadLine());
                    fp.Close();

                }
                catch
                {
                    string msg;
                    if (lvl == -1)
                        msg = "Для пользовательского уровня";
                    else
                        msg = "Для уровня " + lvl;

                    MessageBoxButtons msg_btn = MessageBoxButtons.YesNo;

                    var msgb = MessageBox.Show(msg + " отсутствует файл info.txt или данные уровня вовсе отсутствуют.\nЗапустить резервный уровень?", "Ошибка!", msg_btn, MessageBoxIcon.Error);

                    if (msgb == DialogResult.Yes)
                    {
                        SetLVL(0);
                        return 1;
                    }
                    else
                    {
                        var msgbx = MessageBox.Show("Открыть справку?", "Подсказка", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (msgbx == DialogResult.Yes)
                        {
                            Info thisinfo = new Info((int)Information.Level);
                            thisinfo.ShowInTaskbar = false;

                            thisinfo.ShowDialog();
                        }
                        Cancel = true;
                        return 0;
                    }
                }
            }
            if (ch < ((int)Difficult / 2))
            {
                MessageBox.Show("Для запуска уровня недостаточно данных.\n", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cancel = true;
                return 0;
            }
            return 10;
        }
        #endregion

        public void SetTimeout(int T)
        {
            Timeout = T * 1000;
        }

        /// <summary>
        /// ///////////////////////////////////////////////////////
        /// </summary>
        private void EditLabel()
        {
            MainForm.LabelScore[0].Text = "Рекорд: " + TrueFormatScore(BestScore);
        }

        public string TrueFormatScore(TimeSpan spn)
        {
            return String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            spn.Hours, spn.Minutes, spn.Seconds,
            spn.Milliseconds / 10);
        }
        private void ifNewScore(TimeSpan sp)
        {
            if (BestScore > sp)
            {
                BestScore = sp;
                EditLabel();
                StreamWriter fp = new StreamWriter(PathLVL + "Score" + (int)Difficult + ".txt", false);
                fp.WriteLine(BestScore.Hours);
                fp.WriteLine(BestScore.Minutes);
                fp.WriteLine(BestScore.Seconds);
                fp.WriteLine(BestScore.Milliseconds);
                fp.Close();
                MessageBox.Show("Установлен новый рекорд!!!", "Поздравляем!");
            }
        }

        #region Игровой процесс
        public void PicBox_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Image = Pictures[(int)pb.Tag];
            pb.Enabled = false;
            if (Clicked == null)
            {
                Clicked = pb;
            }
            else
            {
                if (Clicked.Image == pb.Image)
                {
                    Enambled[(int)Clicked.Tag] = true;
                    Enambled[(int)pb.Tag] = true;
                    bool isEnd = true;
                    for (int i = 0; i < (int)Difficult; i++)
                    {
                        if (Enambled[i] == false)
                            isEnd = false;
                    }
                    if (isEnd)//если конец
                        GameOver();
                }
                else
                {
                    Thread.Sleep(750);
                    Clicked.Enabled = true;
                    pb.Enabled = true;
                    Clicked.Image = new Bitmap(Properties.Resources.ClosedNew);
                    pb.Image = new Bitmap(Properties.Resources.ClosedNew);
                }
                Clicked = null;
            }
        }

        

        public void Start(ref List<PictureBox> PicBox)
        {
            EditLabel();

            for (int i = 0; i < PicBox.Count(); i++)
            {
                PicBox[i].Image = Pictures[i];
            }
            
            //запуск таймера
            MainTimer = new System.Windows.Forms.Timer();
            MainTimer.Enabled = true;
             MainTimer.Interval = Timeout;
             MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            MainTimer.Start();
            //вот и весь таймер


            IsStatus = true;

            Enambled = new bool[(int)Difficult];
            for (int i = 0; i < (int)Difficult; i++)
            {
                Enambled[i] = false;
            }
            Clicked = null;
        }
        

        private void GameOver()
        {
            DateTime dt = new DateTime();
            dt = DateTime.Now;//получаем текущее время
            TimeSpan span = new TimeSpan();
            span = dt.Subtract(Time);//вычитаем время, чтобы узнать разницу
            ifNewScore(span);//проверяем, а не рекорд ли это

            string sst = TrueFormatScore(span);


            IsStatus = false;
            MessageBox.Show("Уровень пройдет за " + sst);//, "", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            Menu menu = new Menu(NowLVL);
            menu.ShowDialog();
        }

        private void MainTimer_Tick(object sender, EventArgs e)//готова
        {
            for (int i = 0; i < MainForm.PicBox.Count(); i++)
            {
                MainForm.PicBox[i].Image = new Bitmap(Properties.Resources.ClosedNew);
                MainForm.PicBox[i].Enabled = true;
            }
            Time = DateTime.Now;
            MainTimer.Enabled = false;
        }
        #endregion
    }
}
