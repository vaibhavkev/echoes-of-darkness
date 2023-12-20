using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
public class gun : MonoBehaviour
{
    private StarterAssetsInputs _input;
    [SerializeField] private GameObject bullet;
    [SerializeField] private GameObject bulletpoint;
    // Start is called before the first frame update
    void Start()
    {
        _input = transform.root.GetComponent<StarterAssetsInputs>();
    }

    // Update is called once per frame
    void Update()
    {
        if( _input.shoot)
        {
            shoot();
            _input.shoot = false;
        }
    }
    void shoot()
    {
        Debug.Log("shot");
        GameObject bullet1 = Instantiate(bullet, bulletpoint.transform.position, transform.rotation);
        bullet1.GetComponent<Rigidbody>().AddForce(transform.forward * 6000);
        Destroy(bullet1, 1);
    }
}
