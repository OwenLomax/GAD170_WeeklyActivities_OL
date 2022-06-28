using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace OwenLomax
{


    public class CheatSheet : MonoBehaviour
    {

        //to do set up templates for class/variable/function/if-else/for loop

        //To declare a variable, we need:
        // - a variable to declare, for example: high score
        //
        // accessModifier Type theNameYouGiveTheVariable
        //
        // For example:
        public int highScore;
        public int score;
        public List<GameObject> enemies = new List<GameObject>();



        // To declare a method, we need:
        // accessModifier ReturnType TheNameYouGiveTheMethod
        // Note: TheNameYouGiveTheMethod must use PascalCase ( or UpperCamelCase )
        //For example, a method that reset's the highscore

        public void HighScoreReset()
        {
            //This is our template!
            highScore = 0;

        }

        public void AddScore(int amount)
        {
            score = score + amount;

            // To declare an "if statement" we use this syntax:
            // ( note: it needs to be inside a method)
            // if([value] [operator] [value]){ }
            //For example, to check if our score is higher than our high score, to save a new high score, we do..

            score = 10;
            highScore = 5;

            if (score > highScore)
            {
                highScore = score;
                //highScore is now equal to 10
            }
        }

        public void ResetGame()
        {
            // To declare a "for loop" we use this syntax:
            // for (int i = 0 < length; i++)
            //{
            //
            //}
            //
            // The logic behind a "for loop" is that it will still run the code inside, as many times as you tell it to.
            // The above loop will run 4 times (once per enemy)
            // On each iteration, the code inside will execute.
            //
            // 
            // For example, if we needed to reset four enemies, we can write:

            for (int i = 0; i < 4; i++)
            {
                // Change what we want!
                enemies[i].transform.position = Vector3.zero;
                //enemies[i].health = 100;
                //enemies[i].selectedWeapon = GetRandomWeapon();
                // ...etc
            }
        }



        // Update is called once per frame
        void Update()
        {

        }
    }

    // to declare a class we need:
    // [ accessModifier] [the word "class"] [ClassName]
    //{
    //
    //}
    //For example:

    public class ExampleClass
    {
        //This class can be accessed (i.e. seen) by other classes because it is public.
        // You cannot make a private class. (In general.)
    }

}