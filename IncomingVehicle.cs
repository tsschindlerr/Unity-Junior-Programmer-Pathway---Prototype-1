using UnityEngine;

public class IncomingVehicle : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float incVehSpeed = 3.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * incVehSpeed);
    }
}
