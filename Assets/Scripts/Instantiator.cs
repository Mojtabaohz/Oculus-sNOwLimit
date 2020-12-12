using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    [SerializeField]
    GameObject  cube;

    private float spawnRate = 1;
    private float _timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        SpawnTree();
        
        
    }
    void SpawnTree()
    {
        _timer += Time.deltaTime;
        if(_timer >= spawnRate){
            _timer = 0;
            Instantiate(cube, new Vector3(RandomX(), 1, 50),Quaternion.identity);
        }
        
    }

    float RandomX()
    {
        return Random.Range(-2, 2);
    }
}
