using UnityEngine;

public class SpawnPipe : MonoBehaviour
{
    public GameObject pipesAsset;
    public float spawnTimer = 1f;
    public float minHeight = -1f;
    public float maxHeight = 1f;

    private void OnEnable()
    {
        //enable spawning on enable 
        InvokeRepeating(nameof(Spawn), spawnTimer, spawnTimer);

    }

    private void OnDisable()
    {
        //disable spawning on disable
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()
    {
        //spawn pipes
        GameObject pipes = Instantiate(pipesAsset, transform.position, Quaternion.identity);
        pipes.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
    }

}
