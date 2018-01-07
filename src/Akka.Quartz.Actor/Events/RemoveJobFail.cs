using System;
using Quartz;

namespace Akka.Quartz.Actor.Events
{
    /// <summary>
    ///     Remove job fail
    /// </summary>
    public class RemoveJobFail : JobEvent
    {
        public RemoveJobFail(JobKey jobKey, TriggerKey triggerKey, Exception reason) : base(jobKey, triggerKey)
        {
            Reason = reason;
        }

        public Exception Reason { get; private set; }

        public override string ToString()
        {
            return $"Remove job {JobKey} with trigger {TriggerKey} fail. With reason {Reason}";
        }
    }
}