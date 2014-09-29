using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz;
using Quartz.Impl;

namespace TestQuartz
{
    /// <summary>
    /// For email job
    /// </summary>
   public class EmailJob:IJob
    {
        /// <summary>
        /// Excutes the specified context.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <exception cref="System.NotImplementedException"></exception>
       public void Execute(IJobExecutionContext context) 
       {
           // TODO: Implement this
           Console.WriteLine("Hello World!");
       }
    }
}
