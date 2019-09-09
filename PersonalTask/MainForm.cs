using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace PersonalTask
{

    public partial class MainForm : Form
    {
        #region Var
        public static MyGame Game;
        public static List<PictureBox> PicBox = new List<PictureBox>();
        public static List<Label> LabelScore = new List<Label>();//мог сделать статичным сам label, но так было проще(настраивать расположение элемента удобнее)

        private FlowLayoutPanel GamePanel;
        private PictureBox pictureBox1;
        Random rand = new Random(DateTime.Now.Millisecond);
        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Game = new MyGame((Difficulty)Properties.Settings.Default.Difficult, Properties.Settings.Default.TimeoutInSeconds);
            Int(Game.Difficult);
            LabelScore.Add(lbScore);
        }
        
        private void Int(Difficulty diff)//готова
        {
            GamePanel = new FlowLayoutPanel();

            for (int i = 0; i < (int)diff; i++)
            {
                pictureBox1 = new PictureBox();
                pictureBox1.BackColor = Color.White;
                pictureBox1.Margin = new Padding(10);
                pictureBox1.Name = "pictureBox" + i;
                pictureBox1.Size = new Size(150, 150);
                pictureBox1.TabIndex = i;
                pictureBox1.Tag = i;
                pictureBox1.TabStop = false;
                pictureBox1.Click += new System.EventHandler(Game.PicBox_Click);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Cursor = Cursors.Hand;
                pictureBox1.Enabled = false;
                //добавляем картинку
                //pictureBox1.Image = Game.Pictures[i];
                pictureBox1.Image = new Bitmap(Properties.Resources.ClosedNew);//лучше сразу закрытый

                pictureBox1.BorderStyle = BorderStyle.Fixed3D;

                PicBox.Add(pictureBox1);
            }
         
            GamePanel.SuspendLayout();
            for (int i = 0; i < (int)diff; i++)
            {
                ((ISupportInitialize)(PicBox[i])).BeginInit();
            }
            SuspendLayout();
            // 
            // GamePanel
            // 
            GamePanel.Anchor = ((AnchorStyles)((((
            AnchorStyles.Top 
            | AnchorStyles.Bottom)
            | AnchorStyles.Left)
            | AnchorStyles.Right)));

            GamePanel.BackColor = SystemColors.Control;
            for (int i = 0; i < (int)diff; i++)
            {
                GamePanel.Controls.Add(PicBox[i]);
            }
            
            GamePanel.Location = new System.Drawing.Point(19, 59);
            GamePanel.Margin = new Padding(10, 50, 10, 10);
            GamePanel.Name = "GamePanel";
            GamePanel.BackColor = Color.Transparent;

            Size SizePanel = new System.Drawing.Size();
            Size SizeForm = new System.Drawing.Size();

            Game.SettingSizeScreen(ref SizeForm, ref SizePanel);


            GamePanel.Size = SizePanel;
            this.Size = SizeForm;


            Controls.Add(GamePanel);

            GamePanel.ResumeLayout(false);
            for (int i = 0; i < (int)diff; i++)
            {
                ((ISupportInitialize)(PicBox[i])).EndInit();
            }
           
            ResumeLayout(false);

            //Ровняем форму по центру экрана
            Size st = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = new Point((st.Width - this.Size.Width) / 2, (st.Height - this.Size.Height) / 2);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Menu ThisMenu = new Menu(true);
            ThisMenu.ShowInTaskbar = false;

            ThisMenu.ShowDialog();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            Menu ThisMenu = new Menu();
            ThisMenu.ShowInTaskbar = false;

            ThisMenu.ShowDialog();
        }

        /*Comments | событие изменения переменной
        class MyClass
        {
            public delegate void MyEventHandler(string message); //сигнатура обработчика, который можно привязать к событию.
            public event MyEventHandler SomeEvent = delegate { }; //собственно событие.
            int prop;
            public int MyProp
            {
                get
                {
                    return prop;
                }
                set
                {
                    prop = value;
                    if (prop == 10)
                    {
                        SomeEvent("переменная = 10"); //тут мы генерируем событие
                    }

                }
            }
        }

        void Maikn(string[] args)
        {
            MyClass obj = new MyClass();
            obj.SomeEvent += x => Console.WriteLine(x);//тут подписались
            obj.MyProp = 10;//тут меняем свойство и событие генерируется
        }*/
    }
}
