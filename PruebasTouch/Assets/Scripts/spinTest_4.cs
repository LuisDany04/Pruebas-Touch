using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinTest_4 : MonoBehaviour
{
    float f_lastX = 0.0f;
    float f_difX = 0.5f;
    float f_lastY = 0;
    float f_difY = 0;
    float f_steps = 0.0f;
    int i_direction = 1;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            f_difX = 0.0f;
        }
        else if (Input.GetMouseButton(0)) {
            f_difX = Mathf.Abs(f_lastX - Input.GetAxis("Mouse X"));

            if (f_lastX < Input.GetAxis("Mouse X")) {
                i_direction = -1;
                //transform.Rotate(Vector3.up, -f_difX);
                transform.Rotate(0, 0, -f_difX);
                //transform.rotation = Quaternion.Euler(0f, 0f, -f_difX);
            }
            if (f_lastX > Input.GetAxis("Mouse X")) {
                i_direction = 1;
                //transform.Rotate(Vector3.one, f_difX);
                transform.Rotate(0, 0, f_difX);
                //transform.rotation = Quaternion.Euler(0f, 0f, -f_difX);
            }

            f_lastX = -Input.GetAxis("Mouse X");
        }
        else {
            if (f_difX > 0.5f) f_difX -= 0.05f;
            if (f_difX < 0.5f) f_difX += 0.05f;

            transform.Rotate(0, 0, f_difX * i_direction);
        }


        //Rotate Y
        if (Input.GetMouseButtonDown(0)) {
            f_difY = 0.0f;
        }
        else if (Input.GetMouseButton(0)) {
            f_difY = Mathf.Abs(f_lastY - Input.GetAxis("Mouse Y"));
            if (Input.mousePosition.x < Screen.width / 2) {
                
                if (f_lastY < Input.GetAxis("Mouse Y")) {
                    i_direction = -1;
                    //transform.Rotate(Vector3.up, -f_difX);
                    transform.Rotate(0, 0, -f_difY);
                    //transform.rotation = Quaternion.Euler(0f, 0f, -f_difX);
                }
                if (f_lastY > Input.GetAxis("Mouse Y")) {
                    i_direction = 1;
                    //transform.Rotate(Vector3.one, f_difX);
                    transform.Rotate(0, 0, f_difY);
                    //transform.rotation = Quaternion.Euler(0f, 0f, -f_difX);
                }
            }
            else if (Input.mousePosition.x > Screen.width / 2) {
                if (f_lastY < Input.GetAxis("Mouse Y")) {
                    i_direction = 1;
                    //transform.Rotate(Vector3.up, -f_difX);
                    transform.Rotate(0, 0, f_difY);
                    //transform.rotation = Quaternion.Euler(0f, 0f, -f_difX);
                }
                if (f_lastY > Input.GetAxis("Mouse Y")) {
                    i_direction = -1;
                    //transform.Rotate(Vector3.one, f_difX);
                    transform.Rotate(0, 0, -f_difY);
                    //transform.rotation = Quaternion.Euler(0f, 0f, -f_difX);
                }
            }

            f_lastY = -Input.GetAxis("Mouse Y");
        }
        else {
            if (f_difY > 0.5f) f_difY -= 0.05f;
            if (f_difY < 0.5f) f_difY += 0.05f;

            transform.Rotate(0, 0, f_difY * i_direction);
        }

    }
}
