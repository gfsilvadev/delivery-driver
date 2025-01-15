using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] private float steerSpeed = 250f;
    [SerializeField] private float moveSpeed = 30f;

    void Start()
    {
        
    }

    void Update()
    {
        var steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        var moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
}
