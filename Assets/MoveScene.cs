using UnityEngine.SceneManagement;
using UnityEngine;

public class MoveScene : MonoBehaviour
{
    [SerializeField] private string loadLevel;
		void OnTriggerEnter(Collider other)
        {
            if(other.CompareTag("Player"))
            {
            SceneManager.LoadScene(loadLevel);
            }
        }
	
}
