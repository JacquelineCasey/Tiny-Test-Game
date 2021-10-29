/* Move.cs */
using UnityEngine;

public class Move : MonoBehaviour {
    const float speed = 1;

    void Update() {
        Vector3 pos = transform.position;
        float dt = Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
            pos.z += speed * dt;
        if (Input.GetKey(KeyCode.S))
            pos.z -= speed * dt;
        if (Input.GetKey(KeyCode.D))
            pos.x += speed * dt;
        if (Input.GetKey(KeyCode.A))
            pos.x -= speed * dt;
            
        transform.position = pos;
    }
}