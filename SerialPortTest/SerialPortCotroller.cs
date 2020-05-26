using System.IO.Ports;

namespace SerialPortTest
{
    interface IController
    {

    }

    class SerialPortController : IController
    {
        SerialPort serialPort;
        IWriter seralPortWriter;
        IReader serialPortReader;
    }
}