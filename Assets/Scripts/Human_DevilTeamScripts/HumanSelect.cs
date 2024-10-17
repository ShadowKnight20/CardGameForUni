using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class HumanSelect : MonoBehaviour
{
    public void GoToHumanDeck()
    {
        SceneManager.LoadScene("HumanDeckScene");
    }

}
