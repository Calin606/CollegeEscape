using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KeySystem{
    public class KeyItemControllerR : MonoBehaviour
    {
        [SerializeField] private bool redDoor = false;
        [SerializeField] private bool redKey = false;
        [SerializeField] private KeyInventory _keyInventory = null;

        private KeyDoorController doorObject;
    }
}
