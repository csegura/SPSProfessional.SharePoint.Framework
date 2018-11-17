﻿using System;
using System.IO;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;

namespace SPSProfessional.SharePoint.Framework.Common
{
    ///<summary>
    ///</summary>
    public static class SPSSerialization
    {
        /// <summary>
        /// Deserializes the specified serialized data thats comes in a Base64String
        /// </summary>
        /// <param name="serializedData">The serialized data.</param>
        /// <returns>A new SPSKeyValueList</returns>
        public static object Deserialize(string serializedData)
        {
            byte[] buffer = Convert.FromBase64String(serializedData);
            BinaryFormatter formatter = new BinaryFormatter();
            MemoryStream serializationStream = new MemoryStream(buffer);
            object list = formatter.Deserialize(serializationStream);
            return list;
        }

        /// <summary>
        /// Serializes the specified data.
        /// </summary>
        /// <param name="data">The list.</param>
        /// <returns>An string that contains the Base64String</returns>
        public static string Serialize<T>(T data)
        {
            BinaryFormatter formatter = new BinaryFormatter
                                            {
                                                    AssemblyFormat = FormatterAssemblyStyle.Simple
                                            };
            MemoryStream serializationStream = new MemoryStream();
            formatter.Serialize(serializationStream, data);
            serializationStream.Close();
            return Convert.ToBase64String(serializationStream.GetBuffer());
        }
    }
}