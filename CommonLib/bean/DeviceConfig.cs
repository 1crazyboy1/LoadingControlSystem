using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CommonLib.bean
{
    public  class DeviceConfig : PropertyChangedBase
    {
     
        private DeviceTypeEnum deviceType;
        private string ip;
        private int port;
        private string comPort;
        private int baud;
        private string deviceName;
        /// <summary>
        /// 设备类型
        /// </summary>
        public DeviceTypeEnum DeviceType 
        {
            get { return deviceType; }
            set
            {
                deviceType = value;
                OnPropertyChanged("DeviceType");
            }
        }

        /// <summary>
        /// IP 地址
        /// </summary>
        public string IP 
        {
            get { return ip; }
            set
            {
                ip = value;
                OnPropertyChanged("IP");
            }
        }

        /// <summary>
        /// 端口
        /// </summary>
        public int Port
        {
            get { return port; }
            set
            {
                port = value;
                OnPropertyChanged("Port");
            }
        }

        /// <summary>
        ///串口端口
        /// </summary>
        public string ComPort 
        {
            get { return comPort; }
            set
            {
                comPort = value;
                OnPropertyChanged("ComPort");
            }
        }

        /// <summary>
        /// 波特率
        /// </summary>
        public int Baud
        {
            get { return baud; }
            set
            {
                baud = value;
                OnPropertyChanged("Baud");
            }
        }

        public string DeviceName
        {
            get { return deviceName; }
            set
            {
                deviceName = value;
                OnPropertyChanged("DeviceName");
            }
        }
    }
}
