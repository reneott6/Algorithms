using System;
using System.Collections.Generic;
using Algorithms.Utils.Extensions;

namespace Algorithms.Utils.Logger
{
    public interface ILogger
    {
        void LogList<T>(IList<T> src);
        void LogList<T>(string text , IList<T> src);
        void Log(string src);
    }

    public class ConsoleLogger : ILogger
    {
        public void LogList<T>(IList<T> src)
        {
            Console.WriteLine($"{src.ToLogString()}");
        }

        public void LogList<T>(string text, IList<T> src)
        {
            Console.WriteLine($"{text}: {src.ToLogString()}");
        }

        public void Log(string src)
        {
            Console.WriteLine(src);
        }
    }
}
