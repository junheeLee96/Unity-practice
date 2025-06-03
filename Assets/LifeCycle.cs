using System;
using UnityEngine;

namespace Example
{
    public class LifeCycle : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetButtonDown("Jump"))
            {
                Debug.Log("Jump!");
            }

            if (Input.GetButton("Jump"))
            {
                Debug.Log("Jumping!");
                
            }

            if (Input.GetButtonUp("Jump"))
            {
                Debug.Log("Jump! Dowm");
            }
        }
    }
}