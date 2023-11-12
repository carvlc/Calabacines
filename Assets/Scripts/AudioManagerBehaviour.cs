using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerBehaviour : MonoBehaviour
{
    public static AudioManagerBehaviour Instance;// se crea una variable se esta misma clase para aplicar singleton
   private AudioSource audioSource;// se crea un audiosource para manejar el sonido

// se aplica singleton
   private void Awake() {
    if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        audioSource = GetComponent<AudioSource>();
   }
   // metodo para ejecutar el sonido que se pasa por parametro
   public void PlaySound(AudioClip audio)
    {
        audioSource.PlayOneShot(audio);// se ejecuta el audio
    }
}
