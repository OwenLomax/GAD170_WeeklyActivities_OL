using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace OwenLomax
{


    public class Character : MonoBehaviour
    {
        public int health = 100;
        public int morale = 100;

        // Start is called before the first frame update
        void Start()
        {

        }

        private void Update()
        {
            if(morale <= 50)
            {
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
            }
        }
    }
}