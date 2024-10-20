using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChageToBattle : MonoBehaviour
{
    public void GotoBattleScene()
    {
        SceneManager.LoadScene("GridScene");
    }
}
