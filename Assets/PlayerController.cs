using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // ========= MOVEMENT =================
    public float speed = 4;

    // =========== MOVEMENT ==============
    Rigidbody2D rigidbody2d;
    Vector2 currentInput;

    // ==== ANIMATION =====
    Animator animator;
    Vector2 lookDirection = new Vector2(0, -1);

    void Start()
    {
        // =========== MOVEMENT ==============
        rigidbody2d = GetComponent<Rigidbody2D>();

        // ==== ANIMATION =====
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Run();
        }
        else
        {
            // ============== MOVEMENT ======================
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            Vector2 move = new Vector2(horizontal, vertical);

            if (!Mathf.Approximately(move.x, 0.0f) || !Mathf.Approximately(move.y, 0.0f))
            {
                lookDirection.Set(move.x, move.y);
                lookDirection.Normalize();
            }

            currentInput = move;

            // ============== ANIMATION =======================
            animator.SetFloat("Look X", lookDirection.x);
            animator.SetFloat("Look Y", lookDirection.y);
            animator.SetFloat("Speed", move.magnitude);
        }

    }

    void FixedUpdate()
    {
        // ============== MOVEMENT ======================
        Walk();
    }

    // ============== MOVEMENT_Walk ======================
    private void Run()
    {
        Debug.Log("People can run!");
        Debug.Log("Current Position for Mouse: " + Camera.main.ScreenToWorldPoint(Input.mousePosition));
        
    }


    // ============== MOVEMENT_Walk ======================
    private void Walk()
    {
        Vector2 position = rigidbody2d.position;
        position = position + currentInput * speed * Time.deltaTime;
        rigidbody2d.MovePosition(position);
    }


    
}
