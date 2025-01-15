using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private GameObject thingToFollow;
    // this things position (camera) should be the same as the car's position

    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + (Vector3.back * 10);
    }
}
