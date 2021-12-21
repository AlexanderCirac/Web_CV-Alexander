using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Empujar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    m_velocidad = 8;
    }

  public GameObject m_Objetos;
  public GameObject m_Pos1;
  public GameObject m_Pos2;
  public bool m_activar;
  private float m_velocidad;

    // Update is called once per frame
    void Update()
    {
    MoverTrampa();
    }

  void MoverTrampa()
  {
    if (m_activar)
    {
      if (m_Objetos.transform.position.x > m_Pos1.transform.position.x)
      {

        m_Objetos.transform.position = new Vector3(m_Objetos.transform.position.x - m_velocidad * Time.deltaTime, m_Objetos.transform.position.y, m_Objetos.transform.position.z);
      }
      else
      {
        m_activar = false;
      }
    }
    else
    {
      if (m_Objetos.transform.position.x < m_Pos2.transform.position.x)
      {

        m_Objetos.transform.position = new Vector3(m_Objetos.transform.position.x + m_velocidad * Time.deltaTime, m_Objetos.transform.position.y, m_Objetos.transform.position.z);
      }
    }
  }

  private void OnTriggerEnter(Collider coll)
  {
    if (coll.CompareTag ("Player"))
    {
      if (!m_activar)
      {
        m_activar = true;
      }
      coll.GetComponent<Rigidbody>().mass = 50;
    }
  }  
  private void OnTriggerExit(Collider coll)
  {
    if (coll.CompareTag ("Player"))
    {
      coll.GetComponent<Rigidbody>().mass = 1;
    }
  } 

}
