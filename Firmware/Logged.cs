using System;

namespace Firmware
{
    public class Logged
    {
        public enum EventType { Critical, Error, Warning, Info, Debug }
        static public void LogEvent(string str, EventType e=EventType.Info )
        {
            string pfx = "??";
            switch(e) {
                case EventType.Critical:
                    pfx = "!! CRITICAL ERROR !!\n";
                    break;
                case EventType.Error:
                    pfx = "E!";
                    break;
                case EventType.Warning:
                    pfx = "w:";
                    break;
                case EventType.Info:
                    pfx = "i:";
                    break;
                case EventType.Debug:
#if !DEBUG
                    return;
#endif
                    pfx = ".:";
                    break;
            }
            Console.WriteLine($"{pfx} {str}");
            if (e == EventType.Critical) {
                throw new Exception($"You really thought you'd get away with just logging it?\n{str}");
            }
        }
    }
}