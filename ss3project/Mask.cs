using System;
using System.Collections.Generic;
using System.Text;
using OpenCvSharp;

namespace StartOpenCV
{
    class Mask : IDisposable
    {
        IplImage maskimg;

        //세가지 필터로 선명화 시키기
        public IplImage SunMyung1(IplImage gray)
        {
            double[,] _b = new double[,]{ {0.0f/5.0f, -1.0f/5.0f, 0.0f/5.0f},
                                          {-1.0f/5.0f, 9.0f/5.0f, -1.0f/5.0f},
                                          {0.0f/5.0f, -1.0f/5.0f, 0.0f/5.0f} };

            using (CvMat b = CvMat.FromArray(_b))
            using (IplImage temp = new IplImage(gray.Size, BitDepth.U8, 1))
            {
                Cv.Filter2D(gray, temp, b, new CvPoint(-1, -1));
                maskimg = temp.Clone();
            }
            return maskimg;
        }

        public IplImage SunMyung2(IplImage gray)
        {
            double[,] _b = new double[,]{ {0, -1, 0},
                                          {-1, 5, -1},
                                          {0, -1, 0} };

            using (CvMat b = CvMat.FromArray(_b))
            using (IplImage temp = new IplImage(gray.Size, BitDepth.U8, 1))
            {
                Cv.Filter2D(gray, temp, b, new CvPoint(-1, -1));
                maskimg = temp.Clone();

            }
            return maskimg;

        }

        public IplImage SunMyung3(IplImage gray)
        {
            double[,] _b = new double[,]{ {-1, -1, -1},
                                          {-1, 9, -1},
                                          {-1, -1, -1} };

            using (CvMat b = CvMat.FromArray(_b))
            using (IplImage temp = new IplImage(gray.Size, BitDepth.U8, 1))
            {
                Cv.Filter2D(gray, temp, b, new CvPoint(-1, -1));
                maskimg = temp.Clone();


            }
            return maskimg;

        }

        //수직 엣지 찾기

        public IplImage V_Edge(IplImage src) //그레이 변환된 이미지
        {
            double[,] _b = new double[,]{ {-1, 0, 1},
                                                        {-1, 0, 1},
                                                        {-1, 0, 1} };


            using (CvMat b = CvMat.FromArray(_b))

            using (IplImage temp = new IplImage(src.Size, BitDepth.U8, 1))
            {

                Cv.Filter2D(src, temp, b, new CvPoint(-1, -1));
                Cv.Threshold(temp, temp, 80, 255, ThresholdType.BinaryInv); //이진화

                maskimg = temp.Clone();


            }
            return maskimg;
        }



        //수평 엣지 찾기

        public IplImage H_Edge(IplImage src)
        {
            double[,] _b = new double[,]{ {1, 1, 1},
                                                        {0, 0, 0},
                                                        {-1, -1, -1} };


            using (CvMat b = CvMat.FromArray(_b))



            using (IplImage temp = new IplImage(src.Size, BitDepth.U8, 1))
            {

                Cv.Filter2D(src, temp, b, new CvPoint(-1, -1));
                Cv.Threshold(temp, temp, 80, 255, ThresholdType.BinaryInv);

                maskimg = temp.Clone();


            }
            return maskimg;
        }



        public void Dispose()
        {
            if (maskimg != null) Cv.ReleaseImage(maskimg);
        }
    }
}
