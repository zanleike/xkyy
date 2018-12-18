/*
    创建日期: 2013.6.4
    创建者:张存
    邮箱:zhangcunliang@126.com
    修改记录:
        2016.8.27 Base64Decrypt 字符串为空的bug修复
        2017.3.30 转拼音默认为小写，原因oracle like查询区分大小写的
 */
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.International.Converters.PinYinConverter;
using System.Security.Cryptography;

namespace Framework.Common.Helpers
{
    public class StringHelper
    {
        #region 拼音

        /// <summary>
        /// 获取汉子的拼音
        /// </summary>
        /// <param name="hz">汉字</param>
        /// <param name="isSimple">是否是简拼  true: 为简拼,false为全拼</param>        
        public static string GetPinYin(string hz, bool isSimple)
        {
            if (hz == null) return string.Empty;
            //引用  Microsoft.International.Converters.PinYinConverter 命名空间
            //文件: ChnCharInfo.dll
            StringBuilder sb = new StringBuilder();
            foreach (char hzch in hz)
            {
                if (ChineseChar.IsValidChar(hzch)) //判断是否是中文
                {
                    ChineseChar ch = new ChineseChar(hzch);

                    //s = ch.Pinyins[0].ToString();  //下标用来判断多音字
                    //s += s.Substring(0, s.Length - 1);  //最后一位是声调,去掉
                    if (isSimple) //如果是简拼
                    {
                        sb.Append(ch.Pinyins[0].Substring(0, 1).ToLower());
                    }
                    else
                    {
                        //去掉音调后的拼音
                        sb.Append(ch.Pinyins[0].Remove(ch.Pinyins[0].Length - 1));
                    }
                }
                else
                {
                    sb.Append(hzch.ToString());
                }
            }
            return sb.ToString();
        }
        /// <summary>
        /// 获取汉子的简拼
        /// </summary>
        public static string GetPinYin(string hz)
        {
            return GetPinYin(hz, true);
        }

        #endregion

        #region md5

