using UnityEngine;
using UnityEngine.AI; 

[RequireComponent(typeof(Camera))] 
public class clickMove : MonoBehaviour
{
    Camera mainCam;
    public Transform player;
    public Transform spawnPlayer;
    Rigidbody rbPlayer;
    NavMeshAgent agent;
    public ParticleSystem clickParticle;

    void Start()
    {
        mainCam = GetComponent<Camera>();
        agent = player.GetComponent<NavMeshAgent>();
        rbPlayer = player.GetComponent<Rigidbody>();
        player.position = spawnPlayer.position;
        clickParticle.enableEmission = false; 
    }

    void Update()
    {
        Ray clickPos =  mainCam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit; 
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(clickPos,out hit))
            {
                agent.SetDestination(hit.point);
                clickParticle.transform.position = hit.point;
                clickParticle.enableEmission = true;
            }
        }
    }
}
