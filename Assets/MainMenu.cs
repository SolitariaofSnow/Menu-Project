using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class MainMenu : MonoBehaviour
{
    // why the fuck do i keep getting errors 
    
        public void PlayGame()
        {
            SceneManager.LoadScene("Level 1"); // Okay so I had to use this method to load scene name instead of SceneManager.LoadScene(SceneManager. GetActiveScene().buildIndex + 1); 
            //because Im dumb probably and I wrote * 1 instead of + 1 when I was testing which would pull Active Scene, take next scene in list, add 1. 
          
        }

        public void QuitGame()
        {
            Application.Quit(); //Friendly reminder code is case sensitive usually

        }
}
