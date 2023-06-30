using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave_Controller : MonoBehaviour
{
    public static Wave_Controller instance;
    [SerializeField] private Transform[] Spawns;
    [SerializeField] private GameObject[] Meteors;
    private bool isWaveStart = false;
    int randomNumber;

    void Awake()
    {
        instance = this;
    }
    void Update()
    {
        if(!isWaveStart && GameObject.FindWithTag("Player") != null)
        {
            Waves();
        }
        
    }

    public void Waves()
    {
        isWaveStart = true;
        StartCoroutine(Spawner());
    
    }

    public IEnumerator Spawner()
    {
        int lastNumber = 0;
        for(int i = 0; i < 6; i++)
        {
            
            randomNumber = Random.Range(0, 3);
            if(randomNumber == lastNumber)
            {
                randomNumber = Random.Range(0,2);
            }
            else
            {
                Instantiate(Meteors[randomNumber], Spawns[i]);
                yield return new WaitForSeconds(1.3f);
            }
            lastNumber = randomNumber;
        
        }
        isWaveStart = false;


    }
}
