using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_ColisionadorModelo3D : MonoBehaviour
{
  // Start is called before the first frame update

  public GameObject m_Ver;
  public GameObject m_objOcul1;
  public GameObject m_objOcul2;
  public GameObject m_objOcul3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  private void OnTriggerEnter(Collider coll)
  {
    if (coll.CompareTag("Player"))
    {
      m_Ver.SetActive(true);
      m_objOcul1.SetActive(false);
      m_objOcul1.SetActive(false);
      m_objOcul1.SetActive(false);
    }
  }
  private void OnTriggerExit(Collider coll)
  {
    if (coll.CompareTag("Player"))
    {
      m_Ver.SetActive(false);
      m_objOcul1.SetActive(false);
      m_objOcul1.SetActive(false);
      m_objOcul1.SetActive(false);
    }
  }
}
