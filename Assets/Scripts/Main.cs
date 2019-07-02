using UnityEngine;

public class Main : MonoBehaviour
{
    /// <summary>
    /// This class is just the implementation of all the functions shown in AuthHandler
    /// - It will sign up a user to Firebase Auth
    /// - It will sign in a user to Firebase Auth
    /// </summary>
    
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
    private static void OnAppStart()
    {
        AuthHandler.SignUp("rotolonico@gmail.com", "BestPasswordEvah", new User("Nico", "Rotolo", 17));
        AuthHandler.SignIn("rotolonico@gmail.com", "BestPasswordEvah");
    }
}
