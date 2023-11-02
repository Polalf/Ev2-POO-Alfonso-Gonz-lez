using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{ 
    private Rigidbody2D rb;
    [SerializeField]private float speed = 5f;
    public int life = 10;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        
        rb.AddForce(new Vector2(x,y) * Time.deltaTime*speed);
    }

    public void GetDamage()
    {
        life -= 1;
        if(life <= 0)Death();
    }
    public void Death()
    {
        Destroy(gameObject);
        SceneManager.LoadScene(0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Interactable interactable))
        {
            interactable.Interact(this);
        }
    }
}
