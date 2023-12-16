using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[AddComponentMenu("MyComponent/Teleport")]
public class Teleport1 : MonoBehaviour
{
    [Header("lvl2")]
    public int sceneIndex;
    void OnTriggerEnter(Collider myCollider)
    {
        if (myCollider.tag == "Player")
        {
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
