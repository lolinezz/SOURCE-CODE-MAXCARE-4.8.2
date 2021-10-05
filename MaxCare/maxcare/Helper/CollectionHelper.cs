using System;
using System.Collections.Generic;
using System.Linq;

namespace maxcare.Helper
{
	// Token: 0x0200018C RID: 396
	public class CollectionHelper
	{
		// Token: 0x06001189 RID: 4489 RVA: 0x002C72C4 File Offset: 0x002C54C4
		public static bool ComparyTwoList(List<string> lst1, List<string> lst2)
		{
			List<string> source = lst1.Except(lst2).ToList<string>();
			List<string> source2 = lst2.Except(lst1).ToList<string>();
			return !source.Any<string>() && !source2.Any<string>();
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x0001539C File Offset: 0x0001359C
		public static List<string> ShuffleList(List<string> lst)
		{
			int i = lst.Count;
			while (i != 0)
			{
				int index = Base.rd.Next(0, lst.Count);
				i--;
				string value = lst[i];
				lst[i] = lst[index];
				lst[index] = value;
			}
			return lst;
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x002C732C File Offset: 0x002C552C
		public static List<string> CloneList(List<string> lstFrom)
		{
			List<string> list = new List<string>();
			try
			{
				for (int i = 0; i < lstFrom.Count; i++)
				{
					list.Add(lstFrom[i]);
				}
			}
			catch
			{
			}
			return list;
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x002C73AC File Offset: 0x002C55AC
		public static List<List<string>> SplitList(List<string> lstInput, int numberOfItemPerList)
		{
			List<List<string>> list = new List<List<string>>();
			try
			{
				int num = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)lstInput.Count * 1.0 / (double)numberOfItemPerList)));
				for (int i = 0; i < num; i++)
				{
					list.Add(lstInput.GetRange(numberOfItemPerList * i, (numberOfItemPerList * i + numberOfItemPerList <= lstInput.Count) ? numberOfItemPerList : (lstInput.Count % numberOfItemPerList)));
				}
			}
			catch
			{
			}
			return list;
		}

		// Token: 0x0600118D RID: 4493 RVA: 0x002C7498 File Offset: 0x002C5698
		public static string ConvertListToString(List<string> lstInput, string separatorString = "\r\n")
		{
			return string.Join(separatorString, lstInput);
		}
	}
}
