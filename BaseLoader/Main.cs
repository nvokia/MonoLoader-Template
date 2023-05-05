using BaseLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace MainCheat
{
    class Main : MonoBehaviour
    {
        public void Start()
        {
            GUI.Label(new Rect(0f, 0f, 100f, 30f), "Base");
        }
        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.End))
            {
                Loader.unload();
            }
        }
        public void OnGUI()
        {

        }
    }
}
