using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackLV1 : MonoBehaviour
{
    public void BackToLV1()
    {
        SceneManager.LoadScene("GridScene");
    }
}