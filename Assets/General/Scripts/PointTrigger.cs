﻿using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

#if UNITY_EDITOR
using UnityEditor;
using UnityEditorInternal;
#endif

using Object = UnityEngine.Object;
using Random = UnityEngine.Random;

namespace Game
{
	public class PointTrigger : MonoBehaviour
	{
        public int reward = 1;

        public AudioClip SFX;

        AudioSource audioSource;

        void Awake()
        {
            audioSource = GetComponent<AudioSource>();
        }

        void OnTriggerEnter2D(Collider2D collider)
        {
            if(collider.gameObject == Game.Instance.Bird.gameObject && Game.Instance.Bird.IsAlive)
            {
                Game.Instance.points += reward;
                audioSource.PlayOneShot(SFX);
            }
        }
	}
}