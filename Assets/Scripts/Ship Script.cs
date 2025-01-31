using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 20;
    public float moveSpeed = 20;
    public Vector3 inputVector;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inputVector.x != 0 && inputVector.y != 0)
        {
            inputVector = inputVector / inputVector.magnitude;
        }
      
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
        float TD = Time.deltaTime;
       
        inputVector = new Vector3(inputX, inputY, 0);
        transform.position = transform.position + inputVector * speed * TD;
    }
}
