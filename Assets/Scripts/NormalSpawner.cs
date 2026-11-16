using UnityEngine;

public class NormalSpawner : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        GameObject gm = Instantiate(GameObject.CreatePrimitive(PrimitiveType.Cube), new Vector3(0, 0, 0), Quaternion.identity);
        gm.AddComponent<Drone>();
        Destroy(gm, 5f);
        gm.transform.position = Random.insideUnitSphere * 10;
    }
}
