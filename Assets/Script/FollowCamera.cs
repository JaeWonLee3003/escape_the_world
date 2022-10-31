using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
   
{
    private GameObject player;
    

    private float cameraHallWidth;
    private float cameraHallHeight;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        

        Camera camera = Camera.main;
        cameraHallWidth = camera.aspect * camera.orthographicSize;
        cameraHallHeight = camera.orthographicSize;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = new Vector3(
            player.transform.position.x,
            player.transform.position.y + 2.3f,
            transform.position.z);

        newPosition.x = Mathf.Clamp(newPosition.x, -2.5f, 5f);
        transform.position = newPosition;
    }
}
