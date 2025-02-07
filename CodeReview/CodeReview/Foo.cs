using System.Runtime.CompilerServices;

namespace CodeReview
{
    /// <summary>
    /// A generic class to do operations.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Foo<T>
    {
        protected static T? StartValue
        {
            get;
            private set;
        }        
        public Foo(T startValue)
        {
            StartValue = startValue;
        }
        /// <summary>
        /// Returns (arr1+arg2)/Start value
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        /// <returns></returns>
        public static int DoCalc(object arg1, T arg2)
        {
            return Convert.ToInt32(arg1) + Convert.ToInt32(arg2) / Convert.ToInt32(StartValue);
        }
        public static int HigherOrderCalculation(Func<int, int, int> func, int one, int two)
        {            
            return func(one, two);
        }
        /// <summary>
        /// Writes a log to console.
        /// </summary>
        /// <param name="message">Message to be written on the console.</param>
        public void LogToConsole(string message)
        {
            Console.WriteLine(message);
        }
        /// <summary>
        /// Writes message to the log file.
        /// </summary>
        /// <param name="msg">Message to log.</param>
        /// <returns></returns>
        public async Task LogtoFileAsync(string msg)
        {
            await File.AppendAllTextAsync($"logfile-{DateTime.Now.ToString("yyyy-MM-dd")}.log", msg);
        }
    }
}
