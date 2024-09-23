using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChessCollector : MonoBehaviour
{

    public int RemainingChessPieces = 6;
    public Text RemainingPieces;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        RemainingPieces.text = "Remaing Pieces: " + RemainingChessPieces.ToString();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Chess")
        {
            RemainingChessPieces--;
            GameObject.Destroy(collision.gameObject);
        }
    }


}
