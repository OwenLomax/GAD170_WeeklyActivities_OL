using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace OwenLomax
{


    public class WeekEightActivities : MonoBehaviour
    {
        /// <summary>
        /// My fruit enumerator.
        /// </summary>
        public enum Fruit
        {

            Orange,
            Apple,
            Banana,
            Strawberry,
            Mango,
            Kiwi,
            Watermelon,
            Peach,
            
        }

        public Fruit favouriteFruit = Fruit.Apple;

        public Fruit[] myFruitBasket = new Fruit[10];

        public Fruit favouriteFruitOfAaron = Fruit.Mango;
        public Fruit favouriteFruitOfMitch = Fruit.Banana;
        public Fruit favouriteFruitOfRachelle = Fruit.Watermelon;
        public Fruit favouriteFruitOfOwen = Fruit.Kiwi;
        public Fruit favouriteFruitOfChester = Fruit.Watermelon;
        public Fruit favouriteFruitOfCallum = Fruit.Mango;

        public void Start()
        {
           
            





        }

        public void Update()
        {
            CheckBasketWithIfElse();
            CheckBasketWithSwitch();


        }


        private void CheckBasketWithIfElse()
        {

            for (int i = 0; i < myFruitBasket.Length; i++)
            {
                if(myFruitBasket[i] == favouriteFruitOfAaron)
                {
                    Debug.Log("This is Aaron's Favourite Fruit!");
                }
                else if (myFruitBasket[i] == favouriteFruitOfCallum)
                {
                    Debug.Log("This is Callums Favourite Fruit!");
                }
            }



        }

        private void CheckBasketWithSwitch()
        {
            for (int i = 0; i < myFruitBasket.Length; i++)
            {
                switch (myFruitBasket[i])
                {
                    case Fruit.Mango:
                        //logic
                        Debug.Log("Mango!");
                        break;

                    case Fruit.Orange:
                        //logic
                        Debug.Log("Orange!");
                        break;

                    case Fruit.Kiwi:
                        //logic
                        Debug.Log("Kiwi!");
                        break;

                    case Fruit.Apple:
                        //logic
                        Debug.Log("Apple!");
                        break;

                    case Fruit.Peach:
                        //logic
                        Debug.Log("Peach!");
                        break;

                    case Fruit.Watermelon:
                        //logic
                        break;

                    case Fruit.Strawberry:
                        //logic
                        break;

                    default:
                        //logic if no other case returned true ( i.e. FAIL )
                        Debug.Log("Some other fruit!");
                        break;



                }
            }
        }




    }
}