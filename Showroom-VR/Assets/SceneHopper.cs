using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHopper : MonoBehaviour
{
    [SerializeField] public int sceneIndex = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        HandleInput();
    }

    public void HandleInput()
    {
       // if (Input.GetKeyDown(KeyCode.Return))
        {
            //SceneManager.LoadSceneAsync("SwitchToKuka", LoadSceneMode.Additive);
        //    SceneManager.LoadSceneAsync(sceneIndex, LoadSceneMode.Single);
        }
    }

    public void Load2x2()
    {
        SceneManager.LoadSceneAsync(0, LoadSceneMode.Single);
    }

    public void Load3x2()
    {
        SceneManager.LoadSceneAsync(1, LoadSceneMode.Single);
    }

    public void Load3x3()
    {
        SceneManager.LoadSceneAsync(2, LoadSceneMode.Single);
    }

}
