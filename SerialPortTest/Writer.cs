using System.Collections.Generic;
using System.IO.Ports;

namespace SerialPortTest
{
    interface IWriter
    {
        void Write(string s);
        void Attach(IWriterListener listener);
    }

    interface IWriterListener
    {
        void Update(string s);
    }

    class SerialPortWriter : IWriter
    {
        List<IWriterListener> writerListeners;

        public void Write(string s)
        {
            foreach (IWriterListener writerListener in writerListeners)
                writerListener.Update(s);
        }

        public void Attach(IWriterListener listener)
        {
            writerListeners.Add(listener);
        }
    }

    class SerialPortWriterListener : IWriterListener
    {
        SerialPort serialPort;

        public SerialPortWriterListener()
        {
            serialPort = new SerialPort();
        }

        public SerialPortWriterListener(SerialPort _serialPort)
        {
            serialPort = _serialPort;
        }

        public void Update(string s)
        {
            serialPort.WriteLine(s);   
        }
    }
}