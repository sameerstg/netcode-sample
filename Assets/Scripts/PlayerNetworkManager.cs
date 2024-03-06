using Unity.Netcode;
using UnityEngine;

public class PlayerNetworkManager : MonoBehaviour
{
    public GameObject myPrefab;
    private void Start()
    {
        var instance = Instantiate(myPrefab,Vector3.up,Quaternion.identity);
        var instanceNetworkObject = instance.GetComponent<NetworkObject>();
        instanceNetworkObject.Spawn(true);
    }
}
