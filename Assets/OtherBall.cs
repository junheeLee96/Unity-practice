using System;
using UnityEngine;

namespace Example
{
    public class OtherBall : MonoBehaviour
    {
        private MeshRenderer mesh;
        private Material mat;
        
        void Start()
        {
            mesh = GetComponent<MeshRenderer>();
            mat = mesh.material;
            
        }

        // 물리적 충돌이 시작할 때 호출
        private void OnCollisionEnter(Collision collision)
        {

            if (collision.gameObject.name == "MyBall")
            {
                mat.color = new Color(0, 0, 0);
            }
        }

        // 충돌이 되는 중에 호출
        private void OnCollisionStay(Collision other)
        {
            
        }

        // 물리적 충돌이 끝났을 때 호출
        private void OnCollisionExit(Collision collision)
        {
            if (collision.gameObject.name == "MyBall")
            {
                mat.color = new Color(1, 1, 1);
            }
            
        }
    }
}