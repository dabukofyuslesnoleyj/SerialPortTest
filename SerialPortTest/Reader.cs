using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SerialPortTest
{
    interface IReader
    {
        void Read();
        void Attach(IReaderListener listener);
        void NotifyAll(string s);
    }

    interface IReaderListener
    {
        void Update(string s);
    }

    class SerialPortReader : IReader
    {
        SerialPort serialPort;
        List<IReaderListener> readerListeners;
        public bool _continue;

        public SerialPortReader()
        {
            serialPort = new SerialPort();
            _continue = true;
        }

        public SerialPortReader(SerialPort _serialPort)
        {
            serialPort = _serialPort;
            _continue = true;
        }

        public void Read()
        {
            while (_continue)
            {
                try
                {
                    string s = serialPort.ReadLine();
                    NotifyAll(s);
                }
                catch (TimeoutException e)
                {
                    NotifyAll(e.ToString());
                }
            }
        }

        public void Attach(IReaderListener listener)
        {
            readerListeners.Add(listener);
        }

        public void NotifyAll(string s)
        {
            foreach (IReaderListener readerListener in readerListeners)
                readerListener.Update(s);
        }
    }

    class TextBoxReaderListener : IReaderListener
    {
        TextBox textbox;
        public void Update(string s)
        {
            textbox.AppendText(s + "\n");
        }
    }
}