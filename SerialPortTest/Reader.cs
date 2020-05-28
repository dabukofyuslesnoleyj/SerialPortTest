using System.Collections.Generic;
using System.IO.Ports;
using System.Xml.Linq;

namespace SerialPortTest
{
    interface IReader
    {
        string read();
        void Attach(IReaderListener listener);
        void NotifyAll(string s);
    }

    interface IReaderListener
    {
        void update(string s);
    }

    class SerialPortReader : IReader
    {
        SerialPort serialPort;
        List<IReaderListener> readerListeners;

        public SerialPortReader()
        {
            serialPort = new SerialPort();
        }

        public string read()
        {
            return "";
        }

        public void Attach(IReaderListener listener)
        {
            readerListeners.Add(listener);
        }

        public void NotifyAll(string s)
        {
            foreach (IReaderListener readerListener in readerListeners)
                readerListener.update(s);
        }
    }
}