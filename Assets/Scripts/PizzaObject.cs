using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaObject : MonoBehaviour
{
    // List to contain strings representing the active ingredients
    // in this pizza. Use this in the score evaluation function
    // to test against the expected ingredients list and order for the
    // current request.
    private List<string> _pizzaComponents = new List<string>(6);


    // Update is called once per frame
    void Update()
    {
        
    }

    // Function to reset all elements of the base pizza class, ready for the next request
    // This will be more useful if re-using a single pizza object instead of creating
    // a new object for each request
    public void ResetPizza()
    {
        // Empty the ingredients list
        _pizzaComponents.Clear();
    }

}
