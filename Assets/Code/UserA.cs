using UnityEngine;
using Zenject;

namespace Code
{
    public class UserA : MonoBehaviour
    {
        private DepA _a;

        [Inject]
        public void Init(DepA a)
        {
            _a= a;
        }
    }
}