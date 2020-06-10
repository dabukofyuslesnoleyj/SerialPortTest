

using System.Collections.Generic;

namespace SerialPortTest
{
    interface ILogger
    {
        void WriteLog(string s);
        void Attach(ILoggerListener listener);
    }

    interface ILoggerListener
    {
        void Update(string s);
    }

    class Logger : ILogger
    {
        List<string> logs;
        List<ILoggerListener> loggerListeners;

        public void WriteLog(string s)
        {
            logs.Add(s);

            foreach (ILoggerListener loggerLIstener in loggerListeners)
                loggerLIstener.Update(s);
        }

        public void Attach(ILoggerListener listener)
        {
            loggerListeners.Add(listener);
        }
    }

    class FileWriterLoggerListener : ILoggerListener
    {
        public void Update(string s)
        {

        }
    }
}