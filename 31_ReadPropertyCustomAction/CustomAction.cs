using Microsoft.Deployment.WindowsInstaller;

namespace _31_ReadPropertyCustomAction
{
    public class CustomActions
    {
        [CustomAction]
        public static ActionResult ReadProperty(Session session)
        {
            // Try to read a property called USERNAME.
            // This will fail!
            //string userName = session["USERNAME"];
            string userName = session.CustomActionData["USERNAME"];
            session.Log("Username is " + userName);
            return ActionResult.Success;
        }
    }
}
