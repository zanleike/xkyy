using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Framework.Common.Helpers
{
    /// <summary>
    /// 数字转换类,定义了各进制转换等
    /// </summary>
    public class NumberHelper
    {
        #region 10进制与多进制互转的两个方法

        /// <summary>
        /// 用来定义36进制的字符
        /// </summary>
        private static char[] _BaseNums = {'0','1','2','3','4','5','6',
                           '7','8','9','A','B','C','D',
                           'E','F','G','H','I','J','K',
                           'L','M','N','O','P','Q','R',
                           'S','T','U','V','W','X','Y','Z' };

        /// <summary>
        /// 将非10进制转换成10进制
        /// </summary>
        /// <param name="zex">多进制值</param>
        /// <param name="convertType">指定进制类型</param>
        /// <returns>内部无try操作</returns>
        public static int MoreScaleToInt(string zex, int convertType)  //多进制转换成10进制
        {
            //  16进制转换10进制的方法.
            //  n: 16进制的长度(位数) 
            //  FF 16的n-1次方 * 左数第1位 F + 16的n-1-1次方* 第2位
            //        16 * 15  +  16的0次方(1) * 15 = 255 
            //    FFF      4095
            //    16*15 + （16的3-2次方=16）*15 + 16的0次方=1*15  
            //    十六进制：ABC  =>  2748
            //    (16的3-1次方)*10=2560 + 16的3-2次方 * 11 =176 + 16的3-3次方*12 =192 
            //
            string s = zex;
            string regstr = @"^[A-Za-z0-9]+$";
            if (!Regex.IsMatch(s, regstr))
            {
                return 0;
            }

            zex = zex.ToUpper();
            string OnemoreNum; //得到每一位对进制对应的10进制
            int multiplier = 1;
            int resultTmp = 0;
            for (int i = 0; i < zex.Length; i++)
            {

                #region 定义多进制对应的10进制

                switch (zex[i])
                {
                    case 'A':
                        OnemoreNum = "10";
                        break;
                    case 'B':
                        OnemoreNum = "11";
                        break;
                    case 'C':
                        OnemoreNum = "12";
                        break;
                    case 'D':
                        OnemoreNum = "13";
                        break;
                    case 'E':
                        OnemoreNum = "14";
                        break;
                    case 'F':
                        OnemoreNum = "15";
                        break;
                    case 'G':
                        OnemoreNum = "16";
                        break;
                    case 'H':
                        OnemoreNum = "17";
                        break;
                    case 'I':
                        OnemoreNum = "18";
                        break;
                    case 'J':
                        OnemoreNum = "19";
                        break;
                    case 'K':
                        OnemoreNum = "20";
                        break;
                    case 'L':
                        OnemoreNum = "21";
                        break;
                    case 'M':
                        OnemoreNum = "22";
                        break;
                    case 'N':
                        OnemoreNum = "23";
                        break;
                    case 'O':
                        OnemoreNum = "24";
                        break;
                    case 'P':
                        OnemoreNum = "25";
                        break;
                    case 'Q':
                        OnemoreNum = "26";
                        break;
                    case 'R':
                        OnemoreNum = "27";
                        break;
                    case 'S':
                        OnemoreNum = "28";
                        break;
                    case 'T':
                        OnemoreNum = "29";
                        break;
                    case 'U':
                        OnemoreNum = "30";
                        break;
                    case 'V':
                        OnemoreNum = "31";
                        break;
                    case 'W':
                        OnemoreNum = "32";
                        break;
                    case 'X':
                        OnemoreNum = "33";
                        break;
                    case 'Y':
                        OnemoreNum = "34";
                        break;
                    case 'Z':
                        OnemoreNum = "35";
                        break;
                    default:
                        OnemoreNum = zex[i].ToString();
                        break;
                }

                #endregion

                multiplier = 1;
                for (int j = 0; j < zex.Length - 1 - i; j++)
                {
                    multiplier = multiplier * convertType;     //  X进制 的n-1次方
                }
                resultTmp += multiplier * Convert.ToInt32(OnemoreNum); //X进制 的n-1次方 * 第1位
            }
            return resultTmp;
        }
        /// <summary>
        /// 10进制转换成多进制
        /// </summary>
        /// <param name="num">10进制数值</param>
        /// <param name="convertType">多进制类型</param>
        /// <returns>输出字符串</returns>
        public static string IntToMoreScale(int num, int convertType)  //将10进制转换成多进制
        {
            if (convertType > 36)
            {
                return "";
            }

            string s = num.ToString();
            string regstr = @"^[\d]+$";
            if (!Regex.IsMatch(s, regstr))
            {
                return "ERROR";
            }
            string tmpResult = "";
            // 10进制数转换成16进制的方法，和转换为2进制的方法类似，唯一变化：除数由2变成16。 　　
            //同样是120，转换成16进制则为： 　　
            //被除数 计算过程 商 余数 　　120 120/16 商7 余8 　　商7  7/16 商0 余7 　　120转换为16进制，结果为：78
            int numDiv = num; //初始 商 = num
            while (true)
            {
                //tmpResult=
                tmpResult = _BaseNums[numDiv % convertType].ToString() + tmpResult;  //将结果 倒序 再连接到一起
                numDiv = numDiv / convertType;   // numdiv = 商 ,再继续下一个循环
                if (numDiv / convertType == 0)
                {
                    tmpResult = _BaseNums[numDiv % convertType].ToString() + tmpResult;
                    break;
                }
            }
            return tmpResult;

        }

        #endregion

        #region 各数据类型与字节数组的转换
        
        /// <summary>
        /// 将16进制字符串转换成byte数组,每2个字符转换为1个byte
        /// </summary>
        public static byte[] HexToByteArr(string sValue)
        {
            if (sValue.Length % 2 != 0)
            {
                throw new Exception("数据格式不正确");
            }
            List<byte> dataList = new List<byte>();
            for (int i = 0; i < sValue.Length; i += 2)
            {
                dataList.Add(Convert.ToByte(sValue.Substring(i, 2), 16));
            }
            return dataList.ToArray();
        }
        /// <summary>
        /// 字节数组转换成十六进制字符串
        /// </summary>
        public static string ByteArrToHex(byte[] sValue)
        {
            return ByteArrToHex(sValue, false);
        }
        /// <summary>
        /// 字节数组转换成十六进制字符串,指定是否每个字节加一个空格
        /// </summary>
        public static string ByteArrToHex(byte[] sValue, bool isAddEmpty)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < sValue.Length; i++)
            {
                sb.Append(sValue[i].ToString("X2"));
                if (isAddEmpty) sb.Append(" ");
            }
            return sb.ToString();
        }
        /// <summary>
        /// 字节数组转换为int32
        /// </summary>
        public static int ByteArrToInt32(byte[] sValue)
        {   
            int multiplier = 1;
            int resultTmp = 0;
            
            for (int i = 0; i < sValue.Length; i++)
            {
                multiplier = 1;
                for (int j = 0; j < sValue.Length - 1 - i; j++)
                {
                    multiplier = multiplier * 16;     //  X进制 的n-1次方
                }
                resultTmp += multiplier * 16; //X进制 的n-1次方 * 第1位
            }
            return resultTmp;
        }

        //public static byte[] Int32ToByteArr(int sValue)
        //{
        //    List<byte> byteList = new List<byte>();
        //    int tmpResult = 0;
        //    int numDiv = sValue; //初始 商 = num
        //    while (true)
        //    {
        //        //tmpResult=
        //        tmpResult = _BaseNums[numDiv % 16].ToString() + tmpResult;  //将结果 倒序 再连接到一起
        //        numDiv = numDiv / convertType;   // numdiv = 商 ,再继续下一个循环
        //        if (numDiv / convertType == 0)
        //        {
        //            tmpResult = _BaseNums[numDiv % convertType].ToString() + tmpResult;
        //            break;
        //        }
        //    }
        //    return byteList.ToArray();
        //}
        #endregion
    }
}
