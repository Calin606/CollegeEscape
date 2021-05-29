using System.Collections;
using UnityEngine;

public class KeyDoorController : MonoBehaviour
{
    private Animator doorAnim;
    private bool doorOpen = false;

    [Header("Animation Names")]
    [SerializeField] private string openAnimationName = "DoorOpen";
    [SerializeField] private string closeAnimationName = "DoorClose";

    [Header("Door Locked UI")]
    [SerializeField] private int timeToShowUI = 1;
    [SerializeField] private GameObject showDoorLockedUI = null;

    [Header("Key Inventory")]
    [SerializeField] private KeyDoorInventory keyInventory = null;

    [Header("Pause Timer")]
    [SerializeField] private int waitTimer = 1;
    [SerializeField] private bool pauseInteraction = false;

    private void Awake()
    {
        doorAnim = gameObject.GetComponent<Animator>();
    }

    private IEnumerator PauseDoorInteraction()
    {
        pauseInteraction = true;
        yield return new WaitForSeconds(waitTimer);
        pauseInteraction = false;

    }

    public void PlayAnimation(int nr)
    {
        if (keyInventory.hasRedKey && nr == 0)
        {
            OpenDoor();
            keyInventory.hasRedKey = false;

        } else if(keyInventory.hasFirst_1_Key && nr == 1){
            OpenDoor();
            keyInventory.hasFirst_1_Key = false;
        } else if(keyInventory.hasFirst_2_Key && nr == 2){
            OpenDoor();
            keyInventory.hasFirst_2_Key = false;
        } else if(keyInventory.hasFirst_3_Key && nr == 3){
            OpenDoor();
            keyInventory.hasFirst_3_Key = false;
        } else if(keyInventory.hasSecond_1_Key && nr == 4){
            OpenDoor();
            keyInventory.hasSecond_1_Key = false;
        } else if(keyInventory.hasSecond_2_Key && nr == 5){
            OpenDoor();
            keyInventory.hasSecond_2_Key = false;
        } else if(keyInventory.hasSecond_3_Key && nr == 6){
            OpenDoor();
            keyInventory.hasSecond_3_Key = false;
        } else if(keyInventory.hasSecond_4_Key && nr == 7){
            OpenDoor();
            keyInventory.hasSecond_4_Key = false;
        } else if(keyInventory.hasThird_1_Key && nr == 8){
            OpenDoor();
            keyInventory.hasThird_1_Key = false;
        } else if(keyInventory.hasThird_2_Key && nr == 9){
            OpenDoor();
            keyInventory.hasThird_2_Key = false;
        } else if(keyInventory.hasThird_3_Key && nr == 10){
            OpenDoor();
            keyInventory.hasThird_3_Key = false;
        }

        else
        {
            StartCoroutine(ShowDoorLocked());
        }
    }

    void OpenDoor(){
        if (!doorOpen && !pauseInteraction)
            {
                doorAnim.Play(openAnimationName, 0, 0.0f);
                doorOpen = true;
                StartCoroutine(PauseDoorInteraction());
            }

            else if (doorOpen && !pauseInteraction)
            {
                doorAnim.Play(closeAnimationName, 0, 0.0f);
                doorOpen = false;
                StartCoroutine(PauseDoorInteraction());
            }
    }

    IEnumerator ShowDoorLocked()
    {
        showDoorLockedUI.SetActive(true);
        yield return new WaitForSeconds(timeToShowUI);
        showDoorLockedUI.SetActive(false);
    }
}
