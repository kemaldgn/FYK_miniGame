using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class CollectorController : MonoBehaviour
{
    private Vector3 touchPosition;
    [SerializeField] private Rigidbody2D rb;
    private Vector3 direction;
    [SerializeField] private float moveSpeed;

    [SerializeField] public static float numbersCollected = 0;

    [SerializeField] public Transform cursor;

    public Transform avatar0;
    public Transform avatar1;
    public Transform avatar2;
    public Transform avatar3;
    public Transform avatar4;
    public Transform avatar5;

    [SerializeField] public AudioSource collected;
    [SerializeField] public AudioSource failed;

    void Update()
    {
        if(Input.touchCount > 0){
            Touch touch = Input.GetTouch(0);
            touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0;
            direction = (touchPosition - transform.position);
            rb.velocity = new Vector2(direction.x, 0) * moveSpeed;

            // activate if player is touching to the screen
                activateCursor();
                cursor.gameObject.transform.position = touchPosition;

            if(touch.phase == TouchPhase.Ended){ 
                rb.velocity = Vector2.zero;
            }
        }
        else
        {
            cancelCursor();
        }

        if(numbersCollected >= 3 && GameManage.activeNumber != 5){
            GameManage.activeNumber ++;
            numbersCollected = 0;
            // go to draw next number
            GameManage.changeSceneToDraw();
        }
        else if(numbersCollected >= 3 && GameManage.activeNumber == 5){
            GameManage.goToMainScene(); // game ends
        }

        if(NumberController.playCollectSound){
            collected.Play();
            NumberController.playCollectSound = false;
            }
        else if(NumberController.playFailSound){
            failed.Play();
            NumberController.playFailSound = false;}

        switch (GameManage.activeNumber)
        {
            default:

            case 0:
                    avatar0.gameObject.SetActive(true);
            break;

            case 1:
                    avatar1.gameObject.SetActive(true);
            break;

            case 2:
                    avatar2.gameObject.SetActive(true);
            break;

            case 3:
                    avatar3.gameObject.SetActive(true);
            break;

            case 4:
                    avatar4.gameObject.SetActive(true);
            break;

            case 5:
                    avatar5.gameObject.SetActive(true);
            break;
        }
    }



    void activateCursor(){
        cursor.gameObject.SetActive(true);
    }
    void cancelCursor(){
        cursor.gameObject.SetActive(false);
    }

    
}
