using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace OwenLomax
{


    public class ReversalOrbEventManager : MonoBehaviour
    {
        public delegate void ControlReversalOrbAction();
        public static event ControlReversalOrbAction OnControlReversalOrbAction;
        
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // The events part here needs to be in my on trigger enter scripts for all three features
                if(OnControlReversalOrbAction != null)
                {
                    OnControlReversalOrbAction();
                }
            }
        }

    }
}