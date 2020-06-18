

using System.Collections.Generic;
using System.Windows.Forms;

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

        public Logger()
        {
            logs = new List<string>();
            loggerListeners = new List<ILoggerListener>();
        }

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

    class TextBoxLoggerListener : ILoggerListener
    {
        TextBox textBox;

        public void Update(string s)
        {

        }
    }
}