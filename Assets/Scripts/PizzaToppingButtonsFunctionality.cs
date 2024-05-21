using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaToppingButtonsFunctionality : MonoBehaviour
{
    public GameObject _pizzaBase;
    public GameObject _pizzaSauce;
    public GameObject _cheese;
    public GameObject _pepperoni;
    public GameObject _basil;

    public Animator _pizzaAnimatorStateMachine;
    
    private void Start()
    {
        
    }

    public void AddPizzaBase()
    {
        _pizzaBase.SetActive(true);
    }

    public void AddPizzaSauce()
    {
        _pizzaSauce.SetActive(true);
    }

    public void AddCheese()
    {
        _cheese.SetActive(true);
    }

    public void AddPepperoni()
    {
        _pepperoni.SetActive(true);
    }

    public void AddBasil()
    {
        _basil.SetActive(true);
    }

    public void SubmitPizza()
    {
        // Move the finished pizza object off screen with an animation to send it to the
        // customer. The move function should also handle resetting the GameObject if needed.
        // May or may not use an Object Pool with ingredients ready to be used. If so, could
        // also call the "Reset object" function here.
        _pizzaAnimatorStateMachine.SetTrigger("Submit pizza");
        Debug.Log("Pizza sent to customer, played pizza submission animation");

        

        // Call the score evaluation function. This will either evaluate the score all
        // at once, or if testing the score per ingredient, will aggregate the ingredient
        // scores and the time score together
        Debug.Log("Call pizza evaluation function");


    }

}
