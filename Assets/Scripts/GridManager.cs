using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public int row;
    public int col;
    private float horizantalspacing=0;
    private float verticalspacing=0;
    public GameObject cubePrefab;
    // Start is called before the first frame update
    void Start()
    {
        SpawnManager();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Grid Spawning
    private void SpawnManager()
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Vector3 Position = new Vector3(transform.position.x + horizantalspacing, transform.position.y,
                transform.position.z + verticalspacing);
                Instantiate(cubePrefab, Position, cubePrefab.transform.rotation);
                verticalspacing += 2;
            }
            horizantalspacing += 2;
            verticalspacing = 0;
        }
    }
}
