using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerControls();


    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your Player with WASD");
        Debug.Log("Don't hit the walls!");
    }

    void PlayerControls()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0, zValue);
    }

}
