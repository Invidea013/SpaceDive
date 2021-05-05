using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public Slider oxBar;
    public CharacterController controller;
    public Transform groundCheck;
    public RawImage oxUI;
    public Texture[] oxTextures;

    public AudioSource[] AudioList;

    public GameObject flashLight;
    public GameObject mapUI;
    public GameObject[] oxBars;

    public Vector3 velocity;
    bool isGrounded;

    public float jetpackForce = 10f;
    public float jetpackDelay = 0f;

    public float moveSpeed;
    public float sprintSpeed = 10f;
    public float moveSpeedBase = 5f;
    public float jumpHeight = 3f;

    public float gravity = -9.81f;
    public float groundDistance = 0.4f;

    public float fuelUse = 0.0001f;

    public float oxBreatheBase = 0.00001f;
    public float oxBreathe;
    public float oxSprint = 0.00005f;
    public float oxTimeDelay = 3f;

    public bool canJump = true;
    public bool usingJetpack = false;
    public bool consOx = true;
    public bool flashOn = false;
    public bool mapOn = false;

    public LayerMask groundMask;

    void Start()
    {
        moveSpeed = moveSpeedBase;
        oxBreathe = oxBreatheBase;
    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * moveSpeed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = sprintSpeed;
            if (consOx)
            {
                oxBreathe = oxSprint;
            }
        }

        else
        {
            moveSpeed = moveSpeedBase;
            oxBreathe = oxBreatheBase;
        }

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = 0f;
            jetpackDelay = 0f;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        if (consOx == true)
        {
            oxBar.value -= oxBreathe;
        }
        
        if(consOx == false)
        {
            oxTimeDelay -= Time.deltaTime;
        }

        if (oxTimeDelay <= 0f)
        {
            oxTimeDelay = 3f;
            consOx = true;
        }

        Jetpack();
        Flashlight();
        OxBarModif();
        MovementAudio();
        MapRollup();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Pickup_1") && oxBar.value < 1)
        {
            oxBar.value += 0.25f;
            Destroy(other.gameObject);
        }

        if(other.CompareTag("Pickup_2"))
        {
            consOx = false;
            Destroy(other.gameObject);
        }
    }

    public void Flashlight()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1) && flashOn == false)
        {
            flashLight.SetActive(true);
            flashOn = true;
        }

        else if (Input.GetKeyDown(KeyCode.Mouse1) && flashOn == true)
        {
            flashLight.SetActive(false);
            flashOn = false;
        }
    }

    public void Jetpack()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            jetpackDelay += Time.deltaTime;

            if(jetpackDelay >= 0.35f)
            {
                usingJetpack = true;
                if(!AudioList[2].isPlaying)
                {
                    AudioList[2].Play();
                }

                if (usingJetpack == true)
                {
                    velocity.y += jetpackForce * Time.deltaTime;
                    if (consOx)
                    { 
                        oxBar.value -= fuelUse; 
                    }
                }
            }
        }

        else
        {
            usingJetpack = false;
            velocity.y -= Time.deltaTime;
            AudioList[2].Stop();
        }

    }

    public void OxBarModif()
    {
        if(oxBar.value <= 1.2f)
        {
            oxUI.texture = oxTextures[0];
        }

        if(oxBar.value <= 1f)
        {
            oxUI.texture = oxTextures[1];
        }

        if (oxBar.value <= 0.8f)
        {
            oxUI.texture = oxTextures[2];
        }

        if (oxBar.value <= 0.6f)
        {
            oxUI.texture = oxTextures[3];
        }

        if (oxBar.value <= 0.4f)
        {
            oxUI.texture = oxTextures[4];
        }

        if (oxBar.value <= 0.2f)
        {
            oxUI.texture = oxTextures[5];
        }

        else
        {
            AudioList[5].Stop();
        }
    }


    public void MovementAudio()
    {
        if(Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            if (!AudioList[0].isPlaying)
            {
                AudioList[0].Play();
            }

            if (Input.GetKey(KeyCode.LeftShift))
            {
                AudioList[0].Stop();
                Debug.Log("Hello");
                    
                if (!AudioList[1].isPlaying)
                {
                    AudioList[1].Play();
                }
            }
        }

        else
        {
            AudioList[0].Stop();
        }

        if (isGrounded == false)
        {
            AudioList[0].Stop();
            AudioList[1].Stop();
        }

        if(AudioList[0].isPlaying)
        {
            AudioList[1].Stop();
        }
    }

    public void MapRollup()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && mapOn == false)
        {
            mapUI.SetActive(true);
            mapOn = true;
        }

        else if (Input.GetKeyDown(KeyCode.Tab) && mapOn == true)
        {
            mapUI.SetActive(false);
            mapOn = false;
        }
    }

    /*public void Victory()
    {

    }*/

    /*public void Defeat()
    {
        if(oxBar.value <= 0f)
        {
            SceneManager.LoadScene(3);
        }
    }*/

}
