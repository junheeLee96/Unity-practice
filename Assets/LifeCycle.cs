using System;
using UnityEngine;

namespace Example
{
    public class LifeCycle : MonoBehaviour
    {
        private void Start()
        {
            //Vector3 vec = new Vector3(1,1,1);            
            //transform.Translate(vec);
        }

        private void Update()
        {
            Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
            transform.Translate(vec);
            //throw new NotImplementedException();
        }
    }
}