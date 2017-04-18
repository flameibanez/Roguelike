using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour {
    public Camera camera;
    [System.NonSerialized]
    public Vector3 cameraPos;
    [System.NonSerialized]
    public int xSeed;
    public int ySeed;
	// Use this for initialization
	void Start () {
        xSeed = (int)(Random.value * 10000);
        ySeed = (int)(Random.value * 10000);
        cameraPos = camera.transform.position;
        for (int x = (int)cameraPos.x - 3; x < (int)cameraPos.y + 3; x++)
        {
            for (int y = (int)cameraPos.y - 3; y < (int)cameraPos.y + 3; x++)
            {
                Generate(x, y, xSeed, ySeed);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private Cell Generate(int x, int y, int xSeed, int ySeed)
    {
        float height = Mathf.PerlinNoise(x + xSeed, y + ySeed);
        if (height >= 0.5)
        {
            return new Cell();/***************************************************************************/
        }
        else
        {
            return new Cell();/***************************************************************************/
        }
    }
}
