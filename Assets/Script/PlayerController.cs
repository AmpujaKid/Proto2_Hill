using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float horizontalInput;
    public float speed = 10.0f;
    public float xrange = 10;

    public GameObject projectilePrefab;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xrange) transform.position = new Vector3(-xrange, transform.position.y, transform.position.z); // keep inbounds left
        if (transform.position.x > xrange) transform.position = new Vector3(xrange, transform.position.y, transform.position.z); // keep inbounds right
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        // launch food on spacebar press
        if (Input.GetKeyDown(KeyCode.Space)) Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
    }
}
