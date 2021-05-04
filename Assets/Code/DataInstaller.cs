using UnityEngine;
using Zenject;

namespace Code
{
    [CreateAssetMenu(menuName = "Create DataInstaller", fileName = "DataInstaller", order = 0)]
    public class DataInstaller : ScriptableObjectInstaller
    {
        public DepA A;
        public DepB B;
        public DepC C;

        public override void InstallBindings()
        {
            Container.BindInstance(A);
            Container.BindInstance(B);
            Container.BindInstance(C);
        }
    }
}