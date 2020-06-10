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
        IWriter serialPortWriter;
        IReader serialPortReader;
        StringReaderListener serialPortMessage;
        bool _continue;

        public SerialPortController(SerialPort _serialPort)
        {
            _continue = true;
            serialPort = _serialPort;
            serialPortWriter = new SerialPortWriter();
            serialPortReader = new SerialPortReader(_serialPort);

            serialPortReader.Attach(serialPortMessage);
            serialPortWriter.Attach(new SerialPortWriterListener(_serialPort));
        }

        public void ReadSerialPort()
        {
            serialPortReader.Read();
        }

        public void WriteSerialPort(string s)
        {
            serialPortWriter.Write(s);
        }
    }
}