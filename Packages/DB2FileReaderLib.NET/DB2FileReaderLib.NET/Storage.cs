﻿using DB2FileReaderLib.NET.Attributes;
using System;
using System.Collections.Concurrent;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace DB2FileReaderLib.NET
{
    public class Storage<T> : ConcurrentDictionary<int, T> where T : class, new()
    {
        public Storage(string fileName)
        {
            DB2Reader reader;

            var stream = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            using (var bin = new BinaryReader(stream))
            {
                var identifier = new string(bin.ReadChars(4));
                stream.Position = 0;
                switch (identifier)
                {
                    case "WDC3":
                        reader = new WDC3Reader(stream);
                        break;
                    case "WDC2":
                        reader = new WDC2Reader(stream);
                        break;
                    case "WDC1":
                        reader = new WDC1Reader(stream);
                        break;
                    default:
                        throw new Exception("DBC type " + identifier + " is not supported!");
                }
            }

            FieldInfo[] fields = typeof(T).GetFields();

            FieldCache<T>[] fieldCache = new FieldCache<T>[fields.Length];

            for (int i = 0; i < fields.Length; ++i)
            {
                bool indexMapAttribute = reader.Flags.HasFlagExt(DB2Flags.Index) ? Attribute.IsDefined(fields[i], typeof(IndexAttribute)) : false;

                fieldCache[i] = new FieldCache<T>(fields[i], fields[i].FieldType.IsArray, fields[i].GetSetter<T>(), indexMapAttribute);
            }

            Parallel.ForEach(reader.AsEnumerable(), row =>
            {
                T entry = new T();

                row.Value.GetFields(fieldCache, entry);

                TryAdd(row.Key, entry);
            });
        }
    }
}
