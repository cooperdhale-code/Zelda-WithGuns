using Unity.VisualScripting;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float damage;
   private void Start()
    {
        Destroy(gameObject, 10f);
    }

    private void OnTriggerEnter(Collider other)
    {
      if (other.CompareTag("beam"))
        {
            other.GetComponent<healthplayer>().TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
