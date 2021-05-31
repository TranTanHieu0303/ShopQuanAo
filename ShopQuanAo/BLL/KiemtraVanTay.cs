using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using ShopQuanAo.DAL;
namespace ShopQuanAo
{
    public class KiemtraVanTay
    {
        QLShopDataContext data = new QLShopDataContext();
        public static ArrayList MaskGaborCollection = new ArrayList();
        public static int maskNumber = 32;
        public static int widthSquare = 4;//
        private XLhinhanh_Vantay image1;
        private XLhinhanh_Vantay image2;
        private int[,] image2Data;
        private double[,] directMatrix1;
        private bool isFirst1 = true;
        private int width1, height1;
        private int width2, height2;
        private bool isFirst2 = true;
        private ArrayList minus1 = new ArrayList();
        private ArrayList minus2 = new ArrayList();
        private Minutiae minuResult;
        private int[,] image1Data;
        private double[,] directMatrix2;
        public static int m = 50;
        public static int v = 300;
        public static int threshold = 0;
        public static int f = 7;
        public static int fi = 3;
        private int left1 = 50;
        private int top1 = 20;
        private int right1 = 50;
        private int bottom1 = 20;
        private int left2 = 50;
        private int top2 = 20;
        private int right2 = 50;
        private int bottom2 = 20;
        private int angleLimit = 5;
        private int distanceLimit = 5;
        private int minuNumberLimit = 14;
        public bool ktVantay(string _manv, string _hinh)
        {
            string hinh = data.VANTAYs.FirstOrDefault(vt=>vt.MANV==_manv).VANTAY1.ToString();
            image1 = new XLhinhanh_Vantay(Application.StartupPath + "\\Resources\\"+hinh, widthSquare);
            directMatrix1 = image1.Direct;
            width1 = image1.Width;
            height1 = image1.Height;
            minus1.Clear();
            isFirst1 = true;
            image1Data = new int[image1.Width, image1.Height];
            for (int i = 0; i < image1.Width; i++)
                for (int j = 0; j < image1.Height; j++)
                    image1Data[i, j] = image1.Image[i, j];
            image2 = new XLhinhanh_Vantay(_hinh, widthSquare);
            directMatrix2 = image2.Direct;
            width2 = image2.Width;
            height2 = image2.Height;
            isFirst2 = true;
            minus2.Clear();
            image2Data = new int[width2, height2];
            for (int i = 0; i < image2.Width; i++)
                for (int j = 0; j < image2.Height; j++)
                    image2Data[i, j] = image2.Image[i, j];

            try
            {
                int i, j;
                if (!isFirst1)
                {
                    int[,] input1 = new int[width1, height1];
                    for (i = 0; i < width1; i++)
                        for (j = 0; j < height1; j++)
                            input1[i, j] = image1Data[i, j];

                    image1.SetImage(input1, width1, height1, widthSquare);
                }
                if (!isFirst2)
                {
                    int[,] input2 = new int[width2, height2];
                    for (i = 0; i < width2; i++)
                        for (j = 0; j < height2; j++)
                            input2[i, j] = image2Data[i, j];
                    image2.SetImage(input2, width2, height2, widthSquare);
                }

                #region prepare data
                image1.ToNornal(m, v);
                image2.ToNornal(m, v);

                image1.ToFiltring(widthSquare, f, fi);
                image2.ToFiltring(widthSquare, f, fi);

                image1.ToBinary(threshold);
                image2.ToBinary(threshold);


                image1.ToBoneImage();
                image2.ToBoneImage();

                minus1.Clear();
                minus2.Clear();
                minus1 = image1.GetMinutiae(left1, top1, right1, bottom1);
                minus2 = image2.GetMinutiae(left2, top2, right2, bottom2);
                #endregion

                #region run hough
                //int i;			
                //angles
                int angleStart = -30;
                int angleUnit = 3;
                int angleFinish = 30;
                int anglesCount = Convert.ToInt32((angleFinish - angleStart) / angleUnit) + 1;
                int[] angleSet = new int[anglesCount];
                i = 0;
                int angle = angleStart;
                while (i < anglesCount)
                {
                    angleSet[i] = angle;
                    i++;
                    angle += angleUnit;
                }
                //DELTAXSET
                int deltaXStart = -image1.Width;
                int deltaXFinish = image1.Width;
                int deltaXUnit = 2;
                int deltaXCount = Convert.ToInt32((deltaXFinish - deltaXStart) / deltaXUnit) + 1;
                int[] deltaXSet = new int[deltaXCount];
                i = 0;
                int deltaX = deltaXStart;
                while (i < deltaXCount)
                {
                    deltaXSet[i] = deltaX;
                    i++;
                    deltaX += deltaXUnit;
                }
                //DELTAYSET
                int deltaYStart = -image1.Height;
                int deltaYFinish = image1.Height;
                int deltaYUnit = 2;
                int deltaYCount = Convert.ToInt32((deltaYFinish - deltaYStart) / deltaYUnit) + 1;
                int[] deltaYSet = new int[deltaYCount];
                i = 0;
                int deltaY = deltaYStart;
                while (i < deltaYCount)
                {
                    deltaYSet[i] = deltaY;
                    i++;
                    deltaY += deltaYUnit;
                }

                //scaleset
                double[] scaleSet = { 0.8, 0.9, 1.0, 1.1, 1.2 };
                minuResult = Functions.GetMinutiaeChanging_UseHoughTransform(minus1, minus2, angleSet, deltaXSet, deltaYSet, angleLimit * Math.PI / 180, image1.Width / 2, image1.Height / 2);
                int count = Functions.CountMinuMatching(minus1, minus2, minuResult, distanceLimit, angleLimit * Math.PI / 180);
                #endregion
                isFirst1 = false;
                isFirst2 = false;
                if (count >= minuNumberLimit)
                    return true;
                else
                    return false;
            }
            catch { return false; }
        }
    }
}
