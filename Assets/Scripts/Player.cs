using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private SetBoundary bound;
    public GameObject prefab;
    private GameMnager gamemanager;
    void Start()
    {
        Instantiate(prefab, transform.position, prefab.transform.rotation);
        gamemanager = GameObject.Find("GameManager").GetComponent<GameMnager>();
        bound = GameObject.Find("Boundary").GetComponent<SetBoundary>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    private void Movement()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && bound.forwardMove==true)
        {
         transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z +2);
         Instantiate(prefab, transform.position,prefab.transform.rotation);
            gamemanager.GridFill(1);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && bound.backwardMove == true)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z-2);
            Instantiate(prefab, transform.position, prefab.transform.rotation);
            gamemanager.GridFill(1);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && bound.rightMove==true)
        {
            transform.position = new Vector3(transform.position.x + 2, transform.position.y, transform.position.z);
            Instantiate(prefab, transform.position, prefab.transform.rotation);
            gamemanager.GridFill(1);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && bound.leftMove==true)
        {
            transform.position = new Vector3(transform.position.x-2, transform.position.y, transform.position.z);
            Instantiate(prefab, transform.position, prefab.transform.rotation);
            gamemanager.GridFill(1);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            gamemanager.Lives(-1);
            Destroy(collision.gameObject);
        }
    }
}
