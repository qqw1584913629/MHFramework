using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class TimeInfo: Singleton<TimeInfo>
{
    private int timeZone;
        
    public int TimeZone
    {
        get
        {
            return this.timeZone;
        }
        set
        {
            this.timeZone = value;
            dt = dt1970.AddHours(TimeZone);
        }
    }
        
    private DateTime dt1970;
    private DateTime dt;
        
    // ping消息会设置该值，原子操作
    public long ServerMinusClientTime { private get; set; }

    public long FrameTime { get; private set; }

    protected override async void Awake()
    {
        base.Awake();
        this.dt1970 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        this.dt = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        this.FrameTime = this.ClientNow();
    }
    // 获取下一个每日重置时间（早上8点）
    long GetNextDailyResetTime()
    {
        DateTime nextReset = DateTime.Today.AddHours(8); // 今天的早上8点
        if (DateTime.Now >= nextReset) // 如果已经过了今天的8点，则重置时间为明天的8点
            nextReset = nextReset.AddDays(1);
        return Transition(nextReset);
    }
    // 获取下一个每周重置时间（下一周的早上8点）
    long GetNextWeeklyResetTime()
    {
        DateTime today = DateTime.Today;
        int daysUntilNextMonday = ((int)DayOfWeek.Monday - (int)today.DayOfWeek + 7) % 7;
        DateTime nextReset = today.AddDays(daysUntilNextMonday).AddHours(8);
        // 如果当前时间已经超过今天的8点，并且今天是周一，跳到下周一
        if (daysUntilNextMonday == 0 && DateTime.Now >= today.AddHours(8))
            nextReset = nextReset.AddDays(7);
        return Transition(nextReset);
    }

    // 获取下一个每月重置时间（下个月的1号早上8点）
    long GetNextMonthlyResetTime()
    {
        DateTime nextReset = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(1).AddHours(8);
        return Transition(nextReset);
    }

    public void Update()
    {
        // 赋值long型是原子操作，线程安全
        this.FrameTime = this.ClientNow();
    }
    /// <summary> 
    /// 根据时间戳获取时间 
    /// </summary>  
    public DateTime ToDateTime(long timeStamp)
    {
        return dt.AddTicks(timeStamp * 10000);
    }
    // 线程安全
    public long ClientNow()
    {
        return (DateTime.UtcNow.Ticks - this.dt1970.Ticks) / 10000;
    }
    public long Transition(DateTime d)
    {
        return (d.Ticks - dt.Ticks) / 10000;
    }
    
    public string ConvertSecondsToFormattedTime(int totalSeconds)
    {
        var timeSpan = TimeSpan.FromSeconds(totalSeconds);
        return timeSpan.ToString(totalSeconds >= 3600 ? @"hh\:mm\:ss" : @"mm\:ss");
    }
}