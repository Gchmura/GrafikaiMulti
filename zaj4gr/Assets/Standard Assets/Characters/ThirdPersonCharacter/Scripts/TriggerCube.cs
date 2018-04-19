using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.UI;


public class TriggerCube : MonoBehaviour {


    public Text countText;
    public Text winText;
    public Light lt ;
    public int licznik = 0;


    public void Start()
    {
       
        winText.text = "Wygrałęś";
        countText.text = "";
        Colors = new List<Color>();//l kolorów
        Colors.Add(Color.cyan);
        Colors.Add(Color.magenta);
        Colors.Add(Color.clear);
        Colors.Add(Color.red);
        Colors.Add(Color.blue);
        Colors.Add(Color.magenta);
        Colors.Add(Color.cyan);
        Colors.Add(Color.yellow);
        Colors.Add(Color.grey);
        Colors.Add(Color.red);
        Colors.Add(Color.blue);    
        Colors.Add(Color.white);

    }
    public List<Color> Colors { get; set; }


    public void Update()
    {
        countText.text = "Punkty: " + licznik.ToString();
    }

    public void OnTriggerEnter(Collider other)
    {

        

        if (other.gameObject.CompareTag("Cube"))
        {
            lt.color = Colors[licznik];

            Destroy(other.gameObject);
			licznik++;
			Update();

			if (licznik > 10)
			{
				winText.text = "Wygrałeś !";
				Time.timeScale = 0;
			}


        }

    }
}

