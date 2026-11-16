using UnityEngine;

public class ClientObjectPool : MonoBehaviour
{
    private DroneObjectPool _pool;
        
    void Start()
    {
        _pool = gameObject.AddComponent<DroneObjectPool>();
    }

    void Update()
    {
            _pool.Spawn();
    }
}
