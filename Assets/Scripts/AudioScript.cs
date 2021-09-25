using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    private AudioSource[] AudioClips;

    void Start()
    {
        AudioClips = gameObject.GetComponents<AudioSource>();
        StartCoroutine(playMain());
    }

    IEnumerator playMain()
    {
        AudioSource introMusic = AudioClips[0];
        AudioSource mainMusic = AudioClips[1];

        yield return new WaitForSeconds(introMusic.clip.length);
        mainMusic.Play();
    }
}
