using System.Collections.Generic;
using System.Text;
namespace CarFormsTools
{
    public class DataClass
    {
        public class Item
        {
            public struct Data
            {
                public float Value;
                public int Frame; 
                public Data(int fps,float value=0)
                {
                    Frame = fps;
                    Value = value;
                }
            }
            public readonly List<Data> DatasList = new List<Data>();
            public  string Name;
            public  string Tips;
            public void AddData(float value=0) => DatasList.Add(new Data(Length, value));
            public int Length { get => DatasList.Count;}

            public Item(string name,string str=" ")
            {
                Name = name;
                Tips = str;
            }
        }
        

        private readonly StringBuilder _initemp = new StringBuilder(255);
        private readonly InIhandle _inihandle = new InIhandle();
        
        public DataClass(int length)
        {
           Table = new List<Item>(length);
        }
        public DataClass( string path)
        {
            _inihandle.GetInI("Property", "length", "0", _initemp, 255, path);
            var length = int.Parse(_initemp.ToString());
            Table = new List<Item>();
            for (var i = 0; i < length; i++)
            {
                _inihandle.GetInI("Table", i.ToString(), "unnamed", _initemp, 255, path);
                var name = _initemp.ToString();
                _inihandle.GetInI("Tips", i.ToString(), " ", _initemp, 255, path);
                Table.Add(new Item(name, _initemp.ToString()));
            }
        }
        public List<Item> Table { get; private set; } 

        public void Clear()
        {
            Table.Clear();
        }

        public void AddItem(string name,string tips=" ")
        {
            Table.Add(new Item(name,tips));
        }
    }

}
