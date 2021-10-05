using System;
using System.Data;
using System.Data.SQLite;

namespace maxcare
{
	// Token: 0x020000D2 RID: 210
	public class Connector2
	{
		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600089F RID: 2207 RVA: 0x0010D8CC File Offset: 0x0010BACC
		// (set) Token: 0x060008A0 RID: 2208 RVA: 0x0010D900 File Offset: 0x0010BB00
		public static Connector2 Instance
		{
			get
			{
				bool flag = Connector2.instance == null;
				if (flag)
				{
					Connector2.instance = new Connector2();
				}
				return Connector2.instance;
			}
			private set
			{
				Connector2.instance = value;
			}
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x00002EB7 File Offset: 0x000010B7
		private Connector2()
		{
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x0010D91C File Offset: 0x0010BB1C
		public DataTable ExecuteQuery(string query)
		{
			DataTable dataTable = new DataTable();
			using (SQLiteConnection sqliteConnection = new SQLiteConnection(this.connectionSTR))
			{
				sqliteConnection.Open();
				SQLiteCommand cmd = new SQLiteCommand(query, sqliteConnection);
				SQLiteDataAdapter sqliteDataAdapter = new SQLiteDataAdapter(cmd);
				sqliteDataAdapter.Fill(dataTable);
				sqliteConnection.Close();
			}
			return dataTable;
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x0010D9A0 File Offset: 0x0010BBA0
		public int ExecuteNonQuery(string query)
		{
			int result = 0;
			try
			{
				using (SQLiteConnection sqliteConnection = new SQLiteConnection(this.connectionSTR))
				{
					sqliteConnection.Open();
					SQLiteCommand sqliteCommand = new SQLiteCommand(query, sqliteConnection);
					result = sqliteCommand.ExecuteNonQuery();
					sqliteConnection.Close();
				}
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x0010DA40 File Offset: 0x0010BC40
		public object ExecuteScalar(string query)
		{
			object result = 0;
			using (SQLiteConnection sqliteConnection = new SQLiteConnection(this.connectionSTR))
			{
				sqliteConnection.Open();
				SQLiteCommand sqliteCommand = new SQLiteCommand(query, sqliteConnection);
				long num = (long)sqliteCommand.ExecuteScalar();
				result = (int)num;
				sqliteConnection.Close();
			}
			return result;
		}

		// Token: 0x04000C11 RID: 3089
		private static Connector2 instance;

		// Token: 0x04000C12 RID: 3090
		private string connectionSTR = "Data Source=database/db_post.db;Version=3;";
	}
}