        /// <summary>
        /// 获得MD5加密字符串
        /// </summary>
        public static string MD5EnString(string str)
        {
            return MD5EnString(str, "GBK");
        }
        /// <summary>
        /// 获得MD5加密字符串(指定编码)
        /// </summary>
        public static string MD5EnString(string str, string encode)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] result = md5.ComputeHash(Encoding.GetEncoding(encode).GetBytes(str));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                sb.Append(result[i].ToString("X2"));
            }
            return sb.ToString();
        }

        #endregion

        #region 根据指定字符获得随机字符串，指定长度
        /// <summary>
        /// 获得随机数字，指定长度（Md5）,有重复可能
        /// </summary>
        /// <param name="baseStr">要转换的动态基数</param>
        /// <param name="resultLen">输出字符串的长度</param>
        /// <returns></returns>
        public static string GetRoamdNumberStr(string baseStr, int resultLen)
        {
            baseStr += DateTime.Now.Ticks.ToString();
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] result = md5.ComputeHash(Encoding.UTF8.GetBytes(baseStr));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < resultLen; i++)
            {
                if (i >= result.Length)
                {
                    sb.Append("0");
                }
                else
                {
                    sb.Append(result[i].ToString("D3").Substring(2,1));
                }
            }
            return sb.ToString();
        }

        #endregion

        #region Base64加/解密

        #region  使用 给定密钥 加密/解密/byte[]

        /// <summary>
        /// 生成MD5摘要
        /// </summary>
        /// <param name="original">数据源</param>
        /// <returns>摘要</returns>
        static byte[] MakeMD5(byte[] original)
        {
            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            byte[] keyhash = hashmd5.ComputeHash(original);
            hashmd5 = null;
            return keyhash;
        }
        /// <summary>
        /// 使用给定密钥加密
        /// </summary>
        /// <param name="original">明文</param>
        /// <param name="key">密钥</param>
        /// <returns>密文</returns>
        static byte[] Encrypt(byte[] original, byte[] key)
        {
            TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
            des.Key = MakeMD5(key);
            des.Mode = CipherMode.ECB;
            return des.CreateEncryptor().TransformFinalBlock(original, 0, original.Length);
        }

        /// <summary>
        /// 使用给定密钥解密数据
        /// </summary>
        /// <param name="encrypted">密文</param>
        /// <param name="key">密钥</param>
        /// <returns>明文</returns>
        static byte[] Decrypt(byte[] encrypted, byte[] key)
        {
            TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
            des.Key = MakeMD5(key);
            des.Mode = CipherMode.ECB;
            return des.CreateDecryptor().TransformFinalBlock(encrypted, 0, encrypted.Length);
        }

        #endregion

        /// <summary>
        /// 使用给定密钥字符串加密string
        /// </summary>
        /// <param name="original">原始文字</param>
        /// <param name="key">密钥</param>
        /// <param name="encoding">字符编码方案</param>
        /// <returns>密文</returns>
        public static string Base64Encrypt(string original, string key, Encoding encode)
        {
            byte[] buff = encode.GetBytes(original);
            byte[] kb = encode.GetBytes(key);
            return Convert.ToBase64String(Encrypt(buff, kb));
        }
        /// <summary>
        /// 使用给定密钥字符串加密,默认为Default编码
        /// </summary>
        public static string Base64Encrypt(string original, string key)
        {
            return Base64Encrypt(original, key, Encoding.Default);
        }
        /// <summary>
        /// 指定编码格式,进行base64加密
        /// </summary>
        public static string Base64Encrypt(string str, Encoding encode)
        {
            byte[] bytes = encode.GetBytes(str);
            return Convert.ToBase64String(bytes);
        }
        /// <summary>
        /// 使用Base64编码字符加密(默认编码:Default)
        /// </summary>
        public static string Base64Encrypt(string str)
        {
            return Base64Encrypt(str, Encoding.Default);
        }

        /// <summary>
        /// 使用给定密钥字符串解密string
        /// </summary>
        /// <param name="original">密文</param>
        /// <param name="key">密钥</param>
        /// <returns>明文</returns>
        public static string Base64Decrypt(string original, string key)
        {
            return Base64Decrypt(original, key, System.Text.Encoding.Default);
        }
        /// <summary>
        /// 使用给定密钥字符串解密string,返回指定编码方式明文
        /// </summary>
        /// <param name="encrypted">密文</param>
        /// <param name="key">密钥</param>
        /// <param name="encoding">字符编码方案</param>
        /// <returns>明文</returns>
        public static string Base64Decrypt(string encrypted, string key, Encoding encoding)
        {
            if (string.IsNullOrEmpty(encrypted)) return string.Empty;
            byte[] buff = Convert.FromBase64String(encrypted);
            byte[] kb = encoding.GetBytes(key);
            return encoding.GetString(Decrypt(buff, kb));
        }
        /// <summary>
        /// 使用Base64解码(默认编码:Default)
        /// </summary>
        public static string Base64Decrypt(string str)
        {
            return Base64Decrypt(str, Encoding.Default);
        }
        /// <summary>
        /// 指定编码格式 Base64解码
        /// </summary>
        public static string Base64Decrypt(string str, Encoding encode)
        {
            byte[] outputb = Convert.FromBase64String(str);
            string orgStr = encode.GetString(outputb);
            return orgStr;
        }

        #endregion

        #region SHA1

        /// <summary>
        /// sha1加密(默认编码utf-8)
        /// </summary>
        public static string SHA1Encrypt(string targetPassword)
        {
            return SHA1Encrypt(targetPassword, Encoding.UTF8);
        }
        /// <summary>
        /// sha1加密指定编码
        /// </summary>
        public static string SHA1Encrypt(string targetPassword, Encoding encode)
        {
            byte[] pwBytes = encode.GetBytes(targetPassword);
            byte[] hash = SHA1.Create().ComputeHash(pwBytes);
            StringBuilder hex = new StringBuilder();
            for (int i = 0; i < hash.Length; i++) hex.Append(hash[i].ToString("2"));

            return hex.ToString();
        }

        #endregion

        /// <summary>
        /// 比较两个字符串，不区分大小写且不计算前后空格
        /// </summary>
        public static bool StringEquals(string a, string b)
        {
            if (a == null && b == null) return true;
            if (a == null) return false;
            if (b == null) return false;
            return string.Equals(a.Trim().ToUpper(), b.Trim().ToUpper());
        }
        /// <summary>
        /// 判断所有字符串是否为空，只有其中一个为null或空字符串则返回true
        /// </summary>
        public static bool IsNullOrWhiteSpace(params string[] strs)
        {
            if (strs == null || strs.Length == 0) return true;
            foreach (var item in strs)
            {
                if (item == null) return true;
                if (item.Trim().Length == 0) return true;
            }
            return false;
        }
    }
}