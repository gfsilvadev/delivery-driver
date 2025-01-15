using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] private float boostSpeed = 30f;
    [SerializeField] private float moveSpeed = 20f;
    [SerializeField] private float slowSpeed = 15f;
    [SerializeField] private float steerSpeed = 225f;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "SpeedDown") moveSpeed = slowSpeed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "SpeedUp") moveSpeed = boostSpeed;
    }

    private void Update()
    {
        var steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        var moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
}