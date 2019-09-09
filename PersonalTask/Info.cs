using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using LibraryUserControls;

namespace PersonalTask
{
    public enum Information
    {
        About,
        GameRules,
        MainWindowGame,
        Menu,
        Settings,
        Level,
        UserLevel,
        Score
    };
    public partial class Info : Form
    {

        #region Text
        private string Text0 = 
            "О программе:\n" +
            "\nПрограмма написана на языке C#" + 
            "\nАвтор: Студент 2 курса, ф-та МФиИ, гр.120861, Жимерин Сергей Андреевич" +
            "\nПроектная работа по ООП." +
            "\n\nИгра предназначена для тренировки зрительной памяти.";//О программе
        private string Text1 = 
            "Правила игры:\n" +
            "\nПроцесс игры: \nПосле начала игры Игроку на 3 секунды будут показаны 8, 12, 16 или 20 картинок(в зависимости от уровня сложности), каждые 2 из которых одинаковые. " +
            "\nПо прошествию 3 секунд все изображения будут закрыты контейнерами. Игрок должен поочерёдно выбрать 2 контейнера, при нажатии на каждый, изображение будет открываться, если Игрок выбрал одинаковые изображения, они останутся открытыми, иначе оба закроются." + 
            "\nНеобходимо: Верно выбрать все одинаковые изображения за наименьшее кол-во времени." +
            "" +
            "" +
            "" +
            "" +
            "\n\nПримечание: Уровень сложности можно поменять в настройках игры." +
            "";//Правила игры
        private string Text2 =
            "Главное окно игры:\n" +
            "\nГлавное окно игры представляет собой область приложения, разделенное на 2 неравные части:" +
            "\n\t 1) Область игры(занимает почти всё пространство). В этой области размещаются контейнеры с картинками" +
            "\n\t 2) \"Техническая полоса.\" Занимает малую часть, на ней размещается информация о рекорде, а также кнопка Меню." +
            "";//Главное окно игры
        private string Text3 =
            "Меню:\n" +
            "\nПо середине окна располагается выбор уровня, есть возможность выбрать встроенные в игру 7 уровней, а также пользовательский." +
            "\n\nВ верхнем правом углу располагается кнопка выхода, в нижнем – кнопка закрыть, если окно было вызвано во время игры." +
            "\n\nВ левом нижнем углу располагаются 2 кнопки: Настройки и Справка";//Меню
        private string Text4 =
            "Настройки:\n" +
            "\nВ настройках Вы можете выбрать сложность игры." +
            "\nВнимание: Минимальное кол-во изображений для каждого уровня: \n" +
            String.Format("\n{0,20}   {1,30}  \n", "Сложность", "Мин. кол-во изображений") +
            String.Format("\n{0,20}   {1,32}  ", "Легко", "4") +
            String.Format("\n{0,20}   {1,25}  ", "Нормально", "6") +
            String.Format("\n{0,20}   {1,29}  ", "Сложно", "8") +
            String.Format("\n{0,20}   {1,22}  ", "Невозможно", "10") +
            "\n\nПри увеличении сложности, кол-во контейнеров будет увеличиваться на 4 штуки." +
            "" +
            "\nТакже Вы можете изменить время показа картинок, прежде чем они будут закрыты контейнерами." +
            "" +
            "" +
            "" +
            "";//Настройки
        private string Text5 =
            "Уровни:\n" +
            "\nДанные о уровне хранятся в отдельных файлах рядом с *.exe файлом игры." +
            "\nКаждый уровень лежит в папке LVL, сами файлы уровня лежат в соответствующей папке lvl<x>, где <x> - номер каждого уровня, начиная с единицы. Пропускать числа нельзя." +
            "\nСама папка с данными уровня состоит из:" +
            "\n\t   1) 1ого обязательного файла info.txt, в нём хранится информация о кол-ве изображений для конкретного уровня" +
            "\n\t   2) 4х необязательных(они могут отсутствовать) файлов (Score8, Score12, Score16, Score20).txt" +
            "\n\t   3) Сами изображения, каждое изображение имеет строгий формат(1х1) и разрешение(256х256), а также название: Pic<x>.png, где <x> - номер каждого изображения, начиная с единицы. Пропускать числа нельзя." +
            "\n\nТаким образом, если *.exe файл игры находится по пути: D:\\Game, то файлы уровня должны лежать в папке D:\\Game\\LVL." +
            "\nСоответственно полный путь к первому изображению для 4 уровня следующий: D:\\Game\\LVL\\lvl4\\Pic1.png" +
            "" +
            "" +
            "" +
            //"";//Уровни
            "\nТакже Вы можете скачать все файлы уровней, нажав на              кнопку справа."; 
        private string Text6 =
            "Пользовательские уровни:\n" +
            "\nДанные о пользовательском уровне также хранятся в отдельных файлах рядом с *.exe файлом игры." +
            "\nНаходится он по пути: <Папка с *.exe файлом>\\LVL\\Customs." +
            "\nСама папка с данными уровня, также как и для обычных, состоит из:" +
            "\n\t   1) 1ого обязательного файла info.txt, в нём хранится информация о кол-ве изображений для конкретного уровня" +
            "\n\t   2) 4х необязательных(они могут отсутствовать) файлов (Score8, Score12, Score16, Score20).txt" +
            "\n\t   3) Сами изображения, каждое изображение имеет строгий формат(1х1) и разрешение(256х256), а также название: Pic<x>.png, где <x> - номер каждого изображения, начиная с единицы. Пропускать числа нельзя." +
            "\n\nТаким образом, если *.exe файл игры находится по пути: D:\\Game, то файлы уровня должны лежать в папке D:\\Game\\LVL." +
            "\n\nСоответственно полный путь к первому изображению для пользовательского уровня следующий: D:\\Game\\LVL\\Customs\\Pic1.png" +
            "" +
            "" +
            "";//Пользовательские уровни
        private string Text7 =
            "Рекорд:\n" +
            "\nИдёт загрузка... Пожалуйста подождите" +
            "" +
            "";//Рекорд

