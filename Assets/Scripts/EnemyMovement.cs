using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Player player;
    private float speed = 4;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 LookDirection = (player.transform.position - transform.position).normalized;
        transform.Translate(LookDirection * speed*Time.deltaTime);
    }
}
