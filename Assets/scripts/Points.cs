using System.Collections;
using TMPro;
using UnityEngine;

public class Points : MonoBehaviour
{
    public Jugador State;
    public float Tiempo;
    public int points;
    public TextMeshProUGUI ScoreText;
    public GameObject GameOver;
    void Start()
    {
        StartCoroutine(Puntuacion());
    }

    IEnumerator Puntuacion()
    {
        while (true)
        {
            if (State.alive == true)
            {
            yield return new WaitForSeconds(Tiempo);
            points++;
            ScoreText.text = points.ToString();
            }
            else
            {
                GameOver.SetActive(true);
                yield break;
            }
        }
    }
}
