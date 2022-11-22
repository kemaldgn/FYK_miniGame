using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class drawController : MonoBehaviour
{
    public Transform number0;
    public Transform number1;
    public Transform number2;
    public Transform number3;
    public Transform number4;
    public Transform number5;

    [SerializeField] public AudioSource zero;
    [SerializeField] public AudioSource one;
    [SerializeField] public AudioSource two;
    [SerializeField] public AudioSource three;
    [SerializeField] public AudioSource four;
    [SerializeField] public AudioSource five;

    [SerializeField] public Image nextButton;

    [SerializeField] public static float checkedPoints; // if it is more than 5 go to next scene, task is completed.

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().name != "DrawNumber") return;

        switch (GameManage.activeNumber)
        {
            default:

            case 0:
                if(!number0.gameObject.active){
                    number0.gameObject.SetActive(true);
                    zero.Play();}
            break;

            case 1:
                if(!number1.gameObject.active){
                    number1.gameObject.SetActive(true);
                    one.Play();}
            break;

            case 2:
                    if(!number2.gameObject.active){
                    number2.gameObject.SetActive(true);
                    two.Play();}
            break;

            case 3:
                    if(!number3.gameObject.active){
                    number3.gameObject.SetActive(true);
                    three.Play();}
            break;

            case 4:
                    if(!number4.gameObject.active){
                    number4.gameObject.SetActive(true);
                    four.Play();}
            break;

            case 5:
                    if(!number5.gameObject.active){
                    number5.gameObject.SetActive(true);
                    five.Play();}
            break;
        }
        
        if(checkedPoints == 5){
                nextButton.gameObject.SetActive(true);
        }
    }

    public void ResetCheckedNumbers(){
        checkedPoints = 0;
    }

    
}
