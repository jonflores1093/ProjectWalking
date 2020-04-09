using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPScontroller : MonoBehaviour
{

    private float mouseX;
    private float mouseY;
    private float mouseSensitivity = 100f;

    public Transform player;
    float RotationX = 0f;
    float RotationY = 0f;
    //Vector3 originalPos;




    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        //originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }

    
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        RotationX -= mouseY;
       // RotationX = Mathf.Clamp(RotationX, -90f, 90f);

        RotationY += mouseX;
       //  RotationY = Mathf.Clamp(RotationY, -90f, 90f);
        
        transform.localRotation = Quaternion.Euler(RotationX, RotationY, 0f);

       // player.Rotate(Vector3.up * mouseX);
        //player.Rotate(Vector3.right * mouseY);
    }


    //void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.tag == "End")
    //    {
    //        gameObject.transform.position = originalPos;
    //    }

    //}
}
