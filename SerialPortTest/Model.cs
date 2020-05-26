

using System;
using System.Collections.Generic;

namespace SerialPortTest
{
    interface IDataTypeModel
    {
        IDataType GetData(string key);
        void AddData(string key, IDataType data);
    }

    class DataTypeModel : IDataTypeModel
    {
        Dictionary<string, IDataType>
        public IDataType GetData(string key)an
        {
            return output;
        }
        public void AddData(string key, IDataType data)
        {

        }
    }

    abstract class DataTypeFactory
    {
        public static IDataType GenerateData(string type, string value)
        {
            IDataType data;
            switch (type)
            {
                case "int":
                    data = new IntDataType();
                    break;
                case "float":
                    data = new FloatDataType();
                    break;
                default:
                    data = new StringDataType();
                    break;
            }
            data.SetValueWithString(value);
            return data;
        }
    }

    interface IDataType
    {
        void SetValueWithString(string input);
        T GetValue<T>();
    }

    class StringDataType : IDataType
    {
        private string value;

        public void SetValueWithString(string input)
        {
            value = input;
        }
        public T GetValue<T>()
        {
            return value;
        }
    }

    class IntDataType : IDataType
    {
        private int value;

        public void SetValueWithString(string input)
        {
            value = Int32.Parse(input);
        }
        public string GetValue()
        {
            return value + "";
        }
    }

    class FloatDataType : IDataType
    {
        private float value;

        public void SetValueWithString(string input)
        {
            value = float.Parse(input);
        }
        public string GetValue()
        {
            return value + "";
        }
    }
}