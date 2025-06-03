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

            // if (Input.GetButton("Jump"))
            if (Input.GetButton("Horizontal"))
            {
                Debug.Log("Horizontal"+Input.GetAxis("Horizontal"));
                
                // 수평, 수직 버튼 입력을 받으면 float 리턴
                
                
            }

            if (Input.GetButtonUp("Jump"))
            {
                Debug.Log("Jump! Dowm");
            }
        }
    }
}