using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace OwenLomax
{

    public class MarbleDestroyer : MonoBehaviour
    {
        [SerializeField] private MarbleManager marbleManager;

        private void OnTriggerEnter(Collider other)
        {
            // remove the marble from the list on the marble manager
            marbleManager.allMarbles.Remove(other.gameObject);
            Destroy(other.gameObject);
        }
    }
}