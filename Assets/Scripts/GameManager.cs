using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace OwenLomax
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField]
        private Character playerOne;
        [SerializeField]
        private Character playerTwo;
        void Update()
        {
            //the check:
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (playerOne != null)
                {
                    // the adjustment:
                    playerOne.morale -= Random.Range(1, 13);
                    playerOne.health -= Random.Range(1, 9);

                    if (playerOne.health <= 0)
                    {
                        Destroy(playerOne.gameObject);
                        playerOne = null;
                    }
                }
            }

            if (playerTwo != null)
            {
                //the check:
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    // the adjustment:
                    playerTwo.morale -= Random.Range(1, 13);
                    playerTwo.health -= Random.Range(1, 9);

                    if (playerTwo.health <= 0)
                    {
                        Destroy(playerTwo.gameObject);
                        playerTwo = null;
                    }
                }
            }
        }
    }
}