using System;
using System.Collections.Generic;
using System.Data;

namespace maxcare.KichBan
{
	// Token: 0x02000187 RID: 391
	internal class InteractSQL
	{
		// Token: 0x06001167 RID: 4455 RVA: 0x002C5734 File Offset: 0x002C3934
		public static bool CheckColumnIsExistInTable(string table, string column)
		{
			bool result = false;
			try
			{
				int num = Connector.Instance.ExecuteScalar(string.Concat(new string[]
				{
					"SELECT COUNT(*) AS count FROM pragma_table_info('",
					table,
					"') WHERE name='",
					column,
					"'"
				}));
				bool flag = num > 0;
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

		// Token: 0x06001168 RID: 4456 RVA: 0x002C5818 File Offset: 0x002C3A18
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

		// Token: 0x06001169 RID: 4457 RVA: 0x002C5964 File Offset: 0x002C3B64
		public static DataTable GetKichBanById(string id)
		{
			DataTable result = new DataTable();
			try
			{
				string query = "SELECT * FROM Kich_Ban WHERE Id_KichBan = " + id;
				result = Connector.Instance.ExecuteQuery(query);
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x002C59D8 File Offset: 0x002C3BD8
		public static string GetTenKichBanById(string id)
		{
			string result = "";
			try
			{
				string query = "SELECT TenKichBan FROM Kich_Ban WHERE Id_KichBan = " + id;
				result = Connector.Instance.ExecuteQuery(query).Rows[0][0].ToString();
			}
			catch (Exception ex)
			{
			}
			return result;
		}

		// Token: 0x0600116B RID: 4459 RVA: 0x002C5A78 File Offset: 0x002C3C78
		public static DataTable GetAllKichBan()
		{
			DataTable result = new DataTable();
			try
			{
				string query = "SELECT * FROM Kich_Ban";
				result = Connector.Instance.ExecuteQuery(query);
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x0600116C RID: 4460 RVA: 0x002C5AE0 File Offset: 0x002C3CE0
		public static DataTable GetKichBanMoi()
		{
			DataTable result = new DataTable();
			try
			{
				string query = "SELECT * FROM Kich_Ban ORDER BY Id_KichBan DESC LIMIT 1";
				result = Connector.Instance.ExecuteQuery(query);
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x0600116D RID: 4461 RVA: 0x002C5B48 File Offset: 0x002C3D48
		public static string GetCauHinhFromKichBan(string Id_KichBan)
		{
			string result = "";
			try
			{
				string query = "SELECT CauHinh FROM Kich_Ban WHERE Id_KichBan = " + Id_KichBan;
				result = Connector.Instance.ExecuteQuery(query).Rows[0]["CauHinh"].ToString();
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x0600116E RID: 4462 RVA: 0x002C5BF8 File Offset: 0x002C3DF8
		public static bool SaveCauHinhFromKichBan(string Id_KichBan, string cauHinh)
		{
			try
			{
				string query = "UPDATE Kich_Ban SET CauHinh = '" + cauHinh + "' WHERE Id_KichBan = " + Id_KichBan;
				return Connector.Instance.ExecuteNonQuery(query) > 0;
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x0600116F RID: 4463 RVA: 0x002C5C8C File Offset: 0x002C3E8C
		public static bool CheckExistTenKichBan(string tenKichBan)
		{
			try
			{
				string query = "SELECT Id_KichBan FROM Kich_Ban WHERE TenKichBan = '" + tenKichBan + "'";
				bool flag = Connector.Instance.ExecuteQuery(query).Rows.Count > 0;
				if (flag)
				{
					return true;
				}
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x06001170 RID: 4464 RVA: 0x002C5D34 File Offset: 0x002C3F34
		public static bool InsertKichBan(string tenKichBan)
		{
			bool result = false;
			try
			{
				string query = "INSERT INTO Kich_Ban (TenKichBan) VALUES ('" + tenKichBan + "')";
				bool flag = Connector.Instance.ExecuteNonQuery(query) > 0;
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

		// Token: 0x06001171 RID: 4465 RVA: 0x002C5DD0 File Offset: 0x002C3FD0
		public static bool UpdateKichBan(string id, string tenKichBanMoi)
		{
			bool result = false;
			try
			{
				string query = "UPDATE Kich_Ban SET TenKichBan = '" + tenKichBanMoi + "' WHERE Id_KichBan = " + id;
				bool flag = Connector.Instance.ExecuteNonQuery(query) > 0;
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

		// Token: 0x06001172 RID: 4466 RVA: 0x002C5E70 File Offset: 0x002C4070
		public static bool DeleteKichBan(string id)
		{
			bool result = false;
			try
			{
				string query = "DELETE FROM Kich_Ban WHERE Id_KichBan = " + id;
				bool flag = Connector.Instance.ExecuteNonQuery(query) > 0;
				if (flag)
				{
					InteractSQL.DeleteHanhDongByIdKichBan(id);
					result = true;
				}
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x002C5F04 File Offset: 0x002C4104
		public static bool DuplicateKichBan(string Id_KichBanCu, string TenKichBanMoi)
		{
			bool result = false;
			try
			{
				bool flag = InteractSQL.InsertKichBan(TenKichBanMoi);
				if (flag)
				{
					string text = InteractSQL.GetKichBanMoi().Rows[0]["Id_KichBan"].ToString();
					DataTable dataTable = Connector.Instance.ExecuteQuery("SELECT * FROM Hanh_Dong WHERE Id_KichBan = " + Id_KichBanCu);
					for (int i = 0; i < dataTable.Rows.Count; i++)
					{
						string query = string.Concat(new string[]
						{
							"INSERT INTO Hanh_Dong (STT,Id_KichBan, TenHanhDong, Id_TuongTac, CauHinh) VALUES (",
							dataTable.Rows[i]["STT"].ToString(),
							",",
							text,
							", '",
							dataTable.Rows[i]["TenHanhDong"].ToString(),
							"', ",
							dataTable.Rows[i]["Id_TuongTac"].ToString(),
							", '",
							dataTable.Rows[i]["CauHinh"].ToString(),
							"')"
						});
						Connector.Instance.ExecuteNonQuery(query);
					}
					result = true;
				}
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06001174 RID: 4468 RVA: 0x002C619C File Offset: 0x002C439C
		public static DataTable GetTuongTac(string id = "", string ten = "")
		{
			DataTable result = new DataTable();
			try
			{
				string text = "";
				bool flag = id != "";
				if (flag)
				{
					text = text + "Id_TuongTac = " + id + " AND ";
				}
				bool flag2 = ten != "";
				if (flag2)
				{
					text = text + "TenTuongTac = '" + ten + "'";
				}
				bool flag3 = text != "";
				if (flag3)
				{
					bool flag4 = text.EndsWith(" AND ");
					if (flag4)
					{
						text = text.Replace(" AND ", "");
					}
					string query = "SELECT * FROM Tuong_Tac WHERE " + text;
					result = Connector.Instance.ExecuteQuery(query);
				}
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x002C6368 File Offset: 0x002C4568
		public static DataTable GetAllHanhDongByKichBan(string idKichBan)
		{
			DataTable result = new DataTable();
			try
			{
				string query = "SELECT t1.Id_HanhDong, t1.TenHanhDong,t2.Id_TuongTac,t2.TenTuongTac, t2.MoTa FROM Hanh_Dong t1 JOIN Tuong_Tac t2 ON t1.Id_TuongTac = t2.Id_TuongTac WHERE t1.Id_KichBan = " + idKichBan + " ORDER BY t1.STT";
				result = Connector.Instance.ExecuteQuery(query);
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x002C63F0 File Offset: 0x002C45F0
		public static DataTable GetHanhDongById(string id)
		{
			DataTable result = new DataTable();
			try
			{
				string query = "SELECT t1.TenHanhDong,t1.CauHinh,t2.Id_TuongTac,t2.TenTuongTac, t2.MoTa FROM Hanh_Dong t1 JOIN Tuong_Tac t2 ON t1.Id_TuongTac = t2.Id_TuongTac WHERE t1.Id_HanhDong = " + id;
				result = Connector.Instance.ExecuteQuery(query);
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06001177 RID: 4471 RVA: 0x002C6464 File Offset: 0x002C4664
		public static DataTable GetHanhDongMoi()
		{
			DataTable result = new DataTable();
			try
			{
				string query = "SELECT t1.Id_HanhDong,t1.TenHanhDong,t1.CauHinh,t2.Id_TuongTac,t2.TenTuongTac, t2.MoTa FROM Hanh_Dong t1 JOIN Tuong_Tac t2 ON t1.Id_TuongTac = t2.Id_TuongTac ORDER BY Id_HanhDong DESC LIMIT 1";
				result = Connector.Instance.ExecuteQuery(query);
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06001178 RID: 4472 RVA: 0x002C64CC File Offset: 0x002C46CC
		public static bool CheckExistTenHanhDong(string tenHanhDong)
		{
			try
			{
				string query = "SELECT Id_HanhDong FROM Hanh_Dong WHERE TenHanhDong = '" + tenHanhDong + "'";
				bool flag = Connector.Instance.ExecuteQuery(query).Rows.Count > 0;
				if (flag)
				{
					return true;
				}
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x06001179 RID: 4473 RVA: 0x002C6574 File Offset: 0x002C4774
		public static bool InsertHanhDong(string Id_KichBan, string TenHanhDong, string Id_TuongTac, string CauHinh)
		{
			bool result = false;
			try
			{
				string text = "";
				try
				{
					text = Connector.Instance.ExecuteQuery("SELECT STT FROM Hanh_Dong WHERE Id_KichBan = " + Id_KichBan + " ORDER BY STT DESC LIMIT 1").Rows[0]["STT"].ToString();
				}
				catch
				{
				}
				text = ((text == "") ? "1" : (Convert.ToInt32(text) + 1).ToString());
				CauHinh = CauHinh.Replace("'", "''");
				string query = string.Concat(new string[]
				{
					"INSERT INTO Hanh_Dong (STT,Id_KichBan, TenHanhDong, Id_TuongTac, CauHinh) VALUES (",
					text,
					",",
					Id_KichBan,
					", '",
					TenHanhDong,
					"', ",
					Id_TuongTac,
					", '",
					CauHinh,
					"')"
				});
				bool flag = Connector.Instance.ExecuteNonQuery(query) > 0;
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

		// Token: 0x0600117A RID: 4474 RVA: 0x002C681C File Offset: 0x002C4A1C
		public static bool DuplicateHanhDong(string Id_HanhDong, string TenHanhDongMoi)
		{
			bool result = false;
			try
			{
				DataTable dataTable = Connector.Instance.ExecuteQuery("SELECT * FROM Hanh_Dong WHERE Id_HanhDong = " + Id_HanhDong);
				string text = "";
				try
				{
					text = Connector.Instance.ExecuteQuery("SELECT STT FROM Hanh_Dong WHERE Id_KichBan = " + dataTable.Rows[0]["Id_KichBan"].ToString() + " ORDER BY STT DESC LIMIT 1").Rows[0]["STT"].ToString();
				}
				catch
				{
				}
				text = ((text == "") ? "1" : (Convert.ToInt32(text) + 1).ToString());
				string query = string.Concat(new string[]
				{
					"INSERT INTO Hanh_Dong (STT,Id_KichBan, TenHanhDong, Id_TuongTac, CauHinh) VALUES (",
					text,
					",",
					dataTable.Rows[0]["Id_KichBan"].ToString(),
					", '",
					TenHanhDongMoi,
					"', ",
					dataTable.Rows[0]["Id_TuongTac"].ToString(),
					", '",
					dataTable.Rows[0]["CauHinh"].ToString(),
					"')"
				});
				bool flag = Connector.Instance.ExecuteNonQuery(query) > 0;
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

		// Token: 0x0600117B RID: 4475 RVA: 0x002C6B58 File Offset: 0x002C4D58
		public static bool UpdateHanhDong(string Id_HanhDong, string TenHanhDong = "", string CauHinh = "")
		{
			bool result = false;
			try
			{
				string text = "";
				CauHinh = CauHinh.Replace("'", "''");
				bool flag = TenHanhDong != "";
				if (flag)
				{
					text = text + "TenHanhDong = '" + TenHanhDong + "',";
				}
				bool flag2 = CauHinh != "";
				if (flag2)
				{
					text = text + "CauHinh = '" + CauHinh + "'";
				}
				bool flag3 = text != "";
				if (flag3)
				{
					text = text.TrimEnd(new char[]
					{
						','
					});
					string query = "UPDATE Hanh_Dong SET " + text + " WHERE Id_HanhDong = " + Id_HanhDong;
					bool flag4 = Connector.Instance.ExecuteNonQuery(query) > 0;
					if (flag4)
					{
						result = true;
					}
				}
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x0600117C RID: 4476 RVA: 0x002C6D58 File Offset: 0x002C4F58
		public static bool UpdateThuTuHanhDong(string Id_HanhDong1, string Id_HanhDong2)
		{
			bool result = false;
			try
			{
				string str = Connector.Instance.ExecuteQuery("SELECT STT FROM Hanh_Dong WHERE Id_HanhDong = " + Id_HanhDong1).Rows[0]["STT"].ToString();
				string str2 = Connector.Instance.ExecuteQuery("SELECT STT FROM Hanh_Dong WHERE Id_HanhDong = " + Id_HanhDong2).Rows[0]["STT"].ToString();
				string query = "UPDATE Hanh_Dong SET STT = " + str2 + " WHERE Id_HanhDong = " + Id_HanhDong1;
				string query2 = "UPDATE Hanh_Dong SET STT = " + str + " WHERE Id_HanhDong = " + Id_HanhDong2;
				bool flag = Connector.Instance.ExecuteNonQuery(query) > 0 && Connector.Instance.ExecuteNonQuery(query2) > 0;
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

		// Token: 0x0600117D RID: 4477 RVA: 0x002C6F10 File Offset: 0x002C5110
		public static bool DeleteHanhDongByIdHanhDong(string id)
		{
			bool result = false;
			try
			{
				string query = "DELETE FROM Hanh_Dong WHERE Id_HanhDong = " + id;
				bool flag = Connector.Instance.ExecuteNonQuery(query) > 0;
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

		// Token: 0x0600117E RID: 4478 RVA: 0x002C6F98 File Offset: 0x002C5198
		public static bool DeleteHanhDongByIdKichBan(string id)
		{
			bool result = false;
			try
			{
				string query = "DELETE FROM Hanh_Dong WHERE Id_KichBan = " + id;
				bool flag = Connector.Instance.ExecuteNonQuery(query) > 0;
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

		// Token: 0x0600117F RID: 4479 RVA: 0x002C7020 File Offset: 0x002C5220
		public static List<string> GetIdHanhDongByIdKichBanAndTenTuongTac(string Id_KichBan, string tenTuongTac)
		{
			List<string> list = new List<string>();
			try
			{
				string query = string.Concat(new string[]
				{
					"SELECT t1.Id_HanhDong FROM Hanh_Dong t1 JOIN Tuong_Tac t2 ON t1.Id_TuongTac = t2.Id_TuongTac WHERE t1.Id_KichBan = ",
					Id_KichBan,
					" AND t2.TenTuongTac = '",
					tenTuongTac,
					"'"
				});
				DataTable dataTable = Connector.Instance.ExecuteQuery(query);
				for (int i = 0; i < dataTable.Rows.Count; i++)
				{
					list.Add(dataTable.Rows[i]["Id_HanhDong"].ToString());
				}
			}
			catch
			{
			}
			return list;
		}

		// Token: 0x06001180 RID: 4480 RVA: 0x002C7150 File Offset: 0x002C5350
		public static string GetCauHinhFromHanhDong(string Id_HanhDong)
		{
			string result = "";
			try
			{
				string query = "SELECT CauHinh FROM Hanh_Dong WHERE Id_HanhDong = " + Id_HanhDong;
				result = Connector.Instance.ExecuteQuery(query).Rows[0]["CauHinh"].ToString();
			}
			catch
			{
			}
			return result;
		}
	}
}
