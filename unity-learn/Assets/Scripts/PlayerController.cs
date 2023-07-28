using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;

    private float lastSpawnTime;
    private float spawnInterval = 0.15f; // Oyuncunun tekrar spawn yapabileceği minimum süre (saniye)


    public float xRange = 15.0f;
    public float zRangeMax = 15.0f;
    public float zRangeMin = -1;
    public float speed;


    public GameObject projectilePrefab;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector2.right * speed * horizontalInput * Time.deltaTime);
        transform.Translate(Vector3.forward * speed * verticalInput * Time.deltaTime);

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)  
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z > zRangeMax)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangeMax);
        }

        if (transform.position.z < zRangeMin)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangeMin);
        }

        if (Input.GetKeyDown(KeyCode.Space) && Time.time - lastSpawnTime >= spawnInterval)
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            lastSpawnTime = Time.time;
        }


    }
}
