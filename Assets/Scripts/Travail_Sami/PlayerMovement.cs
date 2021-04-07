using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody m_rigidbody;
    public Vector3 move;
    public Slider oxBar;

    public float jetpackForce = 10f;
    public float jetpackDelay = 0f;
    public float moveSpeed = 5f;
    public float fuelUse = 0.0001f;
    public float oxBreathe = 0.00001f;

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

        oxBar.value -= oxBreathe;

        Jetpack();

        PlayerPrefs.SetFloat("Fuel", fuelUse);
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
                    oxBar.value -= fuelUse;

                    if (oxBar.value <= 0f)
                    {
                        Application.Quit();
                    }
                }
            }
        }
    }

}
