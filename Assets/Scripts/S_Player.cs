using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S_Player : MonoBehaviour
{
    Vector3 _innitialpos;
    Rigidbody2D rigid;
    [SerializeField]
    float pow=500;
    bool launch;
    float timer=0.0f;
    LineRenderer line;

    private void Awake()
    {
       _innitialpos =transform.position;
    }

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        line = GetComponent<LineRenderer>();
    }

    void Update()
    {
        line.SetPosition(1, _innitialpos);
        line.SetPosition(0, transform.position);
        string name = SceneManager.GetActiveScene().name;
        if (launch && rigid.velocity.magnitude <= 0.1f)
        {
            timer += Time.deltaTime; 
        }

        
        
        if (transform.position.y > 300|| transform.position.x > 300 ||timer>=3.0f)
        {
            
            SceneManager.LoadScene(name);
                 
        }
        
    }
    private void OnMouseDown()
    {
        line.enabled = true;
    }

    private void OnMouseUp()
    {
        Vector2 dir = _innitialpos - transform.position;
        rigid.AddForce(dir*pow);
        rigid.gravityScale = 1;
        launch = true;
        line.enabled = false;
    }

    private void OnMouseDrag()
    {
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(newPosition.x, newPosition.y);

    }

}
