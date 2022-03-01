using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class move : MonoBehaviour
{
    float speed=10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    void Update()
    {
        speed=speed+0.003f;
        transform.position += Camera.main.transform.forward * Time.deltaTime*speed;
        if(Input.GetMouseButtonDown(0))SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
