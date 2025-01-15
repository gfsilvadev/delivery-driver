using UnityEngine;

public class Delivery : MonoBehaviour
{
    private bool _hasPackage;
    [SerializeField] float destroyDelay = 0.3f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !_hasPackage)
        {
            Debug.Log("Package picked up!");
            _hasPackage = true;
            Destroy(other.gameObject, destroyDelay);
        }
        else if (other.tag == "Customer" && _hasPackage)
        {
            Debug.Log("Package delivered!");
            _hasPackage = false;
        }
    }
}
