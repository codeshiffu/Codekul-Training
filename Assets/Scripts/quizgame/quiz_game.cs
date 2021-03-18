using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class quiz_game : MonoBehaviour
{
    public string[] questions;
    public string[] answers;
    public Text question_display;
    public InputField user_answer;
    int questions_length, answers_length, question_number, answer_number, score;
    public GameObject sphere;
    

    // Start is called before the first frame update
    void Start()
    {
        //Length of the questions and answers
        questions_length = questions.Length;
        answers_length = answers.Length;

        //Question and Answer number
        question_number = 0;
        answer_number = 0;
        score = 0;

        //call display_questions() for the first time
        display_questions();

        

    }

   void display_questions()
    {
        Debug.Log(question_number);
        try
        {
            question_display.text = questions[question_number];
            question_number++;
        }
        catch(IndexOutOfRangeException e)
        {
            Debug.Log(e);
        }
        
    }

    public void change_question()
    {
        
        if (question_number < questions_length)
        {
            if(user_answer.text != "")
            {
                display_questions();
                check_answers();
            }
           
            
        }

       
        //After quiz ends
        if(question_number > questions_length)
        {
            question_display.text = "Total Score:" + score;
            Destroy(user_answer);
            Destroy(sphere);
            
        }
    }

    void check_answers()
    {
        try
        {

            if (user_answer.text.ToLower() == answers[answer_number].ToLower())
            {
                score = score + 1;
                answer_number++;
                user_answer.text = null;
                Debug.Log(score);
            }
        }catch(IndexOutOfRangeException e)
        {
            Debug.Log("Answers" +e);
        }

    }


}
