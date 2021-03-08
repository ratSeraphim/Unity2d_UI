using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Importē lai lietotu pointer darbību interfeisu
//Papildus ir jāpārliecinās, ka projektā pie Canvas ir importēta EventSystems UI komponente 
using UnityEngine.EventSystems;

//Piesaista pointer interfeisu
public class ObjektuParvietosana : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private RectTransform transformacijuLogs;
    public Canvas kanva;

    private void Awake()
    {
        transformacijuLogs = GetComponent<RectTransform>();
    }

    //Funkcija nostrādā, kad uzklikšķināts uz pārvietojamā objekta

    public void OnPointerDown(PointerEventData notikums)
    {
        Debug.Log("Kreisais kliķšķis uz pārvietojamā objekta!");
    }

    //Funkcija nostrādā uzsākot pārvietošanu
    public void OnBeginDrag(PointerEventData notikums)
    {
        Debug.Log("Uzsākta pārvietošana");
    }

    //Funkcija nostrādā pārvietošanas brīdī
    public void OnDrag(PointerEventData notikums)
    {
        transformacijuLogs.anchoredPosition += notikums.delta / kanva.scaleFactor;
    }

    //Funkcija nostrādā atlaižot vilkto objektu
    public void OnEndDrag(PointerEventData notikums)
    {
        Debug.Log("Pārvietošana beigta");
    }
}
