using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallPlatformCtrl : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Delay());
        
        }

    }
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(0.1f);
        Destroy(this.gameObject);

    }









}
