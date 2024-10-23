using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoNextLevel3 : MonoBehaviour
{
    public void GotoNextLV3()
    {
        SceneManager.LoadScene("Level3");
    }
}
