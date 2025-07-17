using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemybace : MonoBehaviour
{
    [SerializeField] int _damage = 5;
    // Start is called before the first frame update
    public virtual void Activate()
    {

    }

   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Activate();
            PlayerController PlayerScript = collision.gameObject.GetComponent<PlayerController>();
            PlayerScript.hp -= _damage;
            Destroy(this.gameObject);
        }
    }
}
