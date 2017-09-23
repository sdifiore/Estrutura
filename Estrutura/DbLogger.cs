using System;

namespace Estrutura
{
    public class DbLogger
    {
        public static void Log(string reason, string message)
        {
            var context = new DataContext();
            var log = new LogData
            {
                Timestamp = DateTime.Now,
                Reason = reason,
                Message = message
            };

            context.LogData.Add(log);
            context.SaveChanges();

            for (int i = 0; i < 10; i++)
            {
                Console.Beep();
            }
        }
    }
}
