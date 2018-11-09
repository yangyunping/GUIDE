using System;
using System.Runtime.InteropServices;

namespace EQ2008_DataStruct
{
    /// <summary>
    /// ��Ŀ�������
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct User_PartInfo
    {
        public int iX;                    //���ڵ����X
        public int iY;                    //���ڵ����Y
        public int iWidth;                //����Ŀ��
        public int iHeight;               //����ĸ߶�
        public int iFrameMode;            //�߿����ʽ
        public int FrameColor;            //�߿���ɫ
    }

    /// <summary>
    /// �������
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct User_FontSet
    {
        public string strFontName;       //���������
        public int iFontSize;            //����Ĵ�С
        public bool bFontBold;           //�����Ƿ�Ӵ�
        public bool bFontItaic;          //�����Ƿ���б��
        public bool bFontUnderline;      //�����Ƿ���»���
        public int colorFont;            //�������ɫ
        public int iAlignStyle;          //���Ҷ��뷽ʽ��0�� ����룬1�����У�2���Ҷ���
        public int iVAlignerStyle;       //���¶��뷽ʽ��0-�����룬1-���¾��У�2-�׶���    
        public int iRowSpace;            //�м��
    }

    /// <summary>
    /// ������ʽ����
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct User_MoveSet
    {
        public int iActionType;             //��Ŀ�任��ʽ
        public int iActionSpeed;            //��Ŀ�Ĳ����ٶ�
        public bool bClear;                 //�Ƿ���Ҫ�������
        public int iHoldTime;               //����Ļ��ͣ����ʱ��
        public int iClearSpeed;		        //�����ʾ�����ٶ�
        public int iClearActionType;	    //��Ŀ����ı任��ʽ
        public int iFrameTime;              //ÿ֡ʱ��
    }

    /// <summary>
    /// ����ʱ��������
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct User_DateTime
    {
        public User_PartInfo PartInfo;   //������Ϣ
        public int BkColor;              //������ɫ
        public User_FontSet FontInfo;    //��������
        public int iDisplayType;         //��ʾ��� 0��"3/10/2006 ������10:20:30",1��"2006-03-10������10:20:30",2��"2006��3��10�� ������10��20��30��"
        public string chTitle;           //�����ʾ����
        public bool bYearDisType;        //���λ��0��4,1��2λ
        public bool bMulOrSingleLine;    //���л��Ƕ���,0������1������
        public bool bYear;               //�Ƿ���ʾ��
        public bool bMouth;              //�Ƿ���ʾ��
        public bool bDay;                //�Ƿ���ʾ��
        public bool bWeek;               //�Ƿ���ʾ����
        public bool bHour;               //�Ƿ���ʾСʱ
        public bool bMin;                //�Ƿ���ʾ����
        public bool bSec;                //�Ƿ���ʾ��
    }

    /// <summary>
    /// �����ı�������
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct User_SingleText
    {
        public string chContent;            //��ʾ����
        public User_PartInfo PartInfo;      //������Ϣ
        public int BkColor;                 //������ɫ
        public User_FontSet FontInfo;       //��������
        public User_MoveSet MoveSet;        //������ʽ����
    }

    /// <summary>
    /// �ı�������
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct User_Text
    {
        public string chContent;            //��ʾ����
        public User_PartInfo PartInfo;      //������Ϣ
        public int BkColor;                 //������ɫ
        public User_FontSet FontInfo;       //��������
        public User_MoveSet MoveSet;        //������ʽ����
    }

    /// <summary>
    /// ��ʱ������
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct User_Timer
    {
        public User_PartInfo PartInfo;	//������Ϣ
        public int BkColor;			    //������ɫ
        public User_FontSet FontInfo;	//��������
        public int ReachTimeYear;		//������
        public int ReachTimeMonth;	    //������
        public int ReachTimeDay;		//������
        public int ReachTimeHour;		//����ʱ
        public int ReachTimeMinute;	    //�����
        public int ReachTimeSecond;	    //������
        public bool bDay;				//�Ƿ���ʾ�� 0������ʾ 1����ʾ
        public bool bHour;				//�Ƿ���ʾСʱ
        public bool bMin;				//�Ƿ���ʾ����
        public bool bSec;				//�Ƿ���ʾ��
        public bool bMulOrSingleLine;	//���л��Ƕ���
        public string chTitle;			//�����ʾ����
    }

    /// <summary>
    /// �¶�������
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct User_Temperature
    {
        public User_PartInfo PartInfo;		//������Ϣ
        public int BkColor;			        //������ɫ
        public User_FontSet FontInfo;		//��������
        public string chTitle;			    //����
        public int DisplayType;		        //��ʾ��ʽ��0���� 1��C
    }

    /// <summary>
    /// ͼ��������
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct User_Bmp
    {
        public User_PartInfo PartInfo;		//������Ϣ
    }

    /// <summary>
    /// RTF�ļ�������
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct User_RTF
    {
        public string strFileName;      //RTF�ļ���
        public User_PartInfo PartInfo;	//������Ϣ
        public User_MoveSet MoveSet;	//������ʽ����
    }
}