using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace OwenLomax
{


    public class WeekFiveActivites : MonoBehaviour
    {
        
    }


    public class Contact : MonoBehaviour
    {
        //Information about me, my name, contact number, address, email, preferred name

        public new string name;
        public int phoneNumber;
        public string address;
        public string email;
        public string preferredName;

        private void Start()
        {
            Setup();
            
        }

        public void Setup()
        {
            name = "Jordan Kuros";
            phoneNumber = 041136898;
            address = "42 Wallaby Way, Sydney";
            email = "JordanK92@gmail.com";
            preferredName = "Jordizzle";
            //Debug.Log("Contact one is " = Setup);
            
        }

        
        
        
    }


   

    





















}