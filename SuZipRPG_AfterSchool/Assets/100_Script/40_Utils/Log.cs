using UnityEngine;

namespace _100_Script._40_Utils
{
    public static class Log
    {
        public static void Message(string message, LogCategory logcategory)
        {
            // if(Manager.Log.IsLogOn == false)
            //     return;
            
            // if(Manager.Log.IsLogCategoryOn[(int)logcategory])
            //     return;
            
            
            
            Debug.Log(message);
        }

        public static void Error(string message)
        {
            Debug.LogError(message);
        }
    }
}
