using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody m_rigidbody;
    public Vector3 move;

    public float jetpackForce = 10f;
    public float jetpackDelay = 0f;
    public float moveSpeed = 5f;
    public float oxFuel = 1f;

    public int forceConst = 50;

    public bool canJump = true;
    public bool usingJetpack = false;

    void FixedUpdate()
    {
        move = Vector3.zero;

        move.x = Input.GetAxisRaw("Horizontal");
        move.z = Input.GetAxisRaw("Vertical");

        m_rigidbody.MovePosition(transform.position + (move * Time.fixedDeltaTime * moveSpeed));

        Jetpack();
    }

    void Update()
    {
        if (canJump == true && Input.GetKeyDown(KeyCode.Space))
        {
            m_rigidbody.AddForce(0, forceConst * Time.deltaTime, 0, ForceMode.Impulse);
            canJump = false;
        }

        Jetpack();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground") && canJump == false)
        {
            canJump = true;
        }
    }

    public void Jetpack()
    {
        if(Input.GetKey(KeyCode.Space) && canJump == false)
        {
            jetpackDelay += Time.deltaTime;

            if(jetpackDelay >= 1f)
            {
                usingJetpack = true;

                if (usingJetpack == true)
                {
                    m_rigidbody.AddForce(0, jetpackForce * Time.deltaTime, 0, ForceMode.Force);
                    oxFuel -= 0.0001f;

                    if (oxFuel <= 0f)
                    {
                        usingJetpack = false;
                    }
                }
            }
        }
    }

}
