using System;
using UnityEngine;

namespace Example
{
    public class LifeCycle : MonoBehaviour
    {
        void Update()
        {
            // unity 안에 있는 입력값 처리
            // anyKeyDown 아무 입력을 받을 때 true (bool)
            if (Input.anyKeyDown)
            {
                Debug.Log("플레이어가 아무 키를 입력 받았습니다.");
            }

           /*
            if (Input.anyKey)
            {
                Debug.Log("아무 키를 누르고 있습니다.");
            }
            */
           if (Input.GetKeyDown(KeyCode.Return))
           {
               Debug.Log("엔터 키를 눌렀습니다. (GetKeyDown)");
           }

           // 키를 누르고 있는 동안 (매 프레임 실행됨)
           if (Input.GetKey(KeyCode.Return))
           {
               Debug.Log("엔터 키를 누르고 있습니다. (GetKey)");
           }

           // 키를 뗐을 때 (한 번만 실행됨)
           if (Input.GetKeyUp(KeyCode.Return))
           {
               Debug.Log("엔터 키에서 손을 뗐습니다. (GetKeyUp)");
           }
        }
    }
}