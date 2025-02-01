using System;
using Unity.VisualScripting;
using UnityEngine;

public class KiwiScript : CannonBase
{

    [SerializeField]
    Transform startCorpse;

    [SerializeField]
    Transform originCorpse;

    void Update()
    {
        originCorpse.position = startCorpse.position;
        LaunchBullet();
    }

    public override void VisualComportement()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 vecMouseCircle = (Vector2)transform.position - mousePosition;
        float cannonRotation = Mathf.Rad2Deg * Mathf.Atan2(vecMouseCircle.y, vecMouseCircle.x);
        float offSetDegre = 90;


        transform.rotation = Quaternion.Euler(new Vector3(0, 0, cannonRotation - offSetDegre));
        strechPowerTransform.localScale = new Vector3(settings.defaultScale.x, bulletInfo.magnitude * 1.62f, settings.defaultScale.z);
    }

}
