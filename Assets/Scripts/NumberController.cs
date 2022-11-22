using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float number;

    public static bool playCollectSound;
    public static bool playFailSound;

    void Start()
    {
        
    }

    private void Awake() {
        playCollectSound = false;
        playFailSound = false;
    }

    void Update(){
        DestroyNumber();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        move();
    }

    void move(){
        rb.AddForce(Vector2.down * moveSpeed, ForceMode2D.Force);
    }

    void DestroyNumber(){
        if(transform.position.y < -6.5f){
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.tag == "collector" && number == GameManage.activeNumber){ // succeeded
            playCollectSound = true;
            CollectorController.numbersCollected++;
            print(CollectorController.numbersCollected);
        }
        else{ // failed, sound and effect
            playFailSound = true;
        }
        Destroy(gameObject);
    }
}
