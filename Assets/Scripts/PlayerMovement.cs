using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float turnSpeed;
    public float runSpeed;

    Animator m_Animator;
    Rigidbody m_Rigidbody;
    Vector3 m_Movement;
    Quaternion m_Rotation = Quaternion.identity;

    void Start ()
    {
        m_Animator = GetComponent<Animator> ();
        m_Rigidbody = GetComponent<Rigidbody> ();
    }

    void FixedUpdate ()
    {
        // 前進・後退
        float vertical = Input.GetAxis ("Vertical");
        bool hasVerticalInput = !Mathf.Approximately (vertical, 0f);
        m_Animator.SetBool ("IsWalking", hasVerticalInput);
        if(hasVerticalInput){
            m_Movement = transform.forward * runSpeed * vertical * Time.deltaTime;
            m_Rigidbody.MovePosition (m_Rigidbody.position + m_Movement);
        }

        // 回転
        float horizontal = Input.GetAxis ("Horizontal");
        bool hasHorizontalInput = !Mathf.Approximately (horizontal, 0f);
        if(hasHorizontalInput){
            m_Rotation = Quaternion.Euler (0f, turnSpeed * horizontal * Time.deltaTime, 0f);
            m_Rigidbody.MoveRotation (m_Rigidbody.rotation * m_Rotation);
        }

    }
}