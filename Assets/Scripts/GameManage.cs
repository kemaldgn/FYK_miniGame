using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManage : MonoBehaviour
{
    [SerializeField] public static float activeNumber; // 0,1,2,3,4,5
    GameManage gameManage;
    

    void Start()
    {
        
    }

    
    void Update()
    {
        //print(activeNumber);
    }

    public static void changeSceneToDraw(){
        
        SceneManager.LoadScene("DrawNumber");
    }

    public void changeActiveNumber(float number){
        activeNumber = number;
    }

    public void goToCollectScene(){
        SceneManager.LoadScene("CollectNumber");
    }

    public static void goToMainScene(){
        SceneManager.LoadScene("MainScene");
    }

   


    
}
