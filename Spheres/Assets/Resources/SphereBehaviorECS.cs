
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public class SphereBehaviorECS : MonoBehaviour
{

    public Color lerpedColor;
    public Color newColor;
    public float speed;
    public float radius;
    public float angle;
    public float colorChangeThreshold;
    public float colorChangeTimer;
    public bool colorChangePositiveDirection;
    public Vector3 originalPosition;
}

class SphereBehaviorSystem : ComponentSystem
{

    struct Components
    {
        public SphereBehaviorECS sphereBehaviorECS;
        public Transform transform;
        public Renderer renderer;
    }

    //protected override void OnCreateManager(int capacity)
    //{
    //    originalPosition = transform.position;
    //    speed = Random.Range(0.01f, 0.5f);
    //    radius = Random.Range(1.0f, 50.0f);
    //    colorChangeThreshold = Random.Range(1.0f, 4.0f);
    //    colorChangeTimer = colorChangeThreshold;
    //    colorChangePositiveDirection = true;
    //}


    protected override void OnUpdate()
    {
        foreach (var e in GetEntities<Components>())
        {
            //e.sphereBehaviorECS.angle += e.sphereBehaviorECS.speed * Time.deltaTime;
            //var offset = new Vector3(Mathf.Sin(e.sphereBehaviorECS.angle), Mathf.Cos(e.sphereBehaviorECS.angle), Mathf.Tan(e.sphereBehaviorECS.angle)) * e.sphereBehaviorECS.radius;
            //e.transform.position = e.sphereBehaviorECS.originalPosition + offset;

            //e.sphereBehaviorECS.colorChangeTimer += Time.deltaTime;

            //if (e.sphereBehaviorECS.colorChangeTimer >= e.sphereBehaviorECS.colorChangeThreshold && e.sphereBehaviorECS.colorChangePositiveDirection == true)
            //{
            //    e.sphereBehaviorECS.colorChangeTimer = 0;
            //    e.sphereBehaviorECS.colorChangePositiveDirection = false;
            //}

            //if (e.sphereBehaviorECS.colorChangeTimer >= e.sphereBehaviorECS.colorChangeThreshold && e.sphereBehaviorECS.colorChangePositiveDirection == false)
            //{
            //    e.sphereBehaviorECS.newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
            //    e.sphereBehaviorECS.colorChangeTimer = 0;
            //    e.sphereBehaviorECS.colorChangePositiveDirection = true;
            //}

            //if (e.sphereBehaviorECS.colorChangePositiveDirection == true)
            //{
            //    e.sphereBehaviorECS.lerpedColor = Color.Lerp(Color.white, e.sphereBehaviorECS.newColor, e.sphereBehaviorECS.colorChangeTimer / e.sphereBehaviorECS.colorChangeThreshold);
            //}
            //else
            //{
            //    e.sphereBehaviorECS.lerpedColor = Color.Lerp(e.sphereBehaviorECS.newColor, Color.white, e.sphereBehaviorECS.colorChangeTimer / e.sphereBehaviorECS.colorChangeThreshold);
            //}

            ////Renderer rend = EntityManager.GetComponentData<Renderer>();
            ////// Renderer rend = GetComponent<Renderer>();
            ////rend.material.color = e.sphereBehaviorECS.lerpedColor;
        }
    }
}

