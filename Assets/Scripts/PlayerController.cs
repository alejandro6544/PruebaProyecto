using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{
    public float MovVelocity = 7f;
    private PlayerMotor mr;
    // Start is called before the first frame update
    void Awake()
    {
        mr = this.GetComponent<PlayerMotor>();   
    }

    // Update is called once per frame
    void Update()
    {
        _movX = Input.GetAxis("Horizontal");
        _movZ = Input.GetAxis("Vertical");
    }
}
