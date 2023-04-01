using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] float _speed= 10;

    

    
    void Update()
    {
        Vector3 direction=new Vector3(Input.GetAxisRaw("Horizontal"),0,Input.GetAxisRaw("Vertical"));
        transform.position +=direction *_speed *Time.deltaTime;
       // transform.LookAt(transform.position + direction);
       
       
    }
}
