using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartzNET
{
    internal class BackgroundJob : IJob
    {
        //__________ Excecution _____________
        //excecution is method in which we write our job..  which execute when task run
        //ok got it
        public async Task Execute(IJobExecutionContext context)
        {
            //________ Simple excecution ____
            //await Console.Out.WriteLineAsync("Executing background job");

            //________ Geting value form context ____
            var jobdataMap = context.MergedJobDataMap;
            var isActive = jobdataMap.GetBoolean("isActive");

            if (isActive)
            {
                var OutPutMessage = jobdataMap.GetString("OutPutMessage");
                await Console.Out.WriteLineAsync(OutPutMessage);
            }
            else
            {
                await Console.Out.WriteLineAsync("Pakistan zinedabad");
            }

            
        }
    }
}
