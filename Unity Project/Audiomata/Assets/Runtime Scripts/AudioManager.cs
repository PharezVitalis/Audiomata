﻿using UnityEngine;
namespace Audiomata
{
    /// <summary>
    /// Entrypoint for all in game systems within Audiomata, most if not all runtime systems are contained within this class
    /// </summary>
    public class AudioManager : MonoBehaviour
    {
        [Tooltip("The more the clips, the slower the search O(n). Only add clips here that are needed in the scene")]
        [SerializeField]
        public AudioData[] relevantClips;

        private string qTest = "!bird|B&!A";

        public static AudioManager Instance { get; private set; }

        public EventManager EventManager { get; private set; }

        public AudioEffectManager EffectManager { get; private set; }

        /// <summary>
        /// System to Manage queries to the runtime audio dictionaries
        /// </summary>
        public QueryManager QueryManager { get; private set; }

        /// <summary>
        /// Whether the AudioManager has completed it's initialisation (Uses Awake)
        /// </summary>
        public bool IsSetUp { get; private set; }

        private void Awake()
        {
            if (!Instance)
            {
                Instance = this;
            }
            else
            {
                Debug.LogError("2 Audiomata.AudioManagers present on this scene, this is a Singleton Manager class");
                Destroy(this);
                return;
            }

            for (int i = 0; i < relevantClips.Length; i++)
            {
                AudioData next = relevantClips[i];

             //   Debug.Log(next);
            }
            EventManager = new EventManager();
            QueryManager = new QueryManager(relevantClips);

            if (!EffectManager)
            {
                EffectManager = GetComponent<AudioEffectManager>();
            }
            
            IsSetUp = true;
            QueryManager.QueryAudio(qTest, out var results);
            Debug.Log("Full Query Results: ");
            foreach (var result in results)
            {
                Debug.Log(result);
            }
            Debug.Log("Results End");


            EventManager.AddEventReference("test", TestEvent);            
        }

        private void Start()
        {
            EventManager.FireEvent("test", this, this);
        }

        private void TestEvent (object sender, Object target)
        {
            relevantClips = null;
            AudioManager manager = (AudioManager)target;
            manager.gameObject.transform.Rotate(45, 45, 45, Space.Self);
        }

        private void OnDestroy()
        {
            if (Instance == this)
            {
                Instance = null;
            }
        }
    }
}