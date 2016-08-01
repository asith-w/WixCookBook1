using System;
using Microsoft.Deployment.WindowsInstaller;

namespace _30_TimeZoneCustomAction
{
    public class CustomActions
    {
        [CustomAction]
        public static ActionResult GetTimeZone(Session session)
        {
            string timeZoneName = TimeZone.CurrentTimeZone.StandardName;
            // store the time zone in a property
            session["TIME_ZONE"] = timeZoneName;
            return ActionResult.Success;
        }
    }
}
