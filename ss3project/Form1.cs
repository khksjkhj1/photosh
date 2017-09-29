using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Data;
using System.Drawing.Imaging;
using System.IO;

namespace WindowsFormsApplication6
{
    public partial class Form1 : System.Windows.Forms.Form
    {

        private bool line;       // 현재 그려지는 도형 선택
        private bool rect;      // 현재 그려지는 도형 선택
        private bool circle;   // 현재 그려지는 도형 선택
        private Point start;    //시작점
        private Point finish;   //끝점
        private Pen pen;
        private int nline;  // 현재 저장된 선 개수
        private int nrect;  // 현재 저장된 사각형 개수
        private int ncircle;// 현재 저장된 원 개수
        private int i;
        private int thick;
        private bool isSolid;
        private MyLines[] mylines;
        private MyRect[] myrect;
        private MyCircle[] mycircle;

        
        public Form1()
        {
            

            InitializeComponent();

            SetupVar();

            ////
            


            Bitmap image1 = new Bitmap("temp.jpg");
                panel1.Size = image1.Size;
                panel1.BackgroundImage = image1;

            this.AutoSize = true;
            ////





        }
        private void SetupVar()
        {
            i = 0;
            thick = 1;
            isSolid = true;
            line = true;
            rect = false;
            circle = false;
            start = new Point(0, 0);
            finish = new Point(0, 0);
            pen = new Pen(Color.Black);
            mylines = new MyLines[100];
            myrect = new MyRect[100];
            mycircle = new MyCircle[100];
            nline = 0;
            nrect = 0;
            ncircle = 0;
            lineButton.Pushed = true;
            line0Button.Pushed = false;
            line1Button.Pushed = true;
            line2Button.Pushed = false;
            line3Button.Pushed = false;
         

            SetupMine();//저장클래스 초기화
        }

        private void SetupMine()
        {
            for (i = 0; i < 100; i++)
                mylines[i] = new MyLines();
            for (i = 0; i < 100; i++)
                myrect[i] = new MyRect();
            for (i = 0; i < 100; i++)
                mycircle[i] = new MyCircle();
        }

        private void toolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            if(e.Button == newButton)  // 새로 만들기 눌렀으면
            {
                this.lineButton.Pushed = false;
                this.rectButton.Pushed = false;
                this.circleButton.Pushed = false;

                SetupVar();
                panel1.Refresh();
            }
            if (e.Button == lineButton)  // 선그리기 눌렀으면
            {
                line = true;
                rect = false;
                circle = false;

                this.lineButton.Pushed = true;
                this.rectButton.Pushed = false;
                this.circleButton.Pushed = false;
                
            }
            if (e.Button == rectButton)  // 사각형 눌렀으면
            {
                line = false;
                rect = true;
                circle = false;

                this.lineButton.Pushed = false;
                this.rectButton.Pushed = true;
                this.circleButton.Pushed = false;

            }
            if (e.Button == circleButton)  // 원그리기 눌렀으면
            {
                line = false;
                rect = false;
                circle = true;

                this.lineButton.Pushed = false;
                this.rectButton.Pushed = false;
                this.circleButton.Pushed = true;

            }
            if(e.Button == line0Button)
            {
                isSolid = false;
                thick = 1;

                this.line0Button.Pushed = true;
                this.line1Button.Pushed = false;
                this.line2Button.Pushed = false;
                this.line3Button.Pushed = false;
              
            }
            if (e.Button == line1Button)
            {
                isSolid = true;
                thick = 1;

                this.line0Button.Pushed = false;
                this.line1Button.Pushed = true;
                this.line2Button.Pushed = false;
                this.line3Button.Pushed = false;

            }
            if (e.Button == line2Button)
            {
                isSolid = true;
                thick = 3;

                this.line0Button.Pushed = false;
                this.line1Button.Pushed = false;
                this.line2Button.Pushed = true;
                this.line3Button.Pushed = false;

            }
            if (e.Button == line3Button)
            {
                isSolid = true;
                thick = 5;

                this.line0Button.Pushed = false;
                this.line1Button.Pushed = false;
                this.line2Button.Pushed = false;
                this.line3Button.Pushed = true;

            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            start.X = e.X;
            start.Y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((start.X == 0) && (start.Y == 0)) // ?
                return;
            finish.X = e.X;
            finish.Y = e.Y;

            if (line == true)
                mylines[nline].setPoint(start, finish, thick, isSolid);
            if (rect == true)
                myrect[nrect].setRect(start, finish, thick, isSolid);
            if (circle == true)
                mycircle[ncircle].setRectC(start, finish, thick, isSolid);

            panel1.Invalidate(true); // ?
            panel1.Update();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (line == true)
                nline++;
            if (rect == true)
                nrect++;
            if (circle == true)
                ncircle++;

            start.X = 0;
            start.Y = 0;
            finish.X = 0;
            finish.Y = 0;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; // 안티얼라이어싱 적용

            for(i = 0; i<= nline; i++)  //  선그리기
            {
                if(!mylines[i].getSolid()) // 점선이면
                {
                    pen.Width = 1;
                    pen.DashStyle = DashStyle.Dot;
                }
                else              // 실선이면
                {
                    pen.Width = mylines[i].getThick();
                    pen.DashStyle = DashStyle.Solid;

                }

                e.Graphics.DrawLine(pen, mylines[i].getPoint1(), mylines[i].getPoint2());
            }

            for (i = 0; i <= nrect; i++)  //  사각형그리기
            {
                if (!myrect[i].getSolid()) // 점선이면
                {
                    pen.Width = 1;
                    pen.DashStyle = DashStyle.Dot;
                }
                else              // 실선이면
                {
                    pen.Width = myrect[i].getThick();
                    pen.DashStyle = DashStyle.Solid;

                }

                e.Graphics.DrawRectangle(pen, myrect[i].getRect());
            }

            for (i = 0; i <= ncircle; i++)  //  사각형그리기
            {
                if (!mycircle[i].getSolid()) // 점선이면
                {
                    pen.Width = 1;
                    pen.DashStyle = DashStyle.Dot;
                }
                else              // 실선이면
                {
                    pen.Width = mycircle[i].getThick();
                    pen.DashStyle = DashStyle.Solid;

                }

                e.Graphics.DrawEllipse(pen, mycircle[i].getRectC());
            }

            pen.Width = thick;
            pen.DashStyle = DashStyle.Solid;
        }

        private void 불러오기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void 저장하기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savFile = new SaveFileDialog();
            Bitmap bitmap = new Bitmap(this.panel1.DisplayRectangle.Width, this.panel1.DisplayRectangle.Height);    // Bitmap 객체 생성
            Graphics g = Graphics.FromImage(bitmap);                                    // bitmap 객체를 그래픽스로
            g.CopyFromScreen(PointToScreen(new Point(this.panel1.Location.X, this.panel1.Location.Y)), new Point(0, 0), panel1.Size);
            //PointToScreen를 써서 콘트롤의 화면상 실제 좌표을 얻어냄
            savFile.Filter = "BMP|*.bmp";

           // if (savFile.ShowDialog() == DialogResult.OK)
           // {
                // 파일 확장자에 따라 포맷 실제저장코드
                switch (savFile.FilterIndex)
                {
                    case 1:
                        bitmap.Save("temp1.jpg", System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    default:
                        MessageBox.Show("파일 확장자에 문제가 있습니다");
                        ; break;
                }
          //  }
            g.Dispose();
            savFile.Dispose();
            this.DialogResult = DialogResult.OK;

          
            this.Close();
         
        }
        }
}
