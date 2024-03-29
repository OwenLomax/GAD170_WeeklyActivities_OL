using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace OwenLomax
{


    public class SimpleCharacterController : MonoBehaviour
    {
        /// <summary>
        /// Determines how far this character will move, in unity per second.
        /// </summary>
        [SerializeField] public float movementSpeed = 4;

        // Update is called once per frame
        void Update()
        {
            //GetAxisRaw("Horizontal") will have a value on the X axis from -1 to 1 by pressing A/D or Left/Right arrow keys
            //GetAxisRaw("Vertical") will have a value on the Y Axis from -1 to 1 by pressing W/S or Up/Down arrow keys
           transform.position += new Vector3(Input.GetAxisRaw("Horizontal") * movementSpeed * Time.deltaTime, 0, Input.GetAxisRaw("Vertical") * movementSpeed * Time.deltaTime);
        }
    }
}