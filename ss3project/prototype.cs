using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OpenCvSharp;



namespace ss3project
{
    public partial class prototype : Form
    {
        IplImage src, dst;
        int cnt = 0;

        public prototype()
        {
            InitializeComponent();

        }

        private void loadImage(String filename)
        {
            src = new IplImage(filename, LoadMode.AnyColor);

            pictureBoxIpl1.ImageIpl = src;

           

        }

        //프로그램이 종료시 처리할 내용
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (src != null) Cv.ReleaseImage(src); 
            if (dst != null) Cv.ReleaseImage(dst); //메모리 해제

        }
        
        //픽쳐박스를 클릭 했을 경우 새로 창을 띄워 큰 그림으로 보여준다
        private void pictureBoxIpl1_Click_1(object sender, EventArgs e)
        {
            if (pictureBoxIpl1.ImageIpl == null) return;

            using (CvWindow wind = new CvWindow("원본그림"))
            {
                wind.Image = src;
                Cv.WaitKey(0);
            }
        }
         
        private void pictureBoxIpl2_Click(object sender, EventArgs e)
        {
            if (pictureBoxIpl2.ImageIpl == null) return;

            using (CvWindow wind = new CvWindow("결과창"))
            {
                wind.Image = dst;
                Cv.WaitKey(0);
            }

        }

        
        //수정할 부분. 테스트용
        private void openButton_Click(object sender, EventArgs e)
        {
            //  openFileDialog1.InitialDirectory = "c:\\";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                loadImage(openFileDialog1.FileName);
            }
            else
            {
                return;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

           
               // dst.SaveImage("q000.jpg", new JpegEncodingParam(0)); //저 품질
              
              //  dst.SaveImage("q050.jpg", new JpegEncodingParam(50));
               
                dst.SaveImage("q100.jpg", new JpegEncodingParam(100)); //고품질


               

        }

