using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ball : MonoBehaviour
{
    public Text RSText;
    public Text LSText;
    public float speed = 100;
    public int RS;
    public int LS;
    float hitFactor(Vector2 ballposition, Vector2 racketposition, float rackethight)
    {
        return (ballposition.y - racketposition.y) / rackethight;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "LR")
        {
            float y = hitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.y);
            Vector2 dir = new Vector2(1, y).normalized;
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
        if (collision.gameObject.name == "RR")
        {
            float y = hitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.y);
            Vector2 dir = new Vector2(1, y).normalized; GetComponent<Rigidbody2D>().velocity = dir * speed;
        }


        if(collision.gameObject.name =="RB")
        { RS ++;
            RSText.text = RS.ToString();
        }
        if(collision.gameObject.name =="LB")
        { LS++;
            LSText.text = LS.ToString();
        }
    }


    // Start is called before the first frame update

    void Start()
    {
        //Inisializer la vitesse
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;

    }

    void Update()
    {


    }

}