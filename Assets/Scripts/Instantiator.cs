using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    [SerializeField]
    GameObject[]  movingObjects;
    [SerializeField]
    private float spawnRate = 1;
    private float _timer;

    private GameObject _instantiatedGameObject;

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
            var movingObject = movingObjects[Random.Range(0,movingObjects.Length)];
            _timer = 0;
            Instantiate(movingObject, new Vector3(RandomX(), 1, 300),Quaternion.identity);
            
        }
        
    }

    float RandomX()
    {
        return Random.Range(-40, 40);
    }
}
