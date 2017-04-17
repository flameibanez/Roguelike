using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour {
    GameObject f;
	// Use this for initialization
	void Start () {
        f = GameObject.CreatePrimitive(PrimitiveType.Quad);
        f.AddComponent<Cell>();
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
