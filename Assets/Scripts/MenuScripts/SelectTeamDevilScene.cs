using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectTeamDevilScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void GotoSelectDevilTeam()
    {
        SceneManager.LoadScene("DevilScene");
    }
}
