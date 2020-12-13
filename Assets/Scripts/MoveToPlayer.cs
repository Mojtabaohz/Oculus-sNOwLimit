using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayer : MonoBehaviour
{
    [SerializeField]
    private float speed = 1;
    [SerializeField]
    private float acceleration = 2;
    [SerializeField]
    private float maxSpeed = 70;
    
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,0,-(speed*Time.deltaTime));
        if (speed < maxSpeed)
        {
            speed += acceleration;
        }

        if (transform.position.z <= -100)
        {
            Destroy(gameObject);
        }
        
    }
    

}
