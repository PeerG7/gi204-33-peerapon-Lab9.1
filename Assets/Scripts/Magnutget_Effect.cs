using UnityEngine;

public class Magnutget_Effect : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    Rigidbody rb;
    [SerializeField] Vector3 velocity,spin;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //sikekick yike
            kick();
        }
            //apply magnut effect
            magnuteffect();
        
        }
        void kick()
    { 
        //แรงตรง
        rb.linearVelocity = velocity;
        //แรงหมุน
        rb.angularVelocity = spin;

    }
    void magnuteffect() 
    {
        Vector3 magnusForce = Vector3.Cross(rb.linearVelocity,rb.angularVelocity);

        rb.AddForce(magnusForce);
    
    }
}

