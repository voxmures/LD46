using UnityEngine;

public class GlideAnimation : MonoBehaviour
{
    private Vector3 m_StartPosition;
    private Vector3 m_StartRotation;

    private float m_Time = 0f;

    private void Start()
    {
        m_StartPosition = transform.position;
        m_StartRotation = transform.rotation.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        float dt = Time.deltaTime;
        m_Time += dt;

        transform.position = new Vector3(m_StartPosition.x + Mathf.Cos(m_Time) * .8f, transform.position.y, transform.position.z);
        transform.Rotate(new Vector3(Mathf.Cos(m_Time) * .2f, 0, 0));
    }
}
