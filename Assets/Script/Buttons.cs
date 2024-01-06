using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
  public void LoadLevel()
    {
        SceneManager.LoadScene("lvl1");
    }
   public void ExitGame()
    {

    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene("lvl2");
    }
}
