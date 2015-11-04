using UnityEngine;
using System.Collections;

public class OffsetBack : MonoBehaviour {

    public float scrollSpeed = 0.5F;
    private Vector2 vectorOffset;
    public enum Edges { X, Y, XY };
    public Edges stateEdges;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        switch (stateEdges)
        {

            case Edges.X:
                vectorOffset = vectorOffset + Vector2.right * Time.deltaTime * scrollSpeed;
                break;

            case Edges.Y:
                vectorOffset = vectorOffset + Vector2.up * Time.deltaTime * scrollSpeed;
                break;

            case Edges.XY:
                vectorOffset = vectorOffset + Vector2.one * Time.deltaTime * scrollSpeed;
                break;


        }
       // GetComponent<Renderer>().material.SetTextureOffset("_MainTex", vectorOffset);
    }
}
