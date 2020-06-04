using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;

namespace Comm
{
    public class Serial
    {
        private SerialPort sp;

        public Serial()
        {
            sp = new SerialPort();
            sp.DataReceived += Sp_DataReceived;
        }

        public delegate void SerialRecvDataDel(byte[] data, int size);
        public event SerialRecvDataDel SerialRecvData;

        private void Sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(40);
            int num = this.sp.BytesToRead;
            byte[] dat = new byte[num];

            int n = this.sp.Read(dat, 0, num);

            SerialRecvData?.Invoke(dat, n);
        }

        public string[] GetPorts()
        {
            return SerialPort.GetPortNames();
        }

        public bool Open(string name, int baudrate, int parity, int dataBits, int stopBits, out string info)
        {
            this.sp.PortName = name;
            this.sp.BaudRate = baudrate;
            this.sp.DataBits = dataBits;

            switch (parity)
            {
                case 0:
                    this.sp.Parity = Parity.None;
                    break;

                case 1:
                    this.sp.Parity = Parity.Odd;
                    break;

                case 2:
                    this.sp.Parity = Parity.Even;
                    break;

                default:
                    this.sp.Parity = Parity.None;
                    break;
            }

            switch (stopBits)
            {
                case 0:
                    this.sp.StopBits = StopBits.One;
                    break;

                case 1:
                    this.sp.StopBits = StopBits.OnePointFive;
                    break;

                case 2:
                    this.sp.StopBits = StopBits.Two;
                    break;

                default:
                    this.sp.StopBits = StopBits.One;
                    break;
            }

            try
            {
                info = "";
                this.sp.Open();
                return true;
            }
            catch (Exception ex)
            {
                info = ex.Message;
                return false;
            }
        }

        public void Close()
        {
            try
            {
                this.sp.Close();
            }
            catch (Exception ex)
            {
                return;
            }
        }

        public void SendData(byte[] dat)
        {
            try
            {
                this.sp.Write(dat, 0, dat.Length);
            }
            catch (Exception ex)
            {
                return;
            }
        }
    }
}
