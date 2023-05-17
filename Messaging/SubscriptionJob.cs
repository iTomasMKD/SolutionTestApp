using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Concurrency;
using System.Text;
using System.Threading.Tasks;
using static Quartz.Logging.OperationName;


namespace Messaging
{
    public class SubscriptionJob : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            // Code to retrieve active subscriptions from the database
            // ...

            // Code to send email message requests to print-distribution companies
            // ...
        }

        // Create a job and trigger
        IJobDetail job = JobBuilder.Create<SubscriptionJob>()
            .WithIdentity("subscriptionJob", "group1")
            .Build();

        ITrigger trigger = TriggerBuilder.Create()
            .WithIdentity("subscriptionTrigger", "group1")
            .WithCronSchedule("0 0 12 1 * ?")
            .Build();

        // Schedule the job using the trigger
        Scheduler.ScheduleJob(job, trigger);
    }
}

