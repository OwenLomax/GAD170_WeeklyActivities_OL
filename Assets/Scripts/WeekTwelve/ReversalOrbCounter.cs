using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace OwenLomax
{


    public class ReversalOrbCounter : MonoBehaviour
    {
        // For our events system we need these things
        // Announce the event at particular times or when a particular collision occurs, etc...
        // We want to make sure our UI is LISTENING for the event.
        // When the event is announced, we want to update our UI.

        [SerializeField] private TMPro.TextMeshProUGUI ControlReversalOrbCounter;
        [SerializeField] private int controlReverseCount = 0;

        private void OnEnable()
        {
            ReversalOrbEventManager.OnControlReversalOrbAction += IncreaseControlReversalOrbCount;
        }

        private void OnDisable()
        {
            ReversalOrbEventManager.OnControlReversalOrbAction -= IncreaseControlReversalOrbCount;
        }

        private void IncreaseControlReversalOrbCount()
        {
            controlReverseCount++;
            ControlReversalOrbCounter.text = "Reversal Orbs Collected: " + controlReverseCount;

        }
    }
}
