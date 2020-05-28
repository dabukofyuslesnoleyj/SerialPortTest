

using System.Collections.Generic;

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

    class Logger : ILogger
    {
        List<string> logs;
        List<ILoggerLIstener> loggerListeners;

        public void WriteLog(string s)
        {
            logs.Add(s);

            foreach (ILoggerLIstener loggerLIstener in loggerListeners)
                loggerLIstener.Update(s);
        }

        public void Attach(ILoggerLIstener listener)
        {
            loggerListeners.Add(listener);
        }
    }
}