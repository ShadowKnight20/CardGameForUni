using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectTeamHumanScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void GotoSelectHumanTeam()
    {
        SceneManager.LoadScene("HumanScene");
    }
}
