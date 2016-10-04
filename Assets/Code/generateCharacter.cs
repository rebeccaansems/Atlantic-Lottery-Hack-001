using UnityEngine;
using System.Collections;

public class generateCharacter : MonoBehaviour
{
    public static int Hair;
    public static int Pants;
    public static int Shirt;
    public static int Skin;

    // Use this for initialization
    void Start()
    {
        Hair = Random.Range(0, 23);
        Pants = Random.Range(0, 3);
        Shirt = Random.Range(0, 7);
        Skin = Random.Range(0, 1);
    }

    void Regenerate()
    {
        Hair = Random.Range(0, 23);
        Pants = Random.Range(0, 3);
        Shirt = Random.Range(0, 7);
        Skin = Random.Range(0, 1);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
