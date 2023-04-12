using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fabric_metod
{
    public interface ILogger
{
    void Log(string message);
}

public class FileLogger : ILogger
{
    private readonly string _logFilePath;

    public FileLogger(string logFilePath)
    {
        _logFilePath = logFilePath;
    }

    public void Log(string message)
    {
        using (StreamWriter writer = File.AppendText(_logFilePath))
        {
            writer.WriteLine(message);
        }
    }
}

public class RichTextBoxLogger : ILogger
{
    private readonly RichTextBox _logTextBox;

    public RichTextBoxLogger(RichTextBox logTextBox)
    {
        _logTextBox = logTextBox;
    }

    public void Log(string message)
    {
        _logTextBox.AppendText(message + Environment.NewLine);
    }
}

public enum LoggerType
{
    File,
    RichTextBox
}

public static class LoggerFactory
{
    public static ILogger CreateLogger(LoggerType loggerType, string logFilePath = null, RichTextBox logTextBox = null)
    {
        switch (loggerType)
        {
            case LoggerType.File:
                return new FileLogger(logFilePath);
            case LoggerType.RichTextBox:
                return new RichTextBoxLogger(logTextBox);
            default:
                throw new NotSupportedException("Logger type not supported");
        }
    }
}
}
