using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed=2.0f;
    
    

    

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right*(speed * Time.deltaTime);

            
            //It will restrict the player within World
            //We can replace Vector3 with var
                Vector3 pos = transform.position;
                pos.x = Mathf.Clamp(transform.position.x,-12.2f,12.2f);
                transform.position = pos;
               
        }
        else if (Input.GetKey("a"))
        {
            transform.position -= transform.right * (speed * Time.deltaTime);

            

            
            Vector3 pos = transform.position;
            pos.x = Mathf.Clamp(transform.position.x, -12.2f, 12.2f);
            transform.position = pos;
           

        }
        else if (Input.GetKey("w"))
        {
            transform.position += transform.up * (speed * Time.deltaTime);
            
            Vector3 pos = transform.position;
            pos.y = Mathf.Clamp(transform.position.y, -4.5f, 4.5f);
            transform.position = pos;
    
    }
        else if (Input.GetKey("s"))
        {
            transform.position -= transform.up * (speed * Time.deltaTime);
            
            Vector3 pos = transform.position;
            pos.y = Mathf.Clamp(transform.position.y, -4.5f, 4.5f);
            transform.position = pos;
       
    }
    }
  

}
