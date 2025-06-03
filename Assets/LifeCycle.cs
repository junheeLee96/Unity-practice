using System;
using UnityEngine;

namespace Example
{
    public class LifeCycle : MonoBehaviour
    {
        private void Awake()
        {
            Debug.Log("플레이어 데이터 준비 완료");
        }

        private void Start()
        {
            Debug.Log("사냥 장비를 챙겼습니다");
        }

        private void onEabled()
        {
            
        }

        private void onDisabled()
        {
            
        }

        private void FixedUpdate()
        {
            /*
             * 프레임마다 실행 -> CPU 부하
             * 주로 물리 연산과 관련된 연산이 들어감
             */
            Debug.Log("이동~");
        }

        private void Update()
        {
            // 게임 로직 업데이트
            // 사용자 환경에 따라 실행이 떨어질 수 있음
            Debug.Log("몬스터 사냥~");
        }

        private void LateUpdate()
        {
            // 모든 업데이트 끝난 후 실행
            Debug.Log("<UNK> <UNK> <UNK>");
        }

        private void OnDestroy()
        {
            // 게임 오브젝트가 삭제될 때
            Debug.Log("<UNK> <UNK> <UNK>");
        }
    }
}