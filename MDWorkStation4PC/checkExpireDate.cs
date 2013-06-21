using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MDWorkStation4PC
{
    /// <summary>
    /// 试用功能类
    /// </summary>
    static class checkExpireDate
    {
        /// <summary>
        /// 检查试用是否到期
        /// </summary>
        /// <returns>
        /// true:到期
        /// </returns>
        /// 

        //过期文件路径
        //private static string validFileName = "c:\\windows\\system.da1";
        private static string validFileName = "c:\\windows\\system.da1";

        //默认加密密钥
        private static string encKey = "njmd1230";

        //有效期
        private static int iExpireDate = 30;


        /// <summary>
        /// 
        /// </summary>
        /// <returns>
        /// false:未过期
        /// true:已经过期
        /// </returns>
        public static bool isExpire()
        {
            return checkValidFilesExpireDate();
        }

        /// <summary>
        /// 是否已经过期
        /// </summary>
        /// <returns>
        /// false:已经过期
        /// true:未过期
        /// </returns>
        public static bool checkValidFilesExpireDate()
        {

            MyEncode myEnc = new MyEncode();
            string sToday = DateTime.Today.Date.ToString("yyyyMMdd"); //20130531


            //如果文件不存在，就生成一个以日期加密后的文件
            if (!File.Exists(validFileName))
            {                
                //将日期字符串加密
                string encString = myEnc.symmetry_Encode(sToday, encKey);


                //将加密后的内容写入文件
                FileStream fs = new FileStream(validFileName, FileMode.Create);
                //获得字节数组
                byte[] data = new ASCIIEncoding().GetBytes(encString);
                //开始写入
                fs.Write(data, 0, data.Length);
                //清空缓冲区、关闭流
                fs.Flush();
                fs.Close();


                return false;
            }

            FileStream fileStream = null;
            StreamReader streamReader = null;
            fileStream = new FileStream(validFileName, FileMode.Open, FileAccess.Read);
            streamReader = new StreamReader(fileStream, Encoding.ASCII);
            fileStream.Seek(0, SeekOrigin.Begin);
            string content = streamReader.ReadLine();

            //获得当时创建文件的时间
            string fCreateDate =  myEnc.symmetry_Decode(content, encKey);

            try
            {
                //如果 今天 - 创建日期 < 过期间隔，则仍然可以使用
                if ( DateExpire( fCreateDate , sToday ) )
                {
                    return false;
                }

            }
            catch (Exception)
            {

                return true;
            }


            return true;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sd1">创建日期</param>
        /// <param name="sd2">当前日期</param>
        /// <returns>
        /// false:已过期
        /// true:未过期
        /// </returns>
        public static bool DateExpire(string sd1, string sd2)
        {

            DateTime d1 = DateTime.ParseExact(sd1, "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture);
            DateTime d2 = DateTime.ParseExact(sd2, "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture);


            TimeSpan ts1 = new TimeSpan(d1.Ticks);
            TimeSpan ts2 = new TimeSpan(d2.Ticks);
            TimeSpan ts = ts1.Subtract(ts2).Duration();
            int days = ts.Days;
            if (days < iExpireDate)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
