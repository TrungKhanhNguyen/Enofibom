using EnofiFrameAPI.Models;
using GsmComm.GsmCommunication;
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
        
        public LocationHelper()
        {
            
        }
        private string GetMessageStorage()
        {
            string storage = string.Empty;
            storage = PhoneStorageType.Sim;
            if (storage.Length == 0)
                throw new ApplicationException("Unknown message storage.");
            else
                return storage;
        }

        public string callATD()
        {
            SerialPort _serialPort;
            _serialPort = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);
            _serialPort.Handshake = Handshake.None;
            _serialPort.ReadTimeout = 400;
            _serialPort.WriteTimeout = 400;
            try
            {
                
                if (_serialPort.IsOpen)
                {
                    _serialPort.Close();
                    _serialPort.Dispose();
                    Thread.Sleep(200);
                }
                _serialPort.Open();
                if (_serialPort.IsOpen)
                {
                    _serialPort.WriteLine("AT+CUSD=1,\"*101#\",15" + Environment.NewLine);
                    Thread.Sleep(5000);
                    var sms = _serialPort.ReadExisting();
                    if (_serialPort.IsOpen)
                        _serialPort.Close();
                    _serialPort.Dispose();
                    return sms;
                }
                if (_serialPort.IsOpen)
                    _serialPort.Close();
                _serialPort.Dispose();
                return "";
            }
            catch
            {
                if (_serialPort.IsOpen)
                    _serialPort.Close();
                _serialPort.Dispose();
                return "";
            }

        }

        public string CallSilentMessageWithDelivery(string phonenumber)
        {
            SerialPort _serialPort;
            _serialPort = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);
            _serialPort.Handshake = Handshake.None;
            _serialPort.ReadTimeout = 400;
            _serialPort.WriteTimeout = 400;
            try
            {
                if (_serialPort.IsOpen)
                {
                    _serialPort.Close();
                    _serialPort.Dispose();
                    Thread.Sleep(200);
                }
                _serialPort.Open();
                if (_serialPort.IsOpen)
                {
                    _serialPort.WriteLine("AT+CNMI=2,1,0,1,0" + Environment.NewLine);
                    Thread.Sleep(200);

                    _serialPort.WriteLine("AT+CSMP=49,167,0,0" + Environment.NewLine);
                    Thread.Sleep(200);

                    _serialPort.WriteLine("AT+CMGF=0" + Environment.NewLine);
                    Thread.Sleep(200);

                    _serialPort.WriteLine("AT+CMGS=" + 17 + Environment.NewLine);
                    Thread.Sleep(200);

                    var pduMsg = "00B1000B91" + SwapPosition(phonenumber) + "4000AA03201008";
                    _serialPort.WriteLine(pduMsg + char.ConvertFromUtf32(26));
                    Thread.Sleep(4000);

                    var sdsd = _serialPort.ReadExisting();
                    return sdsd;
                }
                if (_serialPort.IsOpen)
                    _serialPort.Close();
                _serialPort.Dispose();
                return "";
            }
            catch
            {
                if (_serialPort.IsOpen)
                    _serialPort.Close();
                _serialPort.Dispose();
                return "";
            }
        }

        public string CallSilentMessage(string phonenumber)
        {
            SerialPort _serialPort;
            _serialPort = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);
            _serialPort.Handshake = Handshake.None;
            _serialPort.ReadTimeout = 400;
            _serialPort.WriteTimeout = 400;
            try
            {
                if (_serialPort.IsOpen)
                {
                    _serialPort.Close();
                    _serialPort.Dispose();
                    Thread.Sleep(200);
                }
                _serialPort.Open();
                if (_serialPort.IsOpen)
                {

                    _serialPort.WriteLine("AT+CMGF=0" + Environment.NewLine);
                    Thread.Sleep(200);

                    _serialPort.WriteLine("AT+CMGS=" + 17 + Environment.NewLine);
                    Thread.Sleep(200);

                    var pduMsg = "00B1000B91" + SwapPosition(phonenumber) + "4000AA03201008";
                    _serialPort.WriteLine(pduMsg + char.ConvertFromUtf32(26));
                    Thread.Sleep(1000);

                    var sdsd = _serialPort.ReadExisting();
                    return sdsd;
                }
                if(_serialPort.IsOpen)
                    _serialPort.Close();
                _serialPort.Dispose();
                return "";
            }
            catch {
                if (_serialPort.IsOpen)
                    _serialPort.Close();
                _serialPort.Dispose();
                return "";
            }
        }

        public string SwapPosition(string _originalMsg)
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