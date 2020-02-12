using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    public bool   m_isFallIn     = false;
    public string m_strActiveTag = "";

    public bool IsFallIn()
    {
        return m_isFallIn;
    }

    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == m_strActiveTag)
        {
            m_isFallIn = true;
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if(collider.gameObject.tag == m_strActiveTag)
        {
            m_isFallIn = false;
        }
    }

    void OnTriggerStay(Collider collider)
    {
        Rigidbody  rigidbody = collider.GetComponent<Rigidbody>();
        Vector3 vecDirection = transform.position - collider.gameObject.transform.position;

        vecDirection.Normalize();

        if(collider.gameObject.tag == m_strActiveTag)
        {
            rigidbody.velocity *= 0.9f;

            rigidbody.AddForce(vecDirection * rigidbody.mass * 20.0f);
        }
        else
        {
            rigidbody.AddForce(-vecDirection * rigidbody.mass * 80.0f);
        }
    }
}
