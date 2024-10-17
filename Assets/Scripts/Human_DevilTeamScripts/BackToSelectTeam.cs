using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToSelectTeam : MonoBehaviour
{
    public void GoToSelect()
    {
        SceneManager.LoadScene("SelectTeam");
    }
}
