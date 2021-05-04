using Zenject;

namespace Code
{
    public class UserInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<UserA>().FromNewComponentOnNewGameObject().AsSingle().NonLazy();
            Container.Bind<UserB>().FromNewComponentOnNewGameObject().AsSingle().NonLazy();
            Container.Bind<UserC>().FromNewComponentOnNewGameObject().AsSingle().NonLazy();
        }
    }
}