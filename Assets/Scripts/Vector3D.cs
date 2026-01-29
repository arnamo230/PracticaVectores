using UnityEngine;

public class Vector3D : MonoBehaviour
{
    public float x;
    public float y;
    public float z;


    public void Initialize()
    {
        x = 0;
        y = 0;
        z = 0;
    }


    public void Initialize(float x, float y, float z)
    {
        this.x = x;
        this.y = y;
        this.z = z;


        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Initialize();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
