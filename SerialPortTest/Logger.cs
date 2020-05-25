

namespace SerialPortTest
{
    interface ILogger
    {
        void WriteLog(string s);
        void Attach(ILoggerLIstener listener);
    }

    interface ILoggerLIstener
    {
        void Update(string s);
    }
}