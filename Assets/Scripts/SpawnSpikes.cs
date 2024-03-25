using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSpikes : MonoBehaviour
{
    float timeLeft = 5F;
    int numSpikes = 0;
    public GameObject spawnPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0 && numSpikes == 0) {
            GameObject spikes = Instantiate(spawnPrefab, transform);
            spikes.transform.position = new Vector2(-6, -3.5F);
            numSpikes++;
        }
        
        // timeLeft < 0 && 

    }
}
