using UnityEngine;

public class Destroyer : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        // maby we shoud increase the score or do some thing
    }

} // end class
