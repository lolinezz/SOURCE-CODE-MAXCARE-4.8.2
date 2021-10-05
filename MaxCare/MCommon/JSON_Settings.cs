using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace MCommon
{
	// Token: 0x0200004A RID: 74
	internal class JSON_Settings
	{
		// Token: 0x060002E3 RID: 739 RVA: 0x000316D0 File Offset: 0x0002F8D0
		public JSON_Settings(string jsonStringOrPathFile, bool isJsonString = false)
		{
			if (isJsonString)
			{
				bool flag = jsonStringOrPathFile.Trim() == "";
				if (flag)
				{
					jsonStringOrPathFile = "{}";
				}
				this.json = JObject.Parse(jsonStringOrPathFile);
			}
			else
			{
				try
				{
					this.PathFileSetting = "settings\\" + jsonStringOrPathFile + ".json";
					bool flag2 = !File.Exists(this.PathFileSetting);
					if (flag2)
					{
						using (File.AppendText(this.PathFileSetting))
						{
						}
					}
					this.json = JObject.Parse(File.ReadAllText(this.PathFileSetting));
				}
				catch
				{
					this.json = new JObject();
				}
			}
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x000026A2 File Offset: 0x000008A2
		public JSON_Settings()
		{
			this.json = new JObject();
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x000319E0 File Offset: 0x0002FBE0
		public string GetValue(string key, string valueDefault = "")
		{
			string result = valueDefault;
			try
			{
				result = ((this.json[key] == null) ? valueDefault : this.json[key].ToString());
			}
			catch
			{
			}
			return result;
		}

		public static Dictionary<string, object> ConvertToDictionary(JObject jObject)
		{
			//Discarded unreachable code: IL_01a0, IL_01ad
			Dictionary<string, object> dic = new Dictionary<string, object>();
			try
			{
				dic = jObject.ToObject<Dictionary<string, object>>();
				List<string> list = (from  h__TransparentIdentifier0 in dic.Select(delegate (KeyValuePair<string, object> r)
				{
					KeyValuePair<string, object> keyValuePair2 = r;
					return new
					{
						r = r,
						key = keyValuePair2.Key
					};
				})
					let value = h__TransparentIdentifier0.r.Value
					where value.GetType() == typeof(JObject)
					select h__TransparentIdentifier0.key).ToList();


				List<string> list2 = (from h__TransparentIdentifier0 in dic.Select(delegate (KeyValuePair<string, object> r)
				{
					KeyValuePair<string, object> keyValuePair = r;
					return new
					{
						r = r,
						key = keyValuePair.Key
					};
				})
					let value = h__TransparentIdentifier0.r.Value
					where value.GetType() == typeof(JArray)
					select h__TransparentIdentifier0.key).ToList();
				list2.ForEach(delegate (string key)
				{
					dic[key] = (from x in ((JArray)dic[key]).Values()
								select ((JValue)x).Value).ToArray();
				});
				list.ForEach(delegate (string key)
				{
					dic[key] = ConvertToDictionary(dic[key] as JObject);
				});
			}
			catch
			{
			}
			return dic;
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00031A68 File Offset: 0x0002FC68
		public List<string> GetValueList(string key, int typeSplitString = 0)
		{
			List<string> list = new List<string>();
			try
			{
				bool flag = typeSplitString == 0;
				if (flag)
				{
					list = this.GetValue(key, "").Split(new char[]
					{
						'\n'
					}).ToList<string>();
				}
				else
				{
					list = this.GetValue(key, "").Split(new string[]
					{
						"\n|\n"
					}, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
				}
				list = Common.RemoveEmptyItems(list);
			}
			catch
			{
			}
			return list;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00031B70 File Offset: 0x0002FD70
		public int GetValueInt(string key, int valueDefault = 0)
		{
			int result = valueDefault;
			try
			{
				result = ((this.json[key] == null) ? valueDefault : Convert.ToInt32(this.json[key].ToString()));
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00031C00 File Offset: 0x0002FE00
		public bool GetValueBool(string key, bool valueDefault = false)
		{
			bool result = valueDefault;
			try
			{
				result = ((this.json[key] == null) ? valueDefault : Convert.ToBoolean(this.json[key].ToString()));
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00031C90 File Offset: 0x0002FE90
		public void Add(string key, string value)
		{
			try
			{
				bool flag = !this.json.ContainsKey(key);
				if (flag)
				{
					this.json.Add(key, value);
				}
				else
				{
					this.json[key] = value;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00031D34 File Offset: 0x0002FF34
		public void Update(string key, object value)
		{
			try
			{
				this.json[key] = value.ToString();
			}
			catch
			{
			}
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00031D94 File Offset: 0x0002FF94
		public void Update(string key, List<string> lst)
		{
			try
			{
				this.json[key] = string.Join("\n", lst).ToString();
			}
			catch
			{
			}
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00031E0C File Offset: 0x0003000C
		public void Remove(string key)
		{
			try
			{
				this.json.Remove(key);
			}
			catch
			{
			}
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00031E5C File Offset: 0x0003005C
		public void Save(string pathFileSetting = "")
		{
			try
			{
				bool flag = pathFileSetting == "";
				if (flag)
				{
					pathFileSetting = this.PathFileSetting;
				}
				File.WriteAllText(pathFileSetting, this.json.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00031EE8 File Offset: 0x000300E8
		public string GetFullString()
		{
			string result = "";
			try
			{
				result = this.json.ToString().Replace("\r\n", "");
			}
			catch (Exception ex)
			{
			}
			return result;
		}

		// Token: 0x04000234 RID: 564
		private string PathFileSetting;

		// Token: 0x04000235 RID: 565
		private JObject json;
	}
}
