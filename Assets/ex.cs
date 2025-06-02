using UnityEngine;

namespace Example
{
    public class ex : MonoBehaviour
    {
        void Start()
        {
            Debug.Log("Hello Unity");
            int level = 5;
            float strength = 15.5f;
            string playerName = "Lee";
            bool isFullLevel = false;
            
            Debug.Log(level);
            Debug.Log(strength);
            Debug.Log(playerName);
            Debug.Log(isFullLevel);
        }
    }
}