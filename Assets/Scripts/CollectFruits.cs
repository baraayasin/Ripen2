using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectFruits : MonoBehaviour
{
   [SerializeField] GameObject[] Fruits;
   [SerializeField] Text Txt;
    [SerializeField]float speed=2f;
    int sum = 0;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Fruits.Length; i++)
        {
            Fruits[i].GetComponent<Rigidbody2D>().gravityScale= 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(Input.GetAxis("Horizontal") * speed, 0, 0));
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Fruits"))
        {
            if (sum >= 5)
            {
                for (int i = 0; i < Fruits.Length; i++)
                {
                    Fruits[i].GetComponent<Rigidbody2D>().gravityScale =5;
                }

            }
            if (sum >= 10)
            {
                for (int i = 0; i < Fruits.Length; i++)
                {
                    Fruits[i].GetComponent<Rigidbody2D>().gravityScale= 10;
                }

            }
            sum++;
            Destroy(collision.gameObject);
            Txt.text = " " + sum + " ";
            

        }
    }
}
