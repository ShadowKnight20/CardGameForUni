using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChageToCard : MonoBehaviour
{
    public void GotoCardScene()
    {
        SceneManager.LoadScene("CardScene");
    }
}
