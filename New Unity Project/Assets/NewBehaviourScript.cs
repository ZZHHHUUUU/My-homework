using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoAnimation : MonoBehaviour
{
    public Material logoMaterial;
    public float transitionSpeed = 0.5f;

    private Vector3 initialScale;
    private Color initialColor;
    private Color finalColor;

    void Start()
    {
        initialScale = transform.localScale;
        initialColor = logoMaterial.color;
        finalColor = new Color(0.5f, 0, 0.5f); // purple color

        StartCoroutine(AnimateLogo());
    }

    IEnumerator AnimateLogo()
    {
        float t = 0;

        while (t < 1)
        {
            t += Time.deltaTime * transitionSpeed;

            // Animate scale
            transform.localScale = Vector3.Lerp(initialScale, 1.5f * initialScale, t);

            // Animate color
            logoMaterial.color = Color.Lerp(initialColor, finalColor, t);

            yield return null;
        }

        // Add virtual world icon
        GameObject icon = GameObject.CreatePrimitive(PrimitiveType.Quad);
        icon.transform.position = transform.position + Vector3.up * initialScale.y / 2f;
        icon.transform.localScale = new Vector3(initialScale.x / 2f, initialScale.y / 2f, initialScale.z / 2f);
        icon.transform.rotation = Quaternion.Euler(90f, 0f, 0f);
        icon.GetComponent<Renderer>().material = logoMaterial;

        // Add text for services provided
        GameObject textObject = new GameObject("Text");
        TextMesh textMesh = textObject.AddComponent<TextMesh>();
        textMesh.text = "Movies, Live Streaming, Television";
        textMesh.anchor = TextAnchor.MiddleCenter;
        textMesh.alignment = TextAlignment.Center;
        textMesh.characterSize = 0.05f;
        textObject.transform.position = transform.position - Vector3.up * initialScale.y / 2f;
        textObject.transform.localScale = Vector3.one * 0.5f;
        textObject.transform.rotation = Quaternion.Euler(90f, 0f, 0f);
        textObject.GetComponent<Renderer>().material = logoMaterial;
    }
}