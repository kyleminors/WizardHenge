using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RunScene : MonoBehaviour
{
    public VisualEffect[] visualEffects;

    public Rigidbody[] cubes;


    public string sceneName;

    [SerializeField]
    private float speed;

    [SerializeField]
    private float targetHeight;

    private Button startButton;

    void Start()
    {
        startButton = GameObject.FindGameObjectWithTag("startButton").GetComponent<Button>();
        startButton.onClick.AddListener(LoadScene);
        RaiseBlocks(); 
    }


    private void LoadScene()
    {
        SceneManager.LoadScene(sceneName); 
    }

    private void RaiseBlocks()
    {

        foreach(Rigidbody cube in cubes)
        {
            cube.AddForce(Vector3.up * (Time.deltaTime + speed));
            cube.gameObject.transform.Rotate(0, 1, 0); 
        }


      
    }

    
}
