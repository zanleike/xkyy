using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
namespace Framework.Common.Helpers
{
    public class ImageHelper
    {
        #region 生成验证码

        /// <summary>
        /// 随即获取验证码
        /// </summary>
        /// <param name="width">放验证码图片控件的宽度</param>
        /// <param name="height">放验证码图片控件的高度</param>
        /// <param name="codeLength">验证码的长度</param>
        /// <param name="s">输出验证码的字符串</param>
        /// <returns></returns>
        public static Image GetCheckCode(int width, int height, int codeLength, out string s)
        {
            Random ran = new Random();
            string strSource = "01234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string codeStr = "";
            for (int i = 0; i < codeLength; i++)
            {
                int r = ran.Next(0, strSource.Length);
                codeStr += strSource[r].ToString();

            }
            s = codeStr;
            Bitmap bitmap = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.White); //清除背景色

            int fontSize = height / 2; //字体的大小由画布的高决定
            // g.DrawRectangle(Pens.White, 0, 0, width, height);
            Font font = new Font("Arial", fontSize, FontStyle.Bold);
            //font.Bold = true;
            //验证码的位置
            PointF pf = new PointF();

            //写入验证码颜色的集合
            List<Brush> listBrush = new List<Brush>();
            listBrush.Add(Brushes.Red);
            listBrush.Add(Brushes.Gold);
            listBrush.Add(Brushes.Blue);
            listBrush.Add(Brushes.Firebrick);
            listBrush.Add(Brushes.GreenYellow);
            listBrush.Add(Brushes.Indigo);

            //加噪点
            Point pt1 = new Point();
            Point pt2 = new Point();
            for (int i = 0; i < 20; i++)
            {
                pt1.X = ran.Next(1, 3);
                pt1.Y = ran.Next(1, height);
                pt2.X = ran.Next(width - 3, width);
                pt2.Y = ran.Next(1, height);
                int brushIndex = ran.Next(0, listBrush.Count);
                g.DrawLine(Pens.Gray, pt1, pt2);
            }


            //按画布比例分配字符(一个字符写入画板的宽度)
            int oneLength = width / codeLength;
            if (fontSize >= oneLength)
            {
                fontSize = oneLength - 1;
            }
            for (int i = 0; i < s.Length; i++)
            {
                pf.X = ran.Next(i * oneLength + 1, (i + 1) * oneLength - fontSize);
                pf.Y = ran.Next(0, height - fontSize - 5);
                int brushIndex = ran.Next(0, listBrush.Count);
                g.DrawString(s[i].ToString(), font, listBrush[brushIndex], pf);
            }

            g.Dispose();
            //bitmap.RawFormat = 
            
            return bitmap;
        }
        #endregion
        #region 图片上加水印

        /// <summary>
        /// 向图片上写文字再输出
        /// </summary>
        /// <param name="img"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public static Image WriteString(Image img, string text)
        {
            Bitmap bmap = new Bitmap(img);
            using (Graphics g = Graphics.FromImage(bmap))
            {
                Font font = new Font("楷体", 15);
                PointF pf = new PointF();//((float)(img.Width/2-2.5),img.Height/2-2.5);
                pf.X = 0;
                pf.Y = 0;
                g.DrawString(text, font, Brushes.Gold, pf);
            }
            return bmap;
        }
        /// <summary>
        /// 将图片加载水印图片
        /// </summary>
        /// <param name="markImg">水印图片</param>
        /// <param name="fromImg">原图</param>
        /// <returns></returns>
        public static Image WriteImg(Image markImg, Image fromImg)
        {
            Bitmap b = new Bitmap(fromImg);
            using (Graphics g = Graphics.FromImage(b))
            {
                g.DrawImage(markImg, 0, 0, markImg.Width, markImg.Height);
                g.Dispose();
            }
            return b;
        }

        #endregion
        #region 缩略图

        /// <summary>
        /// 根据制定的高度和宽度改变图片大小
        /// </summary>
        /// <param name="img">图片源</param>
        /// <param name="width">宽度像素</param>
        /// <param name="heigth">高度像素</param>
        /// <returns></returns>
        public static Bitmap SmallBit(Image img, int width, int heigth)
        {
            Bitmap bitmap = new Bitmap(width, heigth); //要生成新图片的大小
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.DrawImage(img, 0, 0, bitmap.Width, bitmap.Height);
            }
            return bitmap;
        }

        /// <summary>
        /// 根据指定高度改变图片大小
        /// </summary>
        /// <param name="img"></param>
        /// <param name="heigth"></param>
        /// <returns></returns>
        public static Image SmallBitByHeight(Image img, int heigth)
        {
            int h = heigth;
            //高度缩小的比例也是宽度缩小的比例
            // img.Height / heigth; 得到高度缩小的比例
            int w = (int)(img.Width / (img.Height / heigth));
            return SmallBit(img, w, h);
        }

        /// <summary>
        /// 根据指定宽度改变图片大小
        /// </summary>
        /// <param name="img"></param>
        /// <param name="width"></param>
        /// <returns></returns>
        public static Image SmallBitByWidth(Image img, int width)
        {
            int h = (int)(img.Height / (img.Width / width));
            return SmallBit(img, width, h);
        }

        /// <summary>
        /// 根据比例改变图片大小
        /// </summary>
        /// <param name="img"></param>
        /// <param name="ratio">比例大小如:0.5(百分之50)</param>
        /// <returns></returns>
        public static Image SmallBitByRatio(Image img, double ratio)
        {
            int w = (int)(img.Width * ratio);
            int h = (int)(img.Height * ratio);
            return SmallBit(img, w, h);
        }

        /// <summary>
        /// 旋转图片
        /// </summary>
        /// <param name="img"></param>
        /// <param name="rf">要旋转的图片类型(枚举)</param>
        /// <returns></returns>
        public static Image ReverseBit(Image img, RotateFlipType rf)
        {
            img.RotateFlip(rf);
            return img;
        }

        /// <summary>
        /// 根据画布大小比例得到图片
        /// </summary>
        /// <param name="img"></param>
        /// <param name="cWidth"></param>
        /// <param name="cHeight"></param>
        /// <returns></returns>
        public static Image SmallBitByCanva(Image img, int cWidth, int cHeight)
        {
            Bitmap bitmap = new Bitmap(cWidth, cHeight); //要生成新图片的大小

            //哪个缩小的比例大就以谁的比例缩小
            if (img.Width / cWidth > img.Height / cHeight)
            {
                return SmallBitByWidth(img, cWidth);

            }
            else
            {
                return SmallBitByHeight(img, cHeight);
            }
        }

        #endregion
    }
}

