using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinTest_5 : MonoBehaviour
{
    float f_lastX = 0.0f;
    float f_difX = 0.5f;
    float f_lastY = 0;
    float f_difY = 0;
    float f_steps = 0.0f;
    int i_direction = 1;
    public float rotationSpeedX;
    public float rotationSpeedY;

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

            if (Input.mousePosition.y > Screen.height / 2) {

                if (f_lastX < Input.GetAxis("Mouse X")) {
                    i_direction = -1;
                    transform.Rotate(0, 0, -f_difX + Time.deltaTime);
                }
                if (f_lastX > Input.GetAxis("Mouse X")) {
                    i_direction = 1;
                    transform.Rotate(0, 0, f_difX + Time.deltaTime);
                }
            }
            else if (Input.mousePosition.y < Screen.height / 2) {
                if (f_lastX < Input.GetAxis("Mouse X")) {
                    i_direction = 1;
                    transform.Rotate(0, 0, f_difX + Time.deltaTime);
                }
                if (f_lastX > Input.GetAxis("Mouse X")) {
                    i_direction = -1;
                    transform.Rotate(0, 0, -f_difX + Time.deltaTime);
                }
            }

            f_lastX = -Input.GetAxis("Mouse X");
        }
        else {
            if (f_difX > 0.1f) f_difX -= 0.05f;
            if (f_difX < 0.1f) f_difX += 0.05f;
            rotationSpeedX = f_difX;
            if (rotationSpeedX < 0.15 && rotationSpeedX > -0.15) {
                f_difX = 0;
            }
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
                    transform.Rotate(0, 0, -f_difY + Time.deltaTime);
                }
                if (f_lastY > Input.GetAxis("Mouse Y")) {
                    i_direction = 1;
                    transform.Rotate(0, 0, f_difY + Time.deltaTime);
                }
            }
            else if (Input.mousePosition.x > Screen.width / 2) {
                if (f_lastY < Input.GetAxis("Mouse Y")) {
                    i_direction = 1;
                    transform.Rotate(0, 0, f_difY + Time.deltaTime);
                }
                if (f_lastY > Input.GetAxis("Mouse Y")) {
                    i_direction = -1;
                    transform.Rotate(0, 0, -f_difY + Time.deltaTime);
                }
            }

            f_lastY = -Input.GetAxis("Mouse Y");
        }
        else {
            if (f_difY > 0.1f) f_difY -= 0.05f;
            if (f_difY < 0.1f) f_difY += 0.05f;
            rotationSpeedY = f_difY;
            if (rotationSpeedY < 0.11f && rotationSpeedY > -0.11f) {
                f_difY = 0f;
            }
            else if (rotationSpeedX == 0.05f && rotationSpeedY < 0.15f && rotationSpeedY > -0.15f) {
                    f_difY = 0f;
            }
            transform.Rotate(0, 0, f_difY * i_direction);
        }

    }
}
