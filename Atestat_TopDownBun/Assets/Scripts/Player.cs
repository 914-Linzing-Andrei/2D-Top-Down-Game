using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public GameOverScreen GameOverScreen;
    public Joystick joystick;

    public Weapon currentWeapon;

    public float moveSpeed = 10f;

    public Rigidbody2D rb;
    public Camera cam;
    Vector2 movement;
    Vector2 mousePos;

    private float nextTimeOfFire = 0f;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if(Time.time >= nextTimeOfFire)
            {
                currentWeapon.Shoot();
                nextTimeOfFire = Time.time + 1 / currentWeapon.fireRate;
            }
            
        }

        transform.position = new Vector2(Mathf.Clamp(transform.position.x,-23.4f,35.62f),Mathf.Clamp(transform.position.y,-29.49f,29.6f));

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }

    [SerializeField]
    public int health;

    private bool hit = true;
    IEnumerator HitBoxOf()
    {
        hit = false;
        yield return new WaitForSeconds(1.5f);
        hit = true;
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "Enemy")
        {
            health--;
            StartCoroutine(HitBoxOf());
            OnTriggerStay2D(target);
        }
    }
    void OnTriggerStay2D(Collider2D target)
    {
       
        if (target.tag == "Enemy")
        {
            if (hit == true)
            {
                StartCoroutine(HitBoxOf());
                health--;
                if(health <= 0)
                {
                    GameOverScreen.Setup(Score.scoreValue);
                    Time.timeScale = 0f;
                }
            }
        }
    }
    
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
