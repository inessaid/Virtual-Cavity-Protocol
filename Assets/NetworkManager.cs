using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class NetworkManager : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        ConnectToServer();
    }

    void ConnectToServer()
	{
		PhotonNetwork.ConnectUsingSettings();
		Debug.Log("Try Connect To Server...");
	}
	
	public override void OnConnectedToMaster()
	
	{
			Debug.Log("Connected To Server.");
			base.OnConnectedToMaster();
			RoomOptions roomOptions = new RoomOptions();
			roomOptions.MaxPlayers = 5;
			roomOptions.IsVisible = true;
			roomOptions.IsOpen = true;
			PhotonNetwork.JoinOrCreateRoom("Room 1",roomOptions, TypedLobby.Default);
		
	}
	
	
}