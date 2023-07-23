using UnityEngine;

// Define a static class called GameObjectExtensions
public static class GameObjectExtensions 
{
    // This method is an extension method for the GameObject class
    // It takes an integer parameter called index to enable or disable its game object.
    public static void SetChildrenActiveUntil(this GameObject obj, int index){
        // Loop through each child of the GameObject's transform
        foreach (Transform child in obj.transform) {
            // Set the active state of the child to true if index is greater than 0, otherwise set it to false
            child.gameObject.SetActive(index > 0);
            // Decrement the index by 1
            index--;
        }
    }
}
