using UnityEngine;
using MainCheat;

namespace BaseLoader
{
    public class Loader
    {
        public static void Init()
        {
            // Loads our main class through game object
            Loader.Load = new GameObject();

            // Adds our main class to the game object
            Loader.Load.AddComponent<Main>();

            // Prevents the game object from being destroyed on scene change
            UnityEngine.Object.DontDestroyOnLoad(Loader.Load);
        }

        public static void unload()
        {
            _unload();
        }

        private static void _unload()
        {
            GameObject.Destroy(Load);
        }

        private static GameObject Load;
    }
}