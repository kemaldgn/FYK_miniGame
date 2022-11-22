using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberSpawner : MonoBehaviour
{

    [SerializeField] private float cooldown;

    [SerializeField] private float xMin, xMax;

    public GameObject[] numbers;


    void Start()
    {
        StartCoroutine(SpawnAnEnemy());
    }

    IEnumerator SpawnAnEnemy(){
        
        //Vector2 spawnPos = this.gameObject.transform.position;
        //spawnPos += Random.insideUnitCircle.normalized * spawnRadius;,
        Vector2 spawnPos = new Vector2(Random.Range(xMin, xMax), this.gameObject.transform.position.y);

        Instantiate(numbers[Random.Range(0, numbers.Length)], spawnPos, Quaternion.identity);
        yield return new WaitForSeconds(cooldown);

        StartCoroutine(SpawnAnEnemy());

    }
}
