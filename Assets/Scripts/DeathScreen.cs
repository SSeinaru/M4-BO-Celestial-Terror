using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    // Start is called before the first frame update
    public void MenuButton()
    {
        SceneManager.LoadScene(0);
    }
    public void GameButton() 
    {
        SceneManager.LoadScene(1);
    }
        }
