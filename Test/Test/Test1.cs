using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class Test1 : MonoBehaviour
{
    [SerializeField] private Shader shader;
    [SerializeField] private Material material;
    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        if (!material) material = new(shader);
        Graphics.Blit(source, destination, material);
    }
}
