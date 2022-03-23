using EnofiFrameAPI.Models;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Web;
using System.Xml.Linq;

namespace EnofiFrameAPI
{
    public class LocationHelper
    {
        
        public void CallSilentMessage(string phonenumber)
        {
            SerialPort _serialPort;
            _serialPort = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);
            _serialPort.Handshake = Handshake.None;
            _serialPort.ReadTimeout = 400;
            _serialPort.WriteTimeout = 400;
            try
            {
                _serialPort.Open();
                if (_serialPort.IsOpen)
                {
                    _serialPort.WriteLine("AT+CMGF=0" + Environment.NewLine);
                    Thread.Sleep(100);

                    _serialPort.WriteLine("AT+CMGS=" + 17 + Environment.NewLine);
                    Thread.Sleep(100);

                    var pduMsg = "00B1000B91" + SwapPosition(phonenumber) + "4000AA03201008";
                    _serialPort.WriteLine(pduMsg + char.ConvertFromUtf32(26));
                    Thread.Sleep(500);

                    var sdsd = _serialPort.ReadExisting();
                }
                _serialPort.Close();
                _serialPort.Dispose();
            }
            catch { if (_serialPort.IsOpen) _serialPort.Close(); _serialPort.Dispose(); }
            
        }

        private string SwapPosition(string _originalMsg)
        {
            var msg = _originalMsg.Substring(1);
            msg = "84" + msg + "F";
            string returnStr = "";
            for(int i = 0; i < msg.Count(); i++)
            {
                if (i % 2 == 0)
                    returnStr += msg[i + 1];
                else
                    returnStr += msg[i - 1];
            }
            return returnStr;
        }

    }
}