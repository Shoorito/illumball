using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    const  float   m_fGravity       = 9.81f;
    public float   m_fGravityScale  = 1.0f;
    public Vector3 m_vecGravity     = new Vector3();

    // Update is called once per frame
    void Update()
    {
        m_vecGravity.x = Input.GetAxis("Horizontal");
        m_vecGravity.z = Input.GetAxis("Vertical");

        if(Application.isEditor)
        {
            if (Input.GetKey("z"))
                m_vecGravity.y = 1.0f;
            else
                m_vecGravity.y = -1.0f;
        }
        else
        {
            m_vecGravity.x = Input.acceleration.x;
            m_vecGravity.z = Input.acceleration.y;
            m_vecGravity.y = Input.acceleration.z;
        }

        Physics.gravity = m_fGravity * m_vecGravity.normalized * m_fGravityScale;
    }
}
