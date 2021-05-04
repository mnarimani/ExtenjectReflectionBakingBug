using UnityEngine;
using Zenject;

namespace Code
{
    public class UserC: MonoBehaviour
    {
        private DepC _c;

        [Inject]
        public void Init(DepC c)
        {
            _c = c;
        }

    }
}