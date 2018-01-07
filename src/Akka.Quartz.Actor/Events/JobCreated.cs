using Quartz;

namespace Akka.Quartz.Actor.Events
{
    /// <summary>
    ///     Job created event
    /// </summary>
    public class JobCreated : JobEvent
    {
        public JobCreated(JobKey jobKey, TriggerKey triggerKey) : base(jobKey, triggerKey)
        {
        }


        public override string ToString()
        {
            return $"{JobKey} with trigger {TriggerKey} has been created.";
        }
    }

    /// <summary>
    ///     Job removed event
    /// </summary>
    public class JobRemoved : JobEvent
    {
        public JobRemoved(JobKey jobKey, TriggerKey triggerKey) : base(jobKey, triggerKey)
        {
        }


        public override string ToString()
        {
            return $"{JobKey} with trigger {TriggerKey} has been removed.";
        }
    }
}