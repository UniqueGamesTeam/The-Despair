using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawnScript : MonoBehaviour
{
    public float time = 5f;
    float timer=0f;
    public GameObject zombie;
    public Transform[] spawnPoints;
    public Transform spawnPoint;
    // Start is called before the first frame update
    public ZombieScore zScore;
    private int tempScore=0;
    void Start()
    {
        
        spawnPoints = GetComponentsInChildren<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        timer+=Time.deltaTime;
        Debug.Log(timer);
        
        if(timer>=time)
        {
            int index=Random.Range(0,spawnPoints.Length-1);
            spawnPoint = spawnPoints[index];    
            Instantiate(zombie,spawnPoint.transform.position,spawnPoint.transform.rotation);
            timer=0f;
        }
        while(true)
        {
            if(zScore.score%2==0 && zScore.score!=0)
            {
                time-=1;
                break;
           
            
            }
        }
        
        
    }
}
