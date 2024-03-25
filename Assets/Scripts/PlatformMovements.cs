using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovements : MonoBehaviour
{

    public float speed = 0F;
    private float height;
    const float maxSpeed = 500F;
    public GameObject score;
    private Score scoreScript;
    // Start is called before the first frame update
    void Start()
    {
        // score = GameObject.Find("ScoreManager");
        scoreScript = GameObject.Find("ScoreManager").GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {   if (scoreScript.currentTime % 1000 < 1) {
            speed += 0.1F;
        }
        transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
    }

    void OnBecameInvisible() {
        height = Random.Range(5F, 15F);
        gameObject.transform.position = new Vector2(34F, height);
        // speed+=0.5F;
    }

    void OnBecameVisible(){

    }
}
