using UnityEngine;
using Zenject;

namespace Code
{
    public class UserB: MonoBehaviour
    {
        private DepB _b;

        [Inject]
        public void Init(DepB b)
        {
            _b = b;
        }
    }
}