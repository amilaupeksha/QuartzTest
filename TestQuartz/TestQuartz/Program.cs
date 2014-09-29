using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz;
using Quartz.Impl;

namespace TestQuartz
{
     public class Program
    {
         private static readonly ISchedulerFactory SchedulerFactory;
         private static readonly IScheduler Scheduler;
         private static IJobDetail _emailJobDetail;

         /// <summary>
         /// Initializes the <see cref="Program"/> class.
         /// </summary>
         static Program()
         {
             SchedulerFactory = new StdSchedulerFactory();
             Scheduler = SchedulerFactory.GetScheduler();
         }

         /// <summary>
         /// Defines the entry point of the application.
         /// </summary>
         /// <param name="args">The arguments.</param>
         static void Main(string[] args)
        {
            Scheduler.Start();
            CreatJob();
            ScheduledJob();
        }

         /// <summary>
         /// Creats the job.
         /// </summary>
         private static void CreatJob() 
         {
             _emailJobDetail = JobBuilder.Create<EmailJob>().WithIdentity("meee").Build();
         }

         /// <summary>
         /// Scheduleds the job.
         /// </summary>
         private static void ScheduledJob() 
         {
             ITrigger trigger = TriggerBuilder.Create().
                    WithDescription("every ten seconds").
                     WithSimpleSchedule(x=>x.WithIntervalInSeconds(10).RepeatForever()).Build();

             Scheduler.ScheduleJob(_emailJobDetail, trigger);
         }
    }
}
