using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardCoding : MonoBehaviour
{
    private bool zle;

    void Start()
    {
        //zadanie 1
        {
            int calkowita = 7;
            float przecinkowa = 7.7f;
        }
        //zadanie 2
        {
            bool dobre = true;
            bool zle = false;
        }
        //zadanie 3
        {
            string nazwa = "Programuję w C#";
            string epg = "EPG";
        }
        //zadanie 4 
        {
            Debug.Log("calkowita = " + calkowita + "przecinkowa = " + przecinkowa + "dobre " + dobre + "zle " + zle + "nazwa : " + nazwa + "epg" + epg);
        }
        //zadanie 5
        {
            if (calkowita == przecinkowa)
            {
                Debug.Log("Tak, są równe.");
            }
            else if (calkowita != przecinkowa)
            {
                Debug.Log("Nie są równe.");
            }

            if (calkowita < przecinkowa)
            {
                Debug.Log("Całkowita jest mniejsza.");
            }
            else if (calkowita > przecinkowa)
            {
                Debug.Log("Przecinkowa jest mniejsza.");
            }

            if (calkowita <= przecinkowa)
            {
                Debug.Log("Całkowita jest mniejsza lub równa.");
            }
            else if (calkowita >= przecinkowa)
            {
                Debug.Log("Całkowita jest większa lub równa.");
            }
        }
        //zadanie 6 ???
        {
            if (nazwa == epg)
            {
                Debug.Log("Napisy są takie same.");
            }
            else
            {
                Debug.Log("Napisy są różne.");
            }
        }
        //zadanie 7
        {
            Koniunkcja(dobre, zle);
            Alternatywa(dobre, zle);
        }
        //zadanie 8 - uporządkowanie
    { 
        public void Koniunkcja(bool dobre, bool zle)
        {
            if ((dobre == false) && (zle == false))
            {
                Debug.Log((dobre == false) && (zle == false));
                Debug.Log("false");
            }
            if ((dobre == false) && (zle == true))
            {
                Debug.Log((dobre == false) && (zle == true));
                Debug.Log("false");
            }
            if ((dobre == true) && (zle == false))
            {
                Debug.Log((dobre == true) && (zle == false));
                Debug.Log("false");
            }
            if ((dobre == true) && (zle == true))
            {
                Debug.Log((dobre == true) && (zle == true));
                Debug.Log("true");
            }
        }

        public void Alternatywa(bool dobre, bool zle)
        {
            if((dobre == false) || (zle == false))
            {
                Debug.Log((dobre == false) || (zle == false));
                Debug.Log("false");
            }
            if ((dobre == false) || (zle == true))
            {
                Debug.Log((dobre == false) || (zle == true));
                Debug.Log("true");
            }
            if ((dobre == true) || (zle == false))
            {
                Debug.Log((dobre == true) || (zle == false));
                Debug.Log("true");
            }
            if ((dobre == true) || (zle == true))
            {
                Debug.Log((dobre == true) || (zle == true));
                Debug.Log("true");
            }
        }
    }
    void Update()
    {

    }
}
