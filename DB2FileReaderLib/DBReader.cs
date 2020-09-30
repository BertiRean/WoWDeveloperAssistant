﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DBFileReaderLib.Readers;

namespace DBFileReaderLib
{
    public sealed class DBReader
    {
        private readonly BaseReader _reader;

        #region Header

        public int RecordsCount => _reader.RecordsCount;
        public int FieldsCount => _reader.FieldsCount;
        public int RecordSize => _reader.RecordSize;
        public int StringTableSize => _reader.StringTableSize;
        public uint TableHash => _reader.TableHash;
        public uint LayoutHash => _reader.LayoutHash;
        public int IdFieldIndex => _reader.IdFieldIndex;
        public DB2Flags Flags => _reader.Flags;
        public readonly string FileName;

        #endregion

        public DBReader(string patch, string fileName) : this(File.Open(Path.Combine(patch, fileName), FileMode.Open, FileAccess.Read, FileShare.Read))
        {
            FileName = fileName;
        }

        public DBReader(Stream stream)
        {
            using (var bin = new BinaryReader(stream))
            {
                var identifier = new string(bin.ReadChars(4));
                stream.Position = 0;
                switch (identifier)
                {
                    case "WDC3":
                        _reader = new WDC3Reader(stream);
                        break;
                    case "WDC2":
                    case "1SLC":
                        _reader = new WDC2Reader(stream);
                        break;
                    case "WDC1":
                        _reader = new WDC1Reader(stream);
                        break;
                    case "WDB6":
                        _reader = new WDB6Reader(stream);
                        break;
                    case "WDB5":
                        _reader = new WDB5Reader(stream);
                        break;
                    case "WDB4":
                        _reader = new WDB4Reader(stream);
                        break;
                    case "WDB3":
                        _reader = new WDB3Reader(stream);
                        break;
                    case "WDB2":
                        _reader = new WDB2Reader(stream);
                        break;
                    case "WDBC":
                        _reader = new WDBCReader(stream);
                        break;
                    default:
                        throw new Exception("DB type " + identifier + " is not supported!");
                }
            }
        }

        public Storage<T> GetRecords<T>() where T : class, new() => new Storage<T>(this);

        public void PopulateRecords<T>(IDictionary<int, T> storage) where T : class, new() => ReadRecords(storage);

        private void ReadRecords<T>(IDictionary<int, T> storage) where T : class, new()
        {
            var fieldCache = typeof(T).GetFields().Select(x => new FieldCache<T>(x)).ToArray();

            _reader.Enumerate((row) =>
            {
                var entry = new T();
                row.GetFields(fieldCache, entry);
                lock (storage)
                    storage.Add(row.Id, entry);
            });
        }
    }
}
