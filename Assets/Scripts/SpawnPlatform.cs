using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{
    public GameObject spawnPrefab;
    float xPosition = 30F;
    float yPosition = 4F;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 4; i++){
            
            // Debug.Log(yPosition);
            GameObject platform = Instantiate(spawnPrefab, transform);
            platform.transform.position = new Vector2(xPosition, yPosition);
            yPosition = Random.Range(4F, 13F);
            xPosition += 14F;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
