using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDown : MonoBehaviour
{
    [SerializeField]
    private float speed = 1;

    [SerializeField]
    GameObject ps, ls;

    [SerializeField]
    internal List<Material> colors;

    // Use this for initialization
    void Start()
    {
        ps = GameObject.Find("PointSystem");
        ls = GameObject.Find("Lives");
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
                if (collider.GetComponent<LinseSorteringLinseStyrke>().styrke == gameObject.GetComponent<LinseSorteringLinseStyrke>().styrke)
                {
                    ps.GetComponent<PointSystem>().AddPoint();

                }

                if (collider.GetComponent<LinseSorteringLinseStyrke>().styrke != gameObject.GetComponent<LinseSorteringLinseStyrke>().styrke)
                {
                    ls.GetComponent<Lives>().SubtractLives();
                }

            }
            else if (collider.tag == "Ground")
            {
                // Debug.Log("Hej med dig");
                ls.GetComponent<Lives>().SubtractLives();
            }
            Destroy(gameObject);

        }
    }
}
