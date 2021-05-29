using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyItemController : MonoBehaviour
{
    [Header("Object Type")]
    [SerializeField] private bool redDoor = false;
    [SerializeField] private bool redKey = false;

    [SerializeField] private bool first_1_door = false;
    [SerializeField] private bool first_1_key = false;
    [SerializeField] private bool first_2_door = false;
    [SerializeField] private bool first_2_key = false;
    [SerializeField] private bool first_3_door = false;
    [SerializeField] private bool first_3_key = false;

    [SerializeField] private bool second_1_door = false;
    [SerializeField] private bool second_1_key = false;
    [SerializeField] private bool second_2_door = false;
    [SerializeField] private bool second_2_key = false;
    [SerializeField] private bool second_3_door = false;
    [SerializeField] private bool second_3_key = false;
    [SerializeField] private bool second_4_door = false;
    [SerializeField] private bool second_4_key = false;

    [SerializeField] private bool third_1_door = false;
    [SerializeField] private bool third_1_key = false;
    [SerializeField] private bool third_2_door = false;
    [SerializeField] private bool third_2_key = false;
    [SerializeField] private bool third_3_door = false;
    [SerializeField] private bool third_3_key = false;

    [Header("Inventory")]
    [SerializeField] private KeyDoorInventory keyInventory = null;

    private KeyDoorController doorObject;
 
    private void Start()
    {
            doorObject = GetComponent<KeyDoorController>();
        
    }

    public void ObjectInteraction()
    {
        if (redDoor)
        {
            doorObject.PlayAnimation(0);
        }

        else if (redKey)
        {
            keyInventory.hasRedKey = true;
            gameObject.SetActive(false);
            
        }else if(first_1_door){ 
            doorObject.PlayAnimation(1);
        }else if(first_1_key){
            keyInventory.hasFirst_1_Key = true;
            gameObject.SetActive(false);
        }else if(first_2_door){ 
            doorObject.PlayAnimation(2);
        }else if(first_2_key){
            keyInventory.hasFirst_2_Key = true;
            gameObject.SetActive(false);
        }else if(first_3_door){ 
            doorObject.PlayAnimation(3);
        }else if(first_3_key){
            keyInventory.hasFirst_3_Key = true;
            gameObject.SetActive(false);
        }else if(second_1_door){ 
            doorObject.PlayAnimation(4);
        }else if(second_1_key){
            keyInventory.hasSecond_1_Key = true;
            gameObject.SetActive(false);
        }else if(second_2_door){ 
            doorObject.PlayAnimation(5);
        }else if(second_2_key){
            keyInventory.hasSecond_2_Key = true;
            gameObject.SetActive(false);
        }else if(second_3_door){ 
            doorObject.PlayAnimation(6);
        }else if(second_3_key){
            keyInventory.hasSecond_3_Key = true;
            gameObject.SetActive(false);
        }else if(second_4_door){ 
            doorObject.PlayAnimation(7);
        }else if(second_4_key){
            keyInventory.hasSecond_4_Key = true;
            gameObject.SetActive(false);
        }else if(third_1_door){ 
            doorObject.PlayAnimation(8);
        }else if(third_1_key){
            keyInventory.hasThird_1_Key = true;
            gameObject.SetActive(false);
        }else if(third_2_door){ 
            doorObject.PlayAnimation(9);
        }else if(third_2_key){
            keyInventory.hasThird_2_Key = true;
            gameObject.SetActive(false);
        }else if(third_3_door){ 
            doorObject.PlayAnimation(10);
        }else if(third_3_key){
            keyInventory.hasThird_3_Key = true;
            gameObject.SetActive(false);
        }
    }
}
