using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadingControlSystem.Model
{
   public class ICcard
    {

        private static ICcard card;
        Int16 port;  //端口号
        Int32 baud;  //波特率
        Int16 st;
        byte[] snr = new byte[5];  //卡片序列号

        //变量
        public IntPtr icdev = IntPtr.Zero;

        private static object _olock = new object();
        ICcard(Int16 port, Int32 baud)
        {
            this.baud = baud;
            this.port = port;
        }

        public static ICcard GetInstance(Int16 port, Int32 baud)
        {
            if (card==null)
            {
                lock (_olock)
                {
                    if (card==null)
                    {
                        card = new ICcard(port,baud);
                    }
                }
               
            }
            return card;
        }

        public bool IC_IsOpen()
        {
            if (icdev.ToInt32() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
     

        public void IC_Connect()
        {
            try
            {
                if (port != null && baud != null)
                {
                    icdev = Program.rf_init(port, baud);
                    if (icdev.ToInt32() > 0)
                    {
                        Logs.Info("Com Connect success!");
                        byte[] status = new byte[30];
                        st = Program.rf_get_status(icdev, status);  //读取硬件版本号
                                                                    //lbHardVer.Text=System.Text.Encoding.ASCII.GetString(status);
                        Logs.Info(System.Text.Encoding.Default.GetString(status));
                        Program.rf_beep(icdev, 25);
                    }
                    else
                    {
                        Logs.Info("Com Connect failed!");
                    }
                   

                    byte[] key = { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff };
                    byte mode = 0;
                    //加载密码,此密码是用来验证卡片的密码
                    for (byte sector = 0; sector < 16; sector++)
                    {
                        st = Program.rf_load_key(icdev, mode, sector, key);
                        if (st != 0)
                        {
                            string s1 = Convert.ToString(sector);
                            Logs.Info(s1 + " sector rf_load_key error!");
                        }
                    }
                }
             
            }
            catch (Exception)
            {

                throw;
            }
           

        }

        public  void IC_Close()
        {
            if (icdev.ToInt32() > 0)
            {
                st = Program.rf_exit(icdev);
                if (st == 0)
                {
                    Logs.Info("断开连接！");
                }
            }
            else
            {
                st = Program.rf_exit(icdev);
                if (st == 0)
                {
                    Logs.Info("断开连接！");
                }
            }
           
        }

        public  void GetICDate()
        {
            st = Program.rf_card(icdev, (byte)1, snr);　　　　//寻卡
            if (st != 0)
            {
                Logs.Info("rf_card error");
            }
            else
            {
                byte[] snr1 = new byte[8];
                Logs.Info("rf_card right!");
                Program.hex_a(snr, snr1, 4); //将卡号转换为16进制字符串
                Logs.Info(System.Text.Encoding.Default.GetString(snr1));
            }
        }



    }
}
