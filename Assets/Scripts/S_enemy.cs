using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_enemy : MonoBehaviour
{
    // Start is called before the first frame update
    S_Player birdie;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        birdie = collision.collider.GetComponent<S_Player>();
        if (birdie!=null)
        {
            Destroy(gameObject);
        }

        if (collision.contacts[0].normal.y < -0.5f)
        {
            Destroy(gameObject);
        }
    
    }
}
