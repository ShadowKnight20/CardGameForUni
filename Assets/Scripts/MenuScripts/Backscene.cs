using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Backscene : MonoBehaviour
{
    // Start is called before the first frame update
    public void BackScene()
    {
        SceneManager.LoadScene("GameMenu");
    }
}