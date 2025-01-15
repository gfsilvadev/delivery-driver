using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color hasPackageColor = new(0,1,0,1);
    [SerializeField] Color noPackageColor = new(1, 1, 1, 1);

    [SerializeField] float destroyDelay = 0.3f;
    bool _hasPackage;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !_hasPackage)
        {
            Debug.Log("Package picked up!");
            _hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroyDelay);
        }
        else if (other.tag == "Customer" && _hasPackage)
        {
            Debug.Log("Package delivered!");
            _hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
