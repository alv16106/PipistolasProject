using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

    private const string PLAYER_ID_PREFIX = "Player ";

	private static Dictionary<string, Health> players = new Dictionary<string, Health>();

	public static void RegisterPlayer (string _netID, Health _player)
    {
        string _playerID = PLAYER_ID_PREFIX + _netID;
        players.Add(_playerID, _player);
		Debug.Log (_playerID);
		_player.transform.name = _playerID;
    }

    public static void UnRegisterPlayer (string _playerID)
    {
        players.Remove(_playerID);
    }

	public static Health GetPlayer (string _playerID)
    {
        return players[_playerID];
    }


}