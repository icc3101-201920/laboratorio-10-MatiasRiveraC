using Laboratorio_9_OOP_201920.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_9_OOP_201920.Interfaces
{
    public interface IAttackPoints
    {
        int[] GetAttackPoints(EnumType line = EnumType.None);
    }
}
