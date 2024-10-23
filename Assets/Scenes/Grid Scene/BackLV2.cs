using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackLV2 : MonoBehaviour
{
    public void BackToLV2()
    {
        SceneManager.LoadScene("Level2");
    }
}