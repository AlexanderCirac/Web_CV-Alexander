using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Runtime.InteropServices;

using UnityEngine.UI;

public class Coso : MonoBehaviour
{
  public Image m_coso;

    // Start is called before the first frame update
    void Start()
    {
        
    }
  public Camera m_a;
    // Update is called once per frame
    void Update()
    {
    if (IsHardwareAccelerationOn == false)
    {
     // AspectUtility.MainCamera.allowMSAA = false;
      Camera.main.allowMSAA = false;
      QualitySettings.antiAliasing = 0;
    }
  }

  private bool IsHardwareAccelerationOn
  {
    get { return !SystemInfo.graphicsDeviceName.Contains("SwiftShader"); }
  }




public  void Interior()
  {
    if (!m_m1)
    {
    m_coso.color = new Color32(125,125,125,255);
    }
  }  

  public  void Exit()
  {
    m_coso.color = new Color32(255, 255, 255, 255);
    m_m1 = false;
  }

  public void Clic()
  {
    m_coso.color = new Color32(255, 255, 255, 255);
    m_m1 = true;
  }
  private bool m_m1;


  public void CargarNivel(int m_nivel)
  {
    SceneManager.LoadScene(m_nivel);
  }  
  public void CargarURL(string m_URL)
  {
    Application.OpenURL(m_URL);
  }


  public void descargar()
  {

  }
}
