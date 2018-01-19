using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriangleFormation : MonoBehaviour
{
    public int coneAngle = 0;
    public int lookDistance = 0;
    public float lookSpeed = 0;
    public float TailleRayon;
    public GameObject joueur;
    public Collider2D ColliderJoueur;
    string direction = "left";
    float distanceTravelled = 0;

    Vector3 directionLeft;
    Vector3 directionRight;
    Mesh visionCone;

    RaycastHit2D hitPointLeft;
    RaycastHit2D hitPointRight;


    void Start()
    {
        gameObject.AddComponent<MeshFilter>();
        visionCone = GetComponent<MeshFilter>().mesh;
        directionLeft = this.transform.rotation.eulerAngles;
        directionLeft.y -= TailleRayon;
        directionLeft.x -= coneAngle;
        directionRight = this.transform.rotation.eulerAngles;
        directionRight.y -= TailleRayon;
        directionRight.x += coneAngle;
    }


    void FixedUpdate()
    {
        if (direction == "left")
        {
            directionLeft.x -= lookSpeed;
            directionRight.x -= lookSpeed;
            distanceTravelled -= lookSpeed;
        }
        else if (direction == "right")
        {
            directionLeft.x += lookSpeed;
            directionRight.x += lookSpeed;
            distanceTravelled += lookSpeed;
        }
        if (distanceTravelled <= -lookDistance)
        {
            direction = "right";
        }

        else if (distanceTravelled >= lookDistance)
        {
            direction = "left";
        }
        hitPointRight = Physics2D.Raycast(transform.position, directionRight);
        hitPointLeft = Physics2D.Raycast(transform.position, directionLeft);
        Debug.DrawRay(transform.position, directionLeft);
        Debug.DrawRay(transform.position, directionRight);
        if (hitPointLeft.collider == ColliderJoueur || hitPointRight.collider == ColliderJoueur)
        {


            Application.LoadLevel(Application.loadedLevel);

        }
        GenMesh();
    }


    void GenMesh()
    {
        Vector3 vertexTwo = hitPointLeft.point;
        vertexTwo.x -= transform.position.x;
        vertexTwo.y -= transform.position.y;
        Vector3 vertexThree = hitPointRight.point;
        vertexThree.x -= transform.position.x;
        vertexThree.y -= transform.position.y;
        visionCone.Clear();
        visionCone.vertices = new Vector3[] { vertexTwo, vertexThree, new Vector3(0, 0, 0) };
        visionCone.uv = new Vector2[] { new Vector2(0, 0), new Vector2(0, 1), new Vector2(1, 1) };
        visionCone.triangles = new int[] { 0, 1, 2 };
        visionCone.RecalculateBounds();
        visionCone.RecalculateNormals();
        this.gameObject.GetComponent<MeshFilter>().mesh = visionCone;

    }


}

