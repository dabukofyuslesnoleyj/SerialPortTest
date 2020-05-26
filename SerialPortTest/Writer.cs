using System.IO.Ports;

namespace SerialPortTest
{
    interface IWriter
    {
        void write(string s);
    }

    class SerialPortWriter : IWriter
    {
        SerialPort serialPort;
        public void write(string s)
        {

        }
    }
}