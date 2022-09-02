using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefsSphere : MonoBehaviour
{

    public bool reloadLastSave;

    [Header("Spots")]
    public GameObject[] spots;

    [Header("Spheres")]
    public GameObject red;
    public GameObject pur;
    public GameObject yel;
    public GameObject gre;
    public GameObject ora;
    public GameObject cya;
    

    List<string> bubbles = new List<string>();

    private void Awake()
    {
        if (reloadLastSave)
        {
            MassInstantiate();
        }
        else
        {
            FillTheList();
            Shuffle(bubbles);
            SavePlayerPrefs();
            MassInstantiate();
        }        
    }

    public void FillTheList()
    {
        for (int i = 0; i < spots.Length/6; i++)
        {
            bubbles.Add("red");
        }
        for (int i = 0; i < spots.Length / 6; i++)
        {
            bubbles.Add("pur");
        }
        for (int i = 0; i < spots.Length / 6; i++)
        {
            bubbles.Add("yel");
        }
        for (int i = 0; i < spots.Length / 6; i++)
        {
            bubbles.Add("gre");
        }
        for (int i = 0; i < spots.Length / 6; i++)
        {
            bubbles.Add("ora");
        }
        for (int i = 0; i < spots.Length / 6; i++)
        {
            bubbles.Add("cya");
        }
    }

    public static List<T> Shuffle<T>(List<T> list)
    {
        System.Random rng = new System.Random();
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }

        return list;
    }

    public void SavePlayerPrefs()
    {
        for (int i = 0; i < bubbles.Count; i++)
        {
            PlayerPrefs.SetString("loc"+i, bubbles[i]);
        }
    }

    public void MassInstantiate()
    {
        for (int i = 0; i < bubbles.Count; i++)
        {
            switch (bubbles[i])
            {
                case "red":
                    GameObject go = Instantiate(red,spots[i].transform);
                    break;
                case "pur":
                    go = Instantiate(pur, spots[i].transform);
                    break;
                case "yel":
                    go = Instantiate(yel, spots[i].transform);
                    break;
                case "gre":
                    go = Instantiate(gre, spots[i].transform);
                    break;
                case "ora":
                    go = Instantiate(ora, spots[i].transform);
                    break;
                case "cya":
                    go = Instantiate(cya, spots[i].transform);
                    break;
            }
        }
    }
}
