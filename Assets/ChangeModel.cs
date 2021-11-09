using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeModel : MonoBehaviour
{
    [SerializeField] GameObject[] models;
    
    int currentModel;
    
    void Start ()
    {
        currentModel = 0;

        if (models.Length > 0 && models[0] != null)
        {
            models[currentModel].SetActive(true);
        }
    }

    public void ChangeModelObject()
    {
        if (models.Length <= 0) { return; }

        models[currentModel]?.SetActive(false);

        currentModel = (int) Mathf.Repeat(currentModel + 1, models.Length);

        models[currentModel]?.SetActive(true);
    }

    public void ChangeAnimation()
    {
        models[currentModel].GetComponent<Animator>().SetTrigger("Change");
    }
}
