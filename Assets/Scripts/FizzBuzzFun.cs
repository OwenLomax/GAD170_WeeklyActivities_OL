using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace OwenLomax
{


    public class FizzBuzzFun : MonoBehaviour
    {
        private void Start()
        {
            CheckNumbers();
        }
        private void CheckNumbers()
        {
            for (int i = 1; i < 101; i++)
            {

            
            
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Debug.Log("FizzBuzz!");
                }
            
                else if (i % 3 == 0)
                {
                    Debug.Log("Fizz!");
                }
                
                else if (i % 5 == 0)
                {
                    Debug.Log("Buzz!");
                }
                else
                {
                    Debug.Log(i);
                }
                        
                            
                        
               

            }

        }

        private void CaseCheckNumbers()
        {

        }


    }
}