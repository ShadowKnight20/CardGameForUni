using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToHumanTeam : MonoBehaviour
{
    // Start is called before the first frame update
    public void BackToH_Team()
    {
        SceneManager.LoadScene("HumanScene");
    }
}
