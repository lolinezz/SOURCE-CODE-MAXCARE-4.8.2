using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace MCommon
{
	// Token: 0x02000038 RID: 56
	public class Connector
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000119 RID: 281 RVA: 0x0000B3A8 File Offset: 0x000095A8
		// (set) Token: 0x0600011A RID: 282 RVA: 0x0000B3DC File Offset: 0x000095DC
		public static Connector Instance
		{
			get
			{
				bool flag = Connector.instance == null;
				if (flag)
				{
					Connector.instance = new Connector();
				}
				return Connector.instance;
			}
			private set
			{
				Connector.instance = value;
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000231A File Offset: 0x0000051A
		private Connector()
		{
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0000B3F8 File Offset: 0x000095F8
		private void CheckConnectServer()
		{
			try
			{
				bool flag = this.connection == null;
				if (flag)
				{
					this.connection = new SQLiteConnection(this.connectionSTR);
				}
				bool flag2 = this.connection.State == ConnectionState.Closed;
				if (flag2)
				{
					this.connection.Open();
				}
			}
			catch (Exception ex)
			{
				Common.ExportError(ex, "CheckConnectServer");
			}
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0000B4AC File Offset: 0x000096AC
		public DataTable ExecuteQuery(string query)
		{
			DataTable dataTable = new DataTable();
			try
			{
				this.CheckConnectServer();
				SQLiteCommand cmd = new SQLiteCommand(query, this.connection);
				SQLiteDataAdapter sqliteDataAdapter = new SQLiteDataAdapter(cmd);
				sqliteDataAdapter.Fill(dataTable);
			}
			catch (Exception ex)
			{
				Common.ExportError(null, ex, "ExecuteQuery");
			}
			return dataTable;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000B544 File Offset: 0x00009744
		public DataTable ExecuteQuery(List<string> lstQuery)
		{
			DataTable dataTable = new DataTable();
			try
			{
				this.CheckConnectServer();
				for (int i = 0; i < lstQuery.Count; i++)
				{
					string commandText = lstQuery[i];
					SQLiteCommand cmd = new SQLiteCommand(commandText, this.connection);
					SQLiteDataAdapter sqliteDataAdapter = new SQLiteDataAdapter(cmd);
					sqliteDataAdapter.Fill(dataTable);
				}
			}
			catch (Exception ex)
			{
				Common.ExportError(null, ex, "ExecuteQuery");
			}
			return dataTable;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0000B614 File Offset: 0x00009814
		public int ExecuteNonQuery(List<string> lstQuery)
		{
			int result = 0;
			try
			{
				this.CheckConnectServer();
				for (int i = 0; i < lstQuery.Count; i++)
				{
					string commandText = lstQuery[i];
					SQLiteCommand sqliteCommand = new SQLiteCommand(commandText, this.connection);
					result = sqliteCommand.ExecuteNonQuery();
				}
			}
			catch (Exception ex)
			{
				Common.ExportError(null, ex, "ExecuteNonQuery");
			}
			return result;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0000B6D8 File Offset: 0x000098D8
		public int ExecuteNonQuery(string query)
		{
			int result = 0;
			try
			{
				this.CheckConnectServer();
				SQLiteCommand sqliteCommand = new SQLiteCommand(query, this.connection);
				result = sqliteCommand.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				Common.ExportError(null, ex, "ExecuteNonQuery: " + query);
			}
			return result;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000B770 File Offset: 0x00009970
		public int ExecuteScalar(string query)
		{
			int result = 0;
			try
			{
				this.CheckConnectServer();
				SQLiteCommand sqliteCommand = new SQLiteCommand(query, this.connection);
				long num = (long)sqliteCommand.ExecuteScalar();
				result = (int)num;
			}
			catch (Exception ex)
			{
				Common.ExportError(null, ex, "ExecuteScalar: " + query);
			}
			return result;
		}

		// Token: 0x040001E0 RID: 480
		private static Connector instance;

		// Token: 0x040001E1 RID: 481
		private string connectionSTR = "Data Source=database/db_maxcare.sqlite;Version=3;";

		// Token: 0x040001E2 RID: 482
		private SQLiteConnection connection = null;
	}
}