        private List<string> mText = new List<string>();

        #endregion
        private bool Devolop = true;//перед релизом поставить false
        Thread thread2;
        
        public Info()
        {
            InitializeComponent();
            LoadInfoText();
        }
        /// <summary>
        /// При загрузке будем загружать соответствущий модуль справки:
        /// Information.{param} 
        /// </summary>
        /// <param name="Number"></param>
        public Info(int Number)
        {
            InitializeComponent();

            LoadInfoText();
            MainLabel.Text = mText[Number];
            Caption.Text = "Справка · " + InfoPanel.Controls["info" + Number].Text;

            if (Number == (int)Information.Score)
            {
                btn_Downlands.Visible = false;
                MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
                //if (ScoreList == null)//т.к. список уже был инициализирован, нельзя было обойтись простой проверкой
                //GetAllScore();
                try
                {
                    string t = ScoreList[0];//создаем локальную переменную для простой проверки на ошибку: выход за границу диапазона
                    LoadScore_LVL(1);
                    Selec_LVL.Visible = true;
                    //вообще, при инициализации формы такая сложная проверка не нужна, т.к. можно точно утверждать, что до этого данные о рекорде не загружались
                }
                catch
                {
                    thread2 = new Thread(GetAllScore);
                    thread2.Start();
                    //GetAllScore();
                }
                //для проверки работы данного кода в функции GetAllScore() закоментирована первая строка с MessageBox
                //LoadScore_LVL(1);
            }
            else
            {
                MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
                Selec_LVL.Visible = false;
                if (Number == (int)Information.Level)
                    btn_Downlands.Visible = true;
                else
                {
                    btn_Downlands.Visible = false;
                }
            }
        }

        private void LoadInfoText()
        {
            //при загрузке будем присваивать строчки с текстом
            mText.Add(Text0);
            mText.Add(Text1);
            mText.Add(Text2);
            mText.Add(Text3);
            mText.Add(Text4);
            mText.Add(Text5);
            mText.Add(Text6);
            mText.Add(Text7);
        }





