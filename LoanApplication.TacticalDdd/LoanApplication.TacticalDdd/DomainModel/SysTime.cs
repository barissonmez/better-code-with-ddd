using System;

namespace LoanApplication.TacticalDdd.DomainModel
{
    public class SysTime
    {
        public static Func<DateTime> CurrentTimeProvider { get; set; } = () => DateTime.Now;
        
        public static DateTime Now() => CurrentTimeProvider();
    }
}