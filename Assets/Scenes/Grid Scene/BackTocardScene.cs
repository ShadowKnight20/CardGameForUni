using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackTocardScene : MonoBehaviour
{
    public void BackToCardScene()
    {
        SceneManager.LoadScene("CardScene");
    }
}
