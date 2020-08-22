using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace EasyCSharpEncryptor.Data
{
	public class DataContainer
	{
		private readonly Dictionary<Type, object> _cachedData = new Dictionary<Type, object>();
		private Dictionary<Type, string> _dataTypes;

		public void Init()
		{
			InitDataTypes();

			var availableTypes = new Dictionary<Type, string>();
			var invalidTypes = new Dictionary<Type, string>();
			GetTypes(ref availableTypes, ref invalidTypes);

			LoadData(availableTypes);
			if (invalidTypes.Count != 0)
			{
				CreateData(invalidTypes);
			}
		}

		public T GetData<T>() where T : struct
		{
			_cachedData.TryGetValue(typeof(T), out var result);
			return (T)result;
		}

		public void SaveData<T>(T data)
		{
			_cachedData[typeof(T)] = data;
		}

		public void SaveData()
		{
			foreach (var dataPair in _cachedData)
			{
				var dataType = dataPair.Key;
				var dataPath = _dataTypes[dataType];
				var serializer = new XmlSerializer(dataType);

				using (var fileStream = new FileStream(dataPath, FileMode.Create))
				{
					var data = dataPair.Value;
					serializer.Serialize(fileStream, data);
				}
			}
		}

		private void LoadData(IReadOnlyDictionary<Type, string> availableTypes)
		{
			foreach (var pair in availableTypes)
			{
				var type = pair.Key;
				var path = pair.Value;

				var serializer = new XmlSerializer(type);

				if (File.Exists(path))
				{
					using (var fileStream = new FileStream(path, FileMode.Open))
					{
						var data = serializer.Deserialize(fileStream);
						_cachedData.Add(type, data);
					}
				}
			}
		}

		private void CreateData(IReadOnlyDictionary<Type, string> invalidTypes)
		{
			foreach (var pair in invalidTypes)
			{
				var type = pair.Key;
				var path = pair.Value;

				var serializer = new XmlSerializer(type);

				using (var fileStream = new FileStream(path, FileMode.CreateNew))
				{
					var instance = Activator.CreateInstance(type);
					serializer.Serialize(fileStream, instance);
					_cachedData.Add(type, instance);
				}
			}
		}

		private void InitDataTypes()
		{
			_dataTypes = new Dictionary<Type, string>
			{
				{typeof(PasswordGenerationData), "PasswordSettings.xml"}
			};
		}

		private void GetTypes(ref Dictionary<Type, string> availableTypes,
			ref Dictionary<Type, string> invalidTypes)
		{
			foreach (var pair in _dataTypes)
			{
				var type = pair.Key;
				var path = pair.Value;

				if (File.Exists(path))
				{
					availableTypes.Add(type, path);
				}
				else
				{
					invalidTypes.Add(type, path);
				}
			}
		}
	}
}