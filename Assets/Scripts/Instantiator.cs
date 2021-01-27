using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    [SerializeField]
    private float environmentSpawnRate = 1;
    [SerializeField]
    GameObject[]  environment;
    [SerializeField] private int maxWidth;
    [SerializeField] private int minWidth;
    [SerializeField] private float iceCreamSpawnRate = 2;

    [SerializeField] private GameObject[] iceCreamScopes;
    
    private float _environmentTimer;
    private float _iceCreamTimer;

    private GameObject _instantiatedGameObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnEnvironment();
        SpawnIceScopes();
        //OVRInput.Update();
    }
    void SpawnEnvironment()
    {
        _environmentTimer += Time.deltaTime;
        if (_environmentTimer >= environmentSpawnRate)
        {
            var movingObject = environment[Random.Range(0, environment.Length)];
            _environmentTimer = 0;
            Instantiate(movingObject, new Vector3(RandomX(40), 1, 300), Quaternion.identity);

        }
    }

    void SpawnIceScopes()
    {
        _iceCreamTimer += Time.deltaTime;
        if (_iceCreamTimer >= iceCreamSpawnRate)
        {
            var iceCreamObject = iceCreamScopes[Random.Range(0, iceCreamScopes.Length)];
            _iceCreamTimer = 0;
            Instantiate(iceCreamObject, new Vector3(Random.Range(maxWidth, minWidth), 7, 300), Quaternion.identity);
        }
    }

    float RandomX(float posX)
    {
        return Random.Range(-posX, posX);
    }
}
