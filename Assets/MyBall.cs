using System;
using UnityEngine;

namespace Example
{
    public class MyBall : MonoBehaviour 
    {
        private Rigidbody rigid;
        private void Start()
        { 
            rigid = GetComponent<Rigidbody>();
            rigid.AddForce(Vector3.up * 50f, ForceMode.Impulse);
            
            // 1. 속력 바꾸기
            //rigid.linearVelocity = new Vector3(2,4,3);
        }
        

        private void Update()
        {
            // rigid.linearVelocity = new Vector3(2,4,3);  
        }

        private void FixedUpdate()
        {
            /*
            if (Input.GetButtonDown("Jump"))
            {
                //Debug.Log('');
                rigid.AddForce(Vector3.up * 25,ForceMode.Impulse);
            }
            */
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");
            Vector3 vec = new Vector3(h, 0,v);
            
            rigid.AddForce(vec,ForceMode.Impulse);
           
           // 3. 회전력
           //rigid.AddTorque(Vector3.back);
           
        }

        private void OnTriggerStay(Collider other)
        {
            if (other.gameObject.name == "Cube")
            {
                rigid.AddForce(Vector3.up * 3, ForceMode.Impulse);
            }
        }
    }
}