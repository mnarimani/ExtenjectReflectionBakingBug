using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Code
{
    public class Preload : MonoBehaviour
    {
        public float Delay = 5;

        IEnumerator Start()
        {
            yield return new WaitForSeconds(Delay);
            SceneManager.LoadScene("SampleScene");
        }
    }
}
