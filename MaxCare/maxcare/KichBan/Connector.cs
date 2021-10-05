using System;
using System.Data;
using System.Data.SQLite;
using MCommon;

namespace maxcare.KichBan
{
	// Token: 0x02000186 RID: 390
	public class Connector
	{
		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06001160 RID: 4448 RVA: 0x002C54D0 File Offset: 0x002C36D0
		// (set) Token: 0x06001161 RID: 4449 RVA: 0x002C5504 File Offset: 0x002C3704
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

		// Token: 0x06001162 RID: 4450 RVA: 0x00003691 File Offset: 0x00001891
		private Connector()
		{
		}

		// Token: 0x06001163 RID: 4451 RVA: 0x002C5520 File Offset: 0x002C3720
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
				MCommon.Common.ExportError(ex, "CheckConnectServer");
			}
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x002C55D4 File Offset: 0x002C37D4
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
			catch
			{
			}
			return dataTable;
		}

		// Token: 0x06001165 RID: 4453 RVA: 0x002C564C File Offset: 0x002C384C
		public int ExecuteNonQuery(string query)
		{
			int result = 0;
			try
			{
				this.CheckConnectServer();
				SQLiteCommand sqliteCommand = new SQLiteCommand(query, this.connection);
				result = sqliteCommand.ExecuteNonQuery();
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06001166 RID: 4454 RVA: 0x002C56BC File Offset: 0x002C38BC
		public int ExecuteScalar(string query)
		{
			int result = -1;
			try
			{
				this.CheckConnectServer();
				SQLiteCommand sqliteCommand = new SQLiteCommand(query, this.connection);
				long num = (long)sqliteCommand.ExecuteScalar();
				result = (int)num;
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x04001AB7 RID: 6839
		private static Connector instance;

		// Token: 0x04001AB8 RID: 6840
		private string connectionSTR = "Data Source=interact\\interact.sqlite;Version=3;";

		// Token: 0x04001AB9 RID: 6841
		private SQLiteConnection connection = null;
	}
}
