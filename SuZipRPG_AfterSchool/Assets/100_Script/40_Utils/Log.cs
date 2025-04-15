#if LOG

using UnityEngine;

public class Log
{
    //Log.Message("로그");

    public static void Message(string message, LogCategory logCategory)
    {
        if(Manager.Log.IsLogOn == false)
        {
            return;
        }

        if (Manager.Log.IsLogCategoryOn[(int)logCategory] == false)
        {
            return;
        }

        Debug.Log(message);
    }
}

#endif