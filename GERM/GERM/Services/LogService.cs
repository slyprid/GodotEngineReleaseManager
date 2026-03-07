using System.Diagnostics;

namespace GERM.Services
{
    public class LogService
        : ILogService
    {
        public void Write(string message)
        {
            Debug.WriteLine(message);
        }
    }
}