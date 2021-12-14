using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_ColisionURL : MonoBehaviour
{
  public string m_URL;
    // Start is called before the first frame update
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
      Application.OpenURL(m_URL);
    }
  }
}
