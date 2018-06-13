using UnityEngine;

public class KeyboardOrbit : MonoBehaviour
{
    public int Speed = 5;

    void Update()
    {
        float xAxisValue = Input.GetAxis("Vertical") * Speed;
        float zAxisValue = -Input.GetAxis("Horizontal") * Speed;

        transform.position = new Vector3(transform.position.x + xAxisValue, transform.position.y, transform.position.z + zAxisValue);
    }
}