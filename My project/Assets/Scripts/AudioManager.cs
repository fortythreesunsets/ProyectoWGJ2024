using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    public Sound[] musicSounds, sfxSounds;
    public AudioSource musicSource, sfxSource;

    private void Awake(){
        if(Instance=null){
            Instance=this;
            DontDestroyOnLoad(gameObject);
    
        }else{
            Destroy(gameObject);
        }
    }

    void Start()
    {
        PlayMusic("Intro");
    }

    public void PlayMusic(string name){
        Sound s = Array.Find(musicSounds, x=> x.name == name);
        if(s==null){
            Debug.Log("No sound");
        }else{
            musicSource.clip = s.clip;
            musicSource.Play();
        }
    }
    public void PlaySFX(string name){
        Sound s = Array.Find(sfxSounds, x=> x.name == name);
        if(s==null){
            Debug.Log("No sound");
        }else{
            sfxSource.PlayOneShot(s.clip);
        }
    }
}
