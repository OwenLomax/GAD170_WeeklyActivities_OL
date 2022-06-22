using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OwenLomax
{
    public class WeekThreeActivities : MonoBehaviour
    {
    
        // Information about my name that prints my first and last name
        private string firstName = "Owen";
        private string lastName = "Lomax";
        


        // Start is called before the first frame update
        void Start()
        {
            Debug.Log(firstName + " " + lastName);
            

            PowerLevel(Random.Range(8, 17), 8, 11);
            ComparePowerLevels(PowerLevel(Random.Range(10, 18), 8, 12), PowerLevel(Random.Range(11, 19), 8, 12));
            

        }


        int PowerLevel(int strength, int agility, int intelligence)
                      
       
        {
           int result = 0;
            result = (int)(strength * 2 + agility * 1.5f + intelligence);

            Debug.Log("Power level: " + result);
            return result;

        }

        void ComparePowerLevels(int playerOnePower, int playerTwoPower)
        {
            int result = 0;
            result = (int)(strength * 2 + agility * 1.5f + intelligence);



        }
        
        
        // Update is called once per frame
        void Update()
        {
        

        }
    }   
}