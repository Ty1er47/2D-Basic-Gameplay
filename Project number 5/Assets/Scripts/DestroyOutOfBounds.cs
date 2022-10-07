using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    public float topBound;
    public float lowerBound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > topBound)
        {
            Destroy(this.gameObject);
        }
        if(transform.position.y < lowerBound)
        {
            Debug.Log("Game Over,One got passed you");
            Destroy(this.gameObject);
        }
    }
}
