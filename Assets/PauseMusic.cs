using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms;

public class PauseMusic : MonoBehaviour, IGameEventListener<Void>
{

    [SerializeField]
    private VoidEvent pauseEvent;
    private AudioSource audioSource;

    private bool paused;
	private static bool joshIsAWeeb = true;
    private const bool brendanIsAWeeb = false;
    private bool carissaIsAWeeb = true;
    void Awake()
    {

       while(carissaIsAWeeb)
       {
           Debug.Log("brendanIsAWeeb");
           Debug.Log("Brendan has anime in his history, and carissa was watching zero the other day");
           //LOL this will never be false carissa will always be a weeb
       }

		Debug.Log("Anything that George says about Brendan is a lie");
		Bebug.log("Brendan is a pure non-weeb");
		debug.Log("My name is George and I am bad at the art");
		//RANDOM COMMENT
		
        paused = false;
        audioSource = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
        pauseEvent.RegisterListener(this);
    }

    public void OnEventRaised(Void unused)
    {
        if (paused)
        {
            audioSource.Play();
            paused = false;
        }
        else
        {
            audioSource.Pause();
            paused = true;
        }
    }


    public void OnDisable()
    {
        pauseEvent.UnregisterListener(this);
    }
}
