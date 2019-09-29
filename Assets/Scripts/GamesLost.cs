using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamesLost : MonoBehaviour
{
    public Text GamesLostValue;
    public static float GamesLostNum = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GamesLostValue.text = GamesLostNum.ToString();
    }
}