        private void lbinfo_Click(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            MainLabel.Text = mText[Convert.ToInt32(lb.Tag)];
            Caption.Text = "Справка · " + lb.Text;

            if (Convert.ToInt32(lb.Tag) == (int)Information.Score)
            {
                btn_Downlands.Visible = false;
                MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
                //if (ScoreList == null)//т.к. список уже был инициализирован, нельзя было обойтись простой проверкой
                //GetAllScore();
                try
                {
                    string t = ScoreList[0];//создаем локальную переменную для простой проверки на ошибку: выход за границу диапазона
                    LoadScore_LVL(1);
                    Selec_LVL.Visible = true;
                }
                catch
                {
                    thread2 = new Thread(GetAllScore);
                    thread2.Start();
                    //GetAllScore();
                }
                //для проверки работы данного кода в функции GetAllScore() закоментирована первая строка с MessageBox
                //
            }
            else
            {
                MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
                Selec_LVL.Visible = false;
                if (Convert.ToInt32(lb.Tag) == (int)Information.Level)
                    btn_Downlands.Visible = true;
                else
                {
                    btn_Downlands.Visible = false;
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Downlands_Click(object sender, EventArgs e)
        {
            Download_Res dwn = new Download_Res();
            dwn.ShowInTaskbar = false;
            dwn.ShowDialog();
            //MessageBox.Show("Ссылка не добавлена.");
        }



        #region Модуль: Рекорд
        private string ScoreTitle;
        private List<string> ScoreList = new List<string>();

        private string GetDiflvl(int s)
        {
            switch (s)
            {
                case 0:
                    {
                        return "Легко";
                    }
                case 1:
                    {
                        return "Нормально";
                    }
                case 2:
                    {
                        return "Сложно";
                    }
                case 3:
                    {
                        return "Невозможно";
                    }
                default:
                    return "";
            }
        }


        private void GetAllScore()
        {
            //MessageBox.Show("Загрузка данных будет выполнена один раз", "Тест");//Для теста
            string Path = Directory.GetCurrentDirectory();
            string dopPath = @"\LVL\lvl";

            if (Devolop)//отключи перед релизом
            {
                dopPath = @"\..\.." + dopPath;
            }

            string[] n = { "\\Score8.txt", "\\Score12.txt", "\\Score16.txt", "\\Score20.txt" };
            StreamReader fp;
            ScoreTitle = String.Format("{0,7}   {1,10}   {2,15} ", "Уровень", "Сложность", "Время");
            for (int i = 1; i < 8; i++)
            {
                string Tt = "";
                for (int j = 0; j < 4; j++)
                {

                    try
                    {
                        fp = new StreamReader(Path + dopPath + i + n[j]);
                        try
                        {
                            int[] mas = new int[4];
                            for (int k = 0; !fp.EndOfStream; k++)
                            {
                                mas[k] = Convert.ToInt32(fp.ReadLine());
                            }
                            TimeSpan Score = new TimeSpan(0, mas[0], mas[1], mas[2], mas[3]);
                            //Tt += "\nСложность: " + GetDiflvl(j) + "    ·    Время: " + MainForm.Game.TrueFormatScore(Score);
                            switch (j)
                            {
                                case 0:
                                    {
                                        Tt += String.Format("\n{0,7:N0} {1,20} {2, 28}", i, GetDiflvl(j), MainForm.Game.TrueFormatScore(Score));
                                        break;
                                    }
                                case 1:
                                    {
                                        Tt += String.Format("\n{0,7:N0} {1,21} {2, 20}", i, GetDiflvl(j), MainForm.Game.TrueFormatScore(Score));
                                        break;
                                    }
                                case 2:
                                    {
                                        Tt += String.Format("\n{0,7:N0} {1,20} {2, 25}", i, GetDiflvl(j), MainForm.Game.TrueFormatScore(Score));
                                        break;
                                    }
                                case 3:
                                    {
                                        Tt += String.Format("\n{0,7:N0} {1,20} {2, 19}", i, GetDiflvl(j), MainForm.Game.TrueFormatScore(Score));
                                        break;
                                    }
                                default:
                                    break;
                            }
                            //Tt += "\nСложность: " + GetDiflvl(j) + "    ·    Время: " + mas[0] + ":" + mas[1] + ":" + mas[2] + "." + mas[3];
                        }
                        catch
                        {
                            continue;
                        }
                        fp.Close();
                    }
                    catch
                    {
                        continue;
                    }
                }
                ScoreList.Add(Tt);
            }
            this.Invoke((MethodInvoker)delegate () { Selec_LVL.Visible = true; LoadScore_LVL(1); thread2.Abort(); });
        }


        private void LoadScore_LVL(int ScoreLVL)
        {
            MainLabel.Text = ScoreTitle + ScoreList[ScoreLVL - 1];
        }

        public int Selected_Value
        {
            get
            {
                return Convert.ToInt32(SelectedLVL.Text);
            }
            set
            {
                SelectedLVL.Text = value.ToString();
            }
        }
        public int MinValue { get; set; } = 1;
        public int MaxValue { get; set; } = 7;

        private void btn_up1_Click(object sender, EventArgs e)
        {
            if (Selected_Value >= MaxValue)
            {
                return;
            }
            else
            {
                Selected_Value++;
                LoadScore_LVL(Selected_Value);
            }
        }
        private void btn_down1_Click(object sender, EventArgs e)
        {
            if (Selected_Value <= MinValue)
            {
                return;
            }
            else
            {
                Selected_Value--;
                LoadScore_LVL(Selected_Value);
            }
        }


        #endregion

        private void Info_Shown(object sender, EventArgs e)
        {
            Size st = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = new Point((st.Width - this.Size.Width) / 2, (st.Height - this.Size.Height) / 2);
        }
    }
}
