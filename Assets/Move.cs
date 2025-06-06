using System;
using UnityEngine;

namespace Example
{
    public class Move : MonoBehaviour
    {
        private Vector3 target = new Vector3(8,1.5f, 0);
        private Vector3 velo = Vector3.zero;
        private void Update()
        { 
            
            //MoveTowards 목표 위치까지 move
            // MoveTowards(현재 위치, 목표 위치, 속도)
            transform.position = Vector3.MoveTowards(transform.position, target, 2.1f);
            
            // SmoothDamp 목표 위치까지 smooth하게 전진
            // SmoothDamp(현재 위치, 목표 위치, 참조 속도, 속도)      
            transform.position = Vector3.SmoothDamp(transform.position,target,ref velo,1.1f);
            
            
            // Lerp 선형 보간, SmoothDamp보다 감속시간이 김. 마지막 매개변수가 0-1 사이어야 함.
            // Lerp는 MoveTowrads와 매개변수가 같음.
            transform.position = Vector3.Lerp(transform.position, target, 0.1f);
            
            // Slerp 구면 선형 보간. 호를 그리며 이동
            // Slerp
            transform.position = Vector3.Slerp(transform.position, target, 0.05f);
        }
    }
}