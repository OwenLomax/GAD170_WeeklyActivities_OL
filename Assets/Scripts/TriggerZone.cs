using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace OwenLomax
{



    public class TriggerZone : MonoBehaviour
    {
        public delegate void TriggerAction();

        public static event TriggerAction OnTrigger;
        

        //detect when the sphere hits this trigger
        //debug log something
        //then teleport the sphere away

        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("Yow! " + other.name + " jumped on me!");

            //other.transform.position = new Vector3(0, 4, 0);

            if (OnTrigger != null)
            {
                OnTrigger();
            }

        }
        
        
       
    }
}