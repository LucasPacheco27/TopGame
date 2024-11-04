using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rig;
    private Vector2 direction;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();

    }

    private void Update() // Ideal para capturar inputs e logicas sem fisica
    {
        direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    private void FixedUpdate() // Ideal para fisica como manipular rigidbody
    {
        rig.MovePosition(rig.position + direction * speed * Time.fixedDeltaTime); //Moveposition é a posicao do rigidbody na cena
    }
}
