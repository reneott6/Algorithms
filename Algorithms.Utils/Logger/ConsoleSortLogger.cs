using System;
using System.Collections.Generic;
using System.Linq;
using Algorithms.Utils.Extensions;

namespace Algorithms.Utils.Logger
{
    public interface ISortLogger
    {
        void LogInitialList<T>(IList<T> src);
        void LogResultList<T>(IList<T> src);

        void LogOuterLoopBegin<T>(IList<T> src);
        void LogOuterLoopEnd<T>(IList<T> src);

        void LogInnerLoopBegin<T>(IList<T> src);
        void LogInnerLoopEnd<T>(IList<T> src);

        void LogSwap<T>(T fst, T snd, int indendation = 0);
    }

    public class ConsoleSortLogger : ISortLogger
    {
        public void LogInitialList<T>(IList<T> src) => LogListWithPrefix("INITIAL", src);
        public void LogResultList<T>(IList<T> src) => LogListWithPrefix("RESULT", src);

        public void LogOuterLoopBegin<T>(IList<T> src) => LogListWithPrefix("OUTER LOOP BEGIN", src, 1);
        public void LogOuterLoopEnd<T>(IList<T> src) => LogListWithPrefix("OUTER LOOP END", src, 1);

        public void LogInnerLoopBegin<T>(IList<T> src) => LogListWithPrefix("INNER LOOP BEGIN", src, 2);
        public void LogInnerLoopEnd<T>(IList<T> src) => LogListWithPrefix("INNER LOOP END", src, 2);

        public void LogSwap<T>(T fst, T snd, int indendation = 0) => Write($"Swap: {fst} <--> {snd}", indendation);

        private static void LogListWithPrefix<T>(string text, IList<T> src, int indentation = 0) => Write($"{text}: {src.ToLogString()}", indentation);
        private static void Write(string text, int indentation = 0) => Console.WriteLine($"{Enumerable.Repeat(' ', 2 * indentation)}{text}");
    }
}