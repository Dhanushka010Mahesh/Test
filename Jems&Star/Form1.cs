using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Jems_Star
{


    public partial class Form1 : Form
    {
        //.................veriable
        int missionComplete;
        int PlayerSpeed;
        int bulletSpeed;
        int badBulletSpeed;
        int badGuysSpeed;
        int backgroundspeed;
        int score;
        int level;
        int deficulty;
        bool pause;
        bool gameIsOver;
        //.................veriable over



        //........................................pic box..........
        PictureBox[] bulet3;
        PictureBox[] badGuys;
        PictureBox[] badBullet;
        PictureBox[] stars;
        //........................................pic box over...........


        //........................................miusic............
        WindowsMediaPlayer backMusic;
        WindowsMediaPlayer bulletSound;
        WindowsMediaPlayer badGuysBoomMusic;
        Random rnd;
        //........................................music over..........
        public Form1()
        {
            InitializeComponent();
        }
        public void startsTimer()
        {
            for (int i = 0; i < stars.Length / 2; i++)
            {
                stars[i].Top += backgroundspeed;
                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = stars[i].Height;
                }

            }
            for (int i = stars.Length / 2; i < stars.Length; i++)
            {
                stars[i].Top += backgroundspeed - 2;
                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = stars[i].Height;
                }

            }
        }

        public void starts()
        {
            for (int i = 0; i < stars.Length; i++)
            {
                stars[i] = new PictureBox();
                stars[i].BorderStyle = BorderStyle.None;
                stars[i].Location = new Point(rnd.Next(20, 1300), rnd.Next(-10, 780));

                if (i % 2 == 1)
                {
                    stars[i].Size = new Size(4, 4);
                    stars[i].BackColor = Color.Wheat;

                }
                else
                {
                    stars[i].Size = new Size(3, 3);
                    stars[i].BackColor = Color.DarkGray;
                }
                this.Controls.Add(stars[i]);
            }
        }

        public void startsBullet()
        {
            //   4 .......
            bulletSound.controls.play();
            //   4 end....
            for (int i = 0; i < bulet3.Length; i++)
            {
                if (bulet3[i].Top > 0)
                {
                    bulet3[i].Visible = true;
                    bulet3[i].Top -= bulletSpeed;
                    collitions();
                }
                else
                {
                    bulet3[i].Visible = false;
                    bulet3[i].Location = new Point(picStratMyAir.Location.X + 20, picStratMyAir.Location.Y - i * 30);
                }
            }
        }

        public void badBulletTimer()
        {
            for (int i = 0; i < (badBullet.Length - deficulty); i++)
            {
                if (badBullet[i].Top < this.Height)
                {
                    badBullet[i].Visible = true;
                    badBullet[i].Top += badBulletSpeed;
                    collislonBadBullet();
                }
                else
                {
                    badBullet[i].Visible = false;
                    int x = rnd.Next(0, 10);
                    badBullet[i].Location = new Point(badGuys[x].Location.X + 20, badGuys[x].Location.Y + 30);
                }
            }
        }
        private void timStratBadBullet_Tick(object sender, EventArgs e)
        {
            badBulletTimer();
        }
        private void timStartBullet_Tick(object sender, EventArgs e)
        {
            startsBullet();


        }
        private void timStartBackground_Tick(object sender, EventArgs e)
        {
            startsTimer();
        }

        private void timStartLeftt_Tick(object sender, EventArgs e)
        {
            if (picStratMyAir.Left > 10)
            {
                picStratMyAir.Left -= PlayerSpeed;
            }
        }

        private void timStartTop_Tick(object sender, EventArgs e)
        {
            if (picStratMyAir.Top > 10)
            {
                picStratMyAir.Top -= PlayerSpeed;
            }
        }

        private void timStartRight_Tick(object sender, EventArgs e)
        {
            if (picStratMyAir.Left < 1200)
            {
                picStratMyAir.Left += PlayerSpeed;
            }
        }

        private void timStartDown_Tick(object sender, EventArgs e)
        {
            if (picStratMyAir.Top < 650)
            {
                picStratMyAir.Top += PlayerSpeed;
            }
        }

        private void moveBadGuys(PictureBox[] array, int speed)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i].Visible = true;
                array[i].Top += speed;

                if (array[i].Top > this.Height)
                {
                    array[i].Location = new Point((i + 1) * 80, -200);

                }


            }
        }

        public void badGuyss()
        {
            //.............path link............          
            Image badguys1 = Image.FromFile("E:/My Project 2023/Game/Jems&Star/Jems&Star/bin/Debug/pic/badGuy1.png");
            Image badguys2 = Image.FromFile("E:/My Project 2023/Game/Jems&Star/Jems&Star/bin/Debug/pic/badGuy2.png");
            Image badguys3 = Image.FromFile("E:/My Project 2023/Game/Jems&Star/Jems&Star/bin/Debug/pic/badGuy3.png");
            Image badguys4 = Image.FromFile("E:/My Project 2023/Game/Jems&Star/Jems&Star/bin/Debug/pic/badGuy4.png");
            Image badguys5 = Image.FromFile("E:/My Project 2023/Game/Jems&Star/Jems&Star/bin/Debug/pic/badGuy5.png");
            //..............path link over........


            badGuys = new PictureBox[14];

            for(int i=0; i<badGuys.Length; i++)
            {
                badGuys[i]=new PictureBox();
                badGuys[i].Size = new Size(60, 60);
                badGuys[i].SizeMode = PictureBoxSizeMode.Zoom;
                badGuys[i].BorderStyle=BorderStyle.None;
                badGuys[i].Visible = false;
                this.Controls.Add(badGuys[i]);
                badGuys[i].Location = new Point((i + 1) * 80, -50);

            }
            badGuys[0].Image = badguys1;
            badGuys[1].Image = badguys2;
            badGuys[2].Image = badguys3;
            badGuys[3].Image = badguys4;
            badGuys[4].Image = badguys5;
            badGuys[5].Image = badguys4;
            badGuys[6].Image = badguys3;
            badGuys[7].Image = badguys2;
            badGuys[8].Image = badguys1;
            badGuys[9].Image = badguys2;
            badGuys[10].Image = badguys3;
            badGuys[11].Image = badguys4;
            badGuys[12].Image = badguys5;
            badGuys[13].Image = badguys1;

        }
        public void myBullet()
        {
            Image bullet3 = Image.FromFile(@"E:/My Project 2023/Game/Jems&Star/Jems&Star/bin/Debug/pic/bulet3.png");

            bulet3 = new PictureBox[3];

            for (int i = 0; i < bulet3.Length; i++)
            {
                bulet3[i] = new PictureBox();
                bulet3[i].Size = new Size(20, 20);
                bulet3[i].Image = bullet3;
                bulet3[i].SizeMode = PictureBoxSizeMode.Zoom;
                bulet3[i].BorderStyle = BorderStyle.None;
                this.Controls.Add(bulet3[i]);
            }
        }

        public void badBullets()
        {
            badBullet = new PictureBox[14];

            for (int i = 0; i < badBullet.Length; i++)
            {
                badBullet[i] = new PictureBox();
                badBullet[i].Size = new Size(8, 16);
                badBullet[i].Visible = false;
                badBullet[i].BackColor = Color.Red;
                int x = rnd.Next(0, 10);
                badBullet[i].Location = new Point(badGuys[i].Location.X, badGuys[i].Location.Y - 20);
                this.Controls.Add(badBullet[i]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //............speed...............
            backgroundspeed = 4;
            badGuysSpeed = 4;
            bulletSpeed = 20;
            badBulletSpeed = 4;
            PlayerSpeed = 4;
            //.............speed over.........


            //.....................music...........
            backMusic = new WindowsMediaPlayer();
            bulletSound = new WindowsMediaPlayer();
            badGuysBoomMusic = new WindowsMediaPlayer();
            //..................music over.................


            
            //.............music link path..................
            backMusic.URL = "E:/HND 1st Semester/week 10/Jems&Star sample/Jems&Star/Jems&Star/bin/Debug/sound/12.m4a";
            bulletSound.URL = "E:/HND 1st Semester/week 10/Jems&Star sample/Jems&Star/Jems&Star/bin/Debug/sound/machgun2.mp3";
            badGuysBoomMusic.URL = "E:/HND 1st Semester/week 10/Jems&Star sample/Jems&Star/Jems&Star/bin/Debug/sound/bullet3.mp3";
            //...............link path.....................

            //..................music controul...........
            backMusic.settings.setMode("loop", true);
            backMusic.settings.volume = 5;
            bulletSound.settings.volume = 3;
            badGuysBoomMusic.settings.volume = 6;
            backMusic.controls.play();
            //,....................music control over.......

            pause = false;
            gameIsOver = false;
            score = 0;
            level = 1;
            deficulty = 9;
            stars = new PictureBox[15];
            rnd = new Random();

            badGuyss();
            myBullet();
            starts();
            badBullets();


        }
        

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!pause)
            {
                if (e.KeyCode == Keys.Right)
                {
                    timStartRight.Start();
                }
                if (e.KeyCode == Keys.Left)
                {
                    timStartLeftt.Start();
                }
                if (e.KeyCode == Keys.Down)
                {
                    timStartDown.Start();
                }
                if (e.KeyCode == Keys.Up)
                {
                    timStartTop.Start();
                }
            }
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            timStartTop.Stop();
            timStartRight.Stop();
            timStartLeftt.Stop();
            timStartDown.Stop();
              
        }

        private void timStratBadGuys_Tick(object sender, EventArgs e)
        {
            moveBadGuys(badGuys, badGuysSpeed);
        }
        
        private void collitions()
        {
            for(int i=0;i<badGuys.Length;i++) 
            {
                if (bulet3[0].Bounds.IntersectsWith(badGuys[i].Bounds) ||
                    bulet3[1].Bounds.IntersectsWith(badGuys[i].Bounds) ||
                    bulet3[2].Bounds.IntersectsWith(badGuys[i].Bounds))
                {
                    badGuysBoomMusic.controls.play();
                    badGuys[i].Location = new Point((i + 1) * 80, -100);
                }
                if (picStratMyAir.Bounds.IntersectsWith(badGuys[i].Bounds))
                {
                    badGuysBoomMusic.settings.volume = 30;
                    badGuysBoomMusic.controls.play();
                    picStratMyAir.Visible = false;
                    gameOve("");
                }
            
            }
        }
        //.........................7...................
        //......................8.......................
        private void gameOve(String str)
        {
            
            lblStartOver.Visible = true;


            backMusic.controls.stop();
            stopTimer();
        }

        private void stopTimer()
        {
            timStartBackground.Stop();
            timStratBadGuys.Stop();
            timStartBullet.Stop();
            timStratBadBullet.Stop();
            timMisson.Stop();
        }
        private void stratTimer()
        {
            timStratBadGuys.Start();
            timStartBullet.Start();
            timStartBackground.Start();
        }

        
        private void collislonBadBullet()
        {
            for(int i = 0;i<badBullet.Length;i++)
            {
                if (badBullet[i].Bounds.IntersectsWith(picStratMyAir.Bounds))
                {
                    badBullet[i].Visible=false;
                    badGuysBoomMusic.settings.volume = 30;
                    badGuysBoomMusic.controls.play();
                    picStratMyAir.Visible = false;
                    gameOve("Game Over");
                }
            }
        }
        //................................8................
        private void label1_Click(object sender, EventArgs e)
        {
            SelectForm menuForm=new SelectForm();
            menuForm.Show();
            this.Close();
            //Environment.Exit(0);
        }

        private void timMisson_Tick(object sender, EventArgs e)
        {
            
            lblMitionTimeValue.Text = missionComplete++.ToString();

            

                TimeCom();
            
        }


        public void TimeCom()
        {
      

            
            if (missionComplete == 5)
            {
            
                this.BackColor = Color.FromArgb(20 , 20, 99);
                backgroundspeed += 3;
                bulletSpeed += 9;
                badGuysSpeed +=4;
               

            }   }
        
    }

}
