
using UnityEngine;

public class walk : MonoBehaviour
{
   [SerializeField] public float speed;
   public Rigidbody2D body;
   public bool isGlassOn = false;
   public Sprite glassesOnSprite;

   public void Awake()
   {
        body = GetComponent<Rigidbody2D>();
   }

    public void Update()
    {
       body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed*Time.deltaTime, body.velocity.y);

       float horizontal=Input.GetAxis("Horizontal");
       
       if (horizontal > 0) 
       {
            gameObject.transform.localScale = new Vector3(-1,1,1);
       }
       else if (horizontal < 0)
       {
            gameObject.transform.localScale = new Vector3(1,1,1);
       }
    }


    void OnTriggerStay2D(Collider2D other)
    {
        if (other.TryGetComponent<Glasses>(out var glasses))
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Destroy(other.gameObject);
                isGlassOn = true;
                ChangeSprite();
            }
        }
    }

    void ChangeSprite()
    {
        GetComponent<SpriteRenderer>().sprite = glassesOnSprite;
    }

}

