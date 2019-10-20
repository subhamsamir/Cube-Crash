
using UnityEngine;

public class Endtrig : MonoBehaviour
{
    public gameManger gameManger;

    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {
        gameManger.completeLevel();
    }
}
