using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace OwenLomax
{


    public class CharacterColourChanger : MonoBehaviour
    {
        //We need a reference to the character we change the colour of
        [SerializeField] private MeshRenderer simpleCharacterRenderer;
        


        void Update()
        {
            //We need to change the colour IF it has an X position < or > than 0
            if(simpleCharacterRenderer.transform.position.x > 0)
            {
                simpleCharacterRenderer.material.color = Color.green;
            }
            else
            {
                simpleCharacterRenderer.material.color = Color.red;
            }

        }
    }
}