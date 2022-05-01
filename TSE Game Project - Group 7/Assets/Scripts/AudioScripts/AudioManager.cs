using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public Sounds[] sounds;
    public static AudioManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
        foreach(Sounds s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.loop = s.loop;
        }
        //DontDestroyOnLoad(gameObject);
    }

    //void Start()
    //{

    //}

    void Update()
    {
        Scene scene = SceneManager.GetActiveScene();

        if (scene.name == "MainMenu")
        {
            Play("BG_Music_1");
            Debug.Log("Music is playing!");
        }
        else
        {
            StopPlaying("BG_Music_1");
        }

    }

    void Start()
    {
        Play("BG_Music");
    }

    public void Play(string name)
    {
        Sounds s = Array.Find(sounds, sound => sound.name == name);
        if(s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }
        if (PauseMenu.GameIsPaused)
        {
            s.source.pitch *= 5f;
        }
        s.source.volume = s.volume;
        s.source.pitch = s.pitch;
        s.source.Play();
    }

    public void StopPlaying(string sound)
    {
        Sounds s = Array.Find(sounds, item => item.name == sound);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }
        s.source.volume = s.volume;
        s.source.pitch = s.pitch;

        s.source.Stop();
    }

}
