using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject _stars;

    public float _waitForNextSpawn = 2f;
    public float _countdown = 2f;

    // the range of X
    [Header("X Spawn Range")]
    public float _xMin;
    public float _xMax;

    // the range of y
    [Header("Y Spawn Range")]
    public float _yMin;
    public float _yMax;

    // the range of z
    [Header("Z Spawn Range")]
    public float _zMin;
    public float _zMax;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // timer to spawn the next goodie Object
        _countdown -= Time.deltaTime;
        if (_countdown <= 0)
        {
            SpawnStars();
            _countdown = _waitForNextSpawn;
        }
    }

    void SpawnStars()
    {
        // Defines the min and max ranges for x and y
        Vector3 pos = new Vector3(Random.Range(_xMin, _xMax), Random.Range(_yMin, _yMax), Random.Range(_zMin, _zMax));

        // Choose a new goods to spawn from the array (note I specifically call it a 'prefab' to avoid confusing myself!)
        //GameObject starsPrefab = theGoodies[Random.Range(0, theGoodies.Length)];

        // Creates the random object at the random 2D position.
        Instantiate(_stars, pos, transform.rotation);

        // If I wanted to get the result of instantiate and fiddle with it, I might do this instead:
        //GameObject newGoods = (GameObject)Instantiate(goodsPrefab, pos)
        //newgoods.something = somethingelse;
    }
}
