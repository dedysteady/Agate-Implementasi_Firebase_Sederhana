using UnityEngine;
using UnityEngine.SceneManagement;

// untuk memanggil fungsi Load pada userDataManager dan kemudian membuka scene Gameplay.

public class LoadingController : MonoBehaviour
{
    private void Start ()
    {
        UserDataManager.Load ();
        SceneManager.LoadScene (1);
    }
}