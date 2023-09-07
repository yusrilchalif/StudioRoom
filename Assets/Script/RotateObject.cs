using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RotateObject : MonoBehaviour
{
    // Kecepatan rotasi objek
    public float rotationSpeed = 2.0f;

    // Simpan rotasi awal objek
    private Vector3 initialRotation;

    private void Start()
    {
        // Simpan rotasi awal objek saat dimulai
        initialRotation = transform.eulerAngles;
    }

    private void Update()
    {
        // Ambil input mouse berdasarkan sumbu X
        float mouseX = Input.GetAxis("Mouse X");

        // Hitung perubahan rotasi
        Vector3 rotation = new Vector3(0, mouseX * rotationSpeed, 0);

        // Terapkan rotasi pada objek
        transform.eulerAngles = initialRotation + rotation;
    }
}