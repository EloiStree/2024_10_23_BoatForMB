using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Eloi
{
    public class BasicBoatMono : MonoBehaviour
    {
        [ContextMenu("Teleport Forward")]
        public void TeleportForward() { 
        
            transform.position += transform.forward * 1;
        }
    }
}
