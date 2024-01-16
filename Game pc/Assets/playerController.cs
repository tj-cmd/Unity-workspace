using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    // Start is called before the first frame update
   void start()
    {

    }

   



    // Update is called once per frame
    void update()
    {
        Vector2 position = transform.position;
        position.x = position.x + 0.1f;
        transform.position = position;



    }

}

  
    
        
    

