using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    //change: base class -> abstract class
    // Benefits: 1. Does NOT allow us to instantiate it directly
    //           2. Can create instance: BaseClass x = new CildClass();
    //  - Blends both a base class and the interface

    // when to use: (inheritance) IsA relationship ie. "X is a Y"
    public abstract class DataAccess
    {
        // retrun a value: virtual - you don't have to override or can
        public virtual string LoadConnectionString(string name)
        {
            Console.WriteLine("Load Connection String");
            return "testConnectionString";
        }

        public abstract void LoadData(string sql);
        public abstract void SaveData(string sql);
    }
}
