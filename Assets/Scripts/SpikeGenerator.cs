using UnityEngine;

public class SpikeGenerator : MonoBehaviour
{
    public GameObject spike;
    public float MinSpeed;
    public float MaxSpeed;
    public float CurrentSpeed;




    // Start is called before the first frame update
    void Awake()
    {
        CurrentSpeed = MinSpeed;
        generateSpike();

        
    }

    void generateSpike()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
