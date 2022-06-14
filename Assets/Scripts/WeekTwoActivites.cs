using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OwenLomax 
{
    public class WeekTwoActivites : MonoBehaviour
    {
        // Information about my favourite game (name, hours played, and cost)
        private string favouriteGame = "The Witcher 3 Wild Hunt";
        private int hoursPlayed      = 3000; 
        private float costOfGame     = 100.99f; 


        // Start is called before the first frame update
        void Start()
        {
            //Operators: 
            // + Add
            // - Subtract
            // / Divide
            // * Multiply

            float dollarsPerHour; 
            dollarsPerHour = costOfGame / hoursPlayed;

            Debug.Log("My favourite game is " + favouriteGame + " , I have played it for " + hoursPlayed + " hours, and it cost me $" + costOfGame + ". Therefore, my value of dollars per hour is $" + dollarsPerHour ); 
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
    
}
