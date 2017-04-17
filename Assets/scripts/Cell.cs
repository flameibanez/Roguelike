using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cell : MonoBehaviour {

    public enum type
    {
        grass,
        dirt,
        stone
    }

    public List<CellContent> contents;

    public bool canWalkHere()
    {
        foreach  (CellContent content in contents)
        {
            if (!content.canWalkOnThis)
                return false;
        }
        return true;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
