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
                // 수평, 수직 버튼 입력을 받으면 float 리턴
                // Debug.Log("Horizontal"+Input.GetAxis("Horizontal"));
                
                // GetAxis와 달리 가중치가 없음. 가만히 잇으면 0, 움직이면 1
                Debug.Log("Horizontal"+Input.GetAxisRaw("Horizontal"));
                
                
                
                
            }

            if (Input.GetButtonUp("Jump"))
            {
                Debug.Log("Jump! Dowm");
            }
        }
    }
}