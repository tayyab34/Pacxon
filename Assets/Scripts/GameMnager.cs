using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameMnager : MonoBehaviour
{
    private int Gridfill = 0;
    private int lives=5;
    private int time = 0;
    public TextMeshProUGUI livetext;
    public TextMeshProUGUI timetext;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Timer());
        livetext.text = "Lives:" + lives;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Player level completed when grid 70% Fill
    public void GridFill(int value)
    {
        Gridfill += value;
        if (Gridfill >= 70)
        {
            Debug.Log("Player Completed the Level");
        }
    }
    //Add Lives
    public void Lives(int livestoadd)
    {
        lives += livestoadd;
        livetext.text = "Lives:" + lives;
        if (lives == 0)
        {
            Debug.Log("Game Over");
        }
    }
    //Timer
    IEnumerator Timer()
    {
        while (true)
        {
            timetext.text = "Time:" + time;
            yield return new WaitForSeconds(1);
            
            time = time + 1;
        }
        
    }
}
