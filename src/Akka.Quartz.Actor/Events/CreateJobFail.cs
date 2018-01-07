using System;
using Quartz;

namespace Akka.Quartz.Actor.Events
{
    /// <summary>
    ///     Create job fail event
    /// </summary>
    public class CreateJobFail : JobEvent
    {
        public CreateJobFail(JobKey jobKey, TriggerKey triggerKey, Exception reason) : base(jobKey, triggerKey)
        {
            Reason = reason;
        }

        /// <summary>
        ///     Fail reason
        /// </summary>
        public Exception Reason { get; private set; }

        public override string ToString()
        {
            return $"Create job {JobKey} with trigger {TriggerKey} fail. With reason {Reason}";
        }
    }
}