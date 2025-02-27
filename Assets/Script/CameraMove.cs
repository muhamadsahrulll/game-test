using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float speed = 5.0f;
    private bool canMove = false; // Kamera tidak bisa bergerak saat game dimulai
    // Start is called before the first frame update

    void Update()
    {
        if (!canMove) return; // Jika canMove == false, hentikan Update()

        transform.position += transform.forward * Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.position += transform.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime;
    }

    public void StartMovement()
    {
        canMove = true; // Aktifkan gerakan saat tombol ditekan
    }
}
