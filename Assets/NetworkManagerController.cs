using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Networking.Match;

public class NetworkManagerController : NetworkBehaviour {

    public NetworkManager NetworkManagerRef;

    public bool IsServer = false;

	// Use this for initialization
	void Start () {
        if (!IsServer)
        {
           this.NetworkManagerRef.StartClient();
        }
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
