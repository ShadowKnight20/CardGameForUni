using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoNextLevel2 : MonoBehaviour
{
    public void GotoNextLV2()
    {
        SceneManager.LoadScene("Level2");
    }
}

