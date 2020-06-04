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

        public SerialPortController(SerialPort _serialPort)
        {
            serialPort = _serialPort;
            seralPortWriter = new SerialPortWriter();
            serialPortReader = new SerialPortReader(_serialPort);
            seralPortWriter.Attach(new SerialPortWriterListener(_serialPort));
        }

        public void ReadSerialPort()
        {

        }

        public void WriteSerialPort(string s)
        {

        }
    }
}