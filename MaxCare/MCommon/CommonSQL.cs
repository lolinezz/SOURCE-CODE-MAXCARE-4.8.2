using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using maxcare;

namespace MCommon
{
	// Token: 0x02000047 RID: 71
	internal class CommonSQL
	{
		// Token: 0x06000264 RID: 612 RVA: 0x0002A1B4 File Offset: 0x000283B4
		public static bool CheckExitsFile(string name)
		{
			return Connector.Instance.ExecuteScalar("SELECT COUNT(*) FROM files WHERE name='" + name + "' AND active=1;") > 0;
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0002A210 File Offset: 0x00028410
		public static DataTable GetAllFilesFromDatabase(bool isShowAll = false)
		{
			DataTable result = new DataTable();
			try
			{
				bool flag = !isShowAll;
				string query;
				if (flag)
				{
					query = "select id, name from files where active=1";
				}
				else
				{
					query = string.Concat(new string[]
					{
						"select id, name from files where active=1 UNION SELECT -1 AS id, '",
						Language.GetValue("[Tất cả thư mục]"),
						"' AS name UNION SELECT 999999 AS id, '",
						Language.GetValue("[Chọn nhiều thư mục]"),
						"' AS name ORDER BY id ASC"
					});
				}
				result = Connector.Instance.ExecuteQuery(query);
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0002A358 File Offset: 0x00028558
		public static DataTable GetAllFilesFromDatabaseForBin(bool isShowAll = false)
		{
			DataTable result = new DataTable();
			try
			{
				bool flag = !isShowAll;
				string query;
				if (flag)
				{
					query = "select id, name from files WHERE id IN (SELECT DISTINCT idfile FROM accounts WHERE active=0)";
				}
				else
				{
					query = string.Concat(new string[]
					{
						"select id, name from files WHERE id IN (SELECT DISTINCT idfile FROM accounts WHERE active=0) UNION SELECT -1 AS id, '",
						Language.GetValue("[Tất cả thư mục]"),
						"' AS name UNION SELECT 999999 AS id, '",
						Language.GetValue("[Chọn nhiều thư mục]"),
						"' AS name ORDER BY id ASC"
					});
				}
				result = Connector.Instance.ExecuteQuery(query);
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0002A4A0 File Offset: 0x000286A0
		public static bool InsertFileToDatabase(string namefile)
		{
			bool result = true;
			try
			{
				string query = string.Concat(new string[]
				{
					"insert into files values(null,'",
					namefile,
					"','",
					DateTime.Now.ToString(),
					"',1)"
				});
				Connector.Instance.ExecuteQuery(query);
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0002A57C File Offset: 0x0002877C
		public static bool UpdateFileNameToDatabase(string idFile, string nameFile)
		{
			try
			{
				string query = "UPDATE files SET name='" + nameFile + "' where id=" + idFile;
				return Connector.Instance.ExecuteNonQuery(query) > 0;
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0002A610 File Offset: 0x00028810
		public static bool DeleteFileToDatabase(string idFile)
		{
			bool result = false;
			try
			{
				bool flag = Connector.Instance.ExecuteScalar("SELECT COUNT(idfile) FROM accounts WHERE idfile=" + idFile) == 0;
				bool flag2 = flag;
				if (flag2)
				{
					result = (Connector.Instance.ExecuteNonQuery("delete from files where id=" + idFile) > 0);
				}
				else
				{
					bool flag3 = Connector.Instance.ExecuteNonQuery("UPDATE files SET active=0 where id=" + idFile) > 0;
					if (flag3)
					{
						result = CommonSQL.DeleteAccountByIdFile(idFile);
					}
				}
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0002A710 File Offset: 0x00028910
		public static bool UpdateMultiField(string field, List<string> lstId_FieldValue, string table = "accounts")
		{
			List<string> list = new List<string>();
			string text = "";
			for (int i = 0; i < lstId_FieldValue.Count; i++)
			{
				string text2 = lstId_FieldValue[i].Split(new char[]
				{
					'|'
				})[0];
				string text3 = lstId_FieldValue[i].Split(new char[]
				{
					'|'
				})[1];
				bool flag = !string.IsNullOrEmpty(text2);
				if (flag)
				{
					list.Add(text2);
					text = string.Concat(new string[]
					{
						text,
						"WHEN '",
						text2,
						"' THEN '",
						text3,
						"' "
					});
				}
			}
			string query = string.Concat(new string[]
			{
				"UPDATE ",
				table,
				" SET ",
				field,
				" = CASE id ",
				text,
				"END WHERE id IN('",
				string.Join("','", list),
				"'); "
			});
			return Connector.Instance.ExecuteNonQuery(query) > 0;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0002A990 File Offset: 0x00028B90
		public static bool DeleteFileToDatabaseIfEmptyAccount()
		{
			bool result = false;
			try
			{
				result = (Connector.Instance.ExecuteNonQuery("delete from files where id NOT IN (SELECT DISTINCT idfile FROM accounts)") > 0);
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0002A9FC File Offset: 0x00028BFC
		public static DataTable GetAllInfoFromAccount(List<string> lstIdFile, bool isGetActive = true)
		{
			DataTable result = new DataTable();
			try
			{
				bool flag = lstIdFile == null || lstIdFile.Count == 0;
				string text;
				if (flag)
				{
					text = "where active=" + (isGetActive ? 1 : 0).ToString();
				}
				else
				{
					text = "where idfile IN (" + string.Join(",", lstIdFile) + ") AND active=" + (isGetActive ? 1 : 0).ToString();
				}
				string query = string.Concat(new string[]
				{
					"SELECT '-1' as id, '",
					Language.GetValue("[Tất cả tình trạng]"),
					"' AS name UNION select DISTINCT '0' as id,info from accounts ",
					text,
					" ORDER BY id ASC"
				});
				result = Connector.Instance.ExecuteQuery(query);
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0002ABE4 File Offset: 0x00028DE4
		public static bool InsertAccountToDatabase(string uid, string pass, string token, string cookie, string email, string phone, string name, string friends, string groups, string birthday, string gender, string info, string backup, string fa2, string idFile, string emaiRecovery = "", string passMail = "", string useragent = "", string proxy = "")
		{
			bool result = true;
			try
			{
				string text = "INSERT INTO accounts(uid, pass,token,cookie1,email,name,friends,groups,birthday,gender,info,fa2,backup,idfile,passmail,useragent,proxy,dateImport,active) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}',1)";
				text = string.Format(text, new object[]
				{
					uid,
					pass.Replace("'", "''"),
					token,
					cookie,
					email,
					name,
					friends,
					groups,
					birthday,
					gender,
					info,
					fa2,
					backup,
					idFile,
					passMail,
					useragent,
					proxy,
					DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
				});
				Connector.Instance.ExecuteQuery(text);
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0002ADA4 File Offset: 0x00028FA4
		public static List<string> ConvertToSqlInsertAccount(List<string> lstSqlStatement)
		{
			List<string> list = new List<string>();
			try
			{
				int num = 100;
				int num2 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)lstSqlStatement.Count * 1.0 / (double)num)));
				for (int i = 0; i < num2; i++)
				{
					string item = "INSERT INTO accounts(uid, pass,token,cookie1,email,name,friends,groups,birthday,gender,info,fa2,idfile,passmail,useragent,proxy,dateImport,active) VALUES " + string.Join(",", lstSqlStatement.GetRange(num * i, (num * i + num <= lstSqlStatement.Count) ? num : (lstSqlStatement.Count % num)));
					list.Add(item);
				}
			}
			catch
			{
			}
			return list;
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0002AECC File Offset: 0x000290CC
		public static string ConvertToSqlInsertAccount(string uid, string pass, string token, string cookie, string email, string name, string friends, string groups, string birthday, string gender, string info, string fa2, string idFile, string passMail, string useragent, string proxy)
		{
			string text = "";
			try
			{
				text = "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}',1)";
				text = string.Format(text, new object[]
				{
					uid,
					pass.Replace("'", "''"),
					token,
					cookie,
					email,
					name.Replace("'", "''"),
					friends,
					groups,
					birthday,
					gender,
					info,
					fa2,
					idFile,
					passMail,
					useragent,
					proxy,
					DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
				});
			}
			catch
			{
			}
			return text;
		}

		// Token: 0x06000270 RID: 624 RVA: 0x0002B0AC File Offset: 0x000292AC
		public static bool UpdateFieldToAccount(string id, string fieldName, string fieldValue)
		{
			bool result = false;
			try
			{
				string text = "";
				bool flag = fieldName == "pass";
				if (flag)
				{
					text = ", pass_old=pass";
				}
				string query = string.Concat(new string[]
				{
					"update accounts set ",
					fieldName,
					" = '",
					fieldValue.Replace("'", "''"),
					"'",
					text,
					" where id=",
					id
				});
				bool flag2 = Connector.Instance.ExecuteNonQuery(query) > 0;
				result = flag2;
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0002B25C File Offset: 0x0002945C
		public static bool UpdateMultiFieldToAccount(string id, string lstFieldName, string lstFieldValue, bool isAllowEmptyValue = true)
		{
			bool result = false;
			try
			{
				bool flag = lstFieldName.Split(new char[]
				{
					'|'
				}).Length == lstFieldValue.Split(new char[]
				{
					'|'
				}).Length;
				if (flag)
				{
					int num = lstFieldName.Split(new char[]
					{
						'|'
					}).Length;
					string text = "";
					for (int i = 0; i < num; i++)
					{
						bool flag2 = !isAllowEmptyValue && lstFieldValue.Split(new char[]
						{
							'|'
						})[i].Trim() == "";
						if (!flag2)
						{
							text = string.Concat(new string[]
							{
								text,
								lstFieldName.Split(new char[]
								{
									'|'
								})[i],
								"='",
								lstFieldValue.Split(new char[]
								{
									'|'
								})[i].Replace("'", "''"),
								"',"
							});
						}
					}
					text = text.TrimEnd(new char[]
					{
						','
					});
					string query = "update accounts set " + text + " where id=" + id;
					result = (Connector.Instance.ExecuteNonQuery(query) > 0);
				}
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0002B504 File Offset: 0x00029704
		public static bool UpdateMultiFieldToAccount(List<string> lstId, string lstFieldName, string lstFieldValue)
		{
			bool result = false;
			try
			{
				bool flag = lstFieldName.Split(new char[]
				{
					'|'
				}).Length == lstFieldValue.Split(new char[]
				{
					'|'
				}).Length;
				if (flag)
				{
					int num = lstFieldName.Split(new char[]
					{
						'|'
					}).Length;
					string text = "";
					for (int i = 0; i < num; i++)
					{
						text = string.Concat(new string[]
						{
							text,
							lstFieldName.Split(new char[]
							{
								'|'
							})[i],
							"='",
							lstFieldValue.Split(new char[]
							{
								'|'
							})[i].Replace("'", "''"),
							"',"
						});
					}
					text = text.TrimEnd(new char[]
					{
						','
					});
					int num2 = 100;
					int num3 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)lstId.Count * 1.0 / (double)num2)));
					List<string> list = new List<string>();
					for (int j = 0; j < num3; j++)
					{
						string item = string.Concat(new string[]
						{
							"update accounts set ",
							text,
							" where id IN (",
							string.Join(",", lstId.GetRange(num2 * j, (num2 * j + num2 <= lstId.Count) ? num2 : (lstId.Count % num2))),
							")"
						});
						list.Add(item);
					}
					bool flag2 = Connector.Instance.ExecuteNonQuery(list) > 0;
					result = flag2;
				}
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0002B874 File Offset: 0x00029A74
		public static bool UpdateFieldToFile(string idFile, string fieldName, string fieldValue)
		{
			bool result = false;
			try
			{
				string query = string.Concat(new string[]
				{
					"update files set ",
					fieldName,
					" = '",
					fieldValue.Replace("'", "''"),
					"' where id=",
					idFile
				});
				bool flag = Connector.Instance.ExecuteNonQuery(query) > 0;
				result = flag;
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0002B9A0 File Offset: 0x00029BA0
		public static bool UpdateFieldToAccount(List<string> lstId, string fieldName, string fieldValue)
		{
			bool result = false;
			try
			{
				int num = 100;
				int num2 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)lstId.Count * 1.0 / (double)num)));
				List<string> list = new List<string>();
				string text = "";
				bool flag = fieldName == "pass";
				if (flag)
				{
					text = ", pass_old=pass";
				}
				for (int i = 0; i < num2; i++)
				{
					string item = string.Concat(new string[]
					{
						"update accounts set ",
						fieldName,
						" = '",
						fieldValue.Replace("'", "''"),
						"'",
						text,
						" where id IN (",
						string.Join(",", lstId.GetRange(num * i, (num * i + num <= lstId.Count) ? num : (lstId.Count % num))),
						")"
					});
					list.Add(item);
				}
				bool flag2 = Connector.Instance.ExecuteNonQuery(list) > 0;
				result = flag2;
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06000275 RID: 629 RVA: 0x0002BC3C File Offset: 0x00029E3C
		public static bool UpdateFieldToFile(List<string> lstId, string fieldName, string fieldValue)
		{
			bool result = true;
			try
			{
				string query = string.Concat(new string[]
				{
					"update files set ",
					fieldName,
					" = '",
					fieldValue,
					"' where id IN (",
					string.Join(",", lstId),
					")"
				});
				bool flag = Connector.Instance.ExecuteNonQuery(query) > 0;
				result = flag;
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0002BD6C File Offset: 0x00029F6C
		public static DataTable GetAccFromFile(List<string> lstIdFile = null, string info = "", bool isGetActive = true)
		{
			DataTable result = new DataTable();
			try
			{
				string text = "WHERE ";
				string text2 = (lstIdFile != null && lstIdFile.Count > 0) ? ("t1.idFile IN (" + string.Join(",", lstIdFile) + ")") : "";
				bool flag = text2 != "";
				if (flag)
				{
					text = text + text2 + " AND ";
				}
				string text3 = (info != "") ? ("t1.info = '" + info + "'") : "";
				bool flag2 = text3 != "";
				if (flag2)
				{
					text = text + text3 + " AND ";
				}
				string str = string.Format("t1.active = '{0}'", isGetActive ? 1 : 0);
				text += str;
				string query = "SELECT t1.*, t2.name AS nameFile FROM accounts t1 JOIN files t2 ON t1.idfile=t2.id " + text + " ORDER BY t1.idfile";
				result = Connector.Instance.ExecuteQuery(query);
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0002BFDC File Offset: 0x0002A1DC
		public static DataTable GetAccFromUid(List<string> lstUid)
		{
			DataTable result = new DataTable();
			try
			{
				int num = 100;
				int num2 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)lstUid.Count * 1.0 / (double)num)));
				List<string> list = new List<string>();
				for (int i = 0; i < num2; i++)
				{
					string item = "SELECT t1.*, t2.name AS nameFile FROM accounts t1 JOIN files t2 ON t1.idfile=t2.id WHERE t1.uid IN ('" + string.Join("','", lstUid.GetRange(num * i, (num * i + num <= lstUid.Count) ? num : (lstUid.Count % num))) + "') and t1.active=1 ORDER BY t1.uid";
					list.Add(item);
				}
				result = Connector.Instance.ExecuteQuery(list);
			}
			catch (Exception ex)
			{
				Common.ExportError(null, ex, "GetAccFromFile");
			}
			return result;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0002C158 File Offset: 0x0002A358
		public static DataTable GetAllAccountFromDatabase(bool isGetActive = true)
		{
			DataTable result = new DataTable();
			try
			{
				string query = string.Format("select uid from accounts where active={0};", isGetActive ? 1 : 0);
				result = Connector.Instance.ExecuteQuery(query);
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0002C1E4 File Offset: 0x0002A3E4
		public static bool DeleteAccountByIdFile(string idFile)
		{
			bool result = true;
			try
			{
				bool flag = Connector.Instance.ExecuteNonQuery("UPDATE accounts SET active=0, dateDelete='" + DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy") + "' where idfile=" + idFile) > 0;
				result = flag;
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0002C2AC File Offset: 0x0002A4AC
		public static bool DeleteAccountToDatabase(string id)
		{
			try
			{
				return Connector.Instance.ExecuteNonQuery("UPDATE accounts SET active=0, dateDelete='" + DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy") + "' where id=" + id) > 0;
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0002C358 File Offset: 0x0002A558
		public static DataTable GetAccFromId(List<string> lstId)
		{
			DataTable result = new DataTable();
			try
			{
				int num = 100;
				int num2 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)lstId.Count * 1.0 / (double)num)));
				List<string> list = new List<string>();
				for (int i = 0; i < num2; i++)
				{
					string item = "SELECT uid, pass, token, cookie1,email, passmail, fa2 FROM accounts WHERE id IN ('" + string.Join("','", lstId.GetRange(num * i, (num * i + num <= lstId.Count) ? num : (lstId.Count % num))) + "')";
					list.Add(item);
				}
				result = Connector.Instance.ExecuteQuery(list);
			}
			catch (Exception ex)
			{
				Common.ExportError(null, ex, "GetAccFromFile");
			}
			return result;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0002C4D4 File Offset: 0x0002A6D4
		public static bool DeleteAccountToDatabase(List<string> lstId, bool isReallyDelete = false)
		{
			if (isReallyDelete)
			{
				List<string> list = new List<string>();
				DataTable accFromId = CommonSQL.GetAccFromId(lstId);
				for (int i = 0; i < accFromId.Rows.Count; i++)
				{
					string text = "";
					for (int j = 0; j < accFromId.Columns.Count; j++)
					{
						text = text + accFromId.Rows[i][j].ToString() + "|";
					}
					text = text.Substring(0, text.Length - 1);
					list.Add(text);
				}
				File.AppendAllText("bin.txt", "======" + DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy") + "======\r\n");
				File.AppendAllLines("bin.txt", list);
			}
			bool result = true;
			try
			{
				int num = 100;
				int num2 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)lstId.Count * 1.0 / (double)num)));
				List<string> list2 = new List<string>();
				for (int k = 0; k < num2; k++)
				{
					string item;
					if (isReallyDelete)
					{
						item = "delete from accounts where id IN (" + string.Join(",", lstId.GetRange(num * k, (num * k + num <= lstId.Count) ? num : (lstId.Count % num))) + ")";
					}
					else
					{
						item = string.Concat(new string[]
						{
							"UPDATE accounts SET active=0, dateDelete='",
							DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy"),
							"' where id IN (",
							string.Join(",", lstId.GetRange(num * k, (num * k + num <= lstId.Count) ? num : (lstId.Count % num))),
							")"
						});
					}
					list2.Add(item);
				}
				for (int l = 0; l < list2.Count; l++)
				{
					result = (Connector.Instance.ExecuteNonQuery(list2[l]) > 0);
				}
			}
			catch (Exception ex)
			{
				Common.ExportError(null, ex, "DeleteAccountToDatabase");
			}
			return result;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0002C910 File Offset: 0x0002AB10
		public static bool UpdateAccountByUid(string account)
		{
			string[] array = account.Split(new char[]
			{
				'|'
			});
			string text = "";
			text = array[0];
			bool flag = text.Trim() == "";
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				string text2 = array[1];
				string text3 = array[2];
				string text4 = array[3];
				string text5 = array[4];
				string text6 = array[5];
				string text7 = array[6];
				string text8 = array[7];
				string text9 = array[8];
				List<string> list = new List<string>();
				list.Add((text2 != "") ? ("pass|" + text2) : "");
				list.Add((text3 != "") ? ("token|" + text3) : "");
				list.Add((text4 != "") ? ("cookie1|" + text4) : "");
				list.Add((text5 != "") ? ("email|" + text5) : "");
				list.Add((text6 != "") ? ("passmail|" + text6) : "");
				list.Add((text7 != "") ? ("fa2|" + text7) : "");
				list.Add((text8 != "") ? ("useragent|" + text8) : "");
				list.Add((text9 != "") ? ("proxy|" + text9) : "");
				string text10 = "update accounts set";
				foreach (string text11 in list)
				{
					bool flag2 = text11 != "";
					if (flag2)
					{
						text10 = string.Concat(new string[]
						{
							text10,
							" ",
							text11.Split(new char[]
							{
								'|'
							})[0],
							"='",
							text11.Split(new char[]
							{
								'|'
							})[1],
							"',"
						});
						bool flag3 = text11.Split(new char[]
						{
							'|'
						})[0] == "pass";
						if (flag3)
						{
							text10 += "pass_old=pass,";
						}
					}
				}
				text10 = text10.TrimEnd(new char[]
				{
					','
				});
				text10 = text10 + " where uid='" + text + "'";
				result = (Connector.Instance.ExecuteNonQuery(text10) > 0);
			}
			return result;
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0002CFBC File Offset: 0x0002B1BC
		public static string GetIdFileFromIdAccount(string id)
		{
			try
			{
				return Connector.Instance.ExecuteScalar("SELECT idFile FROM accounts WHERE id='" + id + "'").ToString();
			}
			catch
			{
			}
			return "";
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0002D058 File Offset: 0x0002B258
		public static bool CheckColumnIsExistInTable(string table, string column)
		{
			return Connector.Instance.ExecuteScalar(string.Concat(new string[]
			{
				"SELECT COUNT(*) AS count FROM pragma_table_info('",
				table,
				"') WHERE name='",
				column,
				"'"
			})) > 0;
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0002D0FC File Offset: 0x0002B2FC
		public static bool CheckExistTable(string table)
		{
			return Connector.Instance.ExecuteScalar("SELECT COUNT(*) FROM sqlite_master WHERE type='table' AND name='" + table + "';") > 0;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0002D158 File Offset: 0x0002B358
		public static bool AddColumnsIntoTable(string table, string columnName, int typeColumnData)
		{
			bool result = false;
			try
			{
				bool flag = Connector.Instance.ExecuteNonQuery(string.Concat(new string[]
				{
					"ALTER TABLE ",
					table,
					" ADD COLUMN '",
					columnName,
					"' ",
					(typeColumnData == 0) ? "INT" : "TEXT",
					";"
				})) > 0;
				if (flag)
				{
					result = true;
				}
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0002D2A4 File Offset: 0x0002B4A4
		public static bool InsertInteractToDatabase(string uid, string hanhDong, string cauHinh)
		{
			bool result = true;
			try
			{
				string query = string.Concat(new string[]
				{
					"INSERT INTO interacts(uid, timeInteract,hanhDong,cauHinh) VALUES ('",
					uid,
					"','",
					DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"),
					"','",
					hanhDong,
					"','",
					cauHinh,
					"')"
				});
				Connector.Instance.ExecuteQuery(query);
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0002D3F4 File Offset: 0x0002B5F4
		public static List<BaiViet> GetListBaiVietByID(string id)
		{
			List<BaiViet> result = new List<BaiViet>();
			try
			{
				string query = "select id, tenChuDe,ngaytao,tieude,anh,video,noidung from BaiViet WHERE id = " + id;
				DataTable source = Connector2.Instance.ExecuteQuery(query);
				result = (from rw in source.AsEnumerable()
				select new BaiViet
				{
					id = Convert.ToInt32(rw["id"]),
					tenChuDe = Convert.ToString(rw["tenChuDe"]),
					ngayTao = Convert.ToString(rw["ngaytao"]),
					anh = Convert.ToString(rw["anh"]),
					video = Convert.ToString(rw["video"]),
					tieuDe = Convert.ToString(rw["tieude"]),
					noiDung = Convert.ToString(rw["noidung"])
				}).ToList<BaiViet>();
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0002D49C File Offset: 0x0002B69C
		public static List<string> GetListChuDe()
		{
			List<string> list = new List<string>();
			try
			{
				string query = "select ten from ChuDe;";
				DataTable dataTable = Connector2.Instance.ExecuteQuery(query);
				for (int i = 0; i < dataTable.Rows.Count; i++)
				{
					list.Add(dataTable.Rows[i][0].ToString());
				}
			}
			catch
			{
			}
			return list;
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0002D554 File Offset: 0x0002B754
		public static List<BaiViet> GetListBaiViet(string tenChuDe = "")
		{
			List<BaiViet> result = new List<BaiViet>();
			try
			{
				bool flag = tenChuDe != "";
				string query;
				if (flag)
				{
					query = "select id,tenchude,ngaytao,tieude,anh,video,noidung from BaiViet WHERE tenchude='" + tenChuDe + "'";
				}
				else
				{
					query = "select id,tenchude,ngaytao,tieude,anh,video,noidung from BaiViet";
				}
				DataTable source = Connector2.Instance.ExecuteQuery(query);
				result = (from rw in source.AsEnumerable()
				select new BaiViet
				{
					id = Convert.ToInt32(rw["id"]),
					tenChuDe = Convert.ToString(rw["tenChuDe"]),
					ngayTao = Convert.ToString(rw["ngaytao"]),
					anh = Convert.ToString(rw["anh"]),
					video = Convert.ToString(rw["video"]),
					tieuDe = Convert.ToString(rw["tieude"]),
					noiDung = Convert.ToString(rw["noidung"])
				}).ToList<BaiViet>();
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0002D668 File Offset: 0x0002B868
		public static bool DeleteBaiViet(int id)
		{
			bool result = false;
			bool flag = Connector2.Instance.ExecuteNonQuery("delete from BaiViet where id=" + id.ToString()) > 0;
			if (flag)
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0002D6C8 File Offset: 0x0002B8C8
		public static bool DeleteChuDe(string ten)
		{
			bool result = false;
			try
			{
				string query = "delete from ChuDe where ten='" + ten + "'";
				bool flag = Connector2.Instance.ExecuteNonQuery(query) > 0;
				if (flag)
				{
					CommonSQL.DeleteBaiVietByChuDe(ten);
					result = true;
				}
				else
				{
					result = false;
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0002D784 File Offset: 0x0002B984
		public static bool DeleteBaiVietByChuDe(string tenChuDe)
		{
			bool result = false;
			bool flag = Connector2.Instance.ExecuteNonQuery("delete from BaiViet where tenchude='" + tenChuDe + "'") > 0;
			if (flag)
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0002D7F4 File Offset: 0x0002B9F4
		public static bool AddChuDe(string ten)
		{
			bool result = true;
			try
			{
				string query = "insert into ChuDe values('" + ten + "')";
				Connector2.Instance.ExecuteNonQuery(query);
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0002D884 File Offset: 0x0002BA84
		public static List<BaiViet> GetBaiVietNewest()
		{
			List<BaiViet> result = new List<BaiViet>();
			try
			{
				string query = "select id, tenChuDe,ngaytao,tieude,anh,video,noidung from BaiViet ORDER BY id DESC LIMIT 1";
				DataTable source = Connector2.Instance.ExecuteQuery(query);
				result = (from rw in source.AsEnumerable()
				select new BaiViet
				{
					id = Convert.ToInt32(rw["id"]),
					tenChuDe = Convert.ToString(rw["tenChuDe"]),
					ngayTao = Convert.ToString(rw["ngaytao"]),
					anh = Convert.ToString(rw["anh"]),
					video = Convert.ToString(rw["video"]),
					tieuDe = Convert.ToString(rw["tieude"]),
					noiDung = Convert.ToString(rw["noidung"])
				}).ToList<BaiViet>();
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0002D920 File Offset: 0x0002BB20
		public static bool UpdateBaiViet(int id, BaiViet baiviet)
		{
			bool result = true;
			try
			{
				string text = "";
				bool flag = baiviet.tieuDe != null;
				if (flag)
				{
					text = text + "tieude = '" + baiviet.tieuDe.Replace("'", "''") + "',";
				}
				bool flag2 = baiviet.anh != null;
				if (flag2)
				{
					text = text + "anh = '" + baiviet.anh + "',";
				}
				bool flag3 = baiviet.noiDung != null;
				if (flag3)
				{
					text = text + "noidung = '" + baiviet.noiDung.Replace("'", "''") + "',";
				}
				bool flag4 = baiviet.ngayTao != null;
				if (flag4)
				{
					text = text + "ngaytao = '" + baiviet.ngayTao + "',";
				}
				bool flag5 = baiviet.tenChuDe != null;
				if (flag5)
				{
					text = text + "tenchude = '" + baiviet.tenChuDe + "',";
				}
				bool flag6 = baiviet.video != null;
				if (flag6)
				{
					text = text + "video = '" + baiviet.video + "',";
				}
				text = text.TrimEnd(new char[]
				{
					','
				});
				bool flag7 = text != "";
				if (flag7)
				{
					string query = "UPDATE BaiViet SET " + text + " WHERE id=" + id.ToString();
					Connector2.Instance.ExecuteNonQuery(query);
					result = true;
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0002DC70 File Offset: 0x0002BE70
		public static bool UpdateChuDe(string tenCu, string tenMoi)
		{
			bool result = true;
			try
			{
				string query = string.Concat(new string[]
				{
					"UPDATE ChuDe SET ten = '",
					tenMoi,
					"' WHERE ten='",
					tenCu,
					"'"
				});
				bool flag = Connector2.Instance.ExecuteNonQuery(query) > 0;
				if (flag)
				{
					List<BaiViet> listBaiViet = CommonSQL.GetListBaiViet(tenCu);
					for (int i = 0; i < listBaiViet.Count; i++)
					{
						CommonSQL.UpdateBaiViet(listBaiViet[i].id, new BaiViet
						{
							tenChuDe = tenMoi
						});
					}
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0002DDB0 File Offset: 0x0002BFB0
		public static bool AddBaiViet(string tenchuDe, BaiViet baiviet)
		{
			bool result = true;
			try
			{
				string query = string.Concat(new string[]
				{
					"insert into BaiViet(tenChuDe, tieude, noidung, ngaytao, anh,video) values('",
					tenchuDe,
					"','",
					baiviet.tieuDe.Replace("'", "''"),
					"','",
					baiviet.noiDung.Replace("'", "''"),
					"','",
					baiviet.ngayTao,
					"','",
					baiviet.anh,
					"','",
					baiviet.video,
					"')"
				});
				Connector2.Instance.ExecuteNonQuery(query);
			}
			catch
			{
				result = false;
			}
			return result;
		}
	}
}
