using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPSCounter
{
    public class fpsCounter : MonoBehaviour
    {
        private float frameCounter = 0f;
        private float currentFPS = 0f;
        private float lastUpdateTime = 0f;

        // Start is called before the first frame update
        void Start()
        {
            Text fpsText = GetComponent<Text>();
            lastUpdateTime = Time.unscaledTime;
        }

        // Update is called once per frame
        private void Update()
        {
            float currentTime = Time.unscaledTime;
            float deltaTime = currentTime - lastUpdateTime;

            frameCounter += deltaTime;
            currentFPS = 1f / Mathf.Min(deltaTime, 0.01f);

            if (currentTime >= lastUpdateTime + 1f) {
                Text fpsText = GetComponent<Text>();
                fpsText.text = "FPS: " + currentFPS.ToString();
                frameCounter = 0f;
                currentFPS = 0f;
                lastUpdateTime = currentTime;
            }
        }
    }
}
