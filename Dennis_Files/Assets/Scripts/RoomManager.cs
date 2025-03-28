using UnityEngine;
using Photon.Pun;

public class RoomManager : MonoBehaviourPunCallbacks
{
    public string roomCode = "Map1";

    void Start()
    {
        // 1 - Connect to master server (this is like a main menu with settings, store, room list, etc.)
        // 2 - Join the lobby (view all the active games/servers "rooms" in Photon)
        // 3 - Join one of the rooms
        // 4 - Spawn the player on one of the rooms/servers

        Debug.Log("Connecting...");
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Joining lobby...");

        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        Debug.Log("Joining or creating room...");

        PhotonNetwork.JoinOrCreateRoom(roomCode, null, null);
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("Joined room. Spawning player!");


    }



}
