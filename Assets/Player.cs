using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    [SerializeField] private Vector3 direction;
    [SerializeField] private float speed;
    // Update is called once per frame
    void Update()
    {
        transform.position += direction * Time.deltaTime * speed;
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");
    }
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
