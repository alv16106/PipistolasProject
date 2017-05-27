using UnityEngine;
using UnityEngine.Networking;

[RequireComponent(typeof(Health))]
public class setUp : NetworkBehaviour {

	[SerializeField]
	Behaviour[] desactivar;

	void Start ()
	{
		//mask = LayerMask.NameToLayer("Otros") ;
		// Disable components that should only be
		// active on the player that we control
		if (!isLocalPlayer)
		{
			DisableComponents();
			AssignRemoteLayer();
		}
	}

    public override void OnStartClient()
    {
        base.OnStartClient();

        string _netID = GetComponent<NetworkIdentity>().netId.ToString();
		Health _player = GetComponent<Health>();

        GameManager.RegisterPlayer(_netID, _player);
    }

    void AssignRemoteLayer ()
	{
		gameObject.layer = 10;
	}

	void DisableComponents ()
	{
		for (int i = 0; i < desactivar.Length; i++)
		{
			desactivar[i].enabled = false;
		}
	}

}