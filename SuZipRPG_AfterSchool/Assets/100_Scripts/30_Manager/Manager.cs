using UnityEngine;

namespace _100_Scripts._30_Manager
{
    public partial class Manager : MonoBehaviour
    {
        private void Start()
        {
            SetDataManager();
        }
        
        public static DataManager Data {get; private set;}

        private void SetDataManager()
        {
            Data = transform.GetComponentInChildren<DataManager>();
            Data.Initialize();
        }
    }
}
