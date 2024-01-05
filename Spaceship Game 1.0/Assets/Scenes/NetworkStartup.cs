using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NetworkStartup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  public void StartServer()
  {
    GetComponent<NetworkManager>().StartServer();
  }

  public void StartClient()
  {
    GetComponent<NetworkManager>().StartClient();
  }

  public void NextScene()
  {
    SceneManager.LoadScene("Movement Work");
  }

}