    private void saveasButton_Click(object sender, EventArgs e)
        {

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fname = saveFileDialog1.FileName;

                dst.SaveImage(fname, new JpegEncodingParam(100));
            }
        }



        private void 그레이ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (src == null) return;
            dst = new IplImage(src.Size, BitDepth.U8, 1);
            Cv.CvtColor(src, dst, ColorConversion.BgrToGray);
            pictureBoxIpl2.ImageIpl = dst;
        }

        private void 회전ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (src == null) return;

            mydlg md = new mydlg(this);

            md.Show();
                     
        }
        public void rotate(double inputangle)
        {
            

            dst = Cv.CreateImage(src.Size, BitDepth.U8, 3);
            double angle = inputangle; // 시계 반대
            double scale = 1.0;

            CvPoint2D32f centralPoint = new CvPoint2D32f(src.Width / 2, src.Height / 2);           // 회전 기준점 설정

            CvMat rotationMatrix = Cv.CreateMat(2, 3, MatrixType.F32C1);
            Cv._2DRotationMatrix(centralPoint, angle, scale, out rotationMatrix); // 회전 기준 행렬

            Cv.WarpAffine(src, dst, rotationMatrix, Interpolation.Linear | Interpolation.FillOutliers, CvScalar.ScalarAll(0));

            pictureBoxIpl2.ImageIpl = dst;

            Cv.ReleaseMat(rotationMatrix);
        }

        private void 사이즈ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (src == null) return;
            mydlg2 md = new mydlg2(this);

            md.Show();
           
            
        }
        public void resize(double inputsize)
        {
            CvSize size = new CvSize((int)(src.Width * inputsize), (int)(src.Height * inputsize)); // 임의로 두배

            dst = new IplImage(size, src.Depth, src.NChannels);

            Cv.Resize(src, dst, Interpolation.Cubic);

            pictureBoxIpl2.ImageIpl = dst;
        }


        private void 이진화ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (src == null) return;
            dst = new IplImage(src.Size, BitDepth.U8, 1);
            Cv.CvtColor(src, dst, ColorConversion.BgrToGray);

            Cv.Smooth(dst, dst, SmoothType.Gaussian, 5); //스무스 주기
            Cv.Threshold(dst, dst, 150, 255, ThresholdType.Binary); //120은 기준이 될 임계치  (임의)

            pictureBoxIpl2.ImageIpl = dst;
        }

        private void 캐니엣지ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (src == null) return;
            dst = new IplImage(src.Size, BitDepth.U8, 1);//메모리 확보
            Cv.CvtColor(src, dst, ColorConversion.BgrToGray); //그레이로 변환

            Cv.Canny(dst, dst, 80, 255);
            pictureBoxIpl2.ImageIpl = dst;
        }

        private void 소벨엣지ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (src == null) return;
            dst = new IplImage(src.Size, BitDepth.U8, 1);//메모리 확보
            Cv.CvtColor(src, dst, ColorConversion.BgrToGray); //그레이로 변환

            Cv.Sobel(dst, dst, 1, 0, ApertureSize.Size3);
            pictureBoxIpl2.ImageIpl = dst;
        }

        private void 라플라스엣지ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (src == null) return;
            dst = new IplImage(src.Size, BitDepth.U8, 1);//메모리 확보
            IplImage temp = new IplImage(src.Size, BitDepth.S16, 1);
            IplImage graytemp = new IplImage(src.Size, BitDepth.U8, 1);

            Cv.CvtColor(src, graytemp, ColorConversion.BgrToGray); //그레이로 변환

            Cv.Laplace(graytemp, temp);
            Cv.ConvertScaleAbs(temp, dst);
            pictureBoxIpl2.ImageIpl = dst;

        }

      

        private void 선명히ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double[,] _b = new double[,]{ {0, -1, 0},
                                          {-1, 5, -1},
                                          {0, -1, 0} };

            CvMat b = CvMat.FromArray(_b);
            dst = new IplImage(src.Size, BitDepth.U8, 3);

            Cv.Filter2D(src, dst, b, new CvPoint(-1, -1));

            pictureBoxIpl2.ImageIpl = dst;
        }

        private void 부드럽게ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double[,] _b = new double[,]{ {1.0f/9.0f, 1.0f/9.0f, 1.0f/9.0f},
                                          {1.0f/9.0f, 1.0f/9.0f, 1.0f/9.0f},
                                          {1.0f/9.0f, 1.0f/9.0f, 1.0f/9.0f} };

            CvMat b = CvMat.FromArray(_b);
            dst = new IplImage(src.Size, BitDepth.U8, 3);

            Cv.Filter2D(src, dst, b, new CvPoint(-1, -1));

            pictureBoxIpl2.ImageIpl = dst;
        }

        private void 엠보싱ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double[,] _b = new double[,]{ {-3, -1, 0},
                                          {-1, 1, 1},
                                          {0, 1, 3} };

            CvMat b = CvMat.FromArray(_b);
            dst = new IplImage(src.Size, BitDepth.U8, 3);

            Cv.Filter2D(src, dst, b, new CvPoint(-1, -1));

            pictureBoxIpl2.ImageIpl = dst;
        }

        private void 세피아ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IplImage img = src.Clone();

                // (1) 픽셀 데이타(R,G,B)를 차례차례 취득해, 변경한다
                // 저속이지만 간단한 방법

            for (int y = 0; y < img.Height; y++)
            {
                for (int x = 0; x < img.Width; x++)
                {
                    CvColor c = img[y, x];
                    img[y, x] = new CvColor
                    {
                        B = (byte)Math.Round(c.B * 0.7 + 0*0.3f),
                        G = (byte)Math.Round(c.G * 0.7 + 62*0.3f),
                        R = (byte)Math.Round(c.R * 0.7 + 133*0.3f),
                    };
                }
            }
            dst = img;
            pictureBoxIpl2.ImageIpl = dst;

        }

        private void 아쿠아ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IplImage img = src.Clone();

            // (1) 픽셀 데이타(R,G,B)를 차례차례 취득해, 변경한다
            // 저속이지만 간단한 방법

            for (int y = 0; y < img.Height; y++)
            {
                for (int x = 0; x < img.Width; x++)
                {
                    CvColor c = img[y, x];
                    img[y, x] = new CvColor
                    {
                        B = (byte)Math.Round(c.B * 0.8 + 145 * 0.3f),
                        G = (byte)Math.Round(c.G * 0.8 + 75 * 0.3f),
                        R = (byte)Math.Round(c.R * 0.8 + 20 * 0.3f),
                    };
                }
            }
            dst = img;
            pictureBoxIpl2.ImageIpl = dst;
        }

       

        private void 얼굴검출ToolStripMenuItem_Click(object sender, EventArgs e)
        {


            CvColor[] colors = new CvColor[]{
                new CvColor(0,0,255),
                new CvColor(0,128,255),
                new CvColor(0,255,255),
                new CvColor(0,255,0),
                new CvColor(255,128,0),
                new CvColor(255,255,0),
                new CvColor(255,0,0),
                new CvColor(255,0,255),
            };

            const double scale = 1.04;
            const double scaleFactor = 1.139;
            const int minNeighbors = 2;

            using (IplImage img = src.Clone())
            using (IplImage smallImg = new IplImage(new CvSize(Cv.Round(img.Width / scale), Cv.Round(img.Height / scale)), BitDepth.U8, 1))
            {
                // 얼굴 검출용의 화상의 생성
                using (IplImage gray = new IplImage(img.Size, BitDepth.U8, 1))
                {
                    Cv.CvtColor(img, gray, ColorConversion.BgrToGray);
                    Cv.Resize(gray, smallImg, Interpolation.Linear);
                    Cv.EqualizeHist(smallImg, smallImg);
                }

                //using (CvHaarClassifierCascade cascade = Cv.Load<CvHaarClassifierCascade>(Const.XmlHaarcascade))  // 아무거나 가능

                using (CvHaarClassifierCascade cascade = CvHaarClassifierCascade.FromFile(Application.StartupPath + "\\" + "haarcascade_frontalface_alt.xml"))                      // 
                using (CvMemStorage storage = new CvMemStorage())
                {
                    storage.Clear();

                    // 얼굴의 검출

                    CvSeq<CvAvgComp> faces = Cv.HaarDetectObjects(smallImg, cascade, storage, scaleFactor, minNeighbors, 0, new CvSize(30, 30), new CvSize(180, 180));

                    // 검출한 얼굴에 원을 그린다
                    for (int i = 0; i < faces.Total; i++)
                    {
                        CvRect r = faces[i].Value.Rect;
                        CvPoint center = new CvPoint
                        {
                            X = Cv.Round((r.X + r.Width * 0.5) * scale),
                            Y = Cv.Round((r.Y + r.Height * 0.5) * scale)
                        };
                        int radius = Cv.Round((r.Width + r.Height) * 0.25 * scale);
                        img.Circle(center, radius, colors[i % 8], 3, LineType.AntiAlias, 0);
                    }
                }
                dst = img.Clone();
                pictureBoxIpl2.ImageIpl = dst;
            }
        }

  

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 밝기변환ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (src == null) return;

            mydlg3 md = new mydlg3(this);

            md.Show();
        }
 public void bright(int inputbright)
        {
            dst = new IplImage(src.Size, BitDepth.U8, 3);


            Cv.AddS(src, new CvScalar(inputbright, inputbright, inputbright), dst);



            pictureBoxIpl2.ImageIpl = dst;
        }

        private void 색상검출ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (src == null) return;
            
           

            mydlg4 md = new mydlg4(this);

            md.Show();
        }

        private void 그림판ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            

            src.SaveImage("temp.jpg", new JpegEncodingParam(100));
            

            WindowsFormsApplication6.Form1 form = new WindowsFormsApplication6.Form1();
            

            DialogResult dResult = form.ShowDialog();
            if(dResult==DialogResult.OK)
            {

                dst = new IplImage("temp1.jpg", LoadMode.AnyColor);

                pictureBoxIpl2.ImageIpl = dst;
            }

           
            ///

        }

        public void selectHSVColorange(int Hmin, int Hmax)
        {

            
            dst = new IplImage(src.Size, BitDepth.U8, 3);
            IplImage h = new IplImage(src.Size, BitDepth.U8, 1);
            IplImage s = new IplImage(src.Size, BitDepth.U8, 1);
            IplImage v = new IplImage(src.Size, BitDepth.U8, 1);


            Cv.CvtColor(src, dst, ColorConversion.BgrToHsv);
            Cv.Split(dst, h, s, v, null);
            Cv.InRangeS(h, Hmin, Hmax, h);
            dst.SetZero();
            Cv.Copy(src, dst, h);

            pictureBoxIpl2.ImageIpl = dst;
        }
        


    }
}
