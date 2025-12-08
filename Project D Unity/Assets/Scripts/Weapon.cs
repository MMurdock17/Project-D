using UnityEngine;

public class Weapon : MonoBehaviour
{
    public int damage = 10;
    public Camera camera;
    public float fireRate = 5f; 

    public GameObject hitVFX;

    private float nextFire;

    void Update()
    {
        if (nextFire > 0)
            nextFire -= Time.deltaTime;

        if (Input.GetButton("Fire1") && nextFire <= 0)
        {
            nextFire = 1f / fireRate;
            Fire();
        }
    }

    void Fire()
    {
        Ray ray = new Ray(camera.transform.position, camera.transform.forward);
        RaycastHit hit;

        
        if (Physics.Raycast(ray, out hit, 100f))
        {
            
            Debug.Log("Hit object: " + hit.transform.name);

            
            if (hitVFX != null)
            {
                Instantiate(hitVFX, hit.point, Quaternion.LookRotation(hit.normal));
            }
        }
        else
        {
            Debug.Log("Weapon fired but hit nothing.");
        }
    }
}
