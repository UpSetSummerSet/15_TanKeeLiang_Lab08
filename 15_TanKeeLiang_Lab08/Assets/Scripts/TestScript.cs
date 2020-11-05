using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
    public GameObject scoreText;

    float SpacebarTrack;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.GetComponent<Text>().text = "Spacebar: " + SpacebarTrack;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            scoreText.GetComponent<Text>().text = "Spacebar: " + SpacebarTrack;

            print("Spacebar pressed");
            SpacebarTrack++;
        }
    }
}
