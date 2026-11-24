using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class Puzzle1Answered : MonoBehaviour
{
    [Header("Keys")]
    public GameObject key1;
    public GameObject key2;
    public bool key2Active;
    public GameObject key3;
    public bool key3Active;
    public GameObject key4;
    public bool key4Active;
    public GameObject key5;
    public bool key5Active;
    public GameObject key6;
    public bool key6Active;

    [Header("other stuff")]
    public bool puzzle1Correct;
    public GameObject puzzle1Obstacle;
    public bool testing;
    public bool puzzle1Answered;

    private void Update()
    {
        if (key1.GetComponent<HoverTest>().sendSignal == true)
        {
            if(key2Active == true)
            {
                if (key2.GetComponent<HoverTest>().sendSignal == true)
                {
                    if (key3Active == true)
                    {
                        if (key3.GetComponent<HoverTest>().sendSignal == true)
                        {
                            if (key4Active == true)
                            {
                                if (key4.GetComponent<HoverTest>().sendSignal == true)
                                {
                                    if (key5Active == true)
                                    {
                                        if (key5.GetComponent<HoverTest>().sendSignal == true)
                                        {
                                            if (key6Active == true)
                                            {
                                                if (key6.GetComponent<HoverTest>().sendSignal == true)
                                                {
                                                    puzzle1Correct = true;
                                                }
                                                else
                                                {
                                                    puzzle1Correct = false;
                                                }
                                            }
                                            else
                                            {
                                                puzzle1Correct = true;
                                            }
                                        }
                                        else
                                        {
                                            puzzle1Correct = false;
                                        }
                                    }
                                    else
                                    {
                                        puzzle1Correct = true;
                                    }
                                }
                                else
                                {
                                    puzzle1Correct = false;
                                }
                            }
                            else
                            {
                                puzzle1Correct = true;
                            }
                        }
                        else
                        {
                            puzzle1Correct = false;
                        }
                    }
                    else
                    {
                        puzzle1Correct = true;
                    }
                    
                }
                else
                {
                    puzzle1Correct = false;
                }
            }
            else
            {
                puzzle1Correct = true;
            }            
        }
        else
        {
            puzzle1Correct = false;
        }

        // Check if the puzzle is answered and disable the obstacle if it is
        if (puzzle1Correct == true)
        {
            puzzle1Answered = true;
            puzzle1Obstacle.gameObject.SetActive(false);
        }
        else
        {
            if(testing == true)
            {
                puzzle1Answered = false;
                puzzle1Obstacle.gameObject.SetActive(true);
            }
        }
    }
}
