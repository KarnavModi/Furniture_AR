using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class FurnitureManager : MonoBehaviour
{
    public GameObject[] Furniture; // array to store all objects (A-Z)

    // Buttons
    public Button prevBtn;
    public Button nextBtn;

    // Gameobject states
    GameObject currentFurniture;
    GameObject nextFurniture;
    GameObject previousFurniture;

    //TextMesh
    //public TextMeshProUGUI currentAlphabetName;

    int i = 0;

    void Start()
    {
    
        currentFurniture = Furniture[i];  // alphabets[0] --> Apple
        currentFurniture.SetActive(true); // Apple will be enabled
      //  currentAlphabetName.text = currentAlphabet.name; // Apple's name
        prevBtn.interactable = false; // Previous is not active
    }

    private void Update()
    {

    }

    // NextButton Method
    public void NextButton()
    {
        prevBtn.interactable = true;
        i = i + 1;
        if (i == Furniture.Length-1)
        {
            nextBtn.interactable = false;
        }
        nextFurniture = Furniture[i]; // store next alphabet in the arry to nextAlphabet
        currentFurniture.SetActive(false); // Disable currentAlphabet in the Scene
        currentFurniture = nextFurniture; // Assign nextAlphabet to currentAlphabet
        currentFurniture.SetActive(true);  // Enable currentAlphabet in the Scene   
        //currentAlphabetName.text = currentAlphabet.name;

    }

    // PreviousButton Method
    public void PrevButton()
    {
        i = i - 1;
        nextBtn.interactable = true;
        if (i == 0)
        {
            prevBtn.interactable = false;
        }
        previousFurniture = Furniture[i];
        currentFurniture.SetActive(false);
        currentFurniture = previousFurniture; // Assign previousAlphabet to currentAlphabet
        currentFurniture.SetActive(true);  // Enable currentAlphabet in the Scene   
      //currentAlphabetName.text = currentAlphabet.name;
    }

    public void GotoMenuScene()
    {
        SceneManager.LoadScene("MainMenu");
    }

   
}
