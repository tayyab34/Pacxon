using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyprefab;
    private float XRange = 20f;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 5; i++)
        {
            SpawnEnemy();
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SpawnEnemy()
    {
        Vector3 position = new Vector3(Random.Range(0, XRange), transform.position.y, transform.position.z);
        Instantiate(enemyprefab,position, enemyprefab.transform.rotation);
    }
}
