using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.UI;

namespace Assets.Scripts.Stars
{
    public interface IStar
    {
        void Initial(int obj, Text text, string key);
    }
}
