using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maincharacter : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float jumpstrength;
    public LogicScript logic;
    public bool mainCharacterAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && mainCharacterAlive == true)
        {
        myRigidbody.velocity = Vector2.up*jumpstrength;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        mainCharacterAlive = false;
    }
}
