using Quartz;
using QuartzNET;


//===============================  Carts Quartz =====================================
#region Infinit_ Task
//var job = JobBuilder.Create<BackgroundJob>()
//    .WithIdentity(name: "BackgroundJob", group: "JobGroup")
//    .Build();

//var trigger = TriggerBuilder.Create()
//    .WithIdentity(name: "RepeatingTrigger", group: "TriggerGroup")
//    .WithSimpleSchedule(o => o
//        .RepeatForever()
//        .WithIntervalInSeconds(5))
//    .Build();

//var schedulerFactory = SchedulerBuilder.Create().Build();
//var scheduler = await schedulerFactory.GetScheduler();
//await scheduler.Start();

//await scheduler.ScheduleJob(job, trigger);
//Console.ReadKey();






//using System;
//using System.Threading.Tasks;
//using Quartz;
//using Quartz.Impl;

//class Program
//{
//    static async Task Main(string[] args)
//    {
//        var job = JobBuilder.Create<BackgroundJob>()
//            .WithIdentity(name: "BackgroundJob", group: "JobGroup")
//            .Build();

//        var trigger = TriggerBuilder.Create()
//            .WithIdentity(name: "RepeatingTrigger", group: "TriggerGroup")
//            .WithSimpleSchedule(o => o
//                .RepeatForever()
//                .WithIntervalInSeconds(5))
//            .Build();


//        var schedulerFactory = new StdSchedulerFactory();
//        var scheduler = await schedulerFactory.GetScheduler();
//        await scheduler.Start();

//        await scheduler.ScheduleJob(job, trigger);

//        Console.WriteLine("Press any key to exit...");
//        Console.ReadKey();
//    }
//}

//public class BackgroundJob : IJob
//{
//    public async Task Execute(IJobExecutionContext context)
//    {
//        await Console.Out.WriteLineAsync("Executing background job");
//    }
//}


#endregion

//=============================== Passing data to Quartztask =====================================
#region Passing_data_quartzLibarary

//var job = JobBuilder.Create<BackgroundJob>()
//    .WithIdentity(name: "BackgroundJob", group: "JobGroup")
//    //_____ send value to excecuton method _____
//    .UsingJobData("OutPutMessage", "Dill Dill Pakistan Jaan jan Pakistan")
//    .UsingJobData("isActive", true)
//    .Build();

//var trigger = TriggerBuilder.Create()
//    .WithIdentity(name: "RepeatingTrigger", group: "TriggerGroup")
//    .WithSimpleSchedule(o => o
//        .RepeatForever()
//        .WithIntervalInSeconds(5))
//    .Build();

//var schedulerFactory = SchedulerBuilder.Create().Build();
//var scheduler = await schedulerFactory.GetScheduler();
//await scheduler.Start();

//await scheduler.ScheduleJob(job, trigger);
//Console.ReadKey();
#endregion


//=============================== Daily+time  to Quartztask =====================================
#region Daily+time spacifice
//var job = JobBuilder.Create<BackgroundJob>()
//    .WithIdentity(name: "BackgroundJob", group: "JobGroup")
//    //_____ send value to execution method _____
//    .UsingJobData("OutPutMessage", "Dill Dill Pakistan Jaan jan Pakistan")
//    .UsingJobData("isActive", true)
//    .Build();

//var trigger = TriggerBuilder.Create()
//    .WithIdentity(name: "RepeatingTrigger", group: "TriggerGroup")
//    .WithDailyTimeIntervalSchedule(s =>
//        //s.WithIntervalInMinutes(20)
//        s.WithIntervalInSeconds(2)
//         .OnEveryDay()
//         .StartingDailyAt(TimeOfDay.HourMinuteAndSecondOfDay(2, 40, 0)) //(9, 0, 0)) // Start at 9:00 am
//         .EndingDailyAt(TimeOfDay.HourMinuteAndSecondOfDay(2, 40, 40)) //(22, 0, 0)) // End at 10:00 pm
//    )
//    .Build();

//var schedulerFactory = SchedulerBuilder.Create().Build();
//var scheduler = await schedulerFactory.GetScheduler();
//await scheduler.Start();

//await scheduler.ScheduleJob(job, trigger);
//Console.ReadKey();

#endregion


//=============================== spacifice Day  to Quartztask =====================================
#region spacificeDay
var job = JobBuilder.Create<BackgroundJob>()
    .WithIdentity(name: "BackgroundJob", group: "JobGroup")
    //_____ send value to execution method _____
    .UsingJobData("OutPutMessage", "Dill Dill Pakistan Jaan jan Pakistan")
    .UsingJobData("isActive", true)
    .Build();

DateTime startDate = new DateTime(2024, 3, 26, 9, 0, 0); // Set your desired start date and time

var trigger = TriggerBuilder.Create()
    .WithIdentity(name: "RepeatingTrigger", group: "TriggerGroup")
    .StartAt(startDate) // Set the start date and time
    .WithSimpleSchedule(s =>
        s.WithIntervalInMinutes(20)
         .RepeatForever()
    )
    .Build();

var schedulerFactory = SchedulerBuilder.Create().Build();
var scheduler = await schedulerFactory.GetScheduler();
await scheduler.Start();

await scheduler.ScheduleJob(job, trigger);
Console.ReadKey();
#endregion