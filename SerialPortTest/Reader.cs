using System.IO.Ports;

namespace SerialPortTest
{
    interface IReader
    {
        string read();
    }

    class SerialPortReader : IReader
    {
        SerialPort serialPort;

        public SerialPortReader()
        {
            serialPort = new SerialPort();
        }

        public string read()
        {
            return "";
        }
    }
}