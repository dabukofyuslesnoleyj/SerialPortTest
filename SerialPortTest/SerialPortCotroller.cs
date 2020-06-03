using System.IO.Ports;

namespace SerialPortTest
{
    interface IController
    {
        void ReadSerialPort();
        void WriteSerialPort(string s);
    }

    class SerialPortController : IController
    {
        SerialPort serialPort;
        IWriter seralPortWriter;
        IReader serialPortReader;
        bool _continue;

        public void ReadSerialPort()
        {

        }

        public void WriteSerialPort(string s)
        {

        }
    }
}