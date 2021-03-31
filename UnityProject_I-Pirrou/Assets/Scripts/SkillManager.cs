using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillManager : MonoBehaviour
{
    public GameObject[] skill, skillHolder;
    List<int> list = new List<int>();
    int randomResult;
    // Start is called before the first frame update
    void Start()
    {
        for (int j = 0; j < skill.Length; j++)
        {
            list.Add(j);
        }

        for (int i = 0; i < 3; i++)
        {
            randomResult = Random.Range(0, list.Count);
            skill[list[randomResult]].transform.position = skillHolder[i].transform.position;
            skill[list[randomResult]].SetActive(true);
            list.RemoveAt(randomResult);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
