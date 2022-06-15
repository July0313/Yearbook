using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPool : MonoBehaviour
{
    // public List<GameObject> enemys;
    public GameObject[] enemys;

    public bool canSet = true;

    public IEnumerator delayCoroutine = null;

    public int delayNum = 2;
    // public int enemyNum = 0;

    /*
    private void Start()
    {
        for(int i = 0; i < transform.childCount; i++)
        {
            Debug.Log("차일드 번호 : " + i);
            enemys.Add(transform.GetChild(i).gameObject);
        }
    }
    */

    private void Update()
    {
        if (delayCoroutine == null)
        {
            delayCoroutine = DelayCoroutine(delayNum);
            StartCoroutine(delayCoroutine);
        }
    }

    private IEnumerator DelayCoroutine(float delay)
    {
        canSet = true;
        yield return new WaitForSeconds(delay);
        Instantiate(enemys[Random.Range(0, enemys.Length)]);
        canSet = false;
    }
}
