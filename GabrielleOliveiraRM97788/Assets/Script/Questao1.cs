using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Questao1 : MonoBehaviour
{
    private Transform playerTransform;
    [SerializeField] private float velocity;

    private int moeda = 0;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GetComponent<Transform>();
     }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }



    private void PlayerMovement()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        playerTransform.Translate(new Vector3(moveX, moveY, 0) * velocity * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Moeda")
        {
            moeda++;
        }
        if (moeda >= 5)
        {
            print("Foram coletadas" + moeda + "moedas!");
        }
    }
}
