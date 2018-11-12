using EQ2008_DataStruct;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MODEL
{
    public class LEDShow
    {
        #region 引用
        //添加节目
        [DllImport("EQ2008_Dll.dll", CharSet = CharSet.Ansi)]
        public static extern int User_AddProgram(int CardNum, Boolean bWaitToEnd, int iPlayTime);
        //删除所有节目
        [DllImport("EQ2008_Dll.dll", CharSet = CharSet.Ansi)]
        public static extern Boolean User_DelAllProgram(int CardNum);
        //发送数据
        [DllImport("EQ2008_Dll.dll", CharSet = CharSet.Ansi)]
        public static extern Boolean User_SendToScreen(int CardNum);
        //开屏
        [DllImport("EQ2008_Dll.dll", CharSet = CharSet.Ansi)]
        public static extern Boolean User_OpenScreen(int CardNum);
        //关屏
        [DllImport("EQ2008_Dll.dll", CharSet = CharSet.Ansi)]
        public static extern Boolean User_CloseScreen(int CardNum);
        //添加单行文本区
        [DllImport("EQ2008_Dll.dll", CharSet = CharSet.Ansi)]
        public static extern int User_AddSingleText(int CardNum, ref User_SingleText pSingleText, int iProgramIndex);
        //校正时间
        [DllImport("EQ2008_Dll.dll", CharSet = CharSet.Ansi)]
        public static extern Boolean User_AdjustTime(int CardNum);
        //添加时间区
        [DllImport("EQ2008_Dll.dll", CharSet = CharSet.Ansi)]
        public static extern int User_AddTime(int CardNum, ref User_DateTime pdateTime, int iProgramIndex);
        //实时建立连接
        [DllImport("EQ2008_Dll.dll", CharSet = CharSet.Ansi)]
        public static extern Boolean User_RealtimeConnect(int CardNum);
        //实时发送文本
        [DllImport("EQ2008_Dll.dll", CharSet = CharSet.Ansi)]
        public static extern Boolean User_RealtimeSendText(int CardNum, int x, int y, int iWidth, int iHeight, string strText, ref User_FontSet pFontInfo);
        //实时关闭连接
        [DllImport("EQ2008_Dll.dll", CharSet = CharSet.Ansi)]
        public static extern Boolean User_RealtimeDisConnect(int CardNum);
        //实时发送清屏
        [DllImport("EQ2008_Dll.dll", CharSet = CharSet.Ansi)]
        public static extern Boolean User_RealtimeScreenClear(int CardNum);
        #endregion

        public string showContent = string.Empty; //显示内容
        public static int g_iGreen = 0xFF00; //绿色
        public static int g_iYellow = 0xFFFF; //黄色
        public static int g_iRed = 0x00FF; //红色
        public static int g_FontSize =Convert.ToInt32(ConfigurationManager.AppSettings["LEDFontSize"]);
        /// <summary>
        /// 打开显示屏
        /// </summary>
        public static void LedOpen(int cardNum)
        {
            if (User_OpenScreen(cardNum))
            {
                MessageBox.Show(cardNum + "打开显示屏成功！");
            }
            else
            {
                MessageBox.Show(cardNum + "打开显示屏失败！");
            }
        }
        /// <summary>
        /// 关闭显示屏
        /// </summary>
        public void LedClose(int cardNum)
        {
            if (User_CloseScreen(cardNum))
            {
                MessageBox.Show(cardNum +"关闭显示屏成功！");
            }
            else
            {
                MessageBox.Show(cardNum + "关闭显示屏失败！");
            }
        }
        /// <summary>
        /// 添加节目
        /// </summary>
        /// <param name="cardNum">控制卡地址</param>
        /// <param name="duraTion">时长 秒</param>
        public static int AddProgram(int cardNum, int duraTion)
        {
            return User_AddProgram(cardNum, false, duraTion);
        }
        //删除所有节目
        public void DeleteProgram(int cardNum)
        {
            if (User_DelAllProgram(cardNum) == false)
            {
                MessageBox.Show("删除节目失败！");
            }
        }
        /// <summary>
        /// 发送数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static bool SendData(int cardNum)
        {
            return User_SendToScreen(cardNum);
        }
        /// <summary>
        /// 添加显示内容
        /// </summary>
        public static void AddText(int cardNum, string content, int g_iProgramIndex)
        {
            User_SingleText SingleText = new User_SingleText();
            SingleText.BkColor = 0;
            SingleText.chContent = content;
            SingleText.PartInfo.iFrameMode = 0;
            SingleText.PartInfo.iHeight = 32;
            SingleText.PartInfo.iWidth = 128;
            SingleText.PartInfo.iX = 0;
            SingleText.PartInfo.iY = 0;
            SingleText.FontInfo.bFontBold = false;
            SingleText.FontInfo.bFontItaic = false;
            SingleText.FontInfo.bFontUnderline = false;
            SingleText.FontInfo.colorFont = g_iRed;
            SingleText.FontInfo.iFontSize = g_FontSize;
            SingleText.PartInfo.FrameColor = g_iYellow;
            SingleText.FontInfo.strFontName = "宋体";
            SingleText.MoveSet.bClear = false;
            SingleText.MoveSet.iActionSpeed = 6;
            SingleText.MoveSet.iActionType = 2;
            SingleText.MoveSet.iHoldTime = 20;
            SingleText.MoveSet.iClearActionType = 0;
            SingleText.MoveSet.iClearSpeed = 0;
            SingleText.MoveSet.iFrameTime = 20;
            if (-1 == User_AddSingleText(cardNum, ref SingleText, g_iProgramIndex))
            {
                MessageBox.Show("添加文本失败！");
            }
            else
            {
                MessageBox.Show("添加文本成功！");
            }
        }
        //添加单行文本
        private void AddSingleText(int cardNum, string content, int g_iProgramIndex)
        {
            User_SingleText SingleText = new User_SingleText();

            SingleText.BkColor = 0;
            SingleText.chContent = content;
            SingleText.PartInfo.iFrameMode = 0;
            SingleText.PartInfo.iHeight = 32;
            SingleText.PartInfo.iWidth = 128;
            SingleText.PartInfo.iX = 0;
            SingleText.PartInfo.iY = 0;
            SingleText.FontInfo.bFontBold = false;
            SingleText.FontInfo.bFontItaic = false;
            SingleText.FontInfo.bFontUnderline = false;
            SingleText.FontInfo.colorFont = g_iRed;
            SingleText.FontInfo.iFontSize =g_FontSize;
            SingleText.PartInfo.FrameColor = g_iYellow;
            SingleText.FontInfo.strFontName = "宋体";
            SingleText.MoveSet.bClear = false;
            SingleText.MoveSet.iActionSpeed = 6;
            SingleText.MoveSet.iActionType = 2;
            SingleText.MoveSet.iHoldTime = 20;
            SingleText.MoveSet.iClearActionType = 0;
            SingleText.MoveSet.iClearSpeed = 0;
            SingleText.MoveSet.iFrameTime = 20;

            if (-1 == User_AddSingleText(cardNum, ref SingleText, g_iProgramIndex))
            {
                MessageBox.Show("添加单行文本失败！");
            }
            else
            {
                MessageBox.Show("添加单行文本成功！");
            }
        }
        /// <summary>
        /// 校准时间
        /// </summary>
        public static bool CheckTime(int cardNum)
        {
            return User_AdjustTime(cardNum);
        }

        /// <summary>
        /// 添加时间
        /// </summary>
        public static void AddDateTime(int cardNum, int g_iProgramIndex,bool date, bool week, bool time)
        {
            User_DateTime DateTime = new User_DateTime();
            DateTime.bDay = date;
            DateTime.bHour = time;
            DateTime.BkColor = 0;
            DateTime.bMin = time;
            DateTime.bMouth = date;
            DateTime.bMulOrSingleLine = false;
            DateTime.bSec = time;
            DateTime.bWeek = week;
            DateTime.bYear = date;
            DateTime.bYearDisType = false;
            DateTime.chTitle = "";

            DateTime.PartInfo.iFrameMode = 1;
            DateTime.iDisplayType = 1;

            DateTime.PartInfo.FrameColor = 0xFFFF;
            DateTime.PartInfo.iHeight = 32;
            DateTime.PartInfo.iWidth = 128;
            DateTime.PartInfo.iX = 0;
            DateTime.PartInfo.iY = 0;

            DateTime.FontInfo.bFontBold = false;
            DateTime.FontInfo.bFontItaic = false;
            DateTime.FontInfo.bFontUnderline = false;
            DateTime.FontInfo.colorFont = 0xFF;
            DateTime.FontInfo.iAlignStyle = 1;
            DateTime.FontInfo.iFontSize = 12;
            DateTime.FontInfo.strFontName = "宋体";

            if (-1 == User_AddTime(cardNum, ref DateTime, g_iProgramIndex))
            {
                MessageBox.Show("添加时间失败！");
            }
            else
            {
                MessageBox.Show("添加时间成功！");
            }
        }
        /// <summary>
        /// 实时连接
        /// </summary>
        /// <param name="g_iCardNum"></param>
        public static void RealTimeConnect(int g_iCardNum)
        {
            if (!User_RealtimeConnect(g_iCardNum))
            {
                MessageBox.Show("连接实时通信失败！");
            }
            else
            {
                MessageBox.Show("连接实时通信成功！");
            }
        }
        /// <summary>
        /// 实时关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void RealTimeDisConnect(int g_iCardNum)
        {
            if (!User_RealtimeDisConnect(g_iCardNum))
            {
                MessageBox.Show("关闭实时通信失败！");
            }
            else
            {
                MessageBox.Show("关闭实时通信成功！");
            }
        }
        /// <summary>
        /// 实时发送文本内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RealtimeSendText(int g_iCardNum, string strText)
        {
            int iX = 0;
            int iY = 0;
            int iW = 128;
            int iH = 32;
            User_FontSet FontInfo = new User_FontSet();

            FontInfo.bFontBold = false;
            FontInfo.bFontItaic = false;
            FontInfo.bFontUnderline = false;
            FontInfo.colorFont = 0xFFFF;
            FontInfo.iFontSize = 12;
            FontInfo.strFontName = "宋体";
            FontInfo.iAlignStyle = 0;
            FontInfo.iVAlignerStyle = 0;
            FontInfo.iRowSpace = 0;

            if (!User_RealtimeSendText(g_iCardNum, iX, iY, iW, iH, strText, ref FontInfo))
            {
                MessageBox.Show("发送实时文本失败！");
            }
            else
            {
                MessageBox.Show("发送实时文本成功！");
            }
        }
        /// <summary>
        /// 清空显示屏原有节目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void RealtimeScreenClear(int g_iCardNum)
        {
            if (!User_RealtimeScreenClear(g_iCardNum))
            {
                MessageBox.Show("清空控制卡节目失败！");
            }
            else
            {
                MessageBox.Show("清空控制卡节目成功！");
            }
        }
    }
}
