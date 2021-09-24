using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidbody;
    [SerializeField] float delay = 5f;


    // Start is called before the first frame update
    void Start()
    {
        
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        renderer.enabled = false;
        rigidbody.useGravity = false;

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > delay) {
            renderer.enabled = true;
            rigidbody.useGravity = true;
            Debug.Log( delay + "seconds has elapsed");
        }
    }
}
