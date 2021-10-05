using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using MCommon;
using Newtonsoft.Json.Linq;

namespace maxcare.Helper
{
	// maxcare.Helper.JsonHelper
	using System;
	using System.Collections.Generic;
	using System.IO;
	using System.Linq;
	using MCommon;
	using Newtonsoft.Json.Linq;

	internal class JsonHelper
	{
		private string PathFileSetting;

		private JObject json;

		public JsonHelper(string jsonStringOrPathFile, bool isJsonString = false)
		{
			if (isJsonString)
			{
				if (jsonStringOrPathFile.Trim() == "")
				{
					jsonStringOrPathFile = "{}";
				}
				json = JObject.Parse(jsonStringOrPathFile);
				return;
			}
			try
			{
				PathFileSetting = "settings\\" + jsonStringOrPathFile + ".json";
				if (!File.Exists(PathFileSetting))
				{
					using (File.AppendText(PathFileSetting))
					{
					}
				}
				json = JObject.Parse(File.ReadAllText(PathFileSetting));
			}
			catch
			{
				json = new JObject();
			}
		}

		public JsonHelper()
		{
			json = new JObject();
		}

		public string GetValue(string key, string valueDefault = "")
		{
			//Discarded unreachable code: IL_0051, IL_005e
			string result = valueDefault;
			try
			{
				result = ((json[key] == null) ? valueDefault : json[key].ToString());
			}
			catch
			{
			}
			return result;
		}

		public List<string> GetValueList(string key, int typeSplitString = 0)
		{
			//Discarded unreachable code: IL_00d1, IL_00de
			List<string> list = new List<string>();
			try
			{
				list = ((typeSplitString != 0) ? GetValue(key).Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : GetValue(key).Split('\n').ToList());
				list = MCommon.Common.RemoveEmptyItems(list);
			}
			catch
			{
			}
			return list;
		}

		public int GetValueInt(string key, int valueDefault = 0)
		{
			//Discarded unreachable code: IL_0056, IL_0063
			int result = valueDefault;
			try
			{
				result = ((json[key] == null) ? valueDefault : Convert.ToInt32(json[key].ToString()));
			}
			catch
			{
			}
			return result;
		}

		public bool GetValueBool(string key, bool valueDefault = false)
		{
			//Discarded unreachable code: IL_0056, IL_0063
			bool result = valueDefault;
			try
			{
				result = ((json[key] == null) ? valueDefault : Convert.ToBoolean(json[key].ToString()));
			}
			catch
			{
			}
			return result;
		}

		public void Add(string key, string value)
		{
			//Discarded unreachable code: IL_0075, IL_0082
			try
			{
				if (!json.ContainsKey(key))
				{
					json.Add(key, value);
				}
				else
				{
					json[key] = value;
				}
			}
			catch (Exception)
			{
			}
		}

		public void Update(string key, object value)
		{
			//Discarded unreachable code: IL_002f, IL_003c
			try
			{
				json[key] = value.ToString();
			}
			catch
			{
			}
		}

		public void Update(string key, List<string> lst)
		{
			//Discarded unreachable code: IL_0049, IL_0056
			try
			{
				json[key] = string.Join("\n", lst).ToString();
			}
			catch
			{
			}
		}

		public void Remove(string key)
		{
			//Discarded unreachable code: IL_001f, IL_002c
			try
			{
				json.Remove(key);
			}
			catch
			{
			}
		}

		public void Save(string pathFileSetting = "")
		{
			//Discarded unreachable code: IL_005c, IL_0069
			try
			{
				if (pathFileSetting == "")
				{
					pathFileSetting = PathFileSetting;
				}
				File.WriteAllText(pathFileSetting, json.ToString());
			}
			catch
			{
			}
		}

		public string GetFullString()
		{
			//Discarded unreachable code: IL_005e, IL_006b
			string result = "";
			try
			{
				result = json.ToString().Replace("\r\n", "");
			}
			catch (Exception)
			{
			}
			return result;
		}
	}

}