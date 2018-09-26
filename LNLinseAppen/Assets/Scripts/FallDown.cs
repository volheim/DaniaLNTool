using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDown : MonoBehaviour
{
    [SerializeField]
    private float speed = 1;

    [SerializeField]
    GameObject ps;

    [SerializeField]
    internal List<Material> colors;

    // Use this for initialization
    void Start()
    {
        ps = GameObject.Find("PointSystem");

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate((Vector2.down * speed) * Time.deltaTime);

    }
    public void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Ground" || collider.tag == "Player")
        {
            if (collider.tag == "Player")
            {
                if(collider.GetComponent<LinseSorteringLinseStyrke>().styrke == gameObject.GetComponent<LinseSorteringLinseStyrke>().styrke)
                {
                    ps.GetComponent<PointSystem>().AddPoint();

                }
            }

            Destroy(gameObject);

        }
    }
}
