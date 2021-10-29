using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(XRGrabInteractable))]
public class GunBehavior : MonoBehaviour
{
    [SerializeField] Transform m_shootingPoint;
    [SerializeField] GameObject m_bulletPrefab;
    [SerializeField] CommonGun gunStats;
    [SerializeField] float bulletSpeed;

    private void Start()
    {
        //if (gunStats)
        //    bulletSpeed = gunStats.bulletSpeed;
       bulletSpeed = bulletSpeed <= 0 ? 1 : bulletSpeed;
    }

    public void Shoot()
    {
        // use events for bullet effects?
        GameObject _bullet = Instantiate(m_bulletPrefab, m_shootingPoint.position, transform.rotation);
        _bullet.GetComponent<Rigidbody>().AddForce(m_shootingPoint.forward * bulletSpeed);
    }
}
