using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    public float backgroundSpeed = 1f;

    //Get Object
    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    //Update Position of background
    private void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0);
    }
}
