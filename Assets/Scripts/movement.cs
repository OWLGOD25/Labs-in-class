using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float TD = Time.deltaTime;
        transform.position = transform.position + new Vector3 (speed, 0, 0) * TD;
    }
}
