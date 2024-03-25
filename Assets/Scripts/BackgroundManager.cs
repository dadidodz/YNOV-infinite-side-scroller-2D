using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundManager : MonoBehaviour
{
    public GameObject background1;
    public GameObject background2;
    public GameObject background3;
    public GameObject background4;
    int numBackground;

    // Start is called before the first frame update
    void Start()
    {
        numBackground = Random.Range(1,5);
        switch(numBackground) {
        case 1:
            background1.SetActive(true);
            break;
        case 2:
            background2.SetActive(true);
            break;
        case 3:
            background3.SetActive(true);
            break;
        case 4:
            background4.SetActive(true);
            break;
        default:
            background1.SetActive(true);
            break;
        }
    }
}
