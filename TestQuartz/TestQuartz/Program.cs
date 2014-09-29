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


         /// <summary>
         /// Initializes the <see cref="Program"/> class.
         /// </summary>
         static Program()
         {
             SchedulerFactory = new SchedulerFactory();
             Scheduler = SchedulerFactory.GetScheduler();
         }

         /// <summary>
         /// Defines the entry point of the application.
         /// </summary>
         /// <param name="args">The arguments.</param>
         static void Main(string[] args)
        {
            Scheduler.Start();
            
        }

         private static void CreatJob() 
         {
          _emailJobDetail =JobBuilder.Create
         }
    }
}
