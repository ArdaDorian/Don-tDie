using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class advancedwalk : MonoBehaviour
{
    [SerializeField] public float speed;
    public Rigidbody2D body;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed * Time.deltaTime, Input.GetAxis("Vertical") * speed * Time.deltaTime);

        float horizontal = Input.GetAxis("Horizontal");

        if (horizontal > 0)
        {
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (horizontal < 0)
        {
            gameObject.transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
