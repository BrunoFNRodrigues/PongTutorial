using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    float target = 270.0f;
    float speed = 20.0f;

    void Update()
    {
        float angle = Mathf.MoveTowardsAngle(transform.eulerAngles.y, target, speed * Time.deltaTime);
    
        transform.eulerAngles += new Vector3(0, 0, angle);
    }
}
