//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class GameManager : MonoBehaviour
//{
//    public static GameManager Instance;

//    public GameState State;

//    public static event Action<GameState> OnGameStateChanged;

//    void Awake()
//    {
//        Instance = this;
//    }


//    // Start is called before the first frame update
//    void Start()
//    {
//        UpdateGameState(GameState.SelectTeam);
//    }


//    public void UpdateGameState(GameState newState)
//    {
//        State = newState;

//        switch (newState)
//        {
//            case GameState.SelectTeam:
//                break;
//            case GameState.GenerateGrid:
//                break;
//            case GameState.PlayerTurn:
//                break;
//            case GameState.EnemyTurn:
//                break;
//            case GameState.Victory:
//                break;
//            case GameState.lose:
//                break;
//            default:
//                throw new ArgumentOutOfRangeException(nameof(newState), newState, null);

//        }

//        OnGameStateChanged?.Invoke(newState);
//    }

    

//    // Update is called once per frame
//    void Update()
//    {
        
//    }
//}

//public enum GameState
//{
//    SelectTeam,
//    PlayerTurn,
//    EnemyTurn,
//    Victory,
//    lose
//}
