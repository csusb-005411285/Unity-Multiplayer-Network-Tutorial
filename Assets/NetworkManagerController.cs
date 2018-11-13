using UnityEngine;
using UnityEngine.Networking;

public class NetworkManagerController : NetworkBehaviour {

    public NetworkManager NetworkManagerRef;

	// Use this for initialization
	void Start () {
        if (SystemInfo.deviceType == DeviceType.Desktop && SystemInfo.deviceModel == "Alienware Aurora R7 (Alienware)")
        {
            this.NetworkManagerRef.StartHost();
        }
        if (SystemInfo.deviceType == DeviceType.Handheld)
        {
            this.NetworkManagerRef.StartClient();
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
