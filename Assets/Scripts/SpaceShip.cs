using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour
{
    private Rigidbody2D Rig;
    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
        Rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        /**/
        if (Input.GetKey(KeyCode.D))
        {
            Rig.velocity = new Vector2(Speed * Time.deltaTime, Rig.velocity.y);
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            Rig.velocity = new Vector2(0f, Rig.velocity.y);
        }

        if (Input.GetKey(KeyCode.A))
        {
            Rig.velocity = new Vector2(-Speed * Time.deltaTime, Rig.velocity.y);
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            Rig.velocity = new Vector2(0f, Rig.velocity.y);
        }
        /**/

        /**/
        if (Input.GetKey(KeyCode.W))
        {
            Rig.velocity = new Vector2(Rig.velocity.x, Speed * Time.deltaTime);
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            Rig.velocity = new Vector2(Rig.velocity.x, Rig.velocity.y);
        }

        if (Input.GetKey(KeyCode.S))
        {
            Rig.velocity = new Vector2(Rig.velocity.x, -Speed * Time.deltaTime);
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            Rig.velocity = new Vector2(Rig.velocity.x, Rig.velocity.y);
        }
        /**/
    }
}
