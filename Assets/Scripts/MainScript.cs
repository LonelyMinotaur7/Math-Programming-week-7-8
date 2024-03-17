using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class MainScript : MonoBehaviour
{
    
    //All game objects/menus that need to be turned on and off
    
    [SerializeField] private GameObject FirstQuestion;
    [SerializeField] private GameObject SecondQuestionGO;
    [SerializeField] private GameObject ThirdQuestionGO;
    [SerializeField] private GameObject End;
    [SerializeField] private GameObject StartMen;

    [SerializeField] private GameObject TempScoretxt;
    [SerializeField] private GameObject hidetext;
    
    
    
    // --------------------------------------
    
    //Texts, and text inputs
    
    [SerializeField] private TMP_Text Score;

    private int scoreint = 0;
    
    [SerializeField] private TMP_InputField RawInput;
    
    [SerializeField] private TMP_InputField RawInput2;
    
    [SerializeField] private TMP_InputField RawInput3;

    private int input;
    

    // Function for question 1
    public void TestInput(int input)
    {
        int.TryParse(RawInput.text, out int result); //Turns the input into an int
        input = result; //doesn't do anything
        
        Debug.Log(result);

        if (result == 3) //if result is correct add point and go next menu
        {
            scoreint = scoreint + 1;
            FirstQuestion.SetActive(false);
            SecondQuestionGO.SetActive(true);
        }
        else //if it isn't correct dont add point and go next menu
        {
            FirstQuestion.SetActive(false);
            SecondQuestionGO.SetActive(true);
        }


        Score.SetText(scoreint.ToString()); //updates text

    }
    // function for question 2
    public void SecondQuestion(int input)
    {
        int.TryParse(RawInput2.text, out int result2);
        input = result2;
        
        Debug.Log(result2);

        if (result2 == 8)
        {
            scoreint = scoreint + 1;
            ThirdQuestionGO.SetActive(true);
            SecondQuestionGO.SetActive(false);
            
        }
        else
        {
            ThirdQuestionGO.SetActive(true);
            SecondQuestionGO.SetActive(false);
            
        }


        Score.SetText(scoreint.ToString());

    }
    //function for question 3
    public void ThirdQuestion(int input)
    {
        int.TryParse(RawInput3.text, out int result3);
        input = result3;
        
        Debug.Log(result3);

        if (result3 == 20)
        {
            scoreint = scoreint + 1;
            End.SetActive(true);
            ThirdQuestionGO.SetActive(false);
            TempScoretxt.SetActive(false);
        }
        else
        {
            End.SetActive(true);
            ThirdQuestionGO.SetActive(false);
            TempScoretxt.SetActive(false);
        }


        Score.SetText(scoreint.ToString());

    }






    //function for retry / play
    public void Retry()
    {
        scoreint = 0;
        Score.SetText(scoreint.ToString());
        TempScoretxt.SetActive(true);
        End.SetActive(false);
        FirstQuestion.SetActive(true);
        hidetext.SetActive(false);
        StartMen.SetActive(false);
    }
    //function for exit
    public void Exit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Debug.Log("quitting");
    }
    
    
}
